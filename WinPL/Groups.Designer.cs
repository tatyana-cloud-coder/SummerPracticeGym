namespace WinPL
{
    partial class Groups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Groups));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьГруппуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьГруппуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьСписокГруппToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКлиентаВГруппуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьГруппуToolStripMenuItem,
            this.удалитьГруппуToolStripMenuItem,
            this.просмотретьСписокГруппToolStripMenuItem,
            this.добавитьКлиентаВГруппуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьГруппуToolStripMenuItem
            // 
            this.добавитьГруппуToolStripMenuItem.Name = "добавитьГруппуToolStripMenuItem";
            this.добавитьГруппуToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.добавитьГруппуToolStripMenuItem.Text = "Добавить группу";
            this.добавитьГруппуToolStripMenuItem.Click += new System.EventHandler(this.добавитьГруппуToolStripMenuItem_Click);
            // 
            // удалитьГруппуToolStripMenuItem
            // 
            this.удалитьГруппуToolStripMenuItem.Name = "удалитьГруппуToolStripMenuItem";
            this.удалитьГруппуToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.удалитьГруппуToolStripMenuItem.Text = "Удалить группу";
            this.удалитьГруппуToolStripMenuItem.Click += new System.EventHandler(this.удалитьГруппуToolStripMenuItem_Click);
            // 
            // просмотретьСписокГруппToolStripMenuItem
            // 
            this.просмотретьСписокГруппToolStripMenuItem.Name = "просмотретьСписокГруппToolStripMenuItem";
            this.просмотретьСписокГруппToolStripMenuItem.Size = new System.Drawing.Size(170, 20);
            this.просмотретьСписокГруппToolStripMenuItem.Text = "Просмотреть список групп";
            this.просмотретьСписокГруппToolStripMenuItem.Click += new System.EventHandler(this.просмотретьСписокГруппToolStripMenuItem_Click);
            // 
            // добавитьКлиентаВГруппуToolStripMenuItem
            // 
            this.добавитьКлиентаВГруппуToolStripMenuItem.Name = "добавитьКлиентаВГруппуToolStripMenuItem";
            this.добавитьКлиентаВГруппуToolStripMenuItem.Size = new System.Drawing.Size(168, 20);
            this.добавитьКлиентаВГруппуToolStripMenuItem.Text = "Добавить клиента в группу";
            this.добавитьКлиентаВГруппуToolStripMenuItem.Click += new System.EventHandler(this.добавитьКлиентаВГруппуToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список групп:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 63);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(745, 375);
            this.textBox1.TabIndex = 2;
            // 
            // Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Groups";
            this.Text = "Группы";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьГруппуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьГруппуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотретьСписокГруппToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem добавитьКлиентаВГруппуToolStripMenuItem;
    }
}