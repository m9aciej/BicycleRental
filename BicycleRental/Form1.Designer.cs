namespace BicycleRental
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rentBike = new System.Windows.Forms.Button();
            this.ReturnBike = new System.Windows.Forms.Button();
            this.TypeBike = new System.Windows.Forms.ComboBox();
            this.NumberBike = new System.Windows.Forms.TextBox();
            this.AddBike = new System.Windows.Forms.Button();
            this.RemoveBike = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 231);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(452, 181);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(452, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // rentBike
            // 
            this.rentBike.BackColor = System.Drawing.SystemColors.Highlight;
            this.rentBike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rentBike.ForeColor = System.Drawing.SystemColors.Control;
            this.rentBike.Location = new System.Drawing.Point(614, 357);
            this.rentBike.Name = "rentBike";
            this.rentBike.Size = new System.Drawing.Size(123, 55);
            this.rentBike.TabIndex = 0;
            this.rentBike.Text = "Rent bike";
            this.rentBike.UseVisualStyleBackColor = false;
            this.rentBike.Click += new System.EventHandler(this.rentBike_Click);
            // 
            // ReturnBike
            // 
            this.ReturnBike.BackColor = System.Drawing.SystemColors.Highlight;
            this.ReturnBike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ReturnBike.ForeColor = System.Drawing.SystemColors.Control;
            this.ReturnBike.Location = new System.Drawing.Point(614, 297);
            this.ReturnBike.Name = "ReturnBike";
            this.ReturnBike.Size = new System.Drawing.Size(123, 50);
            this.ReturnBike.TabIndex = 0;
            this.ReturnBike.Text = "Return bike";
            this.ReturnBike.UseVisualStyleBackColor = false;
            this.ReturnBike.Click += new System.EventHandler(this.ReturnBike_Click);
            // 
            // TypeBike
            // 
            this.TypeBike.FormattingEnabled = true;
            this.TypeBike.Items.AddRange(new object[] {
            "Montain",
            "Road",
            "Town"});
            this.TypeBike.Location = new System.Drawing.Point(564, 258);
            this.TypeBike.Name = "TypeBike";
            this.TypeBike.Size = new System.Drawing.Size(173, 21);
            this.TypeBike.TabIndex = 2;
            // 
            // NumberBike
            // 
            this.NumberBike.Location = new System.Drawing.Point(564, 206);
            this.NumberBike.Multiline = true;
            this.NumberBike.Name = "NumberBike";
            this.NumberBike.Size = new System.Drawing.Size(173, 33);
            this.NumberBike.TabIndex = 1;
            // 
            // AddBike
            // 
            this.AddBike.BackColor = System.Drawing.SystemColors.Highlight;
            this.AddBike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddBike.ForeColor = System.Drawing.SystemColors.Control;
            this.AddBike.Location = new System.Drawing.Point(485, 297);
            this.AddBike.Name = "AddBike";
            this.AddBike.Size = new System.Drawing.Size(123, 50);
            this.AddBike.TabIndex = 0;
            this.AddBike.Text = "Add bike";
            this.AddBike.UseVisualStyleBackColor = false;
            this.AddBike.Click += new System.EventHandler(this.AddBike_Click);
            // 
            // RemoveBike
            // 
            this.RemoveBike.BackColor = System.Drawing.SystemColors.Highlight;
            this.RemoveBike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RemoveBike.ForeColor = System.Drawing.SystemColors.Control;
            this.RemoveBike.Location = new System.Drawing.Point(485, 357);
            this.RemoveBike.Name = "RemoveBike";
            this.RemoveBike.Size = new System.Drawing.Size(123, 55);
            this.RemoveBike.TabIndex = 3;
            this.RemoveBike.Text = "Remove Bike";
            this.RemoveBike.UseVisualStyleBackColor = false;
            this.RemoveBike.Click += new System.EventHandler(this.RemoveBike_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "available bikes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "current rented";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(477, 43);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(464, 150);
            this.dataGridView3.TabIndex = 6;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(482, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "rented bikes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(481, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "NUMER:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(481, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "TYP:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BicycleRental.Properties.Resources.bike2;
            this.pictureBox1.Location = new System.Drawing.Point(768, 206);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 206);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(951, 424);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemoveBike);
            this.Controls.Add(this.TypeBike);
            this.Controls.Add(this.rentBike);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.NumberBike);
            this.Controls.Add(this.ReturnBike);
            this.Controls.Add(this.AddBike);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Bicycle Rental";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NumberBike;
        private System.Windows.Forms.Button AddBike;
        private System.Windows.Forms.ComboBox TypeBike;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button rentBike;
        private System.Windows.Forms.Button ReturnBike;
        private System.Windows.Forms.Button RemoveBike;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

