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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.adminTabControl = new System.Windows.Forms.TabControl();
            this.newUser = new System.Windows.Forms.TabPage();
            this.registration = new System.Windows.Forms.TabPage();
            this.registrationButton = new System.Windows.Forms.Button();
            this.paymentComboBox = new System.Windows.Forms.ComboBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.yearOrderNumberTextBox = new System.Windows.Forms.TextBox();
            this.noteLabel = new System.Windows.Forms.Label();
            this.studyYearComboBox = new System.Windows.Forms.ComboBox();
            this.indexTextBox = new System.Windows.Forms.TextBox();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.yearOrderNumberLabel = new System.Windows.Forms.Label();
            this.studyYearLabel = new System.Windows.Forms.Label();
            this.indexLabel = new System.Windows.Forms.Label();
            this.studyProgramComboBox = new System.Windows.Forms.ComboBox();
            this.studyProgramLabel = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.citizenshipTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.citizenshipLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.femaleCheckBox = new System.Windows.Forms.CheckBox();
            this.maleCheckBox = new System.Windows.Forms.CheckBox();
            this.jmbgTextBox = new System.Windows.Forms.TextBox();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.yearOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.jmbgLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.addDataLabel = new System.Windows.Forms.Label();
            this.addGrades = new System.Windows.Forms.TabPage();
            this.repeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.addPasswordTextBox = new System.Windows.Forms.TextBox();
            this.addUsernameTextBox = new System.Windows.Forms.TextBox();
            this.repeatPasswordLabel = new System.Windows.Forms.Label();
            this.addPasswordLabel = new System.Windows.Forms.Label();
            this.addUsernameLabel = new System.Windows.Forms.Label();
            this.registrationLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adminTabControl.SuspendLayout();
            this.newUser.SuspendLayout();
            this.registration.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminTabControl
            // 
            this.adminTabControl.Controls.Add(this.newUser);
            this.adminTabControl.Controls.Add(this.registration);
            this.adminTabControl.Controls.Add(this.addGrades);
            this.adminTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminTabControl.Location = new System.Drawing.Point(0, 0);
            this.adminTabControl.Name = "adminTabControl";
            this.adminTabControl.SelectedIndex = 0;
            this.adminTabControl.Size = new System.Drawing.Size(569, 391);
            this.adminTabControl.TabIndex = 0;
            // 
            // newUser
            // 
            this.newUser.Controls.Add(this.label2);
            this.newUser.Controls.Add(this.label1);
            this.newUser.Controls.Add(this.button2);
            this.newUser.Controls.Add(this.registrationLabel);
            this.newUser.Controls.Add(this.repeatPasswordTextBox);
            this.newUser.Controls.Add(this.addPasswordTextBox);
            this.newUser.Controls.Add(this.addUsernameTextBox);
            this.newUser.Controls.Add(this.repeatPasswordLabel);
            this.newUser.Controls.Add(this.addPasswordLabel);
            this.newUser.Controls.Add(this.addUsernameLabel);
            this.newUser.Location = new System.Drawing.Point(4, 22);
            this.newUser.Name = "newUser";
            this.newUser.Size = new System.Drawing.Size(561, 365);
            this.newUser.TabIndex = 5;
            this.newUser.Text = "Регистрација корисника";
            this.newUser.UseVisualStyleBackColor = true;
            // 
            // registration
            // 
            this.registration.Controls.Add(this.registrationButton);
            this.registration.Controls.Add(this.paymentComboBox);
            this.registration.Controls.Add(this.statusComboBox);
            this.registration.Controls.Add(this.yearOrderNumberTextBox);
            this.registration.Controls.Add(this.noteLabel);
            this.registration.Controls.Add(this.studyYearComboBox);
            this.registration.Controls.Add(this.indexTextBox);
            this.registration.Controls.Add(this.paymentLabel);
            this.registration.Controls.Add(this.statusLabel);
            this.registration.Controls.Add(this.yearOrderNumberLabel);
            this.registration.Controls.Add(this.studyYearLabel);
            this.registration.Controls.Add(this.indexLabel);
            this.registration.Controls.Add(this.studyProgramComboBox);
            this.registration.Controls.Add(this.studyProgramLabel);
            this.registration.Controls.Add(this.phoneNumberTextBox);
            this.registration.Controls.Add(this.addressTextBox);
            this.registration.Controls.Add(this.citizenshipTextBox);
            this.registration.Controls.Add(this.cityTextBox);
            this.registration.Controls.Add(this.phoneNumberLabel);
            this.registration.Controls.Add(this.addressLabel);
            this.registration.Controls.Add(this.citizenshipLabel);
            this.registration.Controls.Add(this.cityLabel);
            this.registration.Controls.Add(this.genderLabel);
            this.registration.Controls.Add(this.femaleCheckBox);
            this.registration.Controls.Add(this.maleCheckBox);
            this.registration.Controls.Add(this.jmbgTextBox);
            this.registration.Controls.Add(this.monthComboBox);
            this.registration.Controls.Add(this.yearOfBirthTextBox);
            this.registration.Controls.Add(this.dayTextBox);
            this.registration.Controls.Add(this.lastNameTextBox);
            this.registration.Controls.Add(this.firstNameTextBox);
            this.registration.Controls.Add(this.jmbgLabel);
            this.registration.Controls.Add(this.dateOfBirthLabel);
            this.registration.Controls.Add(this.lastNameLabel);
            this.registration.Controls.Add(this.firstNameLabel);
            this.registration.Controls.Add(this.addDataLabel);
            this.registration.Location = new System.Drawing.Point(4, 22);
            this.registration.Name = "registration";
            this.registration.Padding = new System.Windows.Forms.Padding(3);
            this.registration.Size = new System.Drawing.Size(561, 365);
            this.registration.TabIndex = 1;
            this.registration.Text = "Регистрација студената";
            this.registration.UseVisualStyleBackColor = true;
            // 
            // registrationButton
            // 
            this.registrationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationButton.Location = new System.Drawing.Point(290, 315);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(250, 30);
            this.registrationButton.TabIndex = 83;
            this.registrationButton.Text = "РЕГИСТРУЈ СТУДЕНТА";
            this.registrationButton.UseVisualStyleBackColor = true;
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
            // yearOrderNumberTextBox
            // 
            this.yearOrderNumberTextBox.Location = new System.Drawing.Point(290, 165);
            this.yearOrderNumberTextBox.Name = "yearOrderNumberTextBox";
            this.yearOrderNumberTextBox.Size = new System.Drawing.Size(250, 20);
            this.yearOrderNumberTextBox.TabIndex = 76;
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Location = new System.Drawing.Point(290, 280);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(239, 26);
            this.noteLabel.TabIndex = 82;
            this.noteLabel.Text = "НАПОМЕНА: Поље \"Број индекса\" мора бити\r\nпопуњено латиницом.";
            // 
            // studyYearComboBox
            // 
            this.studyYearComboBox.FormattingEnabled = true;
            this.studyYearComboBox.Items.AddRange(new object[] {
            "прва",
            "друга",
            "трећа",
            "четврта"});
            this.studyYearComboBox.Location = new System.Drawing.Point(290, 125);
            this.studyYearComboBox.Name = "studyYearComboBox";
            this.studyYearComboBox.Size = new System.Drawing.Size(250, 21);
            this.studyYearComboBox.TabIndex = 74;
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
            // yearOrderNumberLabel
            // 
            this.yearOrderNumberLabel.AutoSize = true;
            this.yearOrderNumberLabel.Location = new System.Drawing.Point(290, 150);
            this.yearOrderNumberLabel.Name = "yearOrderNumberLabel";
            this.yearOrderNumberLabel.Size = new System.Drawing.Size(98, 13);
            this.yearOrderNumberLabel.TabIndex = 77;
            this.yearOrderNumberLabel.Text = "Број уписа године";
            // 
            // studyYearLabel
            // 
            this.studyYearLabel.AutoSize = true;
            this.studyYearLabel.Location = new System.Drawing.Point(290, 110);
            this.studyYearLabel.Name = "studyYearLabel";
            this.studyYearLabel.Size = new System.Drawing.Size(82, 13);
            this.studyYearLabel.TabIndex = 75;
            this.studyYearLabel.Text = "Година студија";
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
            "Математика и физика",
            "Српски језик и књижевност",
            "Општа књижевност и библиотекарство",
            "Општа књижевност и театрологија",
            "Руски и српски језик и књижевност",
            "Енглески језик и књижевност",
            "Њемачки језик и књижевност",
            "Кинески и енглески језик и књижевност",
            "Разредна настава",
            "Педагогија",
            "Историја",
            "Географија",
            "Филозофија",
            "Социологија",
            "Психологија",
            "Политикологија и међународни односи",
            "Новинарство"});
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
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(10, 325);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(250, 20);
            this.phoneNumberTextBox.TabIndex = 69;
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
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(10, 205);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(250, 20);
            this.cityTextBox.TabIndex = 63;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(10, 310);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(52, 13);
            this.phoneNumberLabel.TabIndex = 68;
            this.phoneNumberLabel.Text = "Телефон";
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
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(10, 190);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(84, 13);
            this.cityLabel.TabIndex = 62;
            this.cityLabel.Text = "Мјесто рођења";
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
            // jmbgTextBox
            // 
            this.jmbgTextBox.Location = new System.Drawing.Point(10, 165);
            this.jmbgTextBox.Name = "jmbgTextBox";
            this.jmbgTextBox.Size = new System.Drawing.Size(160, 20);
            this.jmbgTextBox.TabIndex = 58;
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
            // jmbgLabel
            // 
            this.jmbgLabel.AutoSize = true;
            this.jmbgLabel.Location = new System.Drawing.Point(10, 150);
            this.jmbgLabel.Name = "jmbgLabel";
            this.jmbgLabel.Size = new System.Drawing.Size(34, 13);
            this.jmbgLabel.TabIndex = 57;
            this.jmbgLabel.Text = "ЈМБГ";
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
            // repeatPasswordTextBox
            // 
            this.repeatPasswordTextBox.Location = new System.Drawing.Point(8, 172);
            this.repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            this.repeatPasswordTextBox.Size = new System.Drawing.Size(250, 20);
            this.repeatPasswordTextBox.TabIndex = 73;
            // 
            // addPasswordTextBox
            // 
            this.addPasswordTextBox.Location = new System.Drawing.Point(8, 132);
            this.addPasswordTextBox.Name = "addPasswordTextBox";
            this.addPasswordTextBox.Size = new System.Drawing.Size(250, 20);
            this.addPasswordTextBox.TabIndex = 71;
            // 
            // addUsernameTextBox
            // 
            this.addUsernameTextBox.Location = new System.Drawing.Point(8, 92);
            this.addUsernameTextBox.Name = "addUsernameTextBox";
            this.addUsernameTextBox.Size = new System.Drawing.Size(250, 20);
            this.addUsernameTextBox.TabIndex = 69;
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
            // addPasswordLabel
            // 
            this.addPasswordLabel.AutoSize = true;
            this.addPasswordLabel.Location = new System.Drawing.Point(8, 117);
            this.addPasswordLabel.Name = "addPasswordLabel";
            this.addPasswordLabel.Size = new System.Drawing.Size(51, 13);
            this.addPasswordLabel.TabIndex = 70;
            this.addPasswordLabel.Text = "Лозинка";
            // 
            // addUsernameLabel
            // 
            this.addUsernameLabel.AutoSize = true;
            this.addUsernameLabel.Location = new System.Drawing.Point(8, 77);
            this.addUsernameLabel.Name = "addUsernameLabel";
            this.addUsernameLabel.Size = new System.Drawing.Size(73, 13);
            this.addUsernameLabel.TabIndex = 68;
            this.addUsernameLabel.Text = "Број индекса";
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
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(8, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 30);
            this.button2.TabIndex = 84;
            this.button2.Text = "РЕГИСТРУЈ КОРИСНИКА";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 85;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 26);
            this.label2.TabIndex = 86;
            this.label2.Text = "НАПОМЕНА: Поље \"Број индекса\" мора бити\r\nпопуњено латиницом.";
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 391);
            this.Controls.Add(this.adminTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "adminForm";
            this.Text = "ИНФО КИОСК - АДМИНИСТРАТОР";
            this.adminTabControl.ResumeLayout(false);
            this.newUser.ResumeLayout(false);
            this.newUser.PerformLayout();
            this.registration.ResumeLayout(false);
            this.registration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl adminTabControl;
        private System.Windows.Forms.TabPage registration;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.ComboBox paymentComboBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.TextBox yearOrderNumberTextBox;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.ComboBox studyYearComboBox;
        private System.Windows.Forms.TextBox indexTextBox;
        private System.Windows.Forms.Label paymentLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label yearOrderNumberLabel;
        private System.Windows.Forms.Label studyYearLabel;
        private System.Windows.Forms.Label indexLabel;
        private System.Windows.Forms.ComboBox studyProgramComboBox;
        private System.Windows.Forms.Label studyProgramLabel;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox citizenshipTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label citizenshipLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.CheckBox femaleCheckBox;
        private System.Windows.Forms.CheckBox maleCheckBox;
        private System.Windows.Forms.TextBox jmbgTextBox;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.TextBox yearOfBirthTextBox;
        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label jmbgLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label addDataLabel;
        private System.Windows.Forms.TabPage addGrades;
        private System.Windows.Forms.TabPage newUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.TextBox repeatPasswordTextBox;
        private System.Windows.Forms.TextBox addPasswordTextBox;
        private System.Windows.Forms.TextBox addUsernameTextBox;
        private System.Windows.Forms.Label repeatPasswordLabel;
        private System.Windows.Forms.Label addPasswordLabel;
        private System.Windows.Forms.Label addUsernameLabel;
    }
}