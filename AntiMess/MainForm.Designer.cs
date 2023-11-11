namespace AntiMess
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.buttonGit = new System.Windows.Forms.Button();
            this.myPanel1 = new AntiMess.MyPanel();
            this.pickButton = new AntiMess.MyButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.readyButton = new AntiMess.MyButton();
            this.myPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(68, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 41);
            this.label1.TabIndex = 4;
            // 
            // textBoxLog
            // 
            this.textBoxLog.BackColor = System.Drawing.Color.White;
            this.textBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLog.Location = new System.Drawing.Point(11, 195);
            this.textBoxLog.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.Size = new System.Drawing.Size(310, 91);
            this.textBoxLog.TabIndex = 6;
            // 
            // buttonGit
            // 
            this.buttonGit.FlatAppearance.BorderSize = 0;
            this.buttonGit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGit.Image = ((System.Drawing.Image)(resources.GetObject("buttonGit.Image")));
            this.buttonGit.Location = new System.Drawing.Point(0, 0);
            this.buttonGit.Margin = new System.Windows.Forms.Padding(0);
            this.buttonGit.Name = "buttonGit";
            this.buttonGit.Size = new System.Drawing.Size(34, 34);
            this.buttonGit.TabIndex = 7;
            this.buttonGit.UseVisualStyleBackColor = true;
            this.buttonGit.Click += new System.EventHandler(this.buttonGit_Click);
            // 
            // myPanel1
            // 
            this.myPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.myPanel1.Controls.Add(this.pickButton);
            this.myPanel1.Controls.Add(this.textBox1);
            this.myPanel1.Controls.Add(this.readyButton);
            this.myPanel1.Location = new System.Drawing.Point(11, 68);
            this.myPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 6);
            this.myPanel1.Name = "myPanel1";
            this.myPanel1.Size = new System.Drawing.Size(310, 119);
            this.myPanel1.TabIndex = 5;
            // 
            // pickButton
            // 
            this.pickButton.BottomColor = System.Drawing.Color.Silver;
            this.pickButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pickButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.pickButton.ForeColor = System.Drawing.Color.DimGray;
            this.pickButton.Image = ((System.Drawing.Image)(resources.GetObject("pickButton.Image")));
            this.pickButton.Location = new System.Drawing.Point(259, 11);
            this.pickButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pickButton.Name = "pickButton";
            this.pickButton.Size = new System.Drawing.Size(36, 35);
            this.pickButton.TabIndex = 2;
            this.pickButton.TopColor = System.Drawing.Color.White;
            this.pickButton.UseVisualStyleBackColor = true;
            this.pickButton.Click += new System.EventHandler(this.pickButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(15, 18);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(236, 23);
            this.textBox1.TabIndex = 1;
            // 
            // readyButton
            // 
            this.readyButton.BottomColor = System.Drawing.Color.DarkSeaGreen;
            this.readyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.readyButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.readyButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.readyButton.Location = new System.Drawing.Point(100, 61);
            this.readyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.readyButton.Name = "readyButton";
            this.readyButton.Size = new System.Drawing.Size(116, 45);
            this.readyButton.TabIndex = 3;
            this.readyButton.Text = "Düzet";
            this.readyButton.TopColor = System.Drawing.Color.White;
            this.readyButton.UseVisualStyleBackColor = true;
            this.readyButton.Click += new System.EventHandler(this.readyButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(332, 297);
            this.Controls.Add(this.buttonGit);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.myPanel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(348, 336);
            this.MinimumSize = new System.Drawing.Size(348, 336);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anti Mess";
            this.myPanel1.ResumeLayout(false);
            this.myPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private MyButton pickButton;
        private MyButton readyButton;
        private System.Windows.Forms.Label label1;
        private MyPanel myPanel1;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Button buttonGit;
    }
}

