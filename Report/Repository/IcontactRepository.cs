using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Report.Repository
{
    internal interface IcontactRepository
    {
        DataTable selectAll(string TblName);
        DataTable selectRow(int IdPatient);
        bool Insert(int IdPatient,string Firstname, string Lastname, DateTime Berthday, string Tell, string City, string Address);
        bool Update(int IdPatient, string Firstname, string Lastname, DateTime Berthday, string Tell, string City, string Address);
        //bool Update(int unserId, string username, string family, string mobile, string email, DateTime age, string address);
        //bool Delete(int userId);
        bool Update(int IdTreatment,int IdPatient, int Age, int WaitingTime, string Diagnosis, string Treatment);
        bool Delete(int Id,string tblName);
        bool Insert(int IdTreatment,int IdPatient, int Age, int WaitingTime, string Diagnosis, string Treatment);
        void Update(int idTreatment);
    }
}
