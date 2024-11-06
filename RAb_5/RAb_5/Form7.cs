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
using System.Xml.Linq;

namespace RAb_5
{
    public partial class Form7 : Form
    {
        string name = "Data Source=ADCLG1;Initial Catalog=CherEPractica;Integrated Security=True";
        //string name = "Data Source=LAPTOP-E9A534AD;Initial Catalog=CherEPractica;Integrated Security=True";
        public Form7()
        {
            InitializeComponent();
        }
        int d;
        public Form7(int d1)
        {
            InitializeComponent();
            d = d1;
        }
        private void вГлавноеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form7"].Dispose();
            new Form2(d).Show();
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            SqlConnection MyConnection = new SqlConnection(name);

            MyConnection.Open();

            string sql = "SELECT UserID, FName, Surname, Patronymic, Phone, Login, typeName FROM Users, TypeUser\r\nwhere Users.Id_type=TypeUser.Id_type";
            SqlCommand cmd1 = new SqlCommand(sql, MyConnection);
            cmd1.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, MyConnection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            statusStrip1.Items[0].Text = "Всего записей: " + dataGridView1.Rows.Count + "Из: " + dataGridView1.Rows.Count;
            dataGridView1.Columns["UserID"].HeaderText = "id";
            dataGridView1.Columns["FName"].HeaderText = "Имя";
            dataGridView1.Columns["Surname"].HeaderText = "Фамилия";
            dataGridView1.Columns["Patronymic"].HeaderText = "Отчество";
            dataGridView1.Columns["Phone"].HeaderText = "Номер телефона";
            dataGridView1.Columns["Login"].HeaderText = "Логин";
            dataGridView1.Columns["typeName"].HeaderText = "Тип";
            MyConnection.Close();
        }
    }
}
