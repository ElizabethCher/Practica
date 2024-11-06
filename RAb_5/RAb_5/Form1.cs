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
using System.Linq.Expressions;
using static System.Net.Mime.MediaTypeNames;

namespace RAb_5
{
    public partial class Form1 : Form
    {
        private string text = String.Empty;//!
        private int numCAPTCHA = 0;//!
        string name = "Data Source=ADCLG1;Initial Catalog=CherEPractica;Integrated Security=True";
      // string name = "Data Source=LAPTOP-E9A534AD;Initial Catalog=CherEPractica;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            MaximumSize = new System.Drawing.Size(404, 310);
            MinimumSize = new System.Drawing.Size(404, 310);
            pictureBox1.Image = this.CreateImage(pictureBox1.Width, pictureBox1.Height);//!
            this.TopMost = true;//!
        }
        private Bitmap CreateImage(int Width, int Height)//!
        {
            Random rnd = new Random();

            //Создадим изображение
            Bitmap result = new Bitmap(Width, Height);

            //Вычислим позицию текста
            int Xpos = rnd.Next(0, Width - 50);
            int Ypos = rnd.Next(15, Height - 15);

            //Добавим различные цвета
            Brush[] colors = { Brushes.Black,
                     Brushes.Red,
                     Brushes.RoyalBlue,
                     Brushes.Green };

            //Укажем где рисовать
            Graphics g = Graphics.FromImage((System.Drawing.Image)result);

            //Пусть фон картинки будет серым
            g.Clear(Color.White);

            //Сгенерируем текст
            text = String.Empty;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 5; ++i)
                text += ALF[rnd.Next(ALF.Length)];

            //Нарисуем сгенирируемый текст
            g.DrawString(text,
                         new Font("Arial", 15),
                         colors[rnd.Next(colors.Length)],
                         new PointF(Xpos, Ypos));

            //Добавим немного помех
            /////Линии из углов
            g.DrawLine(Pens.Black,
                          new Point(0, 0),
                          new Point(Width - 1, Height - 1));
            g.DrawLine(Pens.Black,
                       new Point(0, Height - 1),
                       new Point(Width - 1, 0));
            ////Белые точки
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.Gray);

            return result;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
                textBox2.PasswordChar = '\0';
            else textBox2.PasswordChar = '*';
        }
        private void timer1_Tick(object sender, EventArgs e)//!
        {
            timer1.Stop();
            button4.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool value1 = false;
                string sql;
                if (textBox1.Text != "" && textBox2.Text != "")
                {

                    SqlConnection MyConnection = new SqlConnection(name);
                    MyConnection.Open();
                    if (textBox1.Text != "" && textBox2.Text != "")
                    {
                        sql = $"SELECT UserID FROM Users where Login=\'{textBox1.Text}\' and Password=\'{textBox2.Text}\'";
                        SqlCommand sqlCommand = new SqlCommand(sql, MyConnection);
                        string d = sqlCommand.ExecuteScalar() == null ? string.Empty : sqlCommand.ExecuteScalar().ToString();
                            if (d != "")
                            {
                                value1 = true;
                                this.Hide();
                                new Form2(Convert.ToInt32(d)).Show();
                            }
                        else
                        {
                            
                            MaximumSize = new System.Drawing.Size(791, 310);
                            MinimumSize = new System.Drawing.Size(791, 310);
                            button1.Enabled = false;//!
                            MessageBox.Show("Неверный логин и/или пароль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                            pictureBox1.Image = this.CreateImage(pictureBox1.Width, pictureBox1.Height);
                        }
                    }
                    else
                        MessageBox.Show("Поля должны быть заполнены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    HistoryAutorez(value1);
                    MyConnection.Close();
                }

            }
            catch(Exception ex)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }

        }
        private void HistoryAutorez(bool value1)
        {
            SqlConnection MyConnection = new SqlConnection(name);
            MyConnection.Open();
            string sql = $"INSERT into HistoryAutorez (Login, dateAuto, Value) values (\'{textBox1.Text}\',\'{Convert.ToDateTime(DateTime.Now)}\',\'{value1}\')";
            SqlCommand cmd1 = new SqlCommand(sql, MyConnection);
            cmd1.ExecuteNonQuery();
            MyConnection.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == this.text)
            {
                //numCAPTCHA = 0;
                button1.Enabled = true;
                MaximumSize = new System.Drawing.Size(404, 310);
                MinimumSize = new System.Drawing.Size(404, 310);
            }
            else
            {
                numCAPTCHA++;
                MessageBox.Show("Символы введены неверно.", "Ошибка!",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information);
                if (numCAPTCHA == 2)
                {
                    
                    MessageBox.Show("Слишком много неудачных попыток. Блокировка системы на 3 минуты.", "Ошибка!",
MessageBoxButtons.OK,
MessageBoxIcon.Information);
                    timer1.Interval = 1000;
                    button4.Enabled = false;
                    timer1.Start();
                }
                else if (numCAPTCHA > 2)
                {
                    DialogResult result = MessageBox.Show("Слишком много неудачных попыток. Полная блокировка системы. Перезапустить систему?", "Ошибка!",
MessageBoxButtons.YesNo,
MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        System.Windows.Forms.Application.Restart();
                        this.TopMost = true;
                    }
                    this.TopMost = true;
                    this.Enabled = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = this.CreateImage(pictureBox1.Width, pictureBox1.Height);
        }
    }
}
