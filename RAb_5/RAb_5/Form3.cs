using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAb_5
{
    public partial class Form3 : Form
    {
        string name = "Data Source=ADCLG1;Initial Catalog=CherEPractica;Integrated Security=True";
        public Form3()
        {
            InitializeComponent();
        }

        private void вГлавноеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form3"].Dispose();
            new Form2().Show();
        }

        private void добавитьКомментарийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form3"].Dispose();
            new Form4().Show();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
