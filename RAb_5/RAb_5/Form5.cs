using QRCoder;
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
using System.Xml.Linq;

namespace RAb_5
{
    public partial class Form5 : Form
    {
        int k = 0;
        int d;
        DataTable ds;

        string name = "Data Source=ADCLG1;Initial Catalog=CherEPractica;Integrated Security=True";
        //string name = "Data Source=LAPTOP-E9A534AD;Initial Catalog=CherEPractica;Integrated Security=True";
        public Form5()
        {
            InitializeComponent();
        }
        public Form5(int d1)
        {
            InitializeComponent();
            d = d1;
        }

        private void вГлавноеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form5"].Dispose();
            new Form2(d).Show();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void добавитьЗаявкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form5"].Dispose();
            new ДобавлениеЗаявки(d).Show();
        }
        private void OutPut(int d, int tupe)
        {

                SqlConnection MyConnection = new SqlConnection(name);
            string sql;
                MyConnection.Open();
            if (tupe == 4)
            {
                sql = $"SELECT * FROM Requests where ClientID='{d}'";
            }
            else if (tupe == 2)
            {
                sql = $"SELECT * FROM Requests where MasterID='{d}'";
            }
            else
            {
                sql = $"SELECT * FROM Requests";
            }
            SqlCommand cmd1 = new SqlCommand(sql, MyConnection);
                cmd1.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, MyConnection);
                ds = new DataTable();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds;//.Tables[0];
                k = dataGridView1.Rows.Count;
                statusStrip1.Items[0].Text = "Всего записей: " + dataGridView1.Rows.Count + "Из: " + k;
                dataGridView1.Columns["ReguestID"].HeaderText = "id";
                dataGridView1.Columns["StartDate"].HeaderText = "Дата начала";
                dataGridView1.Columns["HomeTechModelName"].HeaderText = "Модель";
                dataGridView1.Columns["HomeTechTypeName"].HeaderText = "Тип модели";
                dataGridView1.Columns["ProblemDescryptionName"].HeaderText = "Проблема";
                dataGridView1.Columns["RequestStatusName"].HeaderText = "Статус";
                dataGridView1.Columns["CompletionDate"].HeaderText = "дата окончания";
                dataGridView1.Columns["RepairPartsName"].HeaderText = "Заказанные детали";
                dataGridView1.Columns["masterSurname"].HeaderText = "Мастер";
                dataGridView1.Columns["clientSurname"].HeaderText = "Клиент";
                dataGridView1.Columns["Message"].HeaderText = "комментарий";
                MyConnection.Close();

        }
        private void GenerationQRCode(string url)
        {
            QRCodeGenerator codeGenerator = new QRCodeGenerator();
            QRCodeData qRCodeData = codeGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q);
            QRCode qRCode = new QRCode(qRCodeData);
            Bitmap qrCodeImage = qRCode.GetGraphic(1);
            pictureBox1.Image = qrCodeImage;
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            SqlConnection MyConnection = new SqlConnection(name);
            MyConnection.Open();
            string sql = $"SELECT Id_type from Users where UserID=\'{d}\'";
            SqlCommand cmd1 = new SqlCommand(sql, MyConnection);
            string k1 = cmd1.ExecuteScalar().ToString();
            MyConnection.Close();

            if (Convert.ToInt32(k1) != 4)
            {
                добавитьЗаявкуToolStripMenuItem.Visible = false;
            }
            if (Convert.ToInt32(k1) != 2)
            {
                добавитьКомментарийToolStripMenuItem.Visible = false;
            }

            OutPut(d, Convert.ToInt32(k1));
            if (Convert.ToInt32(k1) == 4)
            {
                string url = "https://bazacvetov.site/?roistat=direct1_search_16167361433_---autotargeting&roistat_referrer=none&roistat_pos=premium_1&yclid=14142435571796017151";
                GenerationQRCode(url);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filter = "";
            string[] keywords = textBox1.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var keyword in keywords)
            {
                if (keyword.Length ==2)
                    continue;
                if (filter.Length > 0)
                {
                    filter += " AND ";

                }
                DateTime dateValue;
                if (DateTime.TryParse(keyword, out dateValue))
                {
                    filter += $"[StartDate] = '{dateValue:yyyy-MM-dd}' OR " +
                              $"[CompletionDate] = '{dateValue:yyyy-MM-dd}'"; // Форматируем дату
                }
                else
                {
                    filter += $"[HomeTechModelName] LIKE '%{keyword}%' OR " +
                        $"[HomeTechTypeName] LIKE '%{keyword}%' OR " +
                          $"[ProblemDescryptionName] LIKE '%{keyword}%' OR " +
                          $"[RequestStatusName] LIKE '%{keyword}%' OR " +
                          $"[RepairPartsName] LIKE '%{keyword}%' OR " +
                          $"[masterSurname] LIKE '%{keyword}%' OR " +
                          $"[clientSurname] LIKE '%{keyword}%'";

                }
            }

            DataView dataView = new DataView(ds);
            dataView.RowFilter = filter;

            dataGridView1.DataSource = dataView;
            statusStrip1.Items[0].Text = "Всего записей: " + dataGridView1.Rows.Count + "Из: " + k;
        }

        private void корректироватьЗаявкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form5"].Dispose();
            new КорректировкаЗаявки(d).Show();
        }

        private void добавитьКомментарийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form5"].Dispose();
            new ДобавлениеКомментариев(d).Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

