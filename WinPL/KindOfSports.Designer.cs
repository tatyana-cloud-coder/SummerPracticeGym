namespace WinPL
{
    partial class KindOfSports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KindOfSports));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьВидСпортаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВидСпортаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьСписокВидовСпортаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьРасписаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьВидСпортаToolStripMenuItem,
            this.удалитьВидСпортаToolStripMenuItem,
            this.просмотретьСписокВидовСпортаToolStripMenuItem,
            this.просмотретьРасписаниеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(807, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьВидСпортаToolStripMenuItem
            // 
            this.добавитьВидСпортаToolStripMenuItem.Name = "добавитьВидСпортаToolStripMenuItem";
            this.добавитьВидСпортаToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.добавитьВидСпортаToolStripMenuItem.Text = "Добавить вид спорта";
            this.добавитьВидСпортаToolStripMenuItem.Click += new System.EventHandler(this.добавитьВидСпортаToolStripMenuItem_Click);
            // 
            // удалитьВидСпортаToolStripMenuItem
            // 
            this.удалитьВидСпортаToolStripMenuItem.Name = "удалитьВидСпортаToolStripMenuItem";
            this.удалитьВидСпортаToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.удалитьВидСпортаToolStripMenuItem.Text = "Удалить вид спорта";
            this.удалитьВидСпортаToolStripMenuItem.Click += new System.EventHandler(this.удалитьВидСпортаToolStripMenuItem_Click);
            // 
            // просмотретьСписокВидовСпортаToolStripMenuItem
            // 
            this.просмотретьСписокВидовСпортаToolStripMenuItem.Name = "просмотретьСписокВидовСпортаToolStripMenuItem";
            this.просмотретьСписокВидовСпортаToolStripMenuItem.Size = new System.Drawing.Size(211, 20);
            this.просмотретьСписокВидовСпортаToolStripMenuItem.Text = "Просмотреть список видов спорта";
            this.просмотретьСписокВидовСпортаToolStripMenuItem.Click += new System.EventHandler(this.просмотретьСписокВидовСпортаToolStripMenuItem_Click);
            // 
            // просмотретьРасписаниеToolStripMenuItem
            // 
            this.просмотретьРасписаниеToolStripMenuItem.Name = "просмотретьРасписаниеToolStripMenuItem";
            this.просмотретьРасписаниеToolStripMenuItem.Size = new System.Drawing.Size(161, 20);
            this.просмотретьРасписаниеToolStripMenuItem.Text = "Просмотреть расписание";
            this.просмотретьРасписаниеToolStripMenuItem.Click += new System.EventHandler(this.просмотретьРасписаниеToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список видов спорта:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(26, 69);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(718, 387);
            this.textBox1.TabIndex = 2;
            // 
            // KindOfSports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(807, 463);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KindOfSports";
            this.Text = "KindOfSports";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьВидСпортаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВидСпортаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотретьСписокВидовСпортаToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem просмотретьРасписаниеToolStripMenuItem;
    }
}