namespace TIC_TAC_TOE
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(217, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.newGameToolStripMenuItem.Text = "New-Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.Color.Gainsboro;
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.Location = new System.Drawing.Point(10, 29);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(61, 59);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = false;
            this.A1.Click += new System.EventHandler(this.click);
            this.A1.MouseEnter += new System.EventHandler(this.Enter);
            this.A1.MouseLeave += new System.EventHandler(this.Leave);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.Gainsboro;
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(144, 94);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(61, 59);
            this.B3.TabIndex = 2;
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.click);
            this.B3.MouseEnter += new System.EventHandler(this.Enter);
            this.B3.MouseLeave += new System.EventHandler(this.Leave);
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.Color.Gainsboro;
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.Location = new System.Drawing.Point(144, 159);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(61, 59);
            this.C3.TabIndex = 3;
            this.C3.UseVisualStyleBackColor = false;
            this.C3.Click += new System.EventHandler(this.click);
            this.C3.MouseEnter += new System.EventHandler(this.Enter);
            this.C3.MouseLeave += new System.EventHandler(this.Leave);
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.Color.Gainsboro;
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.Location = new System.Drawing.Point(144, 29);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(61, 59);
            this.A3.TabIndex = 4;
            this.A3.UseVisualStyleBackColor = false;
            this.A3.Click += new System.EventHandler(this.click);
            this.A3.MouseEnter += new System.EventHandler(this.Enter);
            this.A3.MouseLeave += new System.EventHandler(this.Leave);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.Color.Gainsboro;
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.Location = new System.Drawing.Point(77, 159);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(61, 59);
            this.C2.TabIndex = 5;
            this.C2.UseVisualStyleBackColor = false;
            this.C2.Click += new System.EventHandler(this.click);
            this.C2.MouseEnter += new System.EventHandler(this.Enter);
            this.C2.MouseLeave += new System.EventHandler(this.Leave);
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.Color.Gainsboro;
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.Location = new System.Drawing.Point(10, 159);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(61, 59);
            this.C1.TabIndex = 6;
            this.C1.UseVisualStyleBackColor = false;
            this.C1.Click += new System.EventHandler(this.click);
            this.C1.MouseEnter += new System.EventHandler(this.Enter);
            this.C1.MouseLeave += new System.EventHandler(this.Leave);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.Gainsboro;
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(77, 94);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(61, 59);
            this.B2.TabIndex = 7;
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.click);
            this.B2.MouseEnter += new System.EventHandler(this.Enter);
            this.B2.MouseLeave += new System.EventHandler(this.Leave);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.Gainsboro;
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(10, 94);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(61, 59);
            this.B1.TabIndex = 8;
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.click);
            this.B1.MouseEnter += new System.EventHandler(this.Enter);
            this.B1.MouseLeave += new System.EventHandler(this.Leave);
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.Color.Gainsboro;
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.Location = new System.Drawing.Point(77, 29);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(61, 59);
            this.A2.TabIndex = 9;
            this.A2.UseVisualStyleBackColor = false;
            this.A2.Click += new System.EventHandler(this.click);
            this.A2.MouseEnter += new System.EventHandler(this.Enter);
            this.A2.MouseLeave += new System.EventHandler(this.Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 224);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "TIC-TAC-TOE";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button A2;
    }
}

