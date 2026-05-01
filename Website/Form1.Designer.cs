namespace Website
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bpcheckout = new System.Windows.Forms.Button();
            this.Bproducts = new System.Windows.Forms.Button();
            this.Bhome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.bpcheckout);
            this.panel1.Controls.Add(this.Bproducts);
            this.panel1.Controls.Add(this.Bhome);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 534);
            this.panel1.TabIndex = 0;
            // 
            // bpcheckout
            // 
            this.bpcheckout.Location = new System.Drawing.Point(11, 278);
            this.bpcheckout.Name = "bpcheckout";
            this.bpcheckout.Size = new System.Drawing.Size(110, 75);
            this.bpcheckout.TabIndex = 4;
            this.bpcheckout.Text = "Checkout";
            this.bpcheckout.UseVisualStyleBackColor = true;
            this.bpcheckout.Click += new System.EventHandler(this.bpcheckout_Click);
            // 
            // Bproducts
            // 
            this.Bproducts.Location = new System.Drawing.Point(11, 142);
            this.Bproducts.Name = "Bproducts";
            this.Bproducts.Size = new System.Drawing.Size(110, 78);
            this.Bproducts.TabIndex = 3;
            this.Bproducts.Text = "Products";
            this.Bproducts.UseVisualStyleBackColor = true;
            this.Bproducts.Click += new System.EventHandler(this.Bproducts_Click);
            // 
            // Bhome
            // 
            this.Bhome.Location = new System.Drawing.Point(11, 23);
            this.Bhome.Name = "Bhome";
            this.Bhome.Size = new System.Drawing.Size(110, 67);
            this.Bhome.TabIndex = 2;
            this.Bhome.Text = "Home";
            this.Bhome.UseVisualStyleBackColor = true;
            this.Bhome.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(197, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(602, 450);
            this.panel2.TabIndex = 1;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlContent.Location = new System.Drawing.Point(152, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(732, 534);
            this.pnlContent.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(884, 534);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlContent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bpcheckout;
        private System.Windows.Forms.Button Bproducts;
        private System.Windows.Forms.Button Bhome;
        private System.Windows.Forms.Panel pnlContent;
    }
}

