namespace InfoKioskProject
{
    partial class AdminForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.adminTabControl = new System.Windows.Forms.TabControl();
            this.newUser = new System.Windows.Forms.TabPage();
            this.passwordWarningLabel = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.addUserButton = new System.Windows.Forms.Button();
            this.registrationLabel = new System.Windows.Forms.Label();
            this.repeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.repeatPasswordLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.newStudent = new System.Windows.Forms.TabPage();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.paymentComboBox = new System.Windows.Forms.ComboBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.numberOfAdmitionsTextBox = new System.Windows.Forms.TextBox();
            this.noteLabel = new System.Windows.Forms.Label();
            this.yearOfStudyComboBox = new System.Windows.Forms.ComboBox();
            this.indexTextBox = new System.Windows.Forms.TextBox();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.numberOfAdmitionsLabel = new System.Windows.Forms.Label();
            this.yearOfStudyLabel = new System.Windows.Forms.Label();
            this.indexLabel = new System.Windows.Forms.Label();
            this.studyProgramComboBox = new System.Windows.Forms.ComboBox();
            this.studyProgramLabel = new System.Windows.Forms.Label();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.citizenshipTextBox = new System.Windows.Forms.TextBox();
            this.placeOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.telephoneLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.citizenshipLabel = new System.Windows.Forms.Label();
            this.placeOfBirthLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.femaleCheckBox = new System.Windows.Forms.CheckBox();
            this.maleCheckBox = new System.Windows.Forms.CheckBox();
            this.idNumberTextBox = new System.Windows.Forms.TextBox();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.yearOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.idNumberLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.addDataLabel = new System.Windows.Forms.Label();
            this.addGrades = new System.Windows.Forms.TabPage();
            this.exams = new System.Windows.Forms.TabPage();
            this.warningPeriodLabel = new System.Windows.Forms.Label();
            this.endPeriodButton = new System.Windows.Forms.Button();
            this.startPeriodButton = new System.Windows.Forms.Button();
            this.termComboBox = new System.Windows.Forms.ComboBox();
            this.termLabel = new System.Windows.Forms.Label();
            this.periodComboBox = new System.Windows.Forms.ComboBox();
            this.periodLabel = new System.Windows.Forms.Label();
            this.setPeriodLabel = new System.Windows.Forms.Label();
            this.activePeriodLabel = new System.Windows.Forms.Label();
            this.database = new System.Windows.Forms.TabPage();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTermsComboBox = new System.Windows.Forms.ComboBox();
            this.searchDatabaseLabel = new System.Windows.Forms.Label();
            this.databaseDataGridView = new System.Windows.Forms.DataGridView();
            this.hideSearchButton = new System.Windows.Forms.Button();
            this.secondSearchTermComboBox = new System.Windows.Forms.ComboBox();
            this.adminTabControl.SuspendLayout();
            this.newUser.SuspendLayout();
            this.newStudent.SuspendLayout();
            this.exams.SuspendLayout();
            this.database.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // adminTabControl
            // 
            this.adminTabControl.Controls.Add(this.newUser);
            this.adminTabControl.Controls.Add(this.newStudent);
            this.adminTabControl.Controls.Add(this.addGrades);
            this.adminTabControl.Controls.Add(this.exams);
            this.adminTabControl.Controls.Add(this.database);
            this.adminTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminTabControl.Location = new System.Drawing.Point(0, 0);
            this.adminTabControl.Name = "adminTabControl";
            this.adminTabControl.SelectedIndex = 0;
            this.adminTabControl.Size = new System.Drawing.Size(569, 391);
            this.adminTabControl.TabIndex = 0;
            // 
            // newUser
            // 
            this.newUser.Controls.Add(this.passwordWarningLabel);
            this.newUser.Controls.Add(this.warningLabel);
            this.newUser.Controls.Add(this.addUserButton);
            this.newUser.Controls.Add(this.registrationLabel);
            this.newUser.Controls.Add(this.repeatPasswordTextBox);
            this.newUser.Controls.Add(this.passwordTextBox);
            this.newUser.Controls.Add(this.usernameTextBox);
            this.newUser.Controls.Add(this.repeatPasswordLabel);
            this.newUser.Controls.Add(this.passwordLabel);
            this.newUser.Controls.Add(this.usernameLabel);
            this.newUser.Location = new System.Drawing.Point(4, 22);
            this.newUser.Name = "newUser";
            this.newUser.Size = new System.Drawing.Size(561, 365);
            this.newUser.TabIndex = 5;
            this.newUser.Text = "Регистрација корисника";
            this.newUser.UseVisualStyleBackColor = true;
            // 
            // passwordWarningLabel
            // 
            this.passwordWarningLabel.AutoSize = true;
            this.passwordWarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordWarningLabel.ForeColor = System.Drawing.Color.Red;
            this.passwordWarningLabel.Location = new System.Drawing.Point(8, 205);
            this.passwordWarningLabel.Name = "passwordWarningLabel";
            this.passwordWarningLabel.Size = new System.Drawing.Size(156, 15);
            this.passwordWarningLabel.TabIndex = 87;
            this.passwordWarningLabel.Text = "Лозинке се не подударају!";
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Location = new System.Drawing.Point(5, 235);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(239, 26);
            this.warningLabel.TabIndex = 86;
            this.warningLabel.Text = "НАПОМЕНА: Поље \"Број индекса\" мора бити\r\nпопуњено ћирилицом.";
            // 
            // addUserButton
            // 
            this.addUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserButton.Location = new System.Drawing.Point(8, 316);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(250, 30);
            this.addUserButton.TabIndex = 84;
            this.addUserButton.Text = "РЕГИСТРУЈ КОРИСНИКА";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // registrationLabel
            // 
            this.registrationLabel.AutoSize = true;
            this.registrationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationLabel.Location = new System.Drawing.Point(8, 14);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(209, 16);
            this.registrationLabel.TabIndex = 74;
            this.registrationLabel.Text = "Регистрација новог корисника";
            // 
            // repeatPasswordTextBox
            // 
            this.repeatPasswordTextBox.Location = new System.Drawing.Point(8, 172);
            this.repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            this.repeatPasswordTextBox.PasswordChar = '*';
            this.repeatPasswordTextBox.Size = new System.Drawing.Size(250, 20);
            this.repeatPasswordTextBox.TabIndex = 73;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(8, 132);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(250, 20);
            this.passwordTextBox.TabIndex = 71;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(8, 92);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(250, 20);
            this.usernameTextBox.TabIndex = 69;
            // 
            // repeatPasswordLabel
            // 
            this.repeatPasswordLabel.AutoSize = true;
            this.repeatPasswordLabel.Location = new System.Drawing.Point(8, 157);
            this.repeatPasswordLabel.Name = "repeatPasswordLabel";
            this.repeatPasswordLabel.Size = new System.Drawing.Size(100, 13);
            this.repeatPasswordLabel.TabIndex = 72;
            this.repeatPasswordLabel.Text = "Поновити лозинку";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(8, 117);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(51, 13);
            this.passwordLabel.TabIndex = 70;
            this.passwordLabel.Text = "Лозинка";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(8, 77);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(73, 13);
            this.usernameLabel.TabIndex = 68;
            this.usernameLabel.Text = "Број индекса";
            // 
            // newStudent
            // 
            this.newStudent.Controls.Add(this.addStudentButton);
            this.newStudent.Controls.Add(this.paymentComboBox);
            this.newStudent.Controls.Add(this.statusComboBox);
            this.newStudent.Controls.Add(this.numberOfAdmitionsTextBox);
            this.newStudent.Controls.Add(this.noteLabel);
            this.newStudent.Controls.Add(this.yearOfStudyComboBox);
            this.newStudent.Controls.Add(this.indexTextBox);
            this.newStudent.Controls.Add(this.paymentLabel);
            this.newStudent.Controls.Add(this.statusLabel);
            this.newStudent.Controls.Add(this.numberOfAdmitionsLabel);
            this.newStudent.Controls.Add(this.yearOfStudyLabel);
            this.newStudent.Controls.Add(this.indexLabel);
            this.newStudent.Controls.Add(this.studyProgramComboBox);
            this.newStudent.Controls.Add(this.studyProgramLabel);
            this.newStudent.Controls.Add(this.telephoneTextBox);
            this.newStudent.Controls.Add(this.addressTextBox);
            this.newStudent.Controls.Add(this.citizenshipTextBox);
            this.newStudent.Controls.Add(this.placeOfBirthTextBox);
            this.newStudent.Controls.Add(this.telephoneLabel);
            this.newStudent.Controls.Add(this.addressLabel);
            this.newStudent.Controls.Add(this.citizenshipLabel);
            this.newStudent.Controls.Add(this.placeOfBirthLabel);
            this.newStudent.Controls.Add(this.genderLabel);
            this.newStudent.Controls.Add(this.femaleCheckBox);
            this.newStudent.Controls.Add(this.maleCheckBox);
            this.newStudent.Controls.Add(this.idNumberTextBox);
            this.newStudent.Controls.Add(this.monthComboBox);
            this.newStudent.Controls.Add(this.yearOfBirthTextBox);
            this.newStudent.Controls.Add(this.dayTextBox);
            this.newStudent.Controls.Add(this.lastNameTextBox);
            this.newStudent.Controls.Add(this.firstNameTextBox);
            this.newStudent.Controls.Add(this.idNumberLabel);
            this.newStudent.Controls.Add(this.dateOfBirthLabel);
            this.newStudent.Controls.Add(this.lastNameLabel);
            this.newStudent.Controls.Add(this.firstNameLabel);
            this.newStudent.Controls.Add(this.addDataLabel);
            this.newStudent.Location = new System.Drawing.Point(4, 22);
            this.newStudent.Name = "newStudent";
            this.newStudent.Padding = new System.Windows.Forms.Padding(3);
            this.newStudent.Size = new System.Drawing.Size(561, 365);
            this.newStudent.TabIndex = 1;
            this.newStudent.Text = "Регистрација студената";
            this.newStudent.UseVisualStyleBackColor = true;
            // 
            // addStudentButton
            // 
            this.addStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentButton.Location = new System.Drawing.Point(290, 315);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(250, 30);
            this.addStudentButton.TabIndex = 83;
            this.addStudentButton.Text = "РЕГИСТРУЈ СТУДЕНТА";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // paymentComboBox
            // 
            this.paymentComboBox.FormattingEnabled = true;
            this.paymentComboBox.Items.AddRange(new object[] {
            "буџет",
            "самофинансирање",
            "суфинансирање"});
            this.paymentComboBox.Location = new System.Drawing.Point(290, 245);
            this.paymentComboBox.Name = "paymentComboBox";
            this.paymentComboBox.Size = new System.Drawing.Size(250, 21);
            this.paymentComboBox.TabIndex = 80;
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "редован",
            "ванредан"});
            this.statusComboBox.Location = new System.Drawing.Point(290, 205);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(250, 21);
            this.statusComboBox.TabIndex = 78;
            // 
            // numberOfAdmitionsTextBox
            // 
            this.numberOfAdmitionsTextBox.Location = new System.Drawing.Point(290, 165);
            this.numberOfAdmitionsTextBox.Name = "numberOfAdmitionsTextBox";
            this.numberOfAdmitionsTextBox.Size = new System.Drawing.Size(250, 20);
            this.numberOfAdmitionsTextBox.TabIndex = 76;
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Location = new System.Drawing.Point(290, 280);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(241, 26);
            this.noteLabel.TabIndex = 82;
            this.noteLabel.Text = "НАПОМЕНА: Сва поља морају бити попуњена\r\nћирилицом!";
            // 
            // yearOfStudyComboBox
            // 
            this.yearOfStudyComboBox.FormattingEnabled = true;
            this.yearOfStudyComboBox.Items.AddRange(new object[] {
            "прва",
            "друга",
            "трећа",
            "четврта"});
            this.yearOfStudyComboBox.Location = new System.Drawing.Point(290, 125);
            this.yearOfStudyComboBox.Name = "yearOfStudyComboBox";
            this.yearOfStudyComboBox.Size = new System.Drawing.Size(250, 21);
            this.yearOfStudyComboBox.TabIndex = 74;
            // 
            // indexTextBox
            // 
            this.indexTextBox.Location = new System.Drawing.Point(290, 85);
            this.indexTextBox.Name = "indexTextBox";
            this.indexTextBox.Size = new System.Drawing.Size(250, 20);
            this.indexTextBox.TabIndex = 72;
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.Location = new System.Drawing.Point(290, 230);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(113, 13);
            this.paymentLabel.TabIndex = 81;
            this.paymentLabel.Text = "Начин финансирања";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(290, 190);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(89, 13);
            this.statusLabel.TabIndex = 79;
            this.statusLabel.Text = "Статус студента";
            // 
            // numberOfAdmitionsLabel
            // 
            this.numberOfAdmitionsLabel.AutoSize = true;
            this.numberOfAdmitionsLabel.Location = new System.Drawing.Point(290, 150);
            this.numberOfAdmitionsLabel.Name = "numberOfAdmitionsLabel";
            this.numberOfAdmitionsLabel.Size = new System.Drawing.Size(98, 13);
            this.numberOfAdmitionsLabel.TabIndex = 77;
            this.numberOfAdmitionsLabel.Text = "Број уписа године";
            // 
            // yearOfStudyLabel
            // 
            this.yearOfStudyLabel.AutoSize = true;
            this.yearOfStudyLabel.Location = new System.Drawing.Point(290, 110);
            this.yearOfStudyLabel.Name = "yearOfStudyLabel";
            this.yearOfStudyLabel.Size = new System.Drawing.Size(82, 13);
            this.yearOfStudyLabel.TabIndex = 75;
            this.yearOfStudyLabel.Text = "Година студија";
            // 
            // indexLabel
            // 
            this.indexLabel.AutoSize = true;
            this.indexLabel.Location = new System.Drawing.Point(290, 70);
            this.indexLabel.Name = "indexLabel";
            this.indexLabel.Size = new System.Drawing.Size(73, 13);
            this.indexLabel.TabIndex = 73;
            this.indexLabel.Text = "Број индекса";
            // 
            // studyProgramComboBox
            // 
            this.studyProgramComboBox.FormattingEnabled = true;
            this.studyProgramComboBox.Items.AddRange(new object[] {
            "Математика и рачунарство",
            "Српски језик и књижевност",
            "Кинески и енглески језик и књижевност",
            "Историја"});
            this.studyProgramComboBox.Location = new System.Drawing.Point(290, 45);
            this.studyProgramComboBox.Name = "studyProgramComboBox";
            this.studyProgramComboBox.Size = new System.Drawing.Size(250, 21);
            this.studyProgramComboBox.TabIndex = 70;
            // 
            // studyProgramLabel
            // 
            this.studyProgramLabel.AutoSize = true;
            this.studyProgramLabel.Location = new System.Drawing.Point(290, 30);
            this.studyProgramLabel.Name = "studyProgramLabel";
            this.studyProgramLabel.Size = new System.Drawing.Size(102, 13);
            this.studyProgramLabel.TabIndex = 71;
            this.studyProgramLabel.Text = "Студијски програм";
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.Location = new System.Drawing.Point(10, 325);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(250, 20);
            this.telephoneTextBox.TabIndex = 69;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(10, 285);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(250, 20);
            this.addressTextBox.TabIndex = 67;
            // 
            // citizenshipTextBox
            // 
            this.citizenshipTextBox.Location = new System.Drawing.Point(10, 245);
            this.citizenshipTextBox.Name = "citizenshipTextBox";
            this.citizenshipTextBox.Size = new System.Drawing.Size(250, 20);
            this.citizenshipTextBox.TabIndex = 65;
            // 
            // placeOfBirthTextBox
            // 
            this.placeOfBirthTextBox.Location = new System.Drawing.Point(10, 205);
            this.placeOfBirthTextBox.Name = "placeOfBirthTextBox";
            this.placeOfBirthTextBox.Size = new System.Drawing.Size(250, 20);
            this.placeOfBirthTextBox.TabIndex = 63;
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.AutoSize = true;
            this.telephoneLabel.Location = new System.Drawing.Point(10, 310);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(52, 13);
            this.telephoneLabel.TabIndex = 68;
            this.telephoneLabel.Text = "Телефон";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(10, 270);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(104, 13);
            this.addressLabel.TabIndex = 66;
            this.addressLabel.Text = "Адреса становања";
            // 
            // citizenshipLabel
            // 
            this.citizenshipLabel.AutoSize = true;
            this.citizenshipLabel.Location = new System.Drawing.Point(10, 230);
            this.citizenshipLabel.Name = "citizenshipLabel";
            this.citizenshipLabel.Size = new System.Drawing.Size(87, 13);
            this.citizenshipLabel.TabIndex = 64;
            this.citizenshipLabel.Text = "Држављанство";
            // 
            // placeOfBirthLabel
            // 
            this.placeOfBirthLabel.AutoSize = true;
            this.placeOfBirthLabel.Location = new System.Drawing.Point(10, 190);
            this.placeOfBirthLabel.Name = "placeOfBirthLabel";
            this.placeOfBirthLabel.Size = new System.Drawing.Size(84, 13);
            this.placeOfBirthLabel.TabIndex = 62;
            this.placeOfBirthLabel.Text = "Мјесто рођења";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(180, 150);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(27, 13);
            this.genderLabel.TabIndex = 60;
            this.genderLabel.Text = "Пол";
            // 
            // femaleCheckBox
            // 
            this.femaleCheckBox.AutoSize = true;
            this.femaleCheckBox.Location = new System.Drawing.Point(223, 167);
            this.femaleCheckBox.Name = "femaleCheckBox";
            this.femaleCheckBox.Size = new System.Drawing.Size(37, 17);
            this.femaleCheckBox.TabIndex = 61;
            this.femaleCheckBox.Text = "Ж";
            this.femaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // maleCheckBox
            // 
            this.maleCheckBox.AutoSize = true;
            this.maleCheckBox.Location = new System.Drawing.Point(182, 167);
            this.maleCheckBox.Name = "maleCheckBox";
            this.maleCheckBox.Size = new System.Drawing.Size(35, 17);
            this.maleCheckBox.TabIndex = 59;
            this.maleCheckBox.Text = "М";
            this.maleCheckBox.UseVisualStyleBackColor = true;
            // 
            // idNumberTextBox
            // 
            this.idNumberTextBox.Location = new System.Drawing.Point(10, 165);
            this.idNumberTextBox.Name = "idNumberTextBox";
            this.idNumberTextBox.Size = new System.Drawing.Size(160, 20);
            this.idNumberTextBox.TabIndex = 58;
            // 
            // monthComboBox
            // 
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Items.AddRange(new object[] {
            "јануар",
            "фебруар",
            "март",
            "април",
            "мај",
            "јун",
            "јул",
            "август",
            "септембар",
            "октобар",
            "новембар",
            "децембар"});
            this.monthComboBox.Location = new System.Drawing.Point(41, 125);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(160, 21);
            this.monthComboBox.TabIndex = 55;
            // 
            // yearOfBirthTextBox
            // 
            this.yearOfBirthTextBox.Location = new System.Drawing.Point(210, 125);
            this.yearOfBirthTextBox.Name = "yearOfBirthTextBox";
            this.yearOfBirthTextBox.Size = new System.Drawing.Size(50, 20);
            this.yearOfBirthTextBox.TabIndex = 56;
            // 
            // dayTextBox
            // 
            this.dayTextBox.Location = new System.Drawing.Point(10, 125);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(25, 20);
            this.dayTextBox.TabIndex = 54;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(10, 85);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(250, 20);
            this.lastNameTextBox.TabIndex = 51;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(10, 45);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(250, 20);
            this.firstNameTextBox.TabIndex = 50;
            // 
            // idNumberLabel
            // 
            this.idNumberLabel.AutoSize = true;
            this.idNumberLabel.Location = new System.Drawing.Point(10, 150);
            this.idNumberLabel.Name = "idNumberLabel";
            this.idNumberLabel.Size = new System.Drawing.Size(34, 13);
            this.idNumberLabel.TabIndex = 57;
            this.idNumberLabel.Text = "ЈМБГ";
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(10, 110);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(83, 13);
            this.dateOfBirthLabel.TabIndex = 53;
            this.dateOfBirthLabel.Text = "Датум рођења";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(10, 70);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(53, 13);
            this.lastNameLabel.TabIndex = 52;
            this.lastNameLabel.Text = "Презиме";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(10, 30);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(29, 13);
            this.firstNameLabel.TabIndex = 49;
            this.firstNameLabel.Text = "Име";
            // 
            // addDataLabel
            // 
            this.addDataLabel.AutoSize = true;
            this.addDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDataLabel.Location = new System.Drawing.Point(8, 3);
            this.addDataLabel.Name = "addDataLabel";
            this.addDataLabel.Size = new System.Drawing.Size(215, 16);
            this.addDataLabel.TabIndex = 48;
            this.addDataLabel.Text = "Унесите податке о студентима:";
            // 
            // addGrades
            // 
            this.addGrades.Location = new System.Drawing.Point(4, 22);
            this.addGrades.Name = "addGrades";
            this.addGrades.Size = new System.Drawing.Size(561, 365);
            this.addGrades.TabIndex = 2;
            this.addGrades.Text = "Додавање оцјена";
            this.addGrades.UseVisualStyleBackColor = true;
            // 
            // exams
            // 
            this.exams.Controls.Add(this.warningPeriodLabel);
            this.exams.Controls.Add(this.endPeriodButton);
            this.exams.Controls.Add(this.startPeriodButton);
            this.exams.Controls.Add(this.termComboBox);
            this.exams.Controls.Add(this.termLabel);
            this.exams.Controls.Add(this.periodComboBox);
            this.exams.Controls.Add(this.periodLabel);
            this.exams.Controls.Add(this.setPeriodLabel);
            this.exams.Controls.Add(this.activePeriodLabel);
            this.exams.Location = new System.Drawing.Point(4, 22);
            this.exams.Name = "exams";
            this.exams.Size = new System.Drawing.Size(561, 365);
            this.exams.TabIndex = 6;
            this.exams.Text = "Испитни рокови";
            this.exams.UseVisualStyleBackColor = true;
            // 
            // warningPeriodLabel
            // 
            this.warningPeriodLabel.AutoSize = true;
            this.warningPeriodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningPeriodLabel.ForeColor = System.Drawing.Color.Red;
            this.warningPeriodLabel.Location = new System.Drawing.Point(12, 257);
            this.warningPeriodLabel.Name = "warningPeriodLabel";
            this.warningPeriodLabel.Size = new System.Drawing.Size(282, 15);
            this.warningPeriodLabel.TabIndex = 87;
            this.warningPeriodLabel.Text = "Морате изабрати испитни рок и термин!";
            // 
            // endPeriodButton
            // 
            this.endPeriodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endPeriodButton.Location = new System.Drawing.Point(303, 327);
            this.endPeriodButton.Name = "endPeriodButton";
            this.endPeriodButton.Size = new System.Drawing.Size(250, 30);
            this.endPeriodButton.TabIndex = 86;
            this.endPeriodButton.Text = "ЗАВРШИ ПРИЈАВУ";
            this.endPeriodButton.UseVisualStyleBackColor = true;
            // 
            // startPeriodButton
            // 
            this.startPeriodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startPeriodButton.Location = new System.Drawing.Point(12, 327);
            this.startPeriodButton.Name = "startPeriodButton";
            this.startPeriodButton.Size = new System.Drawing.Size(250, 30);
            this.startPeriodButton.TabIndex = 85;
            this.startPeriodButton.Text = "ПОЧНИ ПРИЈАВУ";
            this.startPeriodButton.UseVisualStyleBackColor = true;
            // 
            // termComboBox
            // 
            this.termComboBox.FormattingEnabled = true;
            this.termComboBox.Items.AddRange(new object[] {
            "први",
            "други"});
            this.termComboBox.Location = new System.Drawing.Point(12, 213);
            this.termComboBox.Name = "termComboBox";
            this.termComboBox.Size = new System.Drawing.Size(250, 21);
            this.termComboBox.TabIndex = 8;
            // 
            // termLabel
            // 
            this.termLabel.AutoSize = true;
            this.termLabel.Location = new System.Drawing.Point(12, 183);
            this.termLabel.Name = "termLabel";
            this.termLabel.Size = new System.Drawing.Size(46, 13);
            this.termLabel.TabIndex = 7;
            this.termLabel.Text = "Термин";
            // 
            // periodComboBox
            // 
            this.periodComboBox.FormattingEnabled = true;
            this.periodComboBox.Items.AddRange(new object[] {
            "јануарско-фебруарски",
            "априлски",
            "јунско-јулски",
            "септембарски",
            "октобарски"});
            this.periodComboBox.Location = new System.Drawing.Point(12, 143);
            this.periodComboBox.Name = "periodComboBox";
            this.periodComboBox.Size = new System.Drawing.Size(250, 21);
            this.periodComboBox.TabIndex = 6;
            // 
            // periodLabel
            // 
            this.periodLabel.AutoSize = true;
            this.periodLabel.Location = new System.Drawing.Point(12, 113);
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(71, 13);
            this.periodLabel.TabIndex = 5;
            this.periodLabel.Text = "Испитни рок";
            // 
            // setPeriodLabel
            // 
            this.setPeriodLabel.AutoSize = true;
            this.setPeriodLabel.Location = new System.Drawing.Point(12, 64);
            this.setPeriodLabel.Name = "setPeriodLabel";
            this.setPeriodLabel.Size = new System.Drawing.Size(494, 13);
            this.setPeriodLabel.TabIndex = 1;
            this.setPeriodLabel.Text = "Да бисте омогућили пријаву испита, одаберите испитни рок и термин, а затим почнит" +
    "е пријаву.";
            // 
            // activePeriodLabel
            // 
            this.activePeriodLabel.AutoSize = true;
            this.activePeriodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activePeriodLabel.Location = new System.Drawing.Point(9, 16);
            this.activePeriodLabel.Name = "activePeriodLabel";
            this.activePeriodLabel.Size = new System.Drawing.Size(205, 15);
            this.activePeriodLabel.TabIndex = 0;
            this.activePeriodLabel.Text = "note about exams period, to be filled";
            // 
            // database
            // 
            this.database.Controls.Add(this.hideSearchButton);
            this.database.Controls.Add(this.secondSearchTermComboBox);
            this.database.Controls.Add(this.searchButton);
            this.database.Controls.Add(this.searchTermsComboBox);
            this.database.Controls.Add(this.searchDatabaseLabel);
            this.database.Controls.Add(this.databaseDataGridView);
            this.database.Location = new System.Drawing.Point(4, 22);
            this.database.Name = "database";
            this.database.Size = new System.Drawing.Size(561, 365);
            this.database.TabIndex = 7;
            this.database.Text = "База података";
            this.database.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(404, 11);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(149, 23);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "Претрага";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTermsComboBox
            // 
            this.searchTermsComboBox.FormattingEnabled = true;
            this.searchTermsComboBox.Items.AddRange(new object[] {
            "студенти (корисници)",
            "студенти (подаци)",
            "професори",
            "студијски програми",
            "предмети"});
            this.searchTermsComboBox.Location = new System.Drawing.Point(176, 13);
            this.searchTermsComboBox.Name = "searchTermsComboBox";
            this.searchTermsComboBox.Size = new System.Drawing.Size(184, 21);
            this.searchTermsComboBox.TabIndex = 8;
            // 
            // searchDatabaseLabel
            // 
            this.searchDatabaseLabel.AutoSize = true;
            this.searchDatabaseLabel.Location = new System.Drawing.Point(8, 16);
            this.searchDatabaseLabel.Name = "searchDatabaseLabel";
            this.searchDatabaseLabel.Size = new System.Drawing.Size(152, 13);
            this.searchDatabaseLabel.TabIndex = 7;
            this.searchDatabaseLabel.Text = "Претражи базу података за:";
            // 
            // databaseDataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.databaseDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.databaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.databaseDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.databaseDataGridView.Location = new System.Drawing.Point(0, 89);
            this.databaseDataGridView.Name = "databaseDataGridView";
            this.databaseDataGridView.RowHeadersVisible = false;
            this.databaseDataGridView.Size = new System.Drawing.Size(561, 276);
            this.databaseDataGridView.TabIndex = 6;
            // 
            // hideSearchButton
            // 
            this.hideSearchButton.Location = new System.Drawing.Point(366, 49);
            this.hideSearchButton.Name = "hideSearchButton";
            this.hideSearchButton.Size = new System.Drawing.Size(21, 21);
            this.hideSearchButton.TabIndex = 12;
            this.hideSearchButton.Text = "X";
            this.hideSearchButton.UseVisualStyleBackColor = true;
            this.hideSearchButton.Click += new System.EventHandler(this.hideSearchButton_Click);
            // 
            // secondSearchTermComboBox
            // 
            this.secondSearchTermComboBox.FormattingEnabled = true;
            this.secondSearchTermComboBox.Items.AddRange(new object[] {
            "Математика и рачунарство",
            "Српски језик и књижевност",
            "Кинески и енглески језик и књижевност",
            "Историја"});
            this.secondSearchTermComboBox.Location = new System.Drawing.Point(176, 49);
            this.secondSearchTermComboBox.Name = "secondSearchTermComboBox";
            this.secondSearchTermComboBox.Size = new System.Drawing.Size(184, 21);
            this.secondSearchTermComboBox.TabIndex = 11;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 391);
            this.Controls.Add(this.adminTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ИНФО КИОСК - АДМИНИСТРАТОР";
            this.adminTabControl.ResumeLayout(false);
            this.newUser.ResumeLayout(false);
            this.newUser.PerformLayout();
            this.newStudent.ResumeLayout(false);
            this.newStudent.PerformLayout();
            this.exams.ResumeLayout(false);
            this.exams.PerformLayout();
            this.database.ResumeLayout(false);
            this.database.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl adminTabControl;
        private System.Windows.Forms.TabPage newStudent;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.ComboBox paymentComboBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.TextBox numberOfAdmitionsTextBox;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.ComboBox yearOfStudyComboBox;
        private System.Windows.Forms.TextBox indexTextBox;
        private System.Windows.Forms.Label paymentLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label numberOfAdmitionsLabel;
        private System.Windows.Forms.Label yearOfStudyLabel;
        private System.Windows.Forms.Label indexLabel;
        private System.Windows.Forms.ComboBox studyProgramComboBox;
        private System.Windows.Forms.Label studyProgramLabel;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox citizenshipTextBox;
        private System.Windows.Forms.TextBox placeOfBirthTextBox;
        private System.Windows.Forms.Label telephoneLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label citizenshipLabel;
        private System.Windows.Forms.Label placeOfBirthLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.CheckBox femaleCheckBox;
        private System.Windows.Forms.CheckBox maleCheckBox;
        private System.Windows.Forms.TextBox idNumberTextBox;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.TextBox yearOfBirthTextBox;
        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label idNumberLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label addDataLabel;
        private System.Windows.Forms.TabPage addGrades;
        private System.Windows.Forms.TabPage newUser;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.TextBox repeatPasswordTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label repeatPasswordLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordWarningLabel;
        private System.Windows.Forms.TabPage exams;
        private System.Windows.Forms.TabPage database;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox searchTermsComboBox;
        private System.Windows.Forms.Label searchDatabaseLabel;
        private System.Windows.Forms.DataGridView databaseDataGridView;
        private System.Windows.Forms.Label warningPeriodLabel;
        private System.Windows.Forms.Button endPeriodButton;
        private System.Windows.Forms.Button startPeriodButton;
        private System.Windows.Forms.ComboBox termComboBox;
        private System.Windows.Forms.Label termLabel;
        private System.Windows.Forms.ComboBox periodComboBox;
        private System.Windows.Forms.Label periodLabel;
        private System.Windows.Forms.Label setPeriodLabel;
        private System.Windows.Forms.Label activePeriodLabel;
        private System.Windows.Forms.Button hideSearchButton;
        private System.Windows.Forms.ComboBox secondSearchTermComboBox;
    }
}