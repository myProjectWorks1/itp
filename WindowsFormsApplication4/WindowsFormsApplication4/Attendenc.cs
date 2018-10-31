using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    
    public partial class Attendenc : System.Windows.Forms.Form
    {
        Database db = new Database();
        string x;
        public Attendenc()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime currentTime = DateTime.Now;
            this.button6888.Text = currentTime.ToLongTimeString();
            this.button7566.Text = currentTime.ToLongDateString();
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)

            //{

            //}
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }



            if (bunifuMaterialTextbox2 .Text.Length == 10 )
            {
               // MessageBox.Show("valid");

                //string test = DateTime.ParseExact(DateTime.Now.ToString(), "dd.MM.yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");


                String date1 = DateTime.Now.ToString("yyyy-MM-dd");
                String time1 = DateTime.Now.ToString("HH:mm:ss ");

                Database db = new Database();
                
                

                string cd = bunifuMaterialTextbox2.Text;

                //string ddt= dt.ToString();
                String date2 = DateTime.Now.ToString("yyyy-MM-dd");
                //string test = "2017-11-19";
                MessageBox.Show(Convert.ToString(Convert.ToDateTime("2017-11-19")));
                String qur = "SELECT date FROM attendance WHERE cardid ='" + bunifuMaterialTextbox2.Text + "' and  date = '"+ date2 +"' ";

                String a = db.dbagett(qur);

                // label5.Text = a.Substring(0,10);
                // label6.Text = date1;


                 

                if (String.Compare(date1, a) == 0)
                {
                    //String date2 = DateTime.Now.ToString("dd-MM-yyyy");
                    
                    String qur1 = ("SELECT leave_time FROM attendance WHERE cardid ='" + bunifuMaterialTextbox2.Text + "' and  date = '"+ date2 +"' " );
                    String b = db.dbagett(qur1);
                   
                    
                    
                    
                    if(String.Compare(b,"00:00:00") == 0)
                    {



                        String time2 = DateTime.Now.ToString("HH:mm:ss ");
                        string qu = "Update attendance SET leave_time = '" + time2 + "' WHERE cardid = '" + cd + "'";
                        db.Dbupdate(qu);
                        String qur2 = "SELECT comming_time FROM attendance WHERE cardid ='" + bunifuMaterialTextbox2.Text + "' and date = '"+ date1 +"'" ;
                        String d = db.dbagett(qur2);
                        //label3.Text = d;
                        /* DateTime dateTime3 = DateTime.ParseExact(d, "HH:mm:ss",
                                       CultureInfo.InvariantCulture);

                         //var result = Convert.ToDateTime(time);

                         String t = "05:00:00";
                             DateTime dateTime = DateTime.ParseExact(time2, "HH:mm:ss",
                                         CultureInfo.InvariantCulture);
                             DateTime dateTime1 = DateTime.ParseExact(t, "HH:mm:ss",
                                         CultureInfo.InvariantCulture);*/
                        var dateTime = Convert.ToDateTime(time2);
                        String t = "17:00:00";
                        var dateTime1 = Convert.ToDateTime(t);
                        var dateTime3 = Convert.ToDateTime(d);


                        /*
                            int result = DateTime.Compare(dateTime, dateTime1);
                            //string relationship;




                                if (result < 0)
                            {

                                string work_hour = (dateTime3.Subtract(dateTime).TotalHours).ToString();


                                 label6.Text = work_hour.ToString();
                                string qu2 = "Update attendance SET work_hour = '" + work_hour + "' where cardid= '" + cd + "'";
                                db.Dbupdate(qu2);

                            }

                            else if (result == 0)
                            {

                            }
                            else
                            {
                                label6.Text = "kk";
                                // TimeSpan work_hour1 = dateTime1.Subtract(dateTime3);
                                // TimeSpan ot_hour = dateTime.Subtract(dateTime1);
                                string work_hour1 = (dateTime3.Subtract(dateTime1).TotalHours).ToString();
                                Decimal AA = Convert.ToDecimal(work_hour1) * -1;
                                // int A = -System.Math.Abs(AA) * (-1);
                                String work_hour2 = Convert.ToString(AA);

                                string ot_hour = (dateTime.Subtract(dateTime1).TotalHours).ToString();

                                string qu3 = "Update attendance SET work_time = '" + work_hour2 + "', ot_time = '" + ot_hour + "'   where cardid = '" + cd + "'";
                                db.Dbupdate(qu3);

                                label6.Text = AA.ToString();

                            }




                            */
                        //TimeSpan.Compare(dateTime.TimeOfDay, dateTime1.TimeOfDay)
                       // if (dateTime < dateTime1)
                       if (TimeSpan.Compare(dateTime.TimeOfDay, dateTime1.TimeOfDay)==-1)
                        {

                            // TimeSpan work_hour = dateTime.Subtract(dateTime1);



                                // TimeSpan work_hour = dateTime.Subtract(dateTime1);


                                string work_hour = (dateTime3.Subtract(dateTime).TotalHours).ToString();
                                 Decimal A = Convert.ToDecimal(work_hour) * -1;
                                 String work_hour2 = Convert.ToString(A);

                            // label6.Text = work_hour.ToString();
                            string qu2 = "Update attendance SET work_time = '" + work_hour2 + "' where cardid= '" + cd + "'";
                                db.Dbupdate(qu2);


                            string qu3 = "Update sal_work_hour SET work_time = '" + work_hour2 + "' where cardid= '" + cd + "'";
                            db.Dbupdate1(qu2);

                        }
                            else
                            {
                                
                                // TimeSpan work_hour1 = dateTime1.Subtract(dateTime3);
                                // TimeSpan ot_hour = dateTime.Subtract(dateTime1);
                                string work_hour1 = (dateTime3.Subtract(dateTime1).TotalHours).ToString();
                                Decimal AA = Convert.ToDecimal(work_hour1) * -1;
                         //   Decimal AA = Convert.ToDecimal(work_hour1) ;
                            // int A = -System.Math.Abs(AA) * (-1);
                            String work_hour2 = Convert.ToString(AA);

                                string ot_hour = (dateTime.Subtract(dateTime1).TotalHours).ToString();

                                string qu3 = "Update attendance SET work_time = '" + work_hour2 + "', ot_time = '" + ot_hour + "'   where cardid = '" + cd + "'";
                                db.Dbupdate(qu3);

                            string qu4 = "Update sal_work_hour SET work_time = '" + work_hour2 + "', ot_time = '" + ot_hour + "'   where cardid = '" + cd + "'";
                            db.Dbupdate1(qu4);

                        }

                        }
                        else
                    {
                        MessageBox.Show("YOU ALREADY LEAVE");
                    }
                }
                else
                {
                    //if (String.Compare(time1, "17:00:00") == 0)
                    //{
                    
                    int a1 = Convert.ToInt32(bunifuMaterialTextbox2.Text);
                    string aaa = Convert.ToString(a1);
                    
                    string quuuu = "select empid from emp_reg where cardid ='"+ aaa + "'";
                    Database dss = new Database();
                    string eidd = dss.dbagett(quuuu);

                    String d = "16:00:00";
                    var dateTime123 = Convert.ToDateTime(d);
                    String time2 = DateTime.Now.ToString("HH:mm:ss ");
                    var dateTime5 = Convert.ToDateTime(time2);
                    if  (TimeSpan.Compare(dateTime5.TimeOfDay, dateTime123.TimeOfDay) == -1) {

                        string qu = "insert into attendance (cardid,date,empid,comming_time) values('" + bunifuMaterialTextbox2.Text + "','" + date1 + "' ,'" + eidd + "', '" + time1 + "')";
                        db.DBhand(qu);
                        //MessageBox.Show(Convert.ToString(Convert.ToDateTime(date1)));

                        DateTime date10= (Convert.ToDateTime(date1));

                        string qu8 = "insert into sal_work_hour (cardid,date,empid) values('" + bunifuMaterialTextbox2.Text + "','" + date10 + "' ,'" + eidd + "')";
                        db.DBhand1(qu8);

                    }
                    else
                    {
                        MessageBox.Show("You cannot insert details after 4 pm");
                    }
                    //}
                    //else
                    //{
                      //  MessageBox.Show("You are not allowed to enter");
                    //}
                }
                DataSet ds = db.dbse("SELECT * FROM attendance WHERE date ='" + date1 + "'");
                bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
                //  Database db = new Database();

                /*  string qu = "insert into attendance (cardid,date,comming_time) values('" + bunifuMaterialTextbox2.Text + "','" + date1+ "' , '" + time1 + "')";
                   db.DBhand(qu);*/


                bunifuMaterialTextbox2.Text = "";

                

            }

            if (bunifuMaterialTextbox2.Text.Length >11)
            {
               
                e.Handled = false;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[r];

            x = selectedRow.Cells[1].Value.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
