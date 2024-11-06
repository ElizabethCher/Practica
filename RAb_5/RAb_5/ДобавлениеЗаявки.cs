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
    public partial class ДобавлениеЗаявки : Form
    {
        int d;
        string name = "Data Source=ADCLG1;Initial Catalog=CherEPractica;Integrated Security=True";
        //string name = "Data Source=LAPTOP-E9A534AD;Initial Catalog=CherEPractica;Integrated Security=True";
        public ДобавлениеЗаявки()
        {
            InitializeComponent();
        }
        public ДобавлениеЗаявки(int d1)
        {
            InitializeComponent();
            d = d1;
        }
        private void ДобавлениеЗаявки_Load(object sender, EventArgs e)
        {
            try
            {
                comboBox2.Enabled = false;
                SqlConnection MyConnection = new SqlConnection(name);
                SqlDataReader Reader1;
                string sql1 = $"SELECT HomeTechTypeName FROM HomeTechType";
                MyConnection.Open();
                SqlCommand cmd1 = new SqlCommand(sql1, MyConnection);
                cmd1.ExecuteNonQuery();
                Reader1 = cmd1.ExecuteReader();
                while (Reader1.Read())
                {
                    comboBox1.Items.Add(Reader1[0].ToString());
                }
                MyConnection.Close();
                sql1 = $"SELECT ProblemDescryptionName FROM ProblemDescryption";
                MyConnection.Open();
                cmd1 = new SqlCommand(sql1, MyConnection);
                cmd1.ExecuteNonQuery();
                Reader1 = cmd1.ExecuteReader();
                while (Reader1.Read())
                {
                    comboBox3.Items.Add(Reader1[0].ToString());
                }
                MyConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }

        }

        private void ДобавлениеЗаявки_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["ДобавлениеЗаявки"].Dispose();
            new Form5(d).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection MyConnection = new SqlConnection(name);
                MyConnection.Open();
                string sql = $"SELECT HomeTechModelID from HomeTechModel where HomeTechModelName = \'{comboBox2.Text}\'";
                SqlCommand cmd1 = new SqlCommand(sql, MyConnection);
                int model = Convert.ToInt32(cmd1.ExecuteScalar().ToString());
                MyConnection.Close();
                MyConnection.Open();
                sql = $"SELECT ProblemDescryptionID from ProblemDescryption where ProblemDescryptionName = \'{comboBox3.Text}\'";
                cmd1 = new SqlCommand(sql, MyConnection);
                int problem = Convert.ToInt32(cmd1.ExecuteScalar().ToString());
                MyConnection.Close();
                MyConnection.Open();
                sql = $"INSERT into Request (HomeTechModelID, ProblemDescryptionID, ClientID) values (\'{model}\',\'{problem}\',\'{d}\')";
                cmd1 = new SqlCommand(sql, MyConnection);
                cmd1.ExecuteScalar();
                MyConnection.Close();
                Application.OpenForms["ДобавлениеЗаявки"].Dispose();
                new Form5(d).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBox2.Items.Clear();
                comboBox2.Enabled = true;
                SqlConnection MyConnection = new SqlConnection(name);
                SqlDataReader Reader1;
                string sql1 = $"SELECT HomeTechTypeID FROM HomeTechType where HomeTechTypeName=\'{comboBox1.Text}\'";
                MyConnection.Open();
                SqlCommand cmd1 = new SqlCommand(sql1, MyConnection);
                int type = Convert.ToInt32(cmd1.ExecuteScalar().ToString());
                MyConnection.Close();
                sql1 = $"SELECT HomeTechModelName FROM HomeTechModel where HomeTechTypeTypeID=\'{type}\'";
                MyConnection.Open();
                cmd1 = new SqlCommand(sql1, MyConnection);
                cmd1.ExecuteNonQuery();
                Reader1 = cmd1.ExecuteReader();
                while (Reader1.Read())
                {
                    comboBox2.Items.Add(Reader1[0].ToString());
                }
                MyConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }
    }
}
