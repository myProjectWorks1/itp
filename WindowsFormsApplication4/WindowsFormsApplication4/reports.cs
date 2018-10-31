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

    public partial class reports : UserControl
    {
        private static reports _instance;
        public static reports Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new reports();
                return _instance;
            }
        }
        public reports()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CrystalReport1 cry = new CrystalReport1();
            crystalReportViewer1.ReportSource = cry;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CrystalReport2 cry = new CrystalReport2();
            crystalReportViewer1.ReportSource = cry;
        }
    }
}
