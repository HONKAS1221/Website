namespace Website
{
    partial class UCOrder
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
            this.Add_to_Order = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Save_Order = new System.Windows.Forms.Button();
            this.Remove_from_Order = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add_to_Order
            // 
            this.Add_to_Order.Location = new System.Drawing.Point(0, 222);
            this.Add_to_Order.Name = "Add_to_Order";
            this.Add_to_Order.Size = new System.Drawing.Size(185, 62);
            this.Add_to_Order.TabIndex = 7;
            this.Add_to_Order.Text = "Add to Order";
            this.Add_to_Order.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(575, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(148, 425);
            this.dataGridView2.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(256, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(270, 425);
            this.dataGridView1.TabIndex = 5;
            // 
            // Save_Order
            // 
            this.Save_Order.Location = new System.Drawing.Point(0, 382);
            this.Save_Order.Name = "Save_Order";
            this.Save_Order.Size = new System.Drawing.Size(185, 62);
            this.Save_Order.TabIndex = 4;
            this.Save_Order.Text = "Save Order";
            this.Save_Order.UseVisualStyleBackColor = true;
            // 
            // Remove_from_Order
            // 
            this.Remove_from_Order.Location = new System.Drawing.Point(0, 302);
            this.Remove_from_Order.Name = "Remove_from_Order";
            this.Remove_from_Order.Size = new System.Drawing.Size(185, 62);
            this.Remove_from_Order.TabIndex = 1;
            this.Remove_from_Order.Text = "Remove from Order";
            this.Remove_from_Order.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Add_to_Order);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.Save_Order);
            this.groupBox1.Controls.Add(this.Remove_from_Order);
            this.groupBox1.Location = new System.Drawing.Point(26, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 463);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // UCOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UCOrder";
            this.Size = new System.Drawing.Size(793, 506);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add_to_Order;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Save_Order;
        private System.Windows.Forms.Button Remove_from_Order;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
