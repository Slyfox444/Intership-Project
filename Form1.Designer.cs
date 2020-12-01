namespace FamilyBudget
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
            this.ConstantIncome = new System.Windows.Forms.Button();
            this.CstCost = new System.Windows.Forms.Button();
            this.Cst = new System.Windows.Forms.Button();
            this.Incm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConstantIncome
            // 
            this.ConstantIncome.Location = new System.Drawing.Point(90, 57);
            this.ConstantIncome.Margin = new System.Windows.Forms.Padding(2);
            this.ConstantIncome.Name = "ConstantIncome";
            this.ConstantIncome.Size = new System.Drawing.Size(130, 71);
            this.ConstantIncome.TabIndex = 0;
            this.ConstantIncome.Text = "Add Constant Income";
            this.ConstantIncome.UseVisualStyleBackColor = true;
            this.ConstantIncome.Click += new System.EventHandler(this.ConstantIncome_Click);
            // 
            // CstCost
            // 
            this.CstCost.Location = new System.Drawing.Point(363, 57);
            this.CstCost.Name = "CstCost";
            this.CstCost.Size = new System.Drawing.Size(145, 71);
            this.CstCost.TabIndex = 1;
            this.CstCost.Text = "Add Constant Cost";
            this.CstCost.UseVisualStyleBackColor = true;
            this.CstCost.Click += new System.EventHandler(this.CstCost_Click);
            // 
            // Cst
            // 
            this.Cst.Location = new System.Drawing.Point(90, 161);
            this.Cst.Name = "Cst";
            this.Cst.Size = new System.Drawing.Size(130, 64);
            this.Cst.TabIndex = 2;
            this.Cst.Text = "Add Cost";
            this.Cst.UseVisualStyleBackColor = true;
            this.Cst.Click += new System.EventHandler(this.Cst_Click);
            // 
            // Incm
            // 
            this.Incm.Location = new System.Drawing.Point(363, 161);
            this.Incm.Name = "Incm";
            this.Incm.Size = new System.Drawing.Size(145, 64);
            this.Incm.TabIndex = 3;
            this.Incm.Text = "Add Income";
            this.Incm.UseVisualStyleBackColor = true;
            this.Incm.Click += new System.EventHandler(this.Incm_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(90, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to Family Budget [Program]";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(87, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 100);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Incm);
            this.Controls.Add(this.Cst);
            this.Controls.Add(this.CstCost);
            this.Controls.Add(this.ConstantIncome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "StartScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ConstantIncome;
        private System.Windows.Forms.Button CstCost;
        private System.Windows.Forms.Button Cst;
        private System.Windows.Forms.Button Incm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

