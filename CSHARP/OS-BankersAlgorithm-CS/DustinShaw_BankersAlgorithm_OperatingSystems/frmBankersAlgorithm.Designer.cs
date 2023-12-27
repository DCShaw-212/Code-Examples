
namespace DustinShaw_BankersAlgorithm_OperatingSystems
{
    partial class frmBankersAlgorithm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumberOfProcesses = new System.Windows.Forms.TextBox();
            this.txtNumberOfResourcesTypes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAllocationForP0 = new System.Windows.Forms.TextBox();
            this.txtAllocationForP1 = new System.Windows.Forms.TextBox();
            this.txtAllocationForP2 = new System.Windows.Forms.TextBox();
            this.txtAllocationForP3 = new System.Windows.Forms.TextBox();
            this.txtAllocationForP4 = new System.Windows.Forms.TextBox();
            this.gboAllocation = new System.Windows.Forms.GroupBox();
            this.gboMax = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMaxP0 = new System.Windows.Forms.TextBox();
            this.txtMaxP1 = new System.Windows.Forms.TextBox();
            this.txtMaxP2 = new System.Windows.Forms.TextBox();
            this.txtMaxP3 = new System.Windows.Forms.TextBox();
            this.txtMaxP4 = new System.Windows.Forms.TextBox();
            this.gboRequest = new System.Windows.Forms.GroupBox();
            this.cboProcessRequest = new System.Windows.Forms.ComboBox();
            this.txtProcessRequest = new System.Windows.Forms.TextBox();
            this.btnRequest = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.openFileDialogTxt = new System.Windows.Forms.OpenFileDialog();
            this.gboUpload = new System.Windows.Forms.GroupBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtNeedForP0 = new System.Windows.Forms.TextBox();
            this.txtNeedForP1 = new System.Windows.Forms.TextBox();
            this.txtNeedForP2 = new System.Windows.Forms.TextBox();
            this.txtNeedForP3 = new System.Windows.Forms.TextBox();
            this.txtNeedForP4 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtNumberOfInstances = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtAvailable = new System.Windows.Forms.TextBox();
            this.lstSafeSequence = new System.Windows.Forms.ListBox();
            this.gboAllocation.SuspendLayout();
            this.gboMax.SuspendLayout();
            this.gboRequest.SuspendLayout();
            this.gboUpload.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Processes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Resource Types:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = " P0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "P1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "P2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = " P3";
            // 
            // txtNumberOfProcesses
            // 
            this.txtNumberOfProcesses.Location = new System.Drawing.Point(229, 27);
            this.txtNumberOfProcesses.Name = "txtNumberOfProcesses";
            this.txtNumberOfProcesses.ReadOnly = true;
            this.txtNumberOfProcesses.Size = new System.Drawing.Size(100, 22);
            this.txtNumberOfProcesses.TabIndex = 0;
            this.txtNumberOfProcesses.TabStop = false;
            // 
            // txtNumberOfResourcesTypes
            // 
            this.txtNumberOfResourcesTypes.Location = new System.Drawing.Point(229, 66);
            this.txtNumberOfResourcesTypes.Name = "txtNumberOfResourcesTypes";
            this.txtNumberOfResourcesTypes.ReadOnly = true;
            this.txtNumberOfResourcesTypes.Size = new System.Drawing.Size(100, 22);
            this.txtNumberOfResourcesTypes.TabIndex = 1;
            this.txtNumberOfResourcesTypes.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "P4";
            // 
            // txtAllocationForP0
            // 
            this.txtAllocationForP0.Location = new System.Drawing.Point(35, 37);
            this.txtAllocationForP0.Name = "txtAllocationForP0";
            this.txtAllocationForP0.ReadOnly = true;
            this.txtAllocationForP0.Size = new System.Drawing.Size(59, 22);
            this.txtAllocationForP0.TabIndex = 9;
            this.txtAllocationForP0.TabStop = false;
            // 
            // txtAllocationForP1
            // 
            this.txtAllocationForP1.Location = new System.Drawing.Point(35, 81);
            this.txtAllocationForP1.Name = "txtAllocationForP1";
            this.txtAllocationForP1.ReadOnly = true;
            this.txtAllocationForP1.Size = new System.Drawing.Size(59, 22);
            this.txtAllocationForP1.TabIndex = 10;
            this.txtAllocationForP1.TabStop = false;
            // 
            // txtAllocationForP2
            // 
            this.txtAllocationForP2.Location = new System.Drawing.Point(35, 131);
            this.txtAllocationForP2.Name = "txtAllocationForP2";
            this.txtAllocationForP2.ReadOnly = true;
            this.txtAllocationForP2.Size = new System.Drawing.Size(59, 22);
            this.txtAllocationForP2.TabIndex = 11;
            this.txtAllocationForP2.TabStop = false;
            // 
            // txtAllocationForP3
            // 
            this.txtAllocationForP3.Location = new System.Drawing.Point(35, 175);
            this.txtAllocationForP3.Name = "txtAllocationForP3";
            this.txtAllocationForP3.ReadOnly = true;
            this.txtAllocationForP3.Size = new System.Drawing.Size(59, 22);
            this.txtAllocationForP3.TabIndex = 12;
            this.txtAllocationForP3.TabStop = false;
            // 
            // txtAllocationForP4
            // 
            this.txtAllocationForP4.Location = new System.Drawing.Point(35, 216);
            this.txtAllocationForP4.Name = "txtAllocationForP4";
            this.txtAllocationForP4.ReadOnly = true;
            this.txtAllocationForP4.Size = new System.Drawing.Size(59, 22);
            this.txtAllocationForP4.TabIndex = 13;
            this.txtAllocationForP4.TabStop = false;
            // 
            // gboAllocation
            // 
            this.gboAllocation.Controls.Add(this.label3);
            this.gboAllocation.Controls.Add(this.label4);
            this.gboAllocation.Controls.Add(this.label5);
            this.gboAllocation.Controls.Add(this.label6);
            this.gboAllocation.Controls.Add(this.label7);
            this.gboAllocation.Controls.Add(this.txtAllocationForP0);
            this.gboAllocation.Controls.Add(this.txtAllocationForP1);
            this.gboAllocation.Controls.Add(this.txtAllocationForP2);
            this.gboAllocation.Controls.Add(this.txtAllocationForP3);
            this.gboAllocation.Controls.Add(this.txtAllocationForP4);
            this.gboAllocation.Location = new System.Drawing.Point(54, 150);
            this.gboAllocation.Name = "gboAllocation";
            this.gboAllocation.Size = new System.Drawing.Size(115, 253);
            this.gboAllocation.TabIndex = 26;
            this.gboAllocation.TabStop = false;
            this.gboAllocation.Text = "Allocation";
            // 
            // gboMax
            // 
            this.gboMax.Controls.Add(this.label8);
            this.gboMax.Controls.Add(this.label9);
            this.gboMax.Controls.Add(this.label10);
            this.gboMax.Controls.Add(this.label11);
            this.gboMax.Controls.Add(this.label12);
            this.gboMax.Controls.Add(this.txtMaxP0);
            this.gboMax.Controls.Add(this.txtMaxP1);
            this.gboMax.Controls.Add(this.txtMaxP2);
            this.gboMax.Controls.Add(this.txtMaxP3);
            this.gboMax.Controls.Add(this.txtMaxP4);
            this.gboMax.Location = new System.Drawing.Point(198, 150);
            this.gboMax.Name = "gboMax";
            this.gboMax.Size = new System.Drawing.Size(115, 253);
            this.gboMax.TabIndex = 27;
            this.gboMax.TabStop = false;
            this.gboMax.Text = "Max";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "P0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "P1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "P2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "P3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 219);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = " P4";
            // 
            // txtMaxP0
            // 
            this.txtMaxP0.Location = new System.Drawing.Point(35, 37);
            this.txtMaxP0.Name = "txtMaxP0";
            this.txtMaxP0.ReadOnly = true;
            this.txtMaxP0.Size = new System.Drawing.Size(59, 22);
            this.txtMaxP0.TabIndex = 9;
            this.txtMaxP0.TabStop = false;
            // 
            // txtMaxP1
            // 
            this.txtMaxP1.Location = new System.Drawing.Point(35, 81);
            this.txtMaxP1.Name = "txtMaxP1";
            this.txtMaxP1.ReadOnly = true;
            this.txtMaxP1.Size = new System.Drawing.Size(59, 22);
            this.txtMaxP1.TabIndex = 10;
            this.txtMaxP1.TabStop = false;
            // 
            // txtMaxP2
            // 
            this.txtMaxP2.Location = new System.Drawing.Point(35, 131);
            this.txtMaxP2.Name = "txtMaxP2";
            this.txtMaxP2.ReadOnly = true;
            this.txtMaxP2.Size = new System.Drawing.Size(59, 22);
            this.txtMaxP2.TabIndex = 11;
            this.txtMaxP2.TabStop = false;
            // 
            // txtMaxP3
            // 
            this.txtMaxP3.Location = new System.Drawing.Point(35, 175);
            this.txtMaxP3.Name = "txtMaxP3";
            this.txtMaxP3.ReadOnly = true;
            this.txtMaxP3.Size = new System.Drawing.Size(59, 22);
            this.txtMaxP3.TabIndex = 12;
            this.txtMaxP3.TabStop = false;
            // 
            // txtMaxP4
            // 
            this.txtMaxP4.Location = new System.Drawing.Point(35, 216);
            this.txtMaxP4.Name = "txtMaxP4";
            this.txtMaxP4.ReadOnly = true;
            this.txtMaxP4.Size = new System.Drawing.Size(59, 22);
            this.txtMaxP4.TabIndex = 13;
            this.txtMaxP4.TabStop = false;
            // 
            // gboRequest
            // 
            this.gboRequest.Controls.Add(this.cboProcessRequest);
            this.gboRequest.Controls.Add(this.txtProcessRequest);
            this.gboRequest.Location = new System.Drawing.Point(475, 150);
            this.gboRequest.Name = "gboRequest";
            this.gboRequest.Size = new System.Drawing.Size(213, 68);
            this.gboRequest.TabIndex = 28;
            this.gboRequest.TabStop = false;
            this.gboRequest.Text = "Request";
            // 
            // cboProcessRequest
            // 
            this.cboProcessRequest.FormattingEnabled = true;
            this.cboProcessRequest.Location = new System.Drawing.Point(6, 21);
            this.cboProcessRequest.Name = "cboProcessRequest";
            this.cboProcessRequest.Size = new System.Drawing.Size(60, 24);
            this.cboProcessRequest.TabIndex = 2;
            // 
            // txtProcessRequest
            // 
            this.txtProcessRequest.Location = new System.Drawing.Point(85, 21);
            this.txtProcessRequest.Name = "txtProcessRequest";
            this.txtProcessRequest.Size = new System.Drawing.Size(106, 22);
            this.txtProcessRequest.TabIndex = 1;
            // 
            // btnRequest
            // 
            this.btnRequest.Enabled = false;
            this.btnRequest.Location = new System.Drawing.Point(699, 161);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(100, 43);
            this.btnRequest.TabIndex = 6;
            this.btnRequest.Text = "&Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(12, 409);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 43);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // openFileDialogTxt
            // 
            this.openFileDialogTxt.FileName = "openFileDialog1";
            // 
            // gboUpload
            // 
            this.gboUpload.Controls.Add(this.txtFileName);
            this.gboUpload.Controls.Add(this.btnBrowse);
            this.gboUpload.Location = new System.Drawing.Point(382, 27);
            this.gboUpload.Name = "gboUpload";
            this.gboUpload.Size = new System.Drawing.Size(417, 69);
            this.gboUpload.TabIndex = 31;
            this.gboUpload.TabStop = false;
            this.gboUpload.Text = "Upload TXT File";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(14, 30);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(292, 22);
            this.txtFileName.TabIndex = 0;
            this.txtFileName.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBrowse.Location = new System.Drawing.Point(312, 20);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 43);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "&Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.txtNeedForP0);
            this.groupBox1.Controls.Add(this.txtNeedForP1);
            this.groupBox1.Controls.Add(this.txtNeedForP2);
            this.groupBox1.Controls.Add(this.txtNeedForP3);
            this.groupBox1.Controls.Add(this.txtNeedForP4);
            this.groupBox1.Location = new System.Drawing.Point(331, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 253);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Need";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(4, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 17);
            this.label18.TabIndex = 2;
            this.label18.Text = "P0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(4, 84);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(25, 17);
            this.label19.TabIndex = 3;
            this.label19.Text = "P1";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(4, 131);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(25, 17);
            this.label20.TabIndex = 4;
            this.label20.Text = "P2";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(4, 178);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(25, 17);
            this.label21.TabIndex = 5;
            this.label21.Text = "P3";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(4, 219);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 17);
            this.label22.TabIndex = 8;
            this.label22.Text = " P4";
            // 
            // txtNeedForP0
            // 
            this.txtNeedForP0.Location = new System.Drawing.Point(35, 37);
            this.txtNeedForP0.Name = "txtNeedForP0";
            this.txtNeedForP0.ReadOnly = true;
            this.txtNeedForP0.Size = new System.Drawing.Size(59, 22);
            this.txtNeedForP0.TabIndex = 9;
            this.txtNeedForP0.TabStop = false;
            // 
            // txtNeedForP1
            // 
            this.txtNeedForP1.Location = new System.Drawing.Point(35, 81);
            this.txtNeedForP1.Name = "txtNeedForP1";
            this.txtNeedForP1.ReadOnly = true;
            this.txtNeedForP1.Size = new System.Drawing.Size(59, 22);
            this.txtNeedForP1.TabIndex = 10;
            this.txtNeedForP1.TabStop = false;
            // 
            // txtNeedForP2
            // 
            this.txtNeedForP2.Location = new System.Drawing.Point(35, 131);
            this.txtNeedForP2.Name = "txtNeedForP2";
            this.txtNeedForP2.ReadOnly = true;
            this.txtNeedForP2.Size = new System.Drawing.Size(59, 22);
            this.txtNeedForP2.TabIndex = 11;
            this.txtNeedForP2.TabStop = false;
            // 
            // txtNeedForP3
            // 
            this.txtNeedForP3.Location = new System.Drawing.Point(35, 175);
            this.txtNeedForP3.Name = "txtNeedForP3";
            this.txtNeedForP3.ReadOnly = true;
            this.txtNeedForP3.Size = new System.Drawing.Size(59, 22);
            this.txtNeedForP3.TabIndex = 12;
            this.txtNeedForP3.TabStop = false;
            // 
            // txtNeedForP4
            // 
            this.txtNeedForP4.Location = new System.Drawing.Point(35, 216);
            this.txtNeedForP4.Name = "txtNeedForP4";
            this.txtNeedForP4.ReadOnly = true;
            this.txtNeedForP4.Size = new System.Drawing.Size(59, 22);
            this.txtNeedForP4.TabIndex = 13;
            this.txtNeedForP4.TabStop = false;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(9, 108);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(214, 17);
            this.label28.TabIndex = 32;
            this.label28.Text = "Number of Instances (Per Type):";
            // 
            // txtNumberOfInstances
            // 
            this.txtNumberOfInstances.Location = new System.Drawing.Point(229, 105);
            this.txtNumberOfInstances.Name = "txtNumberOfInstances";
            this.txtNumberOfInstances.ReadOnly = true;
            this.txtNumberOfInstances.Size = new System.Drawing.Size(100, 22);
            this.txtNumberOfInstances.TabIndex = 33;
            this.txtNumberOfInstances.TabStop = false;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(438, 110);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(141, 17);
            this.label29.TabIndex = 34;
            this.label29.Text = "Resources Available:";
            // 
            // txtAvailable
            // 
            this.txtAvailable.Location = new System.Drawing.Point(581, 107);
            this.txtAvailable.Name = "txtAvailable";
            this.txtAvailable.ReadOnly = true;
            this.txtAvailable.Size = new System.Drawing.Size(177, 22);
            this.txtAvailable.TabIndex = 35;
            this.txtAvailable.TabStop = false;
            // 
            // lstSafeSequence
            // 
            this.lstSafeSequence.FormattingEnabled = true;
            this.lstSafeSequence.ItemHeight = 16;
            this.lstSafeSequence.Location = new System.Drawing.Point(475, 234);
            this.lstSafeSequence.Name = "lstSafeSequence";
            this.lstSafeSequence.Size = new System.Drawing.Size(324, 212);
            this.lstSafeSequence.TabIndex = 36;
            this.lstSafeSequence.TabStop = false;
            // 
            // frmBankersAlgorithm
            // 
            this.AcceptButton = this.btnRequest;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(820, 463);
            this.Controls.Add(this.lstSafeSequence);
            this.Controls.Add(this.txtAvailable);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.txtNumberOfInstances);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboUpload);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.gboRequest);
            this.Controls.Add(this.gboMax);
            this.Controls.Add(this.gboAllocation);
            this.Controls.Add(this.txtNumberOfResourcesTypes);
            this.Controls.Add(this.txtNumberOfProcesses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBankersAlgorithm";
            this.Text = "Banker\'s Algorithm";
            this.Load += new System.EventHandler(this.frmBankersAlgorithm_Load);
            this.gboAllocation.ResumeLayout(false);
            this.gboAllocation.PerformLayout();
            this.gboMax.ResumeLayout(false);
            this.gboMax.PerformLayout();
            this.gboRequest.ResumeLayout(false);
            this.gboRequest.PerformLayout();
            this.gboUpload.ResumeLayout(false);
            this.gboUpload.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumberOfProcesses;
        private System.Windows.Forms.TextBox txtNumberOfResourcesTypes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAllocationForP0;
        private System.Windows.Forms.TextBox txtAllocationForP1;
        private System.Windows.Forms.TextBox txtAllocationForP2;
        private System.Windows.Forms.TextBox txtAllocationForP3;
        private System.Windows.Forms.TextBox txtAllocationForP4;
        private System.Windows.Forms.GroupBox gboAllocation;
        private System.Windows.Forms.GroupBox gboMax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMaxP0;
        private System.Windows.Forms.TextBox txtMaxP1;
        private System.Windows.Forms.TextBox txtMaxP2;
        private System.Windows.Forms.TextBox txtMaxP3;
        private System.Windows.Forms.TextBox txtMaxP4;
        private System.Windows.Forms.GroupBox gboRequest;
        private System.Windows.Forms.TextBox txtProcessRequest;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.OpenFileDialog openFileDialogTxt;
        private System.Windows.Forms.GroupBox gboUpload;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtNeedForP0;
        private System.Windows.Forms.TextBox txtNeedForP1;
        private System.Windows.Forms.TextBox txtNeedForP2;
        private System.Windows.Forms.TextBox txtNeedForP3;
        private System.Windows.Forms.TextBox txtNeedForP4;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtNumberOfInstances;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtAvailable;
        private System.Windows.Forms.ComboBox cboProcessRequest;
        private System.Windows.Forms.ListBox lstSafeSequence;
    }
}

