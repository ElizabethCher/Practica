using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAb_5
{
    public partial class Form8 : Form
    {
        int k = 0;
        int d;
        DataTable ds;
        string name = "Data Source=ADCLG1;Initial Catalog=CherEPractica;Integrated Security=True";
        //string name = "Data Source=LAPTOP-E9A534AD;Initial Catalog=CherEPractica;Integrated Security=True";
        public Form8(int d1)
        {
            InitializeComponent();
            d = d1;
        }

        private void вГлавноеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form8"].Dispose();
            new Form2(d).Show();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            SqlConnection MyConnection = new SqlConnection(name);

            MyConnection.Open();

            string sql = "SELECT HistoryID, Login, dateAuto, Value FROM HistoryAutorez";
            SqlCommand cmd1 = new SqlCommand(sql, MyConnection);
            cmd1.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, MyConnection);
            ds = new DataTable();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds;//.Tables[0];
            dataGridView1.Columns["HistoryID"].HeaderText = "id";
            dataGridView1.Columns["Login"].HeaderText = "Логин";
            dataGridView1.Columns["dateAuto"].HeaderText = "Дата";
            dataGridView1.Columns["Value"].HeaderText = "Верный/неверный";
            dataGridView1.Columns["Value"].Width = 200;
            MyConnection.Close();

            //dataGridView1.DataSource = ds.Tables[0];
            k = dataGridView1.Rows.Count;
            statusStrip1.Items[0].Text = "Всего записей: " + dataGridView1.Rows.Count + "Из: " + k;
        }

        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filter = "";
            string[] keywords = textBox1.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var keyword in keywords)
            {
                if (filter.Length > 0)
                {
                    filter += " AND ";

                }

                    filter += $"[Login] LIKE '%{keyword}%'";

            }

            DataView dataView = new DataView(ds);
            dataView.RowFilter = filter;

            dataGridView1.DataSource = dataView;
            statusStrip1.Items[0].Text = "Всего записей: " + dataGridView1.Rows.Count + "Из: " + k;
        }
    }
}
