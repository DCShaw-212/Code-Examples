
namespace DustinShaw_Assignment2
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
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScoreTotal = new System.Windows.Forms.Label();
            this.lblScoreCount = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtScoreTotal = new System.Windows.Forms.TextBox();
            this.txtScoreCount = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.btnClearScores = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(24, 18);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(49, 17);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score:";
            // 
            // lblScoreTotal
            // 
            this.lblScoreTotal.AutoSize = true;
            this.lblScoreTotal.Location = new System.Drawing.Point(24, 68);
            this.lblScoreTotal.Name = "lblScoreTotal";
            this.lblScoreTotal.Size = new System.Drawing.Size(85, 17);
            this.lblScoreTotal.TabIndex = 1;
            this.lblScoreTotal.Text = "Score Total:";
            // 
            // lblScoreCount
            // 
            this.lblScoreCount.AutoSize = true;
            this.lblScoreCount.Location = new System.Drawing.Point(24, 118);
            this.lblScoreCount.Name = "lblScoreCount";
            this.lblScoreCount.Size = new System.Drawing.Size(90, 17);
            this.lblScoreCount.TabIndex = 2;
            this.lblScoreCount.Text = "Score Count:";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(24, 168);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(65, 17);
            this.lblAverage.TabIndex = 3;
            this.lblAverage.Text = "Average:";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(122, 13);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(62, 22);
            this.txtScore.TabIndex = 4;
            // 
            // txtScoreTotal
            // 
            this.txtScoreTotal.Location = new System.Drawing.Point(122, 65);
            this.txtScoreTotal.Name = "txtScoreTotal";
            this.txtScoreTotal.ReadOnly = true;
            this.txtScoreTotal.Size = new System.Drawing.Size(62, 22);
            this.txtScoreTotal.TabIndex = 5;
            this.txtScoreTotal.TabStop = false;
            // 
            // txtScoreCount
            // 
            this.txtScoreCount.Location = new System.Drawing.Point(122, 117);
            this.txtScoreCount.Name = "txtScoreCount";
            this.txtScoreCount.ReadOnly = true;
            this.txtScoreCount.Size = new System.Drawing.Size(62, 22);
            this.txtScoreCount.TabIndex = 6;
            this.txtScoreCount.TabStop = false;
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(122, 169);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(62, 22);
            this.txtAverage.TabIndex = 7;
            this.txtAverage.TabStop = false;
            // 
            // btnClearScores
            // 
            this.btnClearScores.Location = new System.Drawing.Point(73, 223);
            this.btnClearScores.Name = "btnClearScores";
            this.btnClearScores.Size = new System.Drawing.Size(111, 31);
            this.btnClearScores.TabIndex = 9;
            this.btnClearScores.Text = "Clear Scores";
            this.btnClearScores.UseVisualStyleBackColor = true;
            this.btnClearScores.Click += new System.EventHandler(this.btnClearScores_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(212, 223);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 31);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(212, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 31);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(337, 267);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearScores);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.txtScoreCount);
            this.Controls.Add(this.txtScoreTotal);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblScoreCount);
            this.Controls.Add(this.lblScoreTotal);
            this.Controls.Add(this.lblScore);
            this.Name = "Form1";
            this.Text = "Score Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScoreTotal;
        private System.Windows.Forms.Label lblScoreCount;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtScoreTotal;
        private System.Windows.Forms.TextBox txtScoreCount;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Button btnClearScores;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
    }
}

