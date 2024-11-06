namespace RAb_5
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.вГлавноеМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЗаявкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.корректироватьЗаявкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКомментарийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вГлавноеМенюToolStripMenuItem,
            this.добавитьЗаявкуToolStripMenuItem,
            this.корректироватьЗаявкуToolStripMenuItem,
            this.добавитьКомментарийToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1275, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // вГлавноеМенюToolStripMenuItem
            // 
            this.вГлавноеМенюToolStripMenuItem.BackColor = System.Drawing.SystemColors.GrayText;
            this.вГлавноеМенюToolStripMenuItem.Font = new System.Drawing.Font("NSimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.вГлавноеМенюToolStripMenuItem.Name = "вГлавноеМенюToolStripMenuItem";
            this.вГлавноеМенюToolStripMenuItem.Size = new System.Drawing.Size(189, 20);
            this.вГлавноеМенюToolStripMenuItem.Text = "В главное меню";
            this.вГлавноеМенюToolStripMenuItem.Click += new System.EventHandler(this.вГлавноеМенюToolStripMenuItem_Click);
            // 
            // добавитьЗаявкуToolStripMenuItem
            // 
            this.добавитьЗаявкуToolStripMenuItem.BackColor = System.Drawing.SystemColors.GrayText;
            this.добавитьЗаявкуToolStripMenuItem.Font = new System.Drawing.Font("NSimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.добавитьЗаявкуToolStripMenuItem.Name = "добавитьЗаявкуToolStripMenuItem";
            this.добавитьЗаявкуToolStripMenuItem.Size = new System.Drawing.Size(208, 20);
            this.добавитьЗаявкуToolStripMenuItem.Text = "Добавить заявку";
            this.добавитьЗаявкуToolStripMenuItem.Click += new System.EventHandler(this.добавитьЗаявкуToolStripMenuItem_Click);
            // 
            // корректироватьЗаявкуToolStripMenuItem
            // 
            this.корректироватьЗаявкуToolStripMenuItem.BackColor = System.Drawing.SystemColors.GrayText;
            this.корректироватьЗаявкуToolStripMenuItem.Font = new System.Drawing.Font("NSimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.корректироватьЗаявкуToolStripMenuItem.Name = "корректироватьЗаявкуToolStripMenuItem";
            this.корректироватьЗаявкуToolStripMenuItem.Size = new System.Drawing.Size(286, 20);
            this.корректироватьЗаявкуToolStripMenuItem.Text = "Корректировать заявку";
            this.корректироватьЗаявкуToolStripMenuItem.Click += new System.EventHandler(this.корректироватьЗаявкуToolStripMenuItem_Click);
            // 
            // добавитьКомментарийToolStripMenuItem
            // 
            this.добавитьКомментарийToolStripMenuItem.BackColor = System.Drawing.SystemColors.GrayText;
            this.добавитьКомментарийToolStripMenuItem.Font = new System.Drawing.Font("NSimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.добавитьКомментарийToolStripMenuItem.Name = "добавитьКомментарийToolStripMenuItem";
            this.добавитьКомментарийToolStripMenuItem.Size = new System.Drawing.Size(273, 20);
            this.добавитьКомментарийToolStripMenuItem.Text = "Добавить комментарий";
            this.добавитьКомментарийToolStripMenuItem.Click += new System.EventHandler(this.добавитьКомментарийToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 80);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1249, 265);
            this.dataGridView1.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 360);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1275, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NSimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Поиск:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("NSimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(331, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 22);
            this.button1.TabIndex = 7;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("NSimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(95, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1109, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1275, 382);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("NSimSun", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заявки (Request )";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form5_FormClosing);
            this.Load += new System.EventHandler(this.Form5_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem вГлавноеМенюToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem добавитьЗаявкуToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem корректироватьЗаявкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКомментарийToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}