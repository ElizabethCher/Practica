namespace RAb_5
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.вГлавноеМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКомментарийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 42);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(444, 330);
            this.dataGridView1.TabIndex = 1;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вГлавноеМенюToolStripMenuItem,
            this.добавитьКомментарийToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(501, 24);
            this.menuStrip2.TabIndex = 2;
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
            // добавитьКомментарийToolStripMenuItem
            // 
            this.добавитьКомментарийToolStripMenuItem.BackColor = System.Drawing.SystemColors.GrayText;
            this.добавитьКомментарийToolStripMenuItem.Font = new System.Drawing.Font("NSimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.добавитьКомментарийToolStripMenuItem.Name = "добавитьКомментарийToolStripMenuItem";
            this.добавитьКомментарийToolStripMenuItem.Size = new System.Drawing.Size(273, 20);
            this.добавитьКомментарийToolStripMenuItem.Text = "Добавить комментарий";
            this.добавитьКомментарийToolStripMenuItem.Click += new System.EventHandler(this.добавитьКомментарийToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(501, 394);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("NSimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(517, 433);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(517, 433);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Комментарии (Comments)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            //this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem вГлавноеМенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКомментарийToolStripMenuItem;
    }
}