using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace davaleba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn_1 = new SqlConnection("server=BTU404-13\\SQLEXPRESS;DATABASE=Shekveta;uid=sa;pwd=1");
            conn_1.Open();
            SqlCommand comm_1 = conn_1.CreateCommand();
            comm_1.CommandText = "SELECT COUNT(*) FROM Shemkveti WHERE qalaqi=N'თბილისი'";
            object count_1 = comm_1.ExecuteScalar();
            label1.Text = count_1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn_2 = new SqlConnection("server=BTU404-13\\SQLEXPRESS;DATABASE=Shekveta;uid=sa;pwd=1");
            conn_2.Open();
            SqlCommand comm_2 = conn_2.CreateCommand();
            comm_2.CommandText = "SELECT COUNT(*) FROM Xelshekruleba WHERE gadasaxdeli_l > 3000";
            object count_2 = comm_2.ExecuteScalar();
            label1.Text = count_2.ToString();

        }
    }
}
