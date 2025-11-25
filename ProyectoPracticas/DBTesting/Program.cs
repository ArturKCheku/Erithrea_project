using System;
using System.Data.Entity.Validation;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ManteHos.Entities;
using ManteHos.Persistence;
using System.Net;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace DBTest
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                new Program();
            }
            catch (Exception e)
            {
                printError(e);
            }
            Console.WriteLine("\nPulse una tecla para salir");
            Console.ReadLine();
        }

        static void printError(Exception e)
        {
            while (e != null)
            {
                if (e is DbEntityValidationException)
                {
                    DbEntityValidationException dbe = (DbEntityValidationException)e;

                    foreach (var eve in dbe.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"",
                                ve.PropertyName,
                                eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName),
                                ve.ErrorMessage);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: " + e.Message);
                }
                e = e.InnerException;
            }
        }


        Program()
        {
            IDAL dal = new EntityFrameworkDAL(new ManteHosDbContext());

            CreateSampleDB(dal);
            PrintSampleDB(dal);
        }


        private void CreateSampleDB(IDAL dal)
        {
            dal.RemoveAllData();

            Console.WriteLine("CREANDO LOS DATOS Y ALMACENANDOLOS EN LA BD");
            Console.WriteLine("===========================================");

            Console.WriteLine("\n// CREACIÓN DE PERSONAS");
            Head head = new Head("Ibañez", "h1", "h1");
            dal.Insert<Head>(head);
            dal.Commit();

            Master tfmotu = new Master("Bárcenas", "m1", "m1");
            dal.Insert<Master>(tfmotu);
            dal.Commit();

            Master master2 = new Master("He-Man", "m2", "m2");
            dal.Insert<Master>(master2);
            dal.Commit();

            Operator op1 = new Operator("Pepe Gotera", "o1", "o1", Shift.Morning);
            dal.Insert<Operator>(op1);
            dal.Commit();

            Employee empleado1 = new Employee("Sacarino", "e2", "e2");
            dal.Insert<Employee>(empleado1);
            dal.Commit();

            Console.WriteLine("\n// CREACIÓN DE PIEZAS");
            Part part1 = new Part("P001", 10, "Tornillo", 5, "unidades", 0.5f);
            dal.Insert<Part>(part1);
            Part part2 = new Part("P002", 20, "Arandela", 10, "unidades", 0.2f);
            dal.Insert<Part>(part2);
            dal.Commit();

            Console.WriteLine("\n// CREACIÓN DE ÁREAS");
            Area area1 = new Area("Urgencias", tfmotu);
            dal.Insert<Area>(area1);
            Area area2 = new Area("Quirófano", master2);
            dal.Insert<Area>(area2);
            dal.Commit();

            Console.WriteLine("\n// CREACIÓN DE INCIDENTES");
            Incident incident1 = new Incident("Urgencias", "Fuga de agua", DateTime.Now, empleado1);
            incident1.Area = area1;
            dal.Insert<Incident>(incident1);
            dal.Commit();

            /*Console.WriteLine("\n// CREACIÓN DE ÓRDENES DE TRABAJO");
            WorkOrder workOrder1 = new WorkOrder(DateTime.Now, incident1);
            workOrder1.AddOperator(op1);
            dal.Insert<WorkOrder>(workOrder1);
            dal.Commit();
            */
            Console.WriteLine("\n// CREACIÓN DE ÓRDENES DE TRABAJO");
            WorkOrder w1 = new WorkOrder
            {
                StartDate = DateTime.Now,
                EndDate = null,
                RepairReport = "some",
                Incident = incident1,
                Operators = new List<Operator> { op1 }



            }; dal.Insert<WorkOrder>(w1);
            dal.Commit();

            UsedPart up1 = new UsedPart
            {
                Part = part1,
                Quantity = 2,
                Needed = true
            };
            dal.Insert<UsedPart>(up1);
            dal.Commit();

            w1.UsedParts.Add(up1);
            part1.UsedParts.Add(up1);
            part1.CurrentQuantity -= up1.Quantity;
            dal.Commit();



            /*
            workOrder1.AddUsedPart(2, part1);
            workOrder1.AddUsedPart(5, part2);
            dal.Update<WorkOrder>(workOrder1);
            dal.Commit();

            incident1.WorkOrder = workOrder1;
            dal.Update<Incident>(incident1);
            dal.Commit();
            */
        }

        // Copiar a partir de aquí
        private void PrintSampleDB(IDAL dal)
        {
            Console.WriteLine("\n\nMOSTRANDO LOS DATOS DE LA BD");
            Console.WriteLine("============================\n");

            Console.WriteLine("\nPersonas creadas:");
            foreach (Employee p in dal.GetAll<Employee>())
                Console.WriteLine("   FullName: " + p.FullName + " Id: " + p.Id + " Password: " + p.Password);

            // Show the rest of the database
            Console.WriteLine("\nPiezas creadas:");
            foreach (Part p in dal.GetAll<Part>())
                Console.WriteLine("   Code: " + p.Code + " Description: " + p.Description + " CurrentQuantity: " + p.CurrentQuantity);

            Console.WriteLine("\nÁreas, Indicencias, Órdenes de trabajo y piezas pedidas creadas:");
            foreach (Area a in dal.GetAll<Area>())
            {
                Console.WriteLine("   Name: " + a.Name);
                foreach (Incident i in a.Incidents)
                {
                    Console.WriteLine("      Incident Id: " + i.Id + " ReportDate: " + i.ReportDate + " Description: " + i.Description);
                    WorkOrder o = i.WorkOrder;
                    if (o != null)
                    {
                        Console.WriteLine("          WorkOrder Id: " + o.Id + " StartDate: " + o.StartDate);
                        foreach (UsedPart up in o.UsedParts)
                        {
                            Console.WriteLine("             Part Description: " + up.Part.Description + " Quantity: " + up.Quantity);
                        }
                    }

                }
            }


        }

    }

}