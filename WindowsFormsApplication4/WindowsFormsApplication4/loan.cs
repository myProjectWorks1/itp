using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class loan : UserControl
    {
        private static loan _instance;
        public static loan Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new loan();
                return _instance;
            }
        }
        public loan()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void loan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            string qu = "insert into loan (empid,fname,lname,amount,date,description) values('" + empid2.Text + "','" + fname2.Text + "','" + lname2.Text + "','" + amount2.Text + "','"+ dateTimePicker1 + "','"+ description2.Text + "')";
            db.DBhand(qu);

        }

        private void bunifuMaterialTextbox3_OnValueChanged_1(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void empid2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void empid2_Enter(object sender, EventArgs e)
        {
            if (empid2.Text == "Enter Employee ID")
            {
                empid2.Text = "";
                empid2.ForeColor = Color.Black;
            }
        }

        private void empid2_Leave(object sender, EventArgs e)
        {
            if (empid2.Text == "")
            {
                empid2.Text = "Enter Employee ID";
                empid2.ForeColor = Color.Black;
            }
        }

        private void fname2_Enter(object sender, EventArgs e)
        {

            if (fname2.Text == "Enter Employee First Name")
            {
                fname2.Text = "";
                fname2.ForeColor = Color.Black;
            }
        }

        private void fname2_Leave(object sender, EventArgs e)
        {
            if (fname2.Text == "")
            {
                fname2.Text = "Enter Employee First Name";
                fname2.ForeColor = Color.Black;
            }
        }

        private void lname2_Enter(object sender, EventArgs e)
        {

            if (lname2.Text == "Enter Employee Last Name")
            {
                lname2.Text = "";
                lname2.ForeColor = Color.Black;
            }
        }

        private void lname2_Leave(object sender, EventArgs e)
        {
            if (lname2.Text == "")
            {
                lname2.Text = "Enter Employee Last Name";
                lname2.ForeColor = Color.Black;
            }
        }

        private void amount2_Enter(object sender, EventArgs e)
        {

            if (amount2.Text == "Enter Employee salary amount")
            {
                amount2.Text = "";
                amount2.ForeColor = Color.Black;
            }
        }

        private void amount2_Leave(object sender, EventArgs e)
        {
            if (amount2.Text == "")
            {
                amount2.Text = "Enter Employee salary amount";
                amount2.ForeColor = Color.Black;
            }
        }

     /*   private void date_Enter(object sender, EventArgs e)
        {

            if (date.Text == "Enter Date")
            {
                date.Text = "";
                date.ForeColor = Color.Black;
            }
        }*/

     /*   private void date_Leave(object sender, EventArgs e)
        {
            if (date.Text == "")
            {
                date.Text = "Enter Date";
                date.ForeColor = Color.Black;
            }
        }*/

        private void description2_Enter(object sender, EventArgs e)
        {
            
            if (description2.Text == "Enter Description")
            {
                description2.Text = "";
                description2.ForeColor = Color.Black;
            }
        }

        private void description2_Leave(object sender, EventArgs e)
        {

            if (description2.Text == "")
            {
                description2.Text = "Enter Description";
                description2.ForeColor = Color.Black;
            }
        }

        private void clear1_Click(object sender, EventArgs e)
        {
            empid2.Text = "";
            fname2.Text = "";
            lname2.Text = "";
           // date.Text = "";
            amount2.Text = "";
            description2.Text = "";
        
        }

        private void button2_Click(object sender, EventArgs e)
        {

              Database db = new Database();
            DataSet ds = db.dbse("SELECT * FROM loan");
              table123456.DataSource = ds.Tables["load"];
        }
    }
}
