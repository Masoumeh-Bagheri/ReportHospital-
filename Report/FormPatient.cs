using Report.Repository;
using Report.Servises;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report
{
    public partial class FormPatient : Form
    {
        IcontactRepository repository;
        // از خود فرم یک نمونه می سازم که بتوانم از فرم های دیگر به این فرم دسترسی داشته باشم و از مقادیر ان استفاده کنم
        public static FormPatient instance;
        //public TextBox txtIdpatient1, txtLastname1, txtFirstname1, txtBerthday1;

        public void Bindgrid(string tblName)
        {
            dgPatient.DataSource = repository.selectAll(tblName);
        }
        bool IsValidateOperator()
        {
            if (txtIdPatient.Text == "")
            {
                MessageBox.Show("Please Write Id Patient.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            if (txtFirstname.Text == "")
            {
                MessageBox.Show("Please Write Firstname.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            if (txtLastname.Text == "")
            {
                MessageBox.Show("Please Write Lastname.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }

            if (txtBerthday.Text == "")
            {
                MessageBox.Show("Please Write Berthday.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            if (txtTell.Text == "")
            {
                MessageBox.Show("Please Write Tell.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            if (txtCity.Text == "")
            {
                MessageBox.Show("Please Write City.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Please Write Address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            return true;
        }
        public FormPatient()
        {
            InitializeComponent();
            // از خود فایل به متغیر خود فایل می ریزم تا بعدا بتوانم به این مقادیر و کنتر های این فایل دسترسی داشته باشم
            instance = this;
            //txtBerthday1 = instance.txtBerthday;
            //txtFirstname1 = instance.txtFirstname;
            //txtLastname1 = instance.txtLastname;
            //txtIdpatient1 = instance.txtIdPatient;
            repository = new Contactrepository();
        }

        private void FormPatient_Load(object sender, EventArgs e)
        {
            dgPatient.DataSource = repository.selectAll("TblPatient");
        }

        private void dgPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Form_Treatment ft= new Form_Treatment();
           
            if (dgPatient.CurrentRow != null)
            {
                //ft.Idpatient =Convert.ToInt32 (dgPatient.CurrentRow.Cells[0].Value.ToString());
                txtIdPatient.Text = dgPatient.CurrentRow.Cells[0].Value.ToString();
                txtFirstname.Text = dgPatient.CurrentRow.Cells[1].Value.ToString();
                txtLastname.Text = dgPatient.CurrentRow.Cells[2].Value.ToString();
                txtBerthday.Text = dgPatient.CurrentRow.Cells[3].Value.ToString();
                txtTell.Text = dgPatient.CurrentRow.Cells[4].Value.ToString();
                txtCity.Text = dgPatient.CurrentRow.Cells[5].Value.ToString();
                txtAddress.Text = dgPatient.CurrentRow.Cells[6].Value.ToString();

                //مقدار دهی اشیاع داخل فرم مداوا با مقادیر موجود در این فرم
                Form_Treatment.instance.txtIdpatient1.Text = txtIdPatient.Text;
                Form_Treatment.instance.txtFirstname1.Text = txtFirstname.Text;
                Form_Treatment.instance.txtLastname1.Text = txtLastname.Text;
                Form_Treatment.instance.txtBerthday1.Text = txtBerthday.Text;
            }
                
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(IsValidateOperator()==true)
            {
                bool istSuccess = repository.Insert(Convert.ToInt32(txtIdPatient.Text), txtFirstname.Text, txtLastname.Text, Convert.ToDateTime(txtBerthday.Text), txtTell.Text, txtCity.Text, txtAddress.Text);
                if (istSuccess == true)
                {
                    MessageBox.Show("Patient information was saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Bindgrid("TblPatient");

                }
                else
                {
                    MessageBox.Show("Patient information didnot save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dgPatient.CurrentRow != null)
            {
                if (MessageBox.Show("Are you shure you want to Update the record!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int IdTreatment = int.Parse(dgPatient.CurrentRow.Cells[0].Value.ToString());
                    repository.Update( Convert.ToInt32(txtIdPatient.Text),txtFirstname.Text,txtLastname.Text,Convert.ToDateTime(txtBerthday.Text),txtTell.Text,txtCity.Text,txtAddress.Text );
                    Bindgrid("TblPatient");
                }
            }
            else
            {
                MessageBox.Show("Please select one Row.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dgPatient.CurrentRow != null)
            {
                if (MessageBox.Show("Are you shure you want to delete the record!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int IdPatient= int.Parse(dgPatient.CurrentRow.Cells[0].Value.ToString());
                    repository.Delete(IdPatient, "TblPatient");
                    Bindgrid("TblPatient");
                }

            }
            else
            {
                MessageBox.Show("Please select one Row.");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            //مقدار دهی اشیاع داخل فرم مداوا با مقادیر موجود در این فرم
            Form_Treatment.instance.txtIdpatient1.Text = txtIdPatient.Text;
            Form_Treatment.instance.txtFirstname1.Text = txtFirstname.Text;
            Form_Treatment.instance.txtLastname1.Text = txtLastname.Text;
            Form_Treatment.instance.txtBerthday1.Text = txtBerthday.Text;
            this.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
