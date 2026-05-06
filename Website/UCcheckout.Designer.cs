namespace Website
{
    partial class UCcheckout
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Add_to_Checkout = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Save_Checkout = new System.Windows.Forms.Button();
            this.Remove_from_Checkout = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Add_to_Checkout);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.Save_Checkout);
            this.groupBox1.Controls.Add(this.Remove_from_Checkout);
            this.groupBox1.Location = new System.Drawing.Point(3, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 463);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Add_to_Checkout
            // 
            this.Add_to_Checkout.Location = new System.Drawing.Point(-3, 246);
            this.Add_to_Checkout.Name = "Add_to_Checkout";
            this.Add_to_Checkout.Size = new System.Drawing.Size(185, 62);
            this.Add_to_Checkout.TabIndex = 7;
            this.Add_to_Checkout.Text = "Add to Checkout";
            this.Add_to_Checkout.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(502, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(148, 425);
            this.dataGridView2.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(191, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(270, 425);
            this.dataGridView1.TabIndex = 5;
            // 
            // Save_Checkout
            // 
            this.Save_Checkout.Location = new System.Drawing.Point(0, 382);
            this.Save_Checkout.Name = "Save_Checkout";
            this.Save_Checkout.Size = new System.Drawing.Size(185, 62);
            this.Save_Checkout.TabIndex = 4;
            this.Save_Checkout.Text = "Save Checkout";
            this.Save_Checkout.UseVisualStyleBackColor = true;
            // 
            // Remove_from_Checkout
            // 
            this.Remove_from_Checkout.Location = new System.Drawing.Point(0, 314);
            this.Remove_from_Checkout.Name = "Remove_from_Checkout";
            this.Remove_from_Checkout.Size = new System.Drawing.Size(185, 62);
            this.Remove_from_Checkout.TabIndex = 1;
            this.Remove_from_Checkout.Text = "Remove from Checkout";
            this.Remove_from_Checkout.UseVisualStyleBackColor = true;
            // 
            // UCcheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UCcheckout";
            this.Size = new System.Drawing.Size(782, 523);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Save_Checkout;
        private System.Windows.Forms.Button Remove_from_Checkout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Add_to_Checkout;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}
