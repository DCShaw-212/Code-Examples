
namespace DustinShaw_Page_Replacement_Algorithm
{
    partial class frmPageReplacement
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
            this.txtUserEnteredReference = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.cbRandomReference = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstOutPut = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cancelBTN = new System.Windows.Forms.Button();
            this.cboFramesSelected = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtUserEnteredReference
            // 
            this.txtUserEnteredReference.Location = new System.Drawing.Point(12, 109);
            this.txtUserEnteredReference.Name = "txtUserEnteredReference";
            this.txtUserEnteredReference.Size = new System.Drawing.Size(630, 22);
            this.txtUserEnteredReference.TabIndex = 1;
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Would you like to enter your own reference string?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Would you like to generate a random reference string? ";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(531, 137);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(111, 42);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "&Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // cbRandomReference
            // 
            this.cbRandomReference.AutoSize = true;
            this.cbRandomReference.Location = new System.Drawing.Point(375, 19);
            this.cbRandomReference.Name = "cbRandomReference";
            this.cbRandomReference.Size = new System.Drawing.Size(18, 17);
            this.cbRandomReference.TabIndex = 0;
            this.cbRandomReference.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 401);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 42);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstOutPut
            // 
            this.lstOutPut.FormattingEnabled = true;
            this.lstOutPut.ItemHeight = 16;
            this.lstOutPut.Location = new System.Drawing.Point(12, 189);
            this.lstOutPut.Name = "lstOutPut";
            this.lstOutPut.Size = new System.Drawing.Size(630, 212);
            this.lstOutPut.TabIndex = 4;
            this.lstOutPut.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(431, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "(Integers only between 0 and 9. No Spaces. Must be of Length 20.)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Enter the number of Frames:";
            // 
            // cancelBTN
            // 
            this.cancelBTN.Location = new System.Drawing.Point(390, 137);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(111, 42);
            this.cancelBTN.TabIndex = 8;
            this.cancelBTN.Text = "&Cancel";
            this.cancelBTN.UseVisualStyleBackColor = true;
            this.cancelBTN.Click += new System.EventHandler(this.cancelBTN_Click);
            // 
            // cboFramesSelected
            // 
            this.cboFramesSelected.FormattingEnabled = true;
            this.cboFramesSelected.Location = new System.Drawing.Point(208, 141);
            this.cboFramesSelected.Name = "cboFramesSelected";
            this.cboFramesSelected.Size = new System.Drawing.Size(121, 24);
            this.cboFramesSelected.TabIndex = 9;
            
            // 
            // frmPageReplacement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.cboFramesSelected);
            this.Controls.Add(this.cancelBTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstOutPut);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cbRandomReference);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserEnteredReference);
            this.Name = "frmPageReplacement";
            this.Text = "Page Replacement Algorithm";
            this.Load += new System.EventHandler(this.frmPageReplacement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserEnteredReference;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.CheckBox cbRandomReference;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstOutPut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancelBTN;
        private System.Windows.Forms.ComboBox cboFramesSelected;
    }
}

