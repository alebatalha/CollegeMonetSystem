namespace CollegeMonetSystem
{
    partial class UCEmployees
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCEmployees));
            this.dgvEmp = new System.Windows.Forms.DataGridView();
            this.btnExp = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSurn = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.rdoDoc = new System.Windows.Forms.RadioButton();
            this.rdoNurse = new System.Windows.Forms.RadioButton();
            this.rdoPT = new System.Windows.Forms.RadioButton();
            this.txtEmpNo = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.cboSpecialty = new System.Windows.Forms.ComboBox();
            this.btnShowDoc = new System.Windows.Forms.Button();
            this.btnShowNur = new System.Windows.Forms.Button();
            this.btnShowPT = new System.Windows.Forms.Button();
            this.btnall = new System.Windows.Forms.Button();
            this.grp = new System.Windows.Forms.GroupBox();
            this.lblNH = new System.Windows.Forms.Label();
            this.lblSal = new System.Windows.Forms.Label();
            this.lblSpe = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpExp = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.rdoExPT = new System.Windows.Forms.RadioButton();
            this.rdoExpNur = new System.Windows.Forms.RadioButton();
            this.rdoExpDoc = new System.Windows.Forms.RadioButton();
            this.sfdExpCSV = new System.Windows.Forms.SaveFileDialog();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnltop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.epEmpNo = new System.Windows.Forms.ErrorProvider(this.components);
            this.epAge = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSalary = new System.Windows.Forms.ErrorProvider(this.components);
            this.epHours = new System.Windows.Forms.ErrorProvider(this.components);
            this.epFn = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSn = new System.Windows.Forms.ErrorProvider(this.components);
            this.epAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.epEmail = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).BeginInit();
            this.grp.SuspendLayout();
            this.grpExp.SuspendLayout();
            this.pnltop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epEmpNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmp
            // 
            this.dgvEmp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.dgvEmp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmp.Location = new System.Drawing.Point(15, 434);
            this.dgvEmp.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmp.Name = "dgvEmp";
            this.dgvEmp.RowHeadersWidth = 51;
            this.dgvEmp.Size = new System.Drawing.Size(781, 145);
            this.dgvEmp.TabIndex = 0;
            this.dgvEmp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmp_CellContentClick);
            // 
            // btnExp
            // 
            this.btnExp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnExp.FlatAppearance.BorderSize = 0;
            this.btnExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExp.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExp.Location = new System.Drawing.Point(573, 32);
            this.btnExp.Margin = new System.Windows.Forms.Padding(4);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(109, 36);
            this.btnExp.TabIndex = 24;
            this.btnExp.Text = "Export List";
            this.btnExp.UseVisualStyleBackColor = false;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtFirstName.Location = new System.Drawing.Point(129, 97);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(186, 28);
            this.txtFirstName.TabIndex = 5;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            this.txtFirstName.Validated += new System.EventHandler(this.txtFirstName_Validated);
            // 
            // txtSurn
            // 
            this.txtSurn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSurn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSurn.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtSurn.Location = new System.Drawing.Point(419, 94);
            this.txtSurn.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurn.Name = "txtSurn";
            this.txtSurn.Size = new System.Drawing.Size(204, 28);
            this.txtSurn.TabIndex = 6;
            this.txtSurn.Validating += new System.ComponentModel.CancelEventHandler(this.txtSurn_Validating);
            this.txtSurn.Validated += new System.EventHandler(this.txtSurn_Validated);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtAddress.Location = new System.Drawing.Point(129, 134);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(311, 28);
            this.txtAddress.TabIndex = 8;
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddress_Validating);
            this.txtAddress.Validated += new System.EventHandler(this.txtAddress_Validated);
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAge.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtAge.Location = new System.Drawing.Point(685, 97);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(81, 28);
            this.txtAge.TabIndex = 7;
            this.txtAge.Validating += new System.ComponentModel.CancelEventHandler(this.txtAge_Validating);
            this.txtAge.Validated += new System.EventHandler(this.txtAge_Validated);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtEmail.Location = new System.Drawing.Point(129, 171);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(311, 28);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            this.txtEmail.Validated += new System.EventHandler(this.txtEmail_Validated);
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtPhone.Location = new System.Drawing.Point(527, 171);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(239, 28);
            this.txtPhone.TabIndex = 11;
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhone_Validating);
            this.txtPhone.Validated += new System.EventHandler(this.txtPhone_Validated);
            // 
            // cboCounty
            // 
            this.cboCounty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboCounty.Font = new System.Drawing.Font("Calibri", 11F);
            this.cboCounty.FormattingEnabled = true;
            this.cboCounty.Location = new System.Drawing.Point(532, 130);
            this.cboCounty.Margin = new System.Windows.Forms.Padding(4);
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(233, 30);
            this.cboCounty.TabIndex = 9;
            // 
            // rdoDoc
            // 
            this.rdoDoc.AutoSize = true;
            this.rdoDoc.BackColor = System.Drawing.Color.Transparent;
            this.rdoDoc.Checked = true;
            this.rdoDoc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.rdoDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoDoc.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDoc.ForeColor = System.Drawing.Color.Red;
            this.rdoDoc.Location = new System.Drawing.Point(190, 23);
            this.rdoDoc.Margin = new System.Windows.Forms.Padding(4);
            this.rdoDoc.Name = "rdoDoc";
            this.rdoDoc.Size = new System.Drawing.Size(85, 25);
            this.rdoDoc.TabIndex = 1;
            this.rdoDoc.TabStop = true;
            this.rdoDoc.Text = "Teacher";
            this.rdoDoc.UseVisualStyleBackColor = false;
            this.rdoDoc.CheckedChanged += new System.EventHandler(this.rdoDoc_CheckedChanged);
            // 
            // rdoNurse
            // 
            this.rdoNurse.AutoSize = true;
            this.rdoNurse.BackColor = System.Drawing.Color.Transparent;
            this.rdoNurse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.rdoNurse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoNurse.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNurse.ForeColor = System.Drawing.Color.Red;
            this.rdoNurse.Location = new System.Drawing.Point(279, 23);
            this.rdoNurse.Margin = new System.Windows.Forms.Padding(4);
            this.rdoNurse.Name = "rdoNurse";
            this.rdoNurse.Size = new System.Drawing.Size(83, 25);
            this.rdoNurse.TabIndex = 2;
            this.rdoNurse.Text = "Lecture";
            this.rdoNurse.UseVisualStyleBackColor = false;
            this.rdoNurse.CheckedChanged += new System.EventHandler(this.rdoNurse_CheckedChanged);
            // 
            // rdoPT
            // 
            this.rdoPT.AutoSize = true;
            this.rdoPT.BackColor = System.Drawing.Color.Transparent;
            this.rdoPT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.rdoPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoPT.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPT.ForeColor = System.Drawing.Color.Red;
            this.rdoPT.Location = new System.Drawing.Point(362, 23);
            this.rdoPT.Margin = new System.Windows.Forms.Padding(4);
            this.rdoPT.Name = "rdoPT";
            this.rdoPT.Size = new System.Drawing.Size(98, 25);
            this.rdoPT.TabIndex = 3;
            this.rdoPT.Text = "Part Time";
            this.rdoPT.UseVisualStyleBackColor = false;
            this.rdoPT.CheckedChanged += new System.EventHandler(this.rdoPT_CheckedChanged);
            // 
            // txtEmpNo
            // 
            this.txtEmpNo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmpNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpNo.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtEmpNo.Location = new System.Drawing.Point(203, 61);
            this.txtEmpNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpNo.Name = "txtEmpNo";
            this.txtEmpNo.Size = new System.Drawing.Size(210, 28);
            this.txtEmpNo.TabIndex = 4;
            this.txtEmpNo.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmpNo_Validating);
            this.txtEmpNo.Validated += new System.EventHandler(this.txtEmpNo_Validated);
            // 
            // txtSalary
            // 
            this.txtSalary.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalary.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtSalary.Location = new System.Drawing.Point(367, 208);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(119, 28);
            this.txtSalary.TabIndex = 13;
            this.txtSalary.Validating += new System.ComponentModel.CancelEventHandler(this.txtSalary_Validating);
            this.txtSalary.Validated += new System.EventHandler(this.txtSalary_Validated);
            // 
            // txtHours
            // 
            this.txtHours.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHours.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtHours.Location = new System.Drawing.Point(635, 208);
            this.txtHours.Margin = new System.Windows.Forms.Padding(4);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(131, 28);
            this.txtHours.TabIndex = 14;
            this.txtHours.Validating += new System.ComponentModel.CancelEventHandler(this.txtHours_Validating);
            this.txtHours.Validated += new System.EventHandler(this.txtHours_Validated);
            // 
            // cboSpecialty
            // 
            this.cboSpecialty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboSpecialty.Font = new System.Drawing.Font("Calibri", 11F);
            this.cboSpecialty.FormattingEnabled = true;
            this.cboSpecialty.Location = new System.Drawing.Point(128, 208);
            this.cboSpecialty.Margin = new System.Windows.Forms.Padding(4);
            this.cboSpecialty.Name = "cboSpecialty";
            this.cboSpecialty.Size = new System.Drawing.Size(149, 30);
            this.cboSpecialty.TabIndex = 12;
            // 
            // btnShowDoc
            // 
            this.btnShowDoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowDoc.BackgroundImage")));
            this.btnShowDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowDoc.FlatAppearance.BorderSize = 0;
            this.btnShowDoc.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnShowDoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnShowDoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnShowDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowDoc.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDoc.Location = new System.Drawing.Point(387, 402);
            this.btnShowDoc.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowDoc.Name = "btnShowDoc";
            this.btnShowDoc.Size = new System.Drawing.Size(100, 36);
            this.btnShowDoc.TabIndex = 16;
            this.btnShowDoc.Text = "Teacher";
            this.btnShowDoc.UseVisualStyleBackColor = true;
            this.btnShowDoc.Click += new System.EventHandler(this.btnShowDoc_Click);
            // 
            // btnShowNur
            // 
            this.btnShowNur.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowNur.BackgroundImage")));
            this.btnShowNur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowNur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowNur.FlatAppearance.BorderSize = 0;
            this.btnShowNur.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnShowNur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnShowNur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnShowNur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowNur.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowNur.Location = new System.Drawing.Point(488, 402);
            this.btnShowNur.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowNur.Name = "btnShowNur";
            this.btnShowNur.Size = new System.Drawing.Size(100, 36);
            this.btnShowNur.TabIndex = 17;
            this.btnShowNur.Text = "Lecture";
            this.btnShowNur.UseVisualStyleBackColor = true;
            this.btnShowNur.Click += new System.EventHandler(this.btnShowNur_Click);
            // 
            // btnShowPT
            // 
            this.btnShowPT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowPT.BackgroundImage")));
            this.btnShowPT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPT.FlatAppearance.BorderSize = 0;
            this.btnShowPT.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnShowPT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnShowPT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnShowPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPT.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPT.Location = new System.Drawing.Point(588, 402);
            this.btnShowPT.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowPT.Name = "btnShowPT";
            this.btnShowPT.Size = new System.Drawing.Size(100, 36);
            this.btnShowPT.TabIndex = 18;
            this.btnShowPT.Text = "Part Time";
            this.btnShowPT.UseVisualStyleBackColor = true;
            this.btnShowPT.Click += new System.EventHandler(this.btnShowPT_Click);
            // 
            // btnall
            // 
            this.btnall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnall.BackgroundImage")));
            this.btnall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnall.FlatAppearance.BorderSize = 0;
            this.btnall.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnall.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnall.Location = new System.Drawing.Point(688, 402);
            this.btnall.Margin = new System.Windows.Forms.Padding(4);
            this.btnall.Name = "btnall";
            this.btnall.Size = new System.Drawing.Size(100, 36);
            this.btnall.TabIndex = 19;
            this.btnall.Text = "All";
            this.btnall.UseVisualStyleBackColor = true;
            this.btnall.Click += new System.EventHandler(this.btnall_Click);
            // 
            // grp
            // 
            this.grp.BackColor = System.Drawing.Color.Indigo;
            this.grp.Controls.Add(this.lblNH);
            this.grp.Controls.Add(this.lblSal);
            this.grp.Controls.Add(this.lblSpe);
            this.grp.Controls.Add(this.label9);
            this.grp.Controls.Add(this.label8);
            this.grp.Controls.Add(this.label7);
            this.grp.Controls.Add(this.label6);
            this.grp.Controls.Add(this.label5);
            this.grp.Controls.Add(this.label4);
            this.grp.Controls.Add(this.label3);
            this.grp.Controls.Add(this.label2);
            this.grp.Controls.Add(this.label1);
            this.grp.Controls.Add(this.btnAdd);
            this.grp.Controls.Add(this.txtEmail);
            this.grp.Controls.Add(this.cboCounty);
            this.grp.Controls.Add(this.cboSpecialty);
            this.grp.Controls.Add(this.txtAddress);
            this.grp.Controls.Add(this.txtHours);
            this.grp.Controls.Add(this.rdoPT);
            this.grp.Controls.Add(this.rdoNurse);
            this.grp.Controls.Add(this.txtSalary);
            this.grp.Controls.Add(this.rdoDoc);
            this.grp.Controls.Add(this.txtAge);
            this.grp.Controls.Add(this.txtEmpNo);
            this.grp.Controls.Add(this.txtPhone);
            this.grp.Controls.Add(this.txtFirstName);
            this.grp.Controls.Add(this.txtSurn);
            this.grp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grp.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp.ForeColor = System.Drawing.Color.White;
            this.grp.Location = new System.Drawing.Point(15, 78);
            this.grp.Margin = new System.Windows.Forms.Padding(4);
            this.grp.Name = "grp";
            this.grp.Padding = new System.Windows.Forms.Padding(4);
            this.grp.Size = new System.Drawing.Size(783, 295);
            this.grp.TabIndex = 24;
            this.grp.TabStop = false;
            this.grp.Text = "Add a New Employee";
            this.grp.Enter += new System.EventHandler(this.grp_Enter);
            // 
            // lblNH
            // 
            this.lblNH.AutoSize = true;
            this.lblNH.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNH.ForeColor = System.Drawing.Color.White;
            this.lblNH.Location = new System.Drawing.Point(494, 215);
            this.lblNH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNH.Name = "lblNH";
            this.lblNH.Size = new System.Drawing.Size(132, 21);
            this.lblNH.TabIndex = 31;
            this.lblNH.Text = "Number of Hours";
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSal.ForeColor = System.Drawing.Color.White;
            this.lblSal.Location = new System.Drawing.Point(303, 214);
            this.lblSal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(52, 21);
            this.lblSal.TabIndex = 30;
            this.lblSal.Text = "Salary";
            // 
            // lblSpe
            // 
            this.lblSpe.AutoSize = true;
            this.lblSpe.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpe.ForeColor = System.Drawing.Color.White;
            this.lblSpe.Location = new System.Drawing.Point(29, 214);
            this.lblSpe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpe.Name = "lblSpe";
            this.lblSpe.Size = new System.Drawing.Size(73, 21);
            this.lblSpe.TabIndex = 29;
            this.lblSpe.Text = "Specialty";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(464, 174);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 21);
            this.label9.TabIndex = 28;
            this.label9.Text = "Phone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(55, 174);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 21);
            this.label8.TabIndex = 27;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(464, 137);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 21);
            this.label7.TabIndex = 26;
            this.label7.Text = "County";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(37, 137);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(631, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(323, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Employee Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Select the Position";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(656, 244);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 36);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpExp
            // 
            this.grpExp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.grpExp.Controls.Add(this.label14);
            this.grpExp.Controls.Add(this.rdoExPT);
            this.grpExp.Controls.Add(this.rdoExpNur);
            this.grpExp.Controls.Add(this.rdoExpDoc);
            this.grpExp.Controls.Add(this.btnExp);
            this.grpExp.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpExp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.grpExp.Location = new System.Drawing.Point(15, 633);
            this.grpExp.Margin = new System.Windows.Forms.Padding(4);
            this.grpExp.Name = "grpExp";
            this.grpExp.Padding = new System.Windows.Forms.Padding(4);
            this.grpExp.Size = new System.Drawing.Size(781, 92);
            this.grpExp.TabIndex = 25;
            this.grpExp.TabStop = false;
            this.grpExp.Text = "Export to CSV";
            this.grpExp.Enter += new System.EventHandler(this.grpExp_Enter);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(1)))), ((int)(((byte)(10)))));
            this.label14.Location = new System.Drawing.Point(75, 41);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(174, 21);
            this.label14.TabIndex = 32;
            this.label14.Text = "Select the List to Export";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // rdoExPT
            // 
            this.rdoExPT.AutoSize = true;
            this.rdoExPT.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoExPT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(1)))), ((int)(((byte)(10)))));
            this.rdoExPT.Location = new System.Drawing.Point(461, 38);
            this.rdoExPT.Margin = new System.Windows.Forms.Padding(4);
            this.rdoExPT.Name = "rdoExPT";
            this.rdoExPT.Size = new System.Drawing.Size(98, 25);
            this.rdoExPT.TabIndex = 23;
            this.rdoExPT.Text = "Part Time";
            this.rdoExPT.UseVisualStyleBackColor = true;
            // 
            // rdoExpNur
            // 
            this.rdoExpNur.AutoSize = true;
            this.rdoExpNur.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoExpNur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(1)))), ((int)(((byte)(10)))));
            this.rdoExpNur.Location = new System.Drawing.Point(376, 38);
            this.rdoExpNur.Margin = new System.Windows.Forms.Padding(4);
            this.rdoExpNur.Name = "rdoExpNur";
            this.rdoExpNur.Size = new System.Drawing.Size(82, 25);
            this.rdoExpNur.TabIndex = 22;
            this.rdoExpNur.Text = "Lecture";
            this.rdoExpNur.UseVisualStyleBackColor = true;
            // 
            // rdoExpDoc
            // 
            this.rdoExpDoc.AutoSize = true;
            this.rdoExpDoc.Checked = true;
            this.rdoExpDoc.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoExpDoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(1)))), ((int)(((byte)(10)))));
            this.rdoExpDoc.Location = new System.Drawing.Point(284, 38);
            this.rdoExpDoc.Margin = new System.Windows.Forms.Padding(4);
            this.rdoExpDoc.Name = "rdoExpDoc";
            this.rdoExpDoc.Size = new System.Drawing.Size(83, 25);
            this.rdoExpDoc.TabIndex = 21;
            this.rdoExpDoc.TabStop = true;
            this.rdoExpDoc.Text = "Teacher";
            this.rdoExpDoc.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(656, 9);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 36);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.Indigo;
            this.pnltop.Controls.Add(this.lblTitle);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Margin = new System.Windows.Forms.Padding(4);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(813, 73);
            this.pnltop.TabIndex = 28;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(273, 21);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(292, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Employee Management";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(25, 409);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 23);
            this.label13.TabIndex = 32;
            this.label13.Text = "View Employees";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Location = new System.Drawing.Point(15, 574);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 52);
            this.panel1.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(1)))), ((int)(((byte)(10)))));
            this.label10.Location = new System.Drawing.Point(448, 19);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 21);
            this.label10.TabIndex = 33;
            this.label10.Text = "Select a row to delete";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // epEmpNo
            // 
            this.epEmpNo.ContainerControl = this;
            // 
            // epAge
            // 
            this.epAge.ContainerControl = this;
            // 
            // epSalary
            // 
            this.epSalary.ContainerControl = this;
            // 
            // epHours
            // 
            this.epHours.ContainerControl = this;
            // 
            // epFn
            // 
            this.epFn.ContainerControl = this;
            // 
            // epSn
            // 
            this.epSn.ContainerControl = this;
            // 
            // epAddress
            // 
            this.epAddress.ContainerControl = this;
            // 
            // epPhone
            // 
            this.epPhone.ContainerControl = this;
            // 
            // epEmail
            // 
            this.epEmail.ContainerControl = this;
            // 
            // UCEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvEmp);
            this.Controls.Add(this.pnltop);
            this.Controls.Add(this.grpExp);
            this.Controls.Add(this.grp);
            this.Controls.Add(this.btnall);
            this.Controls.Add(this.btnShowPT);
            this.Controls.Add(this.btnShowNur);
            this.Controls.Add(this.btnShowDoc);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCEmployees";
            this.Size = new System.Drawing.Size(813, 746);
            this.Load += new System.EventHandler(this.UCEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).EndInit();
            this.grp.ResumeLayout(false);
            this.grp.PerformLayout();
            this.grpExp.ResumeLayout(false);
            this.grpExp.PerformLayout();
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epEmpNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmp;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSurn;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ComboBox cboCounty;
        private System.Windows.Forms.RadioButton rdoDoc;
        private System.Windows.Forms.RadioButton rdoNurse;
        private System.Windows.Forms.RadioButton rdoPT;
        private System.Windows.Forms.TextBox txtEmpNo;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.ComboBox cboSpecialty;
        private System.Windows.Forms.Button btnShowDoc;
        private System.Windows.Forms.Button btnShowNur;
        private System.Windows.Forms.Button btnShowPT;
        private System.Windows.Forms.Button btnall;
        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpExp;
        private System.Windows.Forms.RadioButton rdoExPT;
        private System.Windows.Forms.RadioButton rdoExpNur;
        private System.Windows.Forms.RadioButton rdoExpDoc;
        private System.Windows.Forms.SaveFileDialog sfdExpCSV;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNH;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.Label lblSpe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ErrorProvider epEmpNo;
        private System.Windows.Forms.ErrorProvider epAge;
        private System.Windows.Forms.ErrorProvider epSalary;
        private System.Windows.Forms.ErrorProvider epHours;
        private System.Windows.Forms.ErrorProvider epFn;
        private System.Windows.Forms.ErrorProvider epSn;
        private System.Windows.Forms.ErrorProvider epAddress;
        private System.Windows.Forms.ErrorProvider epPhone;
        private System.Windows.Forms.ErrorProvider epEmail;
        private System.Windows.Forms.Label label10;
    }
}
