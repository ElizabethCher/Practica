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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RAb_5
{
    public partial class ДобавлениеКомментариев : Form
    {
        int idZak;
        int d;
        string name = "Data Source=ADCLG1;Initial Catalog=CherEPractica;Integrated Security=True";
        //string name = "Data Source=LAPTOP-E9A534AD;Initial Catalog=CherEPractica;Integrated Security=True";
        public ДобавлениеКомментариев()
        {
            InitializeComponent();
        }
        public ДобавлениеКомментариев(int d1)
        {
            InitializeComponent();
            d = d1;
        }
        private void ДобавлениеКомментариев_Load(object sender, EventArgs e)
        {
            SqlConnection MyConnection = new SqlConnection(name);
            SqlDataReader Reader1, Reader11;
            string sql1 = $"SELECT ReguestID FROM Request where MasterID='{d}'";
            MyConnection.Open();
            SqlCommand cmd1 = new SqlCommand(sql1, MyConnection);
            cmd1.ExecuteNonQuery();
            Reader1 = cmd1.ExecuteReader();
            string sql11 = $"SELECT requestID FROM Comments";
            SqlConnection MyConnection1 = new SqlConnection(name);
            MyConnection1.Open();
            SqlCommand cmd11 = new SqlCommand(sql11, MyConnection1);
            Reader11 = cmd11.ExecuteReader();
            while (Reader1.Read())
            {
                comboBox1.Items.Add(Reader1[0].ToString());
            }
            while (Reader11.Read())
            {
                if (comboBox1.Items.Contains(Reader11[0].ToString()))
                    comboBox1.Items.Remove(Reader11[0].ToString());
            }
            MyConnection1.Close();
            MyConnection.Close();
        }

        private void ДобавлениеКомментариев_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["ДобавлениеКомментариев"].Dispose();
            new Form5(d).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    SqlConnection MyConnection = new SqlConnection(name);

                    MyConnection.Open();
                    string sql = $"INSERT into Comments (requestID, Message) values (\'{comboBox1.Text}\',\'{textBox1.Text}\')";
                    SqlCommand cmd1 = new SqlCommand(sql, MyConnection);
                    cmd1 = new SqlCommand(sql, MyConnection);
                    cmd1.ExecuteScalar();
                    MyConnection.Close();
                    Application.OpenForms["ДобавлениеКомментариев"].Dispose();
                    new Form5(d).Show();
                }
                else
                    MessageBox.Show("Заполните комментарий!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }
    }
}
