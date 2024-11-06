using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace RAb_5
{
    public partial class Form2 : Form
    {

        int d;
        string name = "Data Source=ADCLG1;Initial Catalog=CherEPractica;Integrated Security=True";
        //string name = "Data Source=LAPTOP-E9A534AD;Initial Catalog=CherEPractica;Integrated Security=True";
        public Form2(int d1)
        {
            try
            {

                InitializeComponent();
                d = d1;
                SqlConnection MyConnection = new SqlConnection(name);
                MyConnection.Open();
                string sql = $"SELECT FName, Surname, typeName FROM Users, TypeUser where UserID=\'{d}\' and Users.Id_type=TypeUser.Id_type";
                SqlCommand cmd1 = new SqlCommand(sql, MyConnection);
                cmd1.ExecuteNonQuery();
                SqlDataReader Reader1;
                Reader1 = cmd1.ExecuteReader();
                while (Reader1.Read())
                {
                    label3.Text = Reader1[0].ToString();
                    label4.Text = Reader1[1].ToString();
                    label5.Text = "Роль: " + Reader1[2].ToString();
                }

                MyConnection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }

        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form2"].Dispose();
            new Form5(d).Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void повторнаяАвторизацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form2"].Dispose();
            new Form1().Show();
        }

        private void историяВходаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form2"].Dispose();
            new Form8(d).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form2"].Dispose();
            new Form7(d).Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection MyConnection = new SqlConnection(name);
            MyConnection.Open();
            string sql = $"SELECT Id_type from Users where UserID=\'{d}\'";
            SqlCommand cmd1 = new SqlCommand(sql, MyConnection);
            int k1 = Convert.ToInt32(cmd1.ExecuteScalar().ToString());
            MyConnection.Close();
            if (k1 == 4 || k1==2)
            {
                button3.Visible = false;
                историяВходаToolStripMenuItem.Visible = false;
            }
            else
            {
                историяВходаToolStripMenuItem.Visible = true;
                button3.Visible = true;
            }
        }
    }
}
