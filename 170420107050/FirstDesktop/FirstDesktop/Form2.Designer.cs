namespace FirstDesktop
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.Value1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Value2 = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Mult = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number 1";
            // 
            // Value1
            // 
            this.Value1.Location = new System.Drawing.Point(83, 20);
            this.Value1.Name = "Value1";
            this.Value1.Size = new System.Drawing.Size(100, 20);
            this.Value1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number 2";
            // 
            // Value2
            // 
            this.Value2.Location = new System.Drawing.Point(83, 54);
            this.Value2.Name = "Value2";
            this.Value2.Size = new System.Drawing.Size(100, 20);
            this.Value2.TabIndex = 3;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(27, 99);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 4;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Mult
            // 
            this.Mult.Location = new System.Drawing.Point(27, 142);
            this.Mult.Name = "Mult";
            this.Mult.Size = new System.Drawing.Size(75, 23);
            this.Mult.TabIndex = 5;
            this.Mult.Text = "*";
            this.Mult.UseVisualStyleBackColor = true;
            this.Mult.Click += new System.EventHandler(this.Mult_Click);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(131, 142);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(75, 23);
            this.Division.TabIndex = 6;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // Sub
            // 
            this.Sub.Location = new System.Drawing.Point(131, 99);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(75, 23);
            this.Sub.TabIndex = 7;
            this.Sub.Text = "-";
            this.Sub.UseVisualStyleBackColor = true;
            this.Sub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(80, 177);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 13);
            this.Result.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 216);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Mult);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Value2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Value1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Value1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Value2;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Mult;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Sub;
        private System.Windows.Forms.Label Result;
    }
}