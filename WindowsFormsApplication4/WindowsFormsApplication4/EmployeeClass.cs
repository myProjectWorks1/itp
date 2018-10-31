using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WindowsFormsApplication4
{
    class EmployeeClass
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=kanuudb");
        public void AddEmployeeDetails(string fname, string lname, string dob, string gender, string address1, string address2, string city, string nic, string tel, string position, string cardid, double salary, int rpt, int rpot, string empid)
        {
            string quary = "insert into emp_reg (fname,lname,dob,gender,address1,address2,city,nic,tel,position,cardid,basic_salary,rate_per_hour,rate_per_ot_hour,empid) values('" + fname + "','" + lname + "','" + dob + "','" + gender + "','" + address1 + "','" + address2 + "','" + city + "','" + nic + "','" + Convert.ToInt32(tel) + "','" + position + "','" + Convert.ToInt32(cardid) + "','" + salary + "','" + rpt + "','" + rpot + "','" + empid + "')";
            if (con.State.ToString() == "Closed")
            {
                con.Open();
            }

            MySqlCommand cmd = con.CreateCommand();

            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = quary;
                cmd.ExecuteNonQuery();

                // MetroFramework.MetroMessageBox.Show(Form1.ActiveForm, "your details are successfully added.", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                MessageBox.Show("your details are successfully added.");

            }
            catch (Exception e1)
            {
                //   MetroFramework.MetroMessageBox.Show(Form1.ActiveForm, " " + e1, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                MessageBox.Show(" " + e1, "Fail");
            }
            con.Close();



        }
        public void Register(string fname, string lname, string dob, string gender, string address1, string address2, string city, string nic, string tel, string position, string cardid, string salary, string rpt, string rpot, string empid)

        {
            if (fname != "" && lname != "" && address1 != "" && address2 != "" && city != "" && nic != "" && tel != "" && cardid != "" && salary != "" && rpt != "" && rpot != "" && empid != "")
            {
                double salary1 = double.Parse(salary);
                int rpt1 = int.Parse(rpt);
                int rpot1 = int.Parse(rpot);
                AddEmployeeDetails(fname, lname, dob, gender, address1, address2, city, nic, tel, position, cardid, salary1, rpt1, rpot1, empid);


            }
            else
            {
                MessageBox.Show("can't have empty value");
            }
        }
        public DataSet SearchNic(string searchNic)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=kanuudb");
            string query = ("SELECT * FROM emp_reg ");
            if (con.State.ToString() == "Closed")
            {
                con.Open();
            }

            try
            {
                MySqlCommand cmdg = con.CreateCommand();
                cmdg.Connection = con;
                cmdg.CommandType = CommandType.Text;

                cmdg.CommandText = query;

                MySqlDataAdapter deta = new MySqlDataAdapter(cmdg);
                DataSet ds = new DataSet();
                deta.Fill(ds, "load");

                con.Close();
                return ds;
            }
            catch (Exception)
            {
                MessageBox.Show("Somthing wrong. Please check your database connection.");
                DataSet ee = new DataSet();
                return ee;
            }

        }
        public void UpdateDetails(string fname, string cardid, string lname, string address1, string Telephone, string position, string dob, string gender, string nic)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=kanuudb");
            string qu = "Update emp_reg SET fname = '" + fname + "',cardid = '" + cardid + "', lname = '" + lname + "', address1 = '" + address1 + "', tel = '" + Telephone + "', position= '" + position + "', dob= '" + dob + "',gender =  'M' where nic = '" + nic + "' ";
            if (con.State.ToString() == "Closed")
            {
                con.Open();
            }

            MySqlCommand cmd = con.CreateCommand();

            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = qu;
                cmd.ExecuteNonQuery();

                // MetroFramework.MetroMessageBox.Show(Form.ActiveForm, "your details are successfully Update.", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                MessageBox.Show("your details are successfully update.");
            }
            catch (Exception e1)
            {
                // MetroFramework.MetroMessageBox.Show(Form.ActiveForm, " " + e1,   MessageBox.Show(" "+ e1, "Fail");, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                MessageBox.Show(" " + e1, "Fail");
            }
            con.Close();
        }
        public void DeleteDetails(String nic)
        {

            string qu = ("DELETE  FROM emp_reg WHERE  nic ='" + nic + "'");

            if (con.State.ToString() == "Closed")
            {
                con.Open();
            }

            MySqlCommand cmd = con.CreateCommand();

            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = qu;
                cmd.ExecuteNonQuery();

                // MetroFramework.MetroMessageBox.Show(Form.ActiveForm, "your details are successfully Update.", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                MessageBox.Show(" successfully delete.");
            }
            catch (Exception e1)
            {
                // MetroFramework.MetroMessageBox.Show(Form.ActiveForm, " " + e1,   MessageBox.Show(" "+ e1, "Fail");, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                MessageBox.Show(" " + e1, "Fail");
            }
            con.Close();
        }
        public DataSet Searchemp_id(string searchemp)
        {
            string qu = ("SELECT * FROM emp_reg ");
            if (con.State.ToString() == "Closed")
            {
                con.Open();
            }

            try
            {
                MySqlCommand cmdg = con.CreateCommand();
                cmdg.Connection = con;
                cmdg.CommandType = CommandType.Text;

                cmdg.CommandText = qu;

                MySqlDataAdapter deta = new MySqlDataAdapter(cmdg);
                DataSet ds = new DataSet();
                deta.Fill(ds, "load");

                con.Close();
                return ds;
            }
            catch (Exception)
            {
                MessageBox.Show("Somthing wrong. Please check your database connection.");
                DataSet ee = new DataSet();
                return ee;
            }
        }
        public DataSet Searchsalary(string searchemp)
        {
            String qu = ("SELECT * FROM salary WHERE empid ='" + searchemp + "'");
            if (con.State.ToString() == "Closed")
            {
                con.Open();
            }

            try
            {
                MySqlCommand cmdg = con.CreateCommand();
                cmdg.Connection = con;
                cmdg.CommandType = CommandType.Text;

                cmdg.CommandText = qu;

                MySqlDataAdapter deta = new MySqlDataAdapter(cmdg);
                DataSet ds = new DataSet();
                deta.Fill(ds, "load");

                con.Close();
                return ds;
            }
            catch (Exception)
            {
                MessageBox.Show("Somthing wrong. Please check your database connection.");
                DataSet ee = new DataSet();
                return ee;
            }

        }


        public String dbgett(string qu)
        {
            //String txt;
            // List<String> list = new List<string>();
            String gett;



            if (con.State.ToString() == "Closed")
            {
                con.Open();
            }
            MySqlCommand cmd = con.CreateCommand();

            try
            {

                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = qu;


                object p = cmd.ExecuteScalar();
                gett = p.ToString();
                con.Close();

                /*   while (p.Read())
                   {
                       gett[1] =  p["T"];

                       // list.Add(p.GetString(0));
                   }
                   //txt = p.ToString();
                   */

                //con.Close();
                // return list.ToArray();
                return gett;
            }
            catch (Exception e)
            {
                MessageBox.Show("Somthing wrong. Please check your database connection." + e);

                return "Error";
            }

        }
        public void AddsalaryDetails(string empid, int allownces, double totalSalary,string date1,string date2)
        {
            string quary = "insert into salary (empid,allownces,totalSalary,date1,date2) values('" + empid + "','" + allownces + "','" + totalSalary + "','" +date1+ "','"+date2+ "')";
            if (con.State.ToString() == "Closed")
            {
                con.Open();
            }

            MySqlCommand cmd = con.CreateCommand();

            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = quary;
                cmd.ExecuteNonQuery();

                // MetroFramework.MetroMessageBox.Show(Form1.ActiveForm, "your details are successfully added.", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                MessageBox.Show("your details are successfully added.");

            }
            catch (Exception e1)
            {
                //   MetroFramework.MetroMessageBox.Show(Form1.ActiveForm, " " + e1, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                MessageBox.Show(" " + e1, "Fail");
            }
            con.Close();

        }
        public void addsalary(string empid, string allownces, double totalSalary,string date1,string date2)

        {
            //   string basic = salary.ToString();
            // string rph = rpt.ToString();
            // string rpoh = rpot.ToString();
            if (empid != "" )
            {
                //double salary21 = double.Parse(totalSalary);
               int allownces1 = int.Parse(allownces);

                AddsalaryDetails( empid, allownces1,totalSalary,date1,date2);

            }
            else
            {
                MessageBox.Show("can't have empty value");
            }
        }
        public DataSet Searchcardid()
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=kanuudb");
            string query = ("SELECT * FROM emp_reg ");
            if (con.State.ToString() == "Closed")
            {
                con.Open();
            }

            try
            {
                MySqlCommand cmdg = con.CreateCommand();
                cmdg.Connection = con;
                cmdg.CommandType = CommandType.Text;

                cmdg.CommandText = query;

                MySqlDataAdapter deta = new MySqlDataAdapter(cmdg);
                DataSet ds = new DataSet();
                deta.Fill(ds, "load");

                con.Close();
                return ds;
            }
            catch (Exception)
            {
                MessageBox.Show("Somthing wrong. Please check your database connection.");
                DataSet ee = new DataSet();
                return ee;
            }

        }
    }
}
