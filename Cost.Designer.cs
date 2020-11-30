namespace FamilyBudget
{
    partial class Cost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cost));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ValueTB = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.ClearBT = new System.Windows.Forms.Button();
            this.AddBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(202, 68);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(101, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.BackColor = System.Drawing.Color.White;
            this.DescriptionTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTB.ForeColor = System.Drawing.Color.Black;
            this.DescriptionTB.Location = new System.Drawing.Point(132, 131);
            this.DescriptionTB.Multiline = true;
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.Size = new System.Drawing.Size(272, 45);
            this.DescriptionTB.TabIndex = 2;
            this.DescriptionTB.Tag = "";
            this.DescriptionTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(34, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Choose Date";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(34, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 45);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cost Description";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ValueTB
            // 
            this.ValueTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueTB.ForeColor = System.Drawing.Color.Black;
            this.ValueTB.Location = new System.Drawing.Point(132, 210);
            this.ValueTB.Multiline = true;
            this.ValueTB.Name = "ValueTB";
            this.ValueTB.Size = new System.Drawing.Size(272, 45);
            this.ValueTB.TabIndex = 9;
            this.ValueTB.Tag = "";
            this.ValueTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ValueTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(34, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 45);
            this.button3.TabIndex = 10;
            this.button3.Text = "Cost Value";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ClearBT
            // 
            this.ClearBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBT.Location = new System.Drawing.Point(132, 284);
            this.ClearBT.Name = "ClearBT";
            this.ClearBT.Size = new System.Drawing.Size(86, 44);
            this.ClearBT.TabIndex = 11;
            this.ClearBT.Text = "Clear";
            this.ClearBT.UseVisualStyleBackColor = true;
            this.ClearBT.Click += new System.EventHandler(this.ClearBT_Click);
            // 
            // AddBT
            // 
            this.AddBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBT.Location = new System.Drawing.Point(310, 284);
            this.AddBT.Name = "AddBT";
            this.AddBT.Size = new System.Drawing.Size(94, 44);
            this.AddBT.TabIndex = 12;
            this.AddBT.Text = "Add Cost";
            this.AddBT.UseVisualStyleBackColor = true;
            this.AddBT.Click += new System.EventHandler(this.AddBT_Click);
            // 
            // Cost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 340);
            this.Controls.Add(this.AddBT);
            this.Controls.Add(this.ClearBT);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ValueTB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DescriptionTB);
            this.Controls.Add(this.dateTimePicker1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cost";
            this.Text = "Cost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox DescriptionTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ValueTB;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ClearBT;
        private System.Windows.Forms.Button AddBT;
    }
}