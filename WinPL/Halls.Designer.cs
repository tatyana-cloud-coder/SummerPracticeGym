namespace WinPL
{
    partial class Halls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Halls));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьЗалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьЗалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьСписокЗаловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЗалToolStripMenuItem,
            this.удалитьЗалToolStripMenuItem,
            this.просмотретьСписокЗаловToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьЗалToolStripMenuItem
            // 
            this.добавитьЗалToolStripMenuItem.Name = "добавитьЗалToolStripMenuItem";
            this.добавитьЗалToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.добавитьЗалToolStripMenuItem.Text = "Добавить зал";
            this.добавитьЗалToolStripMenuItem.Click += new System.EventHandler(this.добавитьЗалToolStripMenuItem_Click);
            // 
            // удалитьЗалToolStripMenuItem
            // 
            this.удалитьЗалToolStripMenuItem.Name = "удалитьЗалToolStripMenuItem";
            this.удалитьЗалToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.удалитьЗалToolStripMenuItem.Text = "Удалить зал";
            this.удалитьЗалToolStripMenuItem.Click += new System.EventHandler(this.удалитьЗалToolStripMenuItem_Click);
            // 
            // просмотретьСписокЗаловToolStripMenuItem
            // 
            this.просмотретьСписокЗаловToolStripMenuItem.Name = "просмотретьСписокЗаловToolStripMenuItem";
            this.просмотретьСписокЗаловToolStripMenuItem.Size = new System.Drawing.Size(169, 20);
            this.просмотретьСписокЗаловToolStripMenuItem.Text = "Просмотреть список залов";
            this.просмотретьСписокЗаловToolStripMenuItem.Click += new System.EventHandler(this.просмотретьСписокЗаловToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список залов:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(13, 67);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(758, 371);
            this.textBox1.TabIndex = 2;
            // 
            // Halls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Halls";
            this.Text = "Halls";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьЗалToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьЗалToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотретьСписокЗаловToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}