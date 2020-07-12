﻿namespace WinPL
{
    partial class Coaches
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Coaches));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьТренераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьТренераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьСписокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиТренераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьТренераToolStripMenuItem,
            this.удалитьТренераToolStripMenuItem,
            this.просмотретьСписокToolStripMenuItem,
            this.найтиТренераToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьТренераToolStripMenuItem
            // 
            this.добавитьТренераToolStripMenuItem.Name = "добавитьТренераToolStripMenuItem";
            this.добавитьТренераToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.добавитьТренераToolStripMenuItem.Text = "Добавить тренера";
            this.добавитьТренераToolStripMenuItem.Click += new System.EventHandler(this.добавитьТренераToolStripMenuItem_Click);
            // 
            // удалитьТренераToolStripMenuItem
            // 
            this.удалитьТренераToolStripMenuItem.Name = "удалитьТренераToolStripMenuItem";
            this.удалитьТренераToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.удалитьТренераToolStripMenuItem.Text = "Удалить тренера";
            this.удалитьТренераToolStripMenuItem.Click += new System.EventHandler(this.удалитьТренераToolStripMenuItem_Click);
            // 
            // просмотретьСписокToolStripMenuItem
            // 
            this.просмотретьСписокToolStripMenuItem.Name = "просмотретьСписокToolStripMenuItem";
            this.просмотретьСписокToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.просмотретьСписокToolStripMenuItem.Text = "Просмотреть список";
            this.просмотретьСписокToolStripMenuItem.Click += new System.EventHandler(this.просмотретьСписокToolStripMenuItem_Click);
            // 
            // найтиТренераToolStripMenuItem
            // 
            this.найтиТренераToolStripMenuItem.Name = "найтиТренераToolStripMenuItem";
            this.найтиТренераToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.найтиТренераToolStripMenuItem.Text = "Найти тренера";
            this.найтиТренераToolStripMenuItem.Click += new System.EventHandler(this.найтиТренераToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 63);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 375);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список тренеров:";
            // 
            // Coaches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Coaches";
            this.Text = "Тренеры";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьТренераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьТренераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотретьСписокToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem найтиТренераToolStripMenuItem;
    }
}