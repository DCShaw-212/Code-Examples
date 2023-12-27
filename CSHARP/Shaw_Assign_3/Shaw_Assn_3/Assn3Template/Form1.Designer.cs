namespace Assn3Template
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
            this.btnOneIteration = new System.Windows.Forms.Button();
            this.iterationCount = new System.Windows.Forms.NumericUpDown();
            this.multiIteration = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iterationCount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOneIteration
            // 
            this.btnOneIteration.Location = new System.Drawing.Point(12, 464);
            this.btnOneIteration.Name = "btnOneIteration";
            this.btnOneIteration.Size = new System.Drawing.Size(297, 44);
            this.btnOneIteration.TabIndex = 0;
            this.btnOneIteration.Text = "Run One Iteration";
            this.btnOneIteration.UseVisualStyleBackColor = true;
            this.btnOneIteration.Click += new System.EventHandler(this.btnOneIteration_Click);
            // 
            // iterationCount
            // 
            this.iterationCount.Location = new System.Drawing.Point(357, 476);
            this.iterationCount.Name = "iterationCount";
            this.iterationCount.Size = new System.Drawing.Size(104, 22);
            this.iterationCount.TabIndex = 2;
            // 
            // multiIteration
            // 
            this.multiIteration.Location = new System.Drawing.Point(522, 464);
            this.multiIteration.Name = "multiIteration";
            this.multiIteration.Size = new System.Drawing.Size(316, 44);
            this.multiIteration.TabIndex = 4;
            this.multiIteration.Text = "Run Multiple Iteration";
            this.multiIteration.UseVisualStyleBackColor = true;
            this.multiIteration.Click += new System.EventHandler(this.multiIteration_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 554);
            this.Controls.Add(this.multiIteration);
            this.Controls.Add(this.iterationCount);
            this.Controls.Add(this.btnOneIteration);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iterationCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOneIteration;
        private System.Windows.Forms.NumericUpDown iterationCount;
        private System.Windows.Forms.Button multiIteration;
    }
}

