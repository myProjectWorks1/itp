using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication4
{

    
    public partial class salary : UserControl
    {

        Database db = new Database();

        double Tsalary;
        String date;
        String date2;
        //double total_salary =0;

        private static salary _instance;
        public static salary Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new salary();
                return _instance;
            }
        }
        public salary()
        {
            InitializeComponent();
            allownces.Text = "0";
            crystalReportViewer1.Visible = false;
            button6.Visible = false;

        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ename.Text = "";
            txtempid.Text = "";
            //rph.Text = "";
            //rpoh.Text = "";
            allownces.Text = "";
           // deduction.Text = "";
           // basicsalary.Text = "";
           

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

/*
         
            Database db = new Database();
            DataSet ds = db.dbse("SELECT comming_time,leave_time FROM attendance WHERE empid ='" + empid.Text + "'");
            DataSet ds1 = db.dbse("SELECT rate_per_hour,rate_per_ot_hour,basic_salary FROM attendance WHERE empid ='" + empid.Text + "'");
            DataSet ds2 = db.dbse("SELECT amount FROM loan WHERE empid ='" + empid.Text + "'");
            if()


    */



        }

        private void basicsalary_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            EmployeeClass db = new EmployeeClass();
            /*  Database db = new Database();
              DataSet ds = db.dbse("SELECT comming_time,leave_time FROM attendance WHERE empid ='" + empid.Text + "'");
              DataSet ds1 = db.dbse("SELECT rate_per_hour,rate_per_ot_hour,basic_salary FROM attendance WHERE empid ='" + empid.Text + "'");
              DataSet ds2 = db.dbse("SELECT amount FROM loan WHERE empid ='" + empid.Text + "'");
              if ()*/
            try
            {
                //string a = "1111";
                String qur1 = "SELECT basic_salary FROM emp_reg WHERE empid =" + txtempid.Text + "  ";
               // string qur1 = "SELECT * FROM emp_reg";
              //  +empid.Text +

                String qur2 = ("SELECT rate_per_hour FROM emp_reg WHERE empid ='" + txtempid.Text + "'  ");
                String b = db.dbgett(qur1);
                //string b = "12";

                String b1 = db.dbgett(qur2);

               // int rate_per_hour = Convert.ToInt32(b1);

                //int basic_salary = Convert.ToInt32(b);
                 var rate_per_hour = Int32.Parse(b1);
                var basic_salary = Int32.Parse(b);



                String qur3 = ("SELECT rate_per_ot_hour FROM emp_reg WHERE empid ='" + txtempid.Text + "'  ");
                String b2 = db.dbgett(qur3);
                                 String qur4 = ("SELECT amount FROM loan WHERE empid ='" + txtempid.Text + "'  ");
                String b3 =  db.dbgett(qur4);
               // int rate_per_ot_hour = Convert.ToInt32(b2);
               // int amount = Convert.ToInt32(b3);
                var rate_per_ot_hour = Int32.Parse(b2);
                var amount = Int32.Parse(b3);


                 date = bunifuDatepicker1.Value.Date.ToString("yyyy-MM-dd");
                DateTime date1 = Convert.ToDateTime(date);
             
                 date2 =  bunifuDatepicker2.Value.Date.ToString("yyyy-MM-dd");
                DateTime date3 = Convert.ToDateTime(date2);
                // date = dateTimePicker1.Value.Date.ToString("YYYY-MM-DD");
                // date2 = dateTimePicker2.Value.Date.ToString("YYYY-MM-DD");

                String QU = (" SELECT SUM(work_time) FROM sal_work_hour WHERE date BETWEEN '" + date + "' AND '" + date2 + "'  AND empid = '" + txtempid.Text + "' ");

               // MessageBox.Show(QU);

                String b4 = db.dbgett(QU);
                                    String QU1 = (" SELECT SUM(ot_time) FROM sal_work_hour WHERE date BETWEEN '" + date + "' AND '" + date2 + "' AND empid = '" + txtempid.Text + "' ");

                String b5 =  db.dbgett(QU1);
               // MessageBox.Show(b4);
               // MessageBox.Show(b5);
                int total_work_time = Convert.ToInt32(b4);
                int total_ot_time = Convert.ToInt32(b5);
               // var total_work_time = Int32.Parse(b2);
                //var total_ot_time = Int32.Parse(b2);

                int allowences = Convert.ToInt32(allownces.Text);
                //if (total_work_time != 0)
                //{
                   if (allowences >= 0)
                   {
                       var total_salary = (total_work_time * rate_per_hour) + (total_ot_time * rate_per_ot_hour) + basic_salary - amount + allowences;
                       label4.Text = "Total Salary is " + Convert.ToString(total_salary);
                       addsalaryDetails();
                    
                       Tsalary = Convert.ToDouble(total_salary.ToString());

                   }
                   else
                    {
                       MessageBox.Show("invalid allownces");
                   }
                //}
                
            }
            catch (Exception ee)
            {
                MessageBox.Show("error"+ee);
            }




        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            searchsalary();
        }

        private void empid_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void empid_Enter(object sender, EventArgs e)
        {
            if (txtempid.Text == "Enter employee id")
            {
                txtempid.Text = "";
                txtempid.ForeColor = Color.Black;
            }
        }

        private void empid_Leave(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            /*  Database db = new Database();
              DataSet ds = db.dbse("SELECT * FROM emp_reg WHERE empid ='" + empid.Text + "'");
              table1234.DataSource = ds.Tables["load"];*/

            searchemployee();
        }
        public void searchemployee()
        {

            //Database db = new Database();
            //DataSet ds = db.dbse("SELECT * FROM emp_reg WHERE nic ='" + search.Text + "'");
            // table12.DataSource = ds.Tables["load"];
            EmployeeClass db = new EmployeeClass();
            DataSet ds = db.Searchemp_id(txtempid.Text);
            table1234.DataSource = ds.Tables["load"];



        }
        public void searchsalary()
        {
            EmployeeClass db = new EmployeeClass();
            DataSet ds = db.Searchsalary(txtempid.Text);
            bunifuCustomDataGrid2.DataSource = ds.Tables["load"];
        }
        public void addsalaryDetails()
        {
            EmployeeClass ds = new EmployeeClass();
            double salary21 =Tsalary;
            //int allownces1 = int.Parse(allownces.Text);
            // public void AddsalaryDetails(string empid, int allownces, double totalSalary,string date1,string date2)
            ds.addsalary(txtempid.Text, allownces.Text, salary21,date,date2);
            label2.Text = Convert.ToString(Tsalary);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=kanuudb");
          // MySqlDataAdapter ada = new MySqlDataAdapter("SELECT * FROM emp_reg ,salary,loan,sal_work_hour WHERE emp_reg.empid = salary.empid and emp_reg.empid = loan.empid AND emp_reg.empid=sal_work_hour.empid and salary.empid = '"+txtempid.Text+"' AND sal_work_hour.date BETWEEN '"+ bunifuDatepicker1.Value.Date.ToString("yyyy-MM-dd") + "' and '" + bunifuDatepicker2.Value.Date.ToString("yyyy-MM-dd") + "'", con);
            MySqlDataAdapter ada = new MySqlDataAdapter("SELECT * FROM emp_reg, salary, sal_work_hour WHERE emp_reg.empid = salary.empid and emp_reg.empid=sal_work_hour.empid and salary.empid = '" + txtempid.Text+ "' AND sal_work_hour.date BETWEEN '" + bunifuDatepicker1.Value.Date.ToString("yyyy-MM-dd") + "' and '" + bunifuDatepicker2.Value.Date.ToString("yyyy-MM-dd") + "'", con);
            DataSet dat = new DataSet();
            ada.Fill(dat, "salary");
            
            crystalReportViewer1.Visible = true;
            CrystalReport3 cry = new CrystalReport3();
            cry.SetDataSource(dat);
            crystalReportViewer1.ReportSource = cry;
            button6.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.Visible = false;
            button6.Visible = false;
        }

        private void table1234_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            DataGridViewRow selectedRow = table1234.Rows[r];
           txtempid.Text = selectedRow.Cells[14].Value.ToString();
        }
    }
}
