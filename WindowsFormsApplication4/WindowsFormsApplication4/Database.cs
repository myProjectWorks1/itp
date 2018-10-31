using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;


namespace WindowsFormsApplication4
{
    class Database
    {
        //connect to database
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=kanuudb");

        public object MetroFramework { get; private set; }
        public object Form1 { get; private set; }

        //insert method

        public void DBhand(String quary)
        {

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
                MessageBox.Show(" "+ e1, "Fail");
            }
            con.Close();

        }
        public void DBhand1(String quary)
        {

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
              //  MessageBox.Show("your details are successfully added.");

            }
            catch (Exception e1)
            {
                //   MetroFramework.MetroMessageBox.Show(Form1.ActiveForm, " " + e1, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                MessageBox.Show(" " + e1, "Fail");
            }
            con.Close();

        }

        //update method
        public void Dbupdate(String quary)
        {

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
        //delete method   public void Dbdelete(String quary)

        public void Dbupdate1(String quary)
        {

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

                // MetroFramework.MetroMessageBox.Show(Form.ActiveForm, "your details are successfully Update.", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
               // MessageBox.Show("your details are successfully update.");
            }
            catch (Exception e1)
            {
                // MetroFramework.MetroMessageBox.Show(Form.ActiveForm, " " + e1,   MessageBox.Show(" "+ e1, "Fail");, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
               // MessageBox.Show(" " + e1, "Fail");
            }
            con.Close();
        }
        //delete method   public void Dbdelete(String quary)




        //select quary method
        public DataSet dbse(String qu)
        {
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

        public void Dbdelete(String quary)
        {

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
        public void Dbselect(String quary)
        {

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

                // MetroFramework.MetroMessageBox.Show(Form.ActiveForm, "your details are successfully Update.", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                MessageBox.Show(" successfully select.");
            }
            catch (Exception e1)
            {
                // MetroFramework.MetroMessageBox.Show(Form.ActiveForm, " " + e1,   MessageBox.Show(" "+ e1, "Fail");, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                MessageBox.Show(" " + e1, "Fail");
            }
            con.Close();
        }
        public DataSet dbse1(String qu)
        {
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
                deta.Dispose();

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
        public String dbagett(string qu)
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
               // MessageBox.Show("Somthing wrong. Please check your database connection." + e);

                return "Error";
            }

        }
    }
}





    
    //class generator
    //{
    //    public static void autoincrement(Control textbox)
    //    {
    //        SqlCommand cmd = new SqlCommand("select max(register) from vehicleID");
    //    }



