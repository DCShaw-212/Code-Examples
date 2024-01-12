
namespace DustinShaw_Assignment1
{
    partial class frmCalculateGrade
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
            this.lblNumberGrade = new System.Windows.Forms.Label();
            this.lblLetterGrade = new System.Windows.Forms.Label();
            this.txtNumberGrade = new System.Windows.Forms.TextBox();
            this.txtLetterGrade = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumberGrade
            // 
            this.lblNumberGrade.AutoSize = true;
            this.lblNumberGrade.Location = new System.Drawing.Point(33, 36);
            this.lblNumberGrade.Name = "lblNumberGrade";
            this.lblNumberGrade.Size = new System.Drawing.Size(103, 17);
            this.lblNumberGrade.TabIndex = 0;
            this.lblNumberGrade.Text = "&Number grade:";
            this.lblNumberGrade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLetterGrade
            // 
            this.lblLetterGrade.AutoSize = true;
            this.lblLetterGrade.Location = new System.Drawing.Point(33, 92);
            this.lblLetterGrade.Name = "lblLetterGrade";
            this.lblLetterGrade.Size = new System.Drawing.Size(93, 17);
            this.lblLetterGrade.TabIndex = 6;
            this.lblLetterGrade.Text = "Letter Grade:";
            this.lblLetterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLetterGrade.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNumberGrade
            // 
            this.txtNumberGrade.Location = new System.Drawing.Point(167, 36);
            this.txtNumberGrade.Name = "txtNumberGrade";
            this.txtNumberGrade.Size = new System.Drawing.Size(66, 22);
            this.txtNumberGrade.TabIndex = 1;
            this.txtNumberGrade.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtLetterGrade
            // 
            this.txtLetterGrade.Location = new System.Drawing.Point(167, 92);
            this.txtLetterGrade.Name = "txtLetterGrade";
            this.txtLetterGrade.ReadOnly = true;
            this.txtLetterGrade.Size = new System.Drawing.Size(66, 22);
            this.txtLetterGrade.TabIndex = 3;
            this.txtLetterGrade.TabStop = false;
            this.txtLetterGrade.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(36, 140);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 28);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(167, 140);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmCalculateGrade
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(330, 194);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtLetterGrade);
            this.Controls.Add(this.txtNumberGrade);
            this.Controls.Add(this.lblLetterGrade);
            this.Controls.Add(this.lblNumberGrade);
            this.Name = "frmCalculateGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculate Letter Grade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumberGrade;
        private System.Windows.Forms.Label lblLetterGrade;
        private System.Windows.Forms.TextBox txtNumberGrade;
        private System.Windows.Forms.TextBox txtLetterGrade;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

