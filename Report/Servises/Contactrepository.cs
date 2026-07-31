using Report.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Report.Servises
{
    internal class Contactrepository : IcontactRepository
    {
        //Data Source=(localdb)\ProjectModels;Initial Catalog=DBGesundheit;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30
        private string ConectionString = "Data Source=(localdb)\\ProjectModels; Initial Catalog=DBGesundheit; Integrated Security= true";
        public bool Delete(int Id,string tblName)
        {
            SqlConnection conn = new SqlConnection(ConectionString);
            try
            {
                if(tblName == "TblTreatment")
                { 
                    string qurey = "delete TblTreatment where IdTreatment=@IdTreatment";
                    SqlCommand cmd = new SqlCommand(qurey, conn);
                    cmd.Parameters.AddWithValue("@IdTreatment", Id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                else if(tblName=="TblPatient")
                {
                    string qurey = "delete TblPatient where Idpatient=@IdPatient";
                    SqlCommand cmd=new SqlCommand(qurey, conn);
                    cmd.Parameters.AddWithValue("@IdPatient", Id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    
                }
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool Insert(int IdTreatment, int IdPatient,int Age, int WaitingTime, string Diagnosis, string Treatment)
        {
            // throw new NotImplementedException();
            SqlConnection cn = new SqlConnection(ConectionString);
            
            try
            {
                string qurey = "insert into TblTreatment (IdTreatment,IdPatient, Age,WaitingTime,Diagnosis,Treatment) values (@IdTreatment,@IdPatient, @Age,@WaitingTime,@Diagnosis,@Treatment)";
                SqlCommand cmd=new SqlCommand(qurey, cn);
                cmd.Parameters.AddWithValue("@IdTreatment", IdTreatment);
                cmd.Parameters.AddWithValue("@IdPatient", IdPatient);
                cmd.Parameters.AddWithValue("@Age", Age);
                cmd.Parameters.AddWithValue("@WaitingTime", WaitingTime);
                cmd.Parameters.AddWithValue("@Diagnosis", Diagnosis);
                cmd.Parameters.AddWithValue("@Treatment", Treatment);
                cn.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch
            {
                return false;
            }
            finally
            {
                cn.Close();
            }

        }

        public bool Insert(int IdPatient, int Age, DateTime WaitingTime, string Diagnosis, string Treatment)
        {
            throw new NotImplementedException();

        }

        public bool Update(int IdTreatment,int IdPatient, int Age, int WaitingTime, string Diagnosis, string Treatment)
        {
            SqlConnection cn = new SqlConnection(ConectionString);
            try
            {
                string qurey = "update TblTreatment set  IdPatient=@IdPatient,Age=@Age,WaitingTime=@WaitingTime,Diagnosis=@Diagnosis,Treatment=@Treatment where IdTreatment=@IdTreatment";
               
                SqlCommand cmd = new SqlCommand(qurey, cn);
                cmd.Parameters.AddWithValue("@IdTreatment", IdTreatment);
                cmd.Parameters.AddWithValue("@IdPatient", IdPatient);
                cmd.Parameters.AddWithValue("@Age", Age);
                cmd.Parameters.AddWithValue("@WaitingTime", WaitingTime);
                cmd.Parameters.AddWithValue("@Diagnosis", Diagnosis);
                cmd.Parameters.AddWithValue("@Treatment", Treatment);
                cn.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch { return false; }
            finally
            {
                cn.Close();
            }
        }

        public DataTable selectAll(string TblName)
        {
            //throw new NotImplementedException();
            string qurey = "select * from " + TblName;
            SqlConnection cn = new SqlConnection(ConectionString);
            cn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(qurey, cn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cn.Close();
            return dt;
        }

        public DataTable selectAll()
        {
            throw new NotImplementedException();
        }

        public DataTable selectRow(int IdPatient)
        {
            // throw new NotImplementedException();
            string query = "Select * from TblPatieint where IdPatient=@IdPatient";
            SqlConnection cn=new SqlConnection(ConectionString);
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters[0].Value = IdPatient;
            cn.Open();
            SqlDataAdapter adapter=new SqlDataAdapter(cmd);
            DataTable dt=new DataTable();
            adapter.Fill(dt);
            cn.Close() ;
            return dt;  
            
        }

        

        public bool Update(int IdPatient, int Age, string Diagnosis, int WaitingTime, string Treatment)
        {
            throw new NotImplementedException();
        }

        public void Update(int idTreatment)
        {
            throw new NotImplementedException();
        }
        // TBlPatient
        
        public bool Update(int IdPatient, string Firstname, string Lastname, DateTime Berthday, string Tell, string City, string Address)
        {
            // throw new NotImplementedException();
            SqlConnection cn = new SqlConnection(ConectionString);

            try
            {
                string qurey = "update TblPatient set Firstname=@Firstname,Lastname=@Lastname,Berthday=@Berthday,Tell=@Tell,City=@City,Address=@Address where IdPatient=@IdPatient";
                SqlCommand cmd = new SqlCommand(qurey, cn);
                cmd.Parameters.AddWithValue("@IdPatient", IdPatient);
                cmd.Parameters.AddWithValue("@Firstname", Firstname);
                cmd.Parameters.AddWithValue("@Lastname", Lastname);
                cmd.Parameters.AddWithValue("@Berthday", Berthday);
                cmd.Parameters.AddWithValue("@Tell", Tell);
                cmd.Parameters.AddWithValue("@City", City);
                cmd.Parameters.AddWithValue("@Address", Address);
                cn.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch
            {
                return false;
            }
            finally
            {
                cn.Close();
            }

        }
        //------------------
        public bool Insert( int IdPatient,string Firstname,string Lastname,DateTime Berthday,string Tell, string City,string Address)
        {
            // throw new NotImplementedException();
            SqlConnection cn = new SqlConnection(ConectionString);

            try
            {
                string qurey = "insert into TblPatient (IdPatient,Firstname, Lastname,Berthday,Tell,City,Address) values (@IdPatient,@Firstname, @Lastname,@Berthday,@Tell,@City,@Address)";
                SqlCommand cmd = new SqlCommand(qurey, cn);
                cmd.Parameters.AddWithValue("@IdPatient", IdPatient);
                cmd.Parameters.AddWithValue("@Firstname", Firstname);
                cmd.Parameters.AddWithValue("@Lastname", Lastname);
                cmd.Parameters.AddWithValue("@Berthday", Berthday);
                cmd.Parameters.AddWithValue("@Tell", Tell);
                cmd.Parameters.AddWithValue("@City", City);
                cmd.Parameters.AddWithValue("@Address", Address);
                cn.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch
            {
                return false;
            }
            finally
            {
                cn.Close();
            }

        }

        public bool Insert(int IdPatient, string Firstname, string Lastname, string Berthday, string Tell, string City, string Address)
        {
            throw new NotImplementedException();
        }

        public bool Update(int IdPatient, string Firstname, string Lastname, string Berthday, string Tell, string City, string Address)
        {
            throw new NotImplementedException();
        }
    }
}
