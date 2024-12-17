namespace FinanceTracker
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
            this.tb_income_name = new System.Windows.Forms.TextBox();
            this.tb_income_money = new System.Windows.Forms.TextBox();
            this.b_income_submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lv_income = new System.Windows.Forms.ListView();
            this.lv_expenses = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_expenses_money = new System.Windows.Forms.TextBox();
            this.tb_expenses_name = new System.Windows.Forms.TextBox();
            this.b_expenses_submit = new System.Windows.Forms.Button();
            this.lbl_difference = new System.Windows.Forms.Label();
            this.b_load = new System.Windows.Forms.Button();
            this.b_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_income_name
            // 
            this.tb_income_name.Location = new System.Drawing.Point(12, 58);
            this.tb_income_name.Name = "tb_income_name";
            this.tb_income_name.Size = new System.Drawing.Size(210, 20);
            this.tb_income_name.TabIndex = 3;
            this.tb_income_name.Text = "Name";
            // 
            // tb_income_money
            // 
            this.tb_income_money.Location = new System.Drawing.Point(228, 58);
            this.tb_income_money.Name = "tb_income_money";
            this.tb_income_money.Size = new System.Drawing.Size(58, 20);
            this.tb_income_money.TabIndex = 4;
            this.tb_income_money.Text = "€€€";
            // 
            // b_income_submit
            // 
            this.b_income_submit.Location = new System.Drawing.Point(12, 84);
            this.b_income_submit.Name = "b_income_submit";
            this.b_income_submit.Size = new System.Drawing.Size(274, 23);
            this.b_income_submit.TabIndex = 2;
            this.b_income_submit.Text = "Eintragen";
            this.b_income_submit.UseVisualStyleBackColor = true;
            this.b_income_submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Einnahmen";
            // 
            // lv_income
            // 
            this.lv_income.HideSelection = false;
            this.lv_income.Location = new System.Drawing.Point(12, 113);
            this.lv_income.Name = "lv_income";
            this.lv_income.Size = new System.Drawing.Size(274, 66);
            this.lv_income.TabIndex = 6;
            this.lv_income.UseCompatibleStateImageBehavior = false;
            this.lv_income.View = System.Windows.Forms.View.Details;
            this.lv_income.SelectedIndexChanged += new System.EventHandler(this.lv_income_SelectedIndexChanged);
            // 
            // lv_expenses
            // 
            this.lv_expenses.HideSelection = false;
            this.lv_expenses.Location = new System.Drawing.Point(12, 257);
            this.lv_expenses.Name = "lv_expenses";
            this.lv_expenses.Size = new System.Drawing.Size(274, 306);
            this.lv_expenses.TabIndex = 11;
            this.lv_expenses.UseCompatibleStateImageBehavior = false;
            this.lv_expenses.View = System.Windows.Forms.View.Details;
            this.lv_expenses.SelectedIndexChanged += new System.EventHandler(this.lv_expenses_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ausgaben";
            // 
            // tb_expenses_money
            // 
            this.tb_expenses_money.Location = new System.Drawing.Point(228, 202);
            this.tb_expenses_money.Name = "tb_expenses_money";
            this.tb_expenses_money.Size = new System.Drawing.Size(58, 20);
            this.tb_expenses_money.TabIndex = 9;
            this.tb_expenses_money.Text = "€€€";
            // 
            // tb_expenses_name
            // 
            this.tb_expenses_name.Location = new System.Drawing.Point(12, 202);
            this.tb_expenses_name.Name = "tb_expenses_name";
            this.tb_expenses_name.Size = new System.Drawing.Size(210, 20);
            this.tb_expenses_name.TabIndex = 8;
            this.tb_expenses_name.Text = "Name";
            // 
            // b_expenses_submit
            // 
            this.b_expenses_submit.Location = new System.Drawing.Point(12, 228);
            this.b_expenses_submit.Name = "b_expenses_submit";
            this.b_expenses_submit.Size = new System.Drawing.Size(274, 23);
            this.b_expenses_submit.TabIndex = 12;
            this.b_expenses_submit.Text = "Eintragen";
            this.b_expenses_submit.UseVisualStyleBackColor = true;
            this.b_expenses_submit.Click += new System.EventHandler(this.b_expenses_submit_Click);
            // 
            // lbl_difference
            // 
            this.lbl_difference.AutoSize = true;
            this.lbl_difference.Location = new System.Drawing.Point(117, 566);
            this.lbl_difference.Name = "lbl_difference";
            this.lbl_difference.Size = new System.Drawing.Size(49, 13);
            this.lbl_difference.TabIndex = 13;
            this.lbl_difference.Text = "Differenz";
            // 
            // b_load
            // 
            this.b_load.Location = new System.Drawing.Point(12, 13);
            this.b_load.Name = "b_load";
            this.b_load.Size = new System.Drawing.Size(133, 23);
            this.b_load.TabIndex = 14;
            this.b_load.Text = "Load";
            this.b_load.UseVisualStyleBackColor = true;
            this.b_load.Click += new System.EventHandler(this.b_load_Click);
            // 
            // b_save
            // 
            this.b_save.Location = new System.Drawing.Point(153, 13);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(133, 23);
            this.b_save.TabIndex = 15;
            this.b_save.Text = "Save";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 584);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.b_load);
            this.Controls.Add(this.lbl_difference);
            this.Controls.Add(this.b_expenses_submit);
            this.Controls.Add(this.lv_expenses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_expenses_money);
            this.Controls.Add(this.tb_expenses_name);
            this.Controls.Add(this.lv_income);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_income_money);
            this.Controls.Add(this.tb_income_name);
            this.Controls.Add(this.b_income_submit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_income_name;
        private System.Windows.Forms.TextBox tb_income_money;
        private System.Windows.Forms.Button b_income_submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv_income;
        private System.Windows.Forms.ListView lv_expenses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_expenses_money;
        private System.Windows.Forms.TextBox tb_expenses_name;
        private System.Windows.Forms.Button b_expenses_submit;
        private System.Windows.Forms.Label lbl_difference;
        private System.Windows.Forms.Button b_load;
        private System.Windows.Forms.Button b_save;
    }
}

