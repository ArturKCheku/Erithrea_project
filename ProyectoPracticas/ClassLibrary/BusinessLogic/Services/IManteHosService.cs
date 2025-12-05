using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManteHos.Entities;


namespace ManteHos.Services
{
    public interface IManteHosService
    {
        void RemoveAllData();
        void Commit();

        // Necesario para la inicialización de la BD
        void DBInitialization();

        //
        // A partir de aquí los necesarios para los CU solicitados
        //

        /*Employee login(Employee user, string password);//si no funciona, torna null o una excepció, i si no, el usuari identificat
        Employee logout();//Torna el usuari que ha eixit per comoditat de tornar a iniciar sessió si tenim temps de implementar-ho
        void report(Employee employee, Incident incidente);
        */

        void Login(string id, string password);
        void Logout();
        Employee GetLoggedEmployee();
        void reportIncident(Incident incident);//Si el incident fora null, tira
                                               //una excepció, si el Employee es null, tira excepció

        IEnumerable<Incident> getPendingIncidents();
        
        void AcceptIncident(int incidentId, int areaId, Priority priority);
        void RejectIncident(int incidentId, string rao);


        IEnumerable<Incident> GetIncidentsMaster();

        IEnumerable<Operator> GetAllOperators();

        void OperatorToIncident(int incidentId, string operatorId);

        IEnumerable<WorkOrder> GetWorkOrders();

        void CloseWorkOrder(int workOrder, string repairReport);
        


    }
}
