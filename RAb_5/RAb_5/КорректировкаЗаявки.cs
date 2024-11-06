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
    public partial class КорректировкаЗаявки : Form
    {
         string name = "Data Source=ADCLG1;Initial Catalog=CherEPractica;Integrated Security=True";
        //string name = "Data Source=LAPTOP-E9A534AD;Initial Catalog=CherEPractica;Integrated Security=True";
        public КорректировкаЗаявки()
        {
            InitializeComponent();
        }
        string k1;
        int d;
        public КорректировкаЗаявки(int d1)
        {
            InitializeComponent();
            this.d = d1;
        }

        private void КорректировкаЗаявки_Load(object sender, EventArgs e)
        {
            Dostup();
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
            /*sql1 = $"SELECT ReguestID FROM Request where ClientID=\'{d}\'";
            MyConnection.Open();
            cmd1 = new SqlCommand(sql1, MyConnection);
            cmd1.ExecuteNonQuery();
            Reader1 = cmd1.ExecuteReader();
            while (Reader1.Read())
            {
                comboBox4.Items.Add(Reader1[0].ToString());
            }
            MyConnection.Close();*/
            sql1 = $"SELECT RequestStatusName FROM RequestStatus";
            MyConnection.Open();
            cmd1 = new SqlCommand(sql1, MyConnection);
            cmd1.ExecuteNonQuery();
            Reader1 = cmd1.ExecuteReader();
            while (Reader1.Read())
            {
                comboBox7.Items.Add(Reader1[0].ToString());
            }
            MyConnection.Close();
            sql1 = $"SELECT RepairPartsName FROM RepairParts";
            MyConnection.Open();
            cmd1 = new SqlCommand(sql1, MyConnection);
            cmd1.ExecuteNonQuery();
            Reader1 = cmd1.ExecuteReader();
            while (Reader1.Read())
            {
                comboBox6.Items.Add(Reader1[0].ToString());
            }
            MyConnection.Close();

            sql1 = $"select FName from Users,TypeUser  where Users.Id_type=TypeUser.Id_type";
            MyConnection.Open();
            cmd1 = new SqlCommand(sql1, MyConnection);
            cmd1.ExecuteNonQuery();
            Reader1 = cmd1.ExecuteReader();
            while (Reader1.Read())
            {
                comboBox5.Items.Add(Reader1[0].ToString());
            }
            MyConnection.Close();
        }


        private void Dostup()
        {
            SqlConnection MyConnection = new SqlConnection(name);
            MyConnection.Open();
            string sql = $"SELECT Id_type from Users where UserID=\'{d}\'";
            SqlCommand cmd1 = new SqlCommand(sql, MyConnection);
            k1 = cmd1.ExecuteScalar().ToString();
            MyConnection.Close();
            sql = $"SELECT ReguestID FROM Request where ClientID=\'{d}\'";

            if (Convert.ToInt32(k1) == 4)//клиент
            {
                sql = $"SELECT ReguestID FROM Request where ClientID=\'{d}\'";
                label10.Visible = false;
                comboBox7.Visible = false;
                label7.Visible = false;
                comboBox6.Visible = false;
                label6.Visible = false;
                comboBox5.Visible = false;
                label8.Visible = false;
                dateTimePicker1.Visible = false;
                label9.Visible = false;
                dateTimePicker2.Visible = false;
            }
            if (Convert.ToInt32(k1) == 3)//оператор
            {
                sql = $"SELECT ReguestID FROM Request";
                label4.Visible = false;
                comboBox3.Visible = false;
                label3.Visible = false;
                comboBox2.Visible = false;
                label2.Visible = false;
                comboBox1.Visible = false;
                label8.Visible = false;
                dateTimePicker1.Visible = false;
                label9.Visible = false;
                dateTimePicker2.Visible = false;
                label7.Visible = false;
                comboBox6.Visible = false;
                label10.Visible = false;
                comboBox7.Visible = false;
            }
            if (Convert.ToInt32(k1) == 1)//оператор
            {
                sql = $"SELECT ReguestID FROM Request";
                label4.Visible = false;
                comboBox3.Visible = false;
                label3.Visible = false;
                comboBox2.Visible = false;
                label2.Visible = false;
                comboBox1.Visible = false;
                label8.Visible = false;
                dateTimePicker1.Visible = false;
                label9.Visible = true;
                dateTimePicker2.Visible = true;
                label7.Visible = false;
                comboBox6.Visible = false;
                label10.Visible = false;
                comboBox7.Visible = false;
            }
            if (Convert.ToInt32(k1) == 2)//мастер
            {
                sql = $"SELECT ReguestID FROM Request where MasterID='{d}'";
                label6.Visible = false;
                comboBox5.Visible = false;
                label2.Visible = false;
                comboBox1.Visible = false;
                label3.Visible = false;
                comboBox2.Visible = false;
                label4.Visible = false;
                comboBox3.Visible = false;
            }
            SqlDataReader Reader1;
            MyConnection.Open();
            cmd1 = new SqlCommand(sql, MyConnection);
            cmd1.ExecuteNonQuery();
            Reader1 = cmd1.ExecuteReader();
            while (Reader1.Read())
            {
                comboBox4.Items.Add(Reader1[0].ToString());
            }
            MyConnection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection MyConnection = new SqlConnection(name);
                MyConnection.Open();
                string sql;
                SqlCommand cmd1;
                if (Convert.ToInt32(k1) == 4)
                {
                    sql = $"SELECT HomeTechModelID from HomeTechModel where HomeTechModelName  = \'{comboBox2.Text}\'";
                    cmd1 = new SqlCommand(sql, MyConnection);
                    int model = Convert.ToInt32(cmd1.ExecuteScalar().ToString());
                    MyConnection.Close();
                    MyConnection.Open();
                    sql = $"SELECT ProblemDescryptionID from ProblemDescryption where ProblemDescryptionName = \'{comboBox3.Text}\'";
                    cmd1 = new SqlCommand(sql, MyConnection);
                    int problem = Convert.ToInt32(cmd1.ExecuteScalar().ToString());
                    MyConnection.Close();
                    MyConnection.Open();
                    sql = $"UPDATE Request set HomeTechModelID=\'{model}\', ProblemDescryptionID=\'{problem}\' where ReguestID=\'{comboBox4.Text}\'";
                    cmd1 = new SqlCommand(sql, MyConnection);
                    cmd1.ExecuteScalar();
                    MyConnection.Close();
                }
                if (Convert.ToInt32(k1) == 3)
                {
                    sql = $"select UserID from Users  where FName= \'{comboBox5.Text}\'";
                    cmd1 = new SqlCommand(sql, MyConnection);
                    string UserID = cmd1.ExecuteScalar().ToString();
                    MyConnection.Close();
                    MyConnection.Open();
                    sql = $"UPDATE Request set MasterID=\'{UserID}\' where ReguestID=\'{comboBox4.Text}\'";
                    cmd1 = new SqlCommand(sql, MyConnection);
                    cmd1.ExecuteScalar();
                    MyConnection.Close();
                }
                if ((Convert.ToInt32(k1)) == 2)
                {
                    sql = $"select RequestStatusID from RequestStatus  where RequestStatusName= \'{comboBox7.Text}\'";
                    cmd1 = new SqlCommand(sql, MyConnection);
                    string RequestStatusID = cmd1.ExecuteScalar().ToString();
                    MyConnection.Close();
                    MyConnection.Open();
                    sql = $"select RequestStatusID from RepairParts  where RepairPartsName= \'{comboBox6.Text}\'";
                    cmd1 = new SqlCommand(sql, MyConnection);
                    string RequestStatusID1 = cmd1.ExecuteScalar().ToString();
                    MyConnection.Close();
                    MyConnection.Open();
                    sql = $"UPDATE Request set RepairParsID='{RequestStatusID1}',RequestStatusID=\'{RequestStatusID}\', StartDate = \'{dateTimePicker1.Value}\', CompletionDate =\'{dateTimePicker2.Value}\' where ReguestID=\'{comboBox4.Text}\'";
                    cmd1 = new SqlCommand(sql, MyConnection);
                    cmd1.ExecuteScalar();
                    MyConnection.Close();
                }
                if ((Convert.ToInt32(k1)) == 1)
                {
                  
                    if (comboBox1.Text != "")
                    {

                        sql = $"select UserID from Users  where FName= \'{comboBox5.Text}\'";
                        cmd1 = new SqlCommand(sql, MyConnection);
                        int masterlID = Convert.ToInt32(cmd1.ExecuteScalar().ToString());
                        MyConnection.Close();
                        MyConnection.Open();
                        sql = $"update Requests set MasterID=\'{masterlID}\'where ReguestID=N\'{comboBox4.Text}\'";
                        cmd1 = new SqlCommand(sql, MyConnection);
                        cmd1.ExecuteNonQuery();
                        MyConnection.Close();
                        MessageBox.Show("Мастер добавлен!", "Сообщение",
MessageBoxButtons.OK,
MessageBoxIcon.Information);
                    }
                    MyConnection.Close();
                    MyConnection.Open();
                    sql = $"select CompletionDate from Requests where ReguestID=N\'{comboBox4.Text}\'";
                    cmd1 = new SqlCommand(sql, MyConnection);
                    string data = cmd1.ExecuteScalar() == null ? string.Empty : cmd1.ExecuteScalar().ToString();
                    MyConnection.Close();
                    if (data != "")
                    {
                        if (Convert.ToDateTime(data) < Convert.ToDateTime(dateTimePicker2.Text))
                        {
                            MyConnection.Open();
                            sql = $"update Requests set CompletionDate=N\'{Convert.ToDateTime(dateTimePicker2.Text)}\' where ReguestID=N\'{comboBox4.Text}\'";
                            cmd1 = new SqlCommand(sql, MyConnection);
                            cmd1.ExecuteNonQuery();
                            MyConnection.Close();
                            MessageBox.Show("Дата отредаетирована!", "Сообщение",
MessageBoxButtons.OK,
MessageBoxIcon.Information);
                        }
                        else MessageBox.Show("Новая дата не может быть меньше предыдущей!", "Сообщение",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Мастер еще не назначил дату окончания!", "Сообщение",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
                }
                Application.OpenForms["КорректировкаЗаявки"].Dispose();
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

        private void КорректировкаЗаявки_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["КорректировкаЗаявки"].Dispose();
            new Form5(d).Show();
        }
    }
}
