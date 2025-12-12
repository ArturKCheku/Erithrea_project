using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using ManteHos.Entities;
using ManteHos.Persistence;


namespace ManteHos.Services
{
    public class ManteHosService : IManteHosService
    {
        private readonly IDAL dal;
        private Employee loggedEmployee;

        public ManteHosService(IDAL dal)
        {
            this.dal = dal;
            //this.loggedEmployee = null;
        }

        /// <summary>
        /// Borra todos los datos de la BD
        /// </summary>
        public void RemoveAllData()
        {
            dal.RemoveAllData();
            //loggedEmployee = null;
        }

        /// <summary>
        /// Salva todos los cambios que haya habido en el contexto de la aplicación desde la última vez que se hizo Commit
        /// </summary>
        public void Commit()
        {
            dal.Commit();
        }

        /// <summary>
        /// Inicializa los datos para que haya ciertos datos para poder usarlos luego
        /// </summary>
        public void DBInitialization()
        {
            RemoveAllData();

            // Dar de alta ciertos datos relevantes para el sistema
            Head head = new Head("Ibañez", "h1", "h1");
            AddPerson(head);
            Master tfmotu = new Master("Bárcenas", "m1", "m1");
            AddPerson(tfmotu);
            Master master2 = new Master("He-Man", "m2", "m2");
            AddPerson(master2);
            Master master3 = new Master("Picasso", "m3", "m3");
            AddPerson(master3);
            Operator op1 = new Operator("Pepe Gotera", "o1", "o1", Shift.Morning);
            AddPerson(op1);
            Operator op2 = new Operator("Otilio", "o2", "o2", Shift.Morning);
            AddPerson(op2);
            Operator op3 = new Operator("Rompetechos", "o3", "o3", Shift.Night);
            AddPerson(op3);

            Employee empleado1 = new Employee("Sacarino", "e1", "e1");
            AddPerson(empleado1);
            Employee empleado2 = new Employee("Pepe García", "e2", "e2");
            AddPerson(empleado2);

            Area a1 = new Area("Mecánica", tfmotu);
            AddArea(a1);
            Area a2 = new Area("Electricidad", master2);
            AddArea(a2);
            Area a3 = new Area("Pintura", master3);
            AddArea(a3);

            Part p1 = new Part("Esc50", 5, "Placa de escayola para techo", 1, "Placa de 50x30cms", 5);
            AddPart(p1);
            Part p2 = new Part("TM8", 3000, "Tornillo métrica 8", 100, "Tornillo", 0.01F);
            AddPart(p2);
            Part p3 = new Part("ClimaEst", 4, "Cristal Climalit de ventana estándar", 0, "Cristal 75x100cms", 200);
            AddPart(p3);

        }

        public void AddPerson(Employee person)
        {
            // Restricción: No puede haber dos personas con el mismo Id
            if (dal.GetById<Employee>(person.Id) == null)
            {
                dal.Insert<Employee>(person);
                dal.Commit();
            }
            else throw new ServiceException("Person with Id " + person.Id + " already exists.");
        }

        public void AddArea(Area area)
        {
            // Restricción: No puede haber dos áreas con el mismo Nombre
            if (!dal.GetWhere<Area>(x => x.Name == area.Name).Any())
            {
                dal.Insert<Area>(area);
                dal.Commit();
            }
            else throw new ServiceException("Area with Name " + area.Name + " already exists.");
        }

        public void AddPart(Part part)
        {
            // Restricción: No puede haber dos piezas con la misma descripción
            if (!dal.GetWhere<Part>(x => x.Description == part.Description).Any())
            {
                dal.Insert<Part>(part);
                dal.Commit();
            }
            else throw new ServiceException("Part with Description " + part.Description + " already exists.");
        }

        //
        // Resto de metodos necesarios para el servicio
        //

        public void Login(string id, string password)
        {
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(password))
                throw new ServiceException("Id y password son requerits.");

            Employee employee = dal.GetById<Employee>(id);

            if (employee == null)
            {
                throw new ServiceException("User Id no trobat.");
            }

            if (employee.Password != password)
            {
                throw new ServiceException("Password incorrecta.");
            }

            this.loggedEmployee = employee;

        }

        public void Logout()
        {
            this.loggedEmployee = null;
        }

        public Employee GetLoggedEmployee()
        {
            return this.loggedEmployee;
        }


        public void reportIncident(Incident incident)
        {
            if (loggedEmployee == null)
            {
                throw new ServiceException("Es necessari estar loggeat per a reportar un incident");
            }
            if (string.IsNullOrWhiteSpace(incident.Description))
            {
                throw new ServiceException("Es requereix una descripcio");
            }
            if (string.IsNullOrWhiteSpace(incident.Department))
            {
                throw new ServiceException("Es requereix indicar el departament");
            }

            incident.Reporter = loggedEmployee;
            incident.ReportDate = DateTime.Now;
            incident.Status = Status.Created;
            incident.CostOfUsedParts= 0;



            dal.Insert<Incident>(incident);
            dal.Commit();
        }

        public IEnumerable<Incident> getPendingIncidents()
        {
            if(loggedEmployee == null || !(loggedEmployee is Head))
            {
                throw new ServiceException("Sols Head pot accedir");
            }
            return dal.GetWhere<Incident>(x => x.Status == Status.Created);
        }
        

        public IEnumerable<Area> GetAllAreas()
        {
            return dal.GetAll<Area>();
        }

        public void AcceptIncident(int incidentId, int areaId, Priority priority)
        {
            if (loggedEmployee == null || !(loggedEmployee is Head)) 
            {
                throw new ServiceException("Sols Head pot accedir");
            }
            Incident incident = dal.GetById<Incident>(incidentId);
            if (incident == null) throw new ServiceException("No es troba incident");

            if(incident.Status != Status.Created)
            {
                throw new ServiceException("Sols es pot acceptar un incident amb el estat 'created'. ");
            }

            Area area = dal.GetById<Area>(areaId);
            if (area == null) throw new ServiceException("No es troba area");

            incident.Area = area;
            incident.Priority = priority;
            incident.Status = Status.Accepted;

            dal.Commit();
        }

        public void RejectIncident(int incidentId, string rao)
        {
            if (loggedEmployee == null || !(loggedEmployee is Head))
            {
                throw new ServiceException("Sols Head pot accedir");
            }

            if (string.IsNullOrEmpty(rao))
            {
                throw new ServiceException("Es requereix una rao");
            }

            Incident incident = dal.GetById<Incident>(incidentId);
            incident.RejectionReason = rao;
            incident.Status = Status.Rejected;

            dal.Commit();
        }

        public IEnumerable<Incident> GetIncidentsMaster()
        {
            if (loggedEmployee == null || !(loggedEmployee is Master))
            {
                throw new ServiceException("Sols Master pot accedir");
            }
            Master actualMaster = dal.GetById<Master>(loggedEmployee.Id);

            if(actualMaster.Area == null)
            {
                throw new ServiceException("No hi ha area asignada per al Master actual.");
            }

            return dal.GetWhere<Incident>(x => x.Area.Id == actualMaster.Area.Id &&
                                              (x.Status == Status.Accepted || x.Status == Status.InProgress));
        }

        public IEnumerable<Operator> GetAllOperators()
        {
            return dal.GetAll<Operator>();
        }

        public void AssignOperatorToIncident(int incidentId, string operatorId)
        {
            if(loggedEmployee == null || !(loggedEmployee is Master))
            {
                throw new ServiceException("Sols Master pot accedir");
            }

            Incident incident = dal.GetById<Incident>(incidentId);
            if (incident == null) throw new ServiceException("Incident no trobat.");

            Operator op = dal.GetById<Operator>(operatorId);
            if (op == null) throw new ServiceException("Operator no trobat.");

            Master actualMaster = (Master)loggedEmployee;

            if(incident.Area == null || incident.Area.Id != actualMaster.Area.Id)
            {
                throw new ServiceException("Sols pots accedir a Incidents de la teua mateixa Area");
            }

            if (incident.WorkOrder == null)
            {
                WorkOrder nWorkOrder = new WorkOrder()
                {
                    StartDate = DateTime.Now,
                    Incident = incident,
                    Operators = new List<Operator>(),
                    UsedParts = new List<UsedPart>(),
                    RepairReport = ""
                };

                incident.WorkOrder = nWorkOrder;
                incident.Status = Status.InProgress;

            }

            if (!incident.WorkOrder.Operators.Contains(op))
            {
                incident.WorkOrder.Operators.Add(op);
            }
            else
            {
                throw new ServiceException("El operator ya te asignat aquest WorkOrder.");
            }

            dal.Commit();

        }

        public void UnassignOperatorToIncident(int incidentId, string operatorId)
        {
            if (loggedEmployee == null || !(loggedEmployee is Master))
            {
                throw new ServiceException("Sols Master pot accedir");
            }

            Incident incident = dal.GetById<Incident>(incidentId);
            if (incident == null) throw new ServiceException("Incident no trobat.");

            Operator op = dal.GetById<Operator>(operatorId);
            if (op == null) throw new ServiceException("Operator no trobat.");

            Master actualMaster = (Master)loggedEmployee;

            if (incident.Area == null || incident.Area.Id != actualMaster.Area.Id)
            {
                throw new ServiceException("Sols pots accedir a Incidents de la teua mateixa Area");
            }

            if (incident.WorkOrder == null)
            {
                throw new ServiceException("No existeix workOrder per a este incident");
            }

            if (incident.WorkOrder.Operators.Contains(op))
            {
                incident.WorkOrder.Operators.Remove(op);
            }
            else
            {
                throw new ServiceException("El operator no te asignat aquest workOrder.");
            }

            dal.Commit();

        }


        public IEnumerable<WorkOrder> GetWorkOrders()
        {
            if (loggedEmployee == null || !(loggedEmployee is Operator))
            {
                throw new ServiceException("Sols Operator pot accedir.");
            }
            string operatorId = loggedEmployee.Id;

            return dal.GetWhere<WorkOrder>(wo => wo.EndDate == null && wo.Operators.Any(op => op.Id == operatorId));
        }
        
        public void CloseWorkOrder(int workOrderId, string repairReport)
        {
            if (loggedEmployee == null || !(loggedEmployee is Operator))
            {
                throw new ServiceException("Sols Operator pot accedir.");
            }
            string operatorId = loggedEmployee.Id;

            WorkOrder wo = dal.GetById<WorkOrder>(workOrderId);
            if (wo == null) throw new ServiceException("No s'ha trobat workOrder");

            if (!wo.Operators.Any(op => op.Id == operatorId))
            {
                throw new ServiceException("El Operator no esta asignat a ixe workOrder");
            }

            if(wo.UsedParts.Any(up=> up.Needed == true))
            {
                throw new ServiceException("No es pot tancar el workOrder. N'hi han pendents parts Needed.");
            }

            wo.RepairReport = repairReport;
            wo.EndDate = DateTime.Now;

            if(wo.Incident != null)
            {
                wo.Incident.Status = Status.Completed;
            }

            dal.Commit();

        }
        
    }
}
