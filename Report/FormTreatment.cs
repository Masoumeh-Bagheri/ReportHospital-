using Report.Repository;
using Report.Servises;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report
{
    
    public partial class Form_Treatment : Form
    {
        public static Form_Treatment instance;
        //private string ConectionString = "Data Source=(localdb)\\ProjectModels; Initial Catalog=DBGesundheit; Integrated Security= true";
        IcontactRepository repository;
        public TextBox txtIdpatient1,txtLastname1,txtFirstname1,txtBerthday1;

        //public int Idpatient=-1;
        public void Bindgrid(string TblName)
        {
            dgTreatment.DataSource = repository.selectAll(TblName);
        }
        bool IsValidateOperator()
        {
            if (TxtIdTreatment.Text == "")
            {
                MessageBox.Show("Please Write Id Patient.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            if (TxtIdPatient.Text=="")
            {
                MessageBox.Show("Please Write Id Patient.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            if (TxtAge.Text == "")
            {
                MessageBox.Show("Please Write Age.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
           
            if (TxtWaitingTime.Text == "")
            {
                MessageBox.Show("Please Write Watingtime.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            if (TxtDiagnosis.Text == "")
            {
                MessageBox.Show("Please Write Diagnosis.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            if (TxtTreatment.Text == "")
            {
                MessageBox.Show("Please Write Treatment.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            return true;
        }
        public Form_Treatment()
        {
            InitializeComponent();
            instance = this;
            txtBerthday1=instance.txtBerthday;
            txtFirstname1 = instance.txtFirstname;
            txtLastname1 = instance.txtLastname;
            txtIdpatient1 = instance.TxtIdPatient;
            repository = new Contactrepository();
        }

        private void buttonListPatient_Click(object sender, EventArgs e)
        {
            FormPatient patient = new FormPatient();
            patient.Show();
        }

        private void Form_Treatment_Load(object sender, EventArgs e)
        {
            dgTreatment.DataSource = repository.selectAll("TblTreatment");
            //if (Idpatient != -1)
            //{
            //    DataTable dt = new DataTable();
            //    dt= repository.selectRow(Idpatient);
            //    TxtIdPatient.Text= dt.Rows[0][0].ToString();
            //    txtFirstname.Text= dt.Rows[0][1].ToString();
            //    txtLastname.Text= dt.Rows[0][2].ToString();
            //    txtBerthday.Text= dt.Rows[0][3].ToString();
            //}

                
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (IsValidateOperator())
            {
                bool isSuccess = repository.Insert(Convert.ToInt32(TxtIdTreatment.Text), Convert.ToInt32(TxtIdPatient.Text), Convert.ToInt32(TxtAge.Text), Convert.ToInt32(TxtWaitingTime.Text), TxtDiagnosis.Text, TxtTreatment.Text);

                if (isSuccess == true)
                {
                    MessageBox.Show("Patient information was saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Bindgrid("TblTreatment");

                }
                else
                {
                    MessageBox.Show("Patient information didnot save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dgTreatment.CurrentRow != null)
            {
                if (MessageBox.Show("Are you shure you want to delete the record!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                { 
                int IdTreatment = int.Parse(dgTreatment.CurrentRow.Cells[0].Value.ToString());
                repository.Delete(IdTreatment,"TblTreatment");
                    Bindgrid("TblTreatment");
                }

            }
            else
            {
                MessageBox.Show("Please select one Row.");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if(dgTreatment.CurrentRow != null)  {
                if(MessageBox.Show("Are you shure you want to Update the record!","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    int IdTreatment = int.Parse(dgTreatment.CurrentRow.Cells[0].Value.ToString());
                    repository.Update(IdTreatment, Convert.ToInt32(TxtIdPatient.Text), Convert.ToInt32(TxtAge.Text), Convert.ToInt32(TxtWaitingTime.Text), TxtDiagnosis.Text, TxtTreatment.Text);
                    Bindgrid("TblTreatment");
                }
            }
            else
            {
                MessageBox.Show("Please select one Row.");
            }
        }

        private void dgTreatment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtIdTreatment.Text = dgTreatment.CurrentRow.Cells[0].Value.ToString();
            TxtIdPatient.Text = dgTreatment.CurrentRow.Cells[1].Value.ToString();
            TxtAge.Text = dgTreatment.CurrentRow.Cells[2].Value.ToString();
            TxtWaitingTime.Text = dgTreatment.CurrentRow.Cells[3].Value.ToString();
            TxtDiagnosis.Text = dgTreatment.CurrentRow.Cells[4].Value.ToString();
            TxtTreatment.Text = dgTreatment.CurrentRow.Cells[5].Value.ToString();

        }

        private void dgTreatment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtIdTreatment.Text = dgTreatment.CurrentRow.Cells[0].Value.ToString();
            TxtIdPatient.Text = dgTreatment.CurrentRow.Cells[1].Value.ToString();
            TxtAge.Text = dgTreatment.CurrentRow.Cells[2].Value.ToString();
            TxtWaitingTime.Text = dgTreatment.CurrentRow.Cells[3].Value.ToString();
            TxtDiagnosis.Text = dgTreatment.CurrentRow.Cells[4].Value.ToString();
            TxtTreatment.Text = dgTreatment.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
