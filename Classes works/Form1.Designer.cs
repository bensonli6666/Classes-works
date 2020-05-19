namespace Classes_works
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
            this.Outlbl = new System.Windows.Forms.Label();
            this.Outbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Outlbl
            // 
            this.Outlbl.AutoSize = true;
            this.Outlbl.Location = new System.Drawing.Point(38, 39);
            this.Outlbl.Name = "Outlbl";
            this.Outlbl.Size = new System.Drawing.Size(0, 13);
            this.Outlbl.TabIndex = 0;
            // 
            // Outbtn
            // 
            this.Outbtn.Location = new System.Drawing.Point(41, 72);
            this.Outbtn.Name = "Outbtn";
            this.Outbtn.Size = new System.Drawing.Size(75, 23);
            this.Outbtn.TabIndex = 1;
            this.Outbtn.Text = "Output";
            this.Outbtn.UseVisualStyleBackColor = true;
            this.Outbtn.Click += new System.EventHandler(this.Outbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Outbtn);
            this.Controls.Add(this.Outlbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Outlbl;
        private System.Windows.Forms.Button Outbtn;
    }
}

