namespace InfoKioskProject
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.adminTabControl = new System.Windows.Forms.TabControl();
            this.homeTabPage = new System.Windows.Forms.TabPage();
            this.loadStudyProgramLabel = new System.Windows.Forms.Label();
            this.loadYearOfStudyLabel = new System.Windows.Forms.Label();
            this.loadNumberOfAdmitionsLabel = new System.Windows.Forms.Label();
            this.loadStatusLabel = new System.Windows.Forms.Label();
            this.loadPaymentLabel = new System.Windows.Forms.Label();
            this.studPaymentLabel = new System.Windows.Forms.Label();
            this.studStatusLabel = new System.Windows.Forms.Label();
            this.studNumberOfAdmitionsLabel = new System.Windows.Forms.Label();
            this.studYearOfStudyLabel = new System.Windows.Forms.Label();
            this.studStudyProgramLabel = new System.Windows.Forms.Label();
            this.loadDateOfBirthLabel = new System.Windows.Forms.Label();
            this.loadIdNumberLabel = new System.Windows.Forms.Label();
            this.loadGenderLabel = new System.Windows.Forms.Label();
            this.loadPlaceOfBirthLabel = new System.Windows.Forms.Label();
            this.loadCitizenshipLabel = new System.Windows.Forms.Label();
            this.studAddressLabel = new System.Windows.Forms.Label();
            this.studTelephoneLabel = new System.Windows.Forms.Label();
            this.loadAddressLabel = new System.Windows.Forms.Label();
            this.loadTelephoneLabel = new System.Windows.Forms.Label();
            this.studCitizenshipLabel = new System.Windows.Forms.Label();
            this.studPlaceOfBirthLabel = new System.Windows.Forms.Label();
            this.studGenderLabel = new System.Windows.Forms.Label();
            this.studIdNumberLabel = new System.Windows.Forms.Label();
            this.studDateOfBirthLabel = new System.Windows.Forms.Label();
            this.loadProfileLabel = new System.Windows.Forms.Label();
            this.gradesTabPage = new System.Windows.Forms.TabPage();
            this.gradesDataGridView = new System.Windows.Forms.DataGridView();
            this.attemptsTabPage = new System.Windows.Forms.TabPage();
            this.attemptsDataGridView = new System.Windows.Forms.DataGridView();
            this.examsTabPage = new System.Windows.Forms.TabPage();
            this.loadAttemptsLabel = new System.Windows.Forms.Label();
            this.attemptsLabel = new System.Windows.Forms.Label();
            this.loadCourseCodeLabel = new System.Windows.Forms.Label();
            this.courseCodeLabel = new System.Windows.Forms.Label();
            this.addExamRequestButton = new System.Windows.Forms.Button();
            this.loadActiveTermLabel = new System.Windows.Forms.Label();
            this.activeTermLabel = new System.Windows.Forms.Label();
            this.activeExamsPeriodLabel = new System.Windows.Forms.Label();
            this.loadActiveExamsPeriodLabel = new System.Windows.Forms.Label();
            this.noteLabel = new System.Windows.Forms.Label();
            this.unfinishedExamsDataGridView = new System.Windows.Forms.DataGridView();
            this.unfinishedExamsLabel = new System.Windows.Forms.Label();
            this.noActivePeriodsLabel = new System.Windows.Forms.Label();
            this.adminTabControl.SuspendLayout();
            this.homeTabPage.SuspendLayout();
            this.gradesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradesDataGridView)).BeginInit();
            this.attemptsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attemptsDataGridView)).BeginInit();
            this.examsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unfinishedExamsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // adminTabControl
            // 
            this.adminTabControl.Controls.Add(this.homeTabPage);
            this.adminTabControl.Controls.Add(this.gradesTabPage);
            this.adminTabControl.Controls.Add(this.attemptsTabPage);
            this.adminTabControl.Controls.Add(this.examsTabPage);
            this.adminTabControl.Location = new System.Drawing.Point(2, 1);
            this.adminTabControl.Name = "adminTabControl";
            this.adminTabControl.SelectedIndex = 0;
            this.adminTabControl.Size = new System.Drawing.Size(680, 309);
            this.adminTabControl.TabIndex = 0;
            // 
            // homeTabPage
            // 
            this.homeTabPage.Controls.Add(this.loadStudyProgramLabel);
            this.homeTabPage.Controls.Add(this.loadYearOfStudyLabel);
            this.homeTabPage.Controls.Add(this.loadNumberOfAdmitionsLabel);
            this.homeTabPage.Controls.Add(this.loadStatusLabel);
            this.homeTabPage.Controls.Add(this.loadPaymentLabel);
            this.homeTabPage.Controls.Add(this.studPaymentLabel);
            this.homeTabPage.Controls.Add(this.studStatusLabel);
            this.homeTabPage.Controls.Add(this.studNumberOfAdmitionsLabel);
            this.homeTabPage.Controls.Add(this.studYearOfStudyLabel);
            this.homeTabPage.Controls.Add(this.studStudyProgramLabel);
            this.homeTabPage.Controls.Add(this.loadDateOfBirthLabel);
            this.homeTabPage.Controls.Add(this.loadIdNumberLabel);
            this.homeTabPage.Controls.Add(this.loadGenderLabel);
            this.homeTabPage.Controls.Add(this.loadPlaceOfBirthLabel);
            this.homeTabPage.Controls.Add(this.loadCitizenshipLabel);
            this.homeTabPage.Controls.Add(this.studAddressLabel);
            this.homeTabPage.Controls.Add(this.studTelephoneLabel);
            this.homeTabPage.Controls.Add(this.loadAddressLabel);
            this.homeTabPage.Controls.Add(this.loadTelephoneLabel);
            this.homeTabPage.Controls.Add(this.studCitizenshipLabel);
            this.homeTabPage.Controls.Add(this.studPlaceOfBirthLabel);
            this.homeTabPage.Controls.Add(this.studGenderLabel);
            this.homeTabPage.Controls.Add(this.studIdNumberLabel);
            this.homeTabPage.Controls.Add(this.studDateOfBirthLabel);
            this.homeTabPage.Controls.Add(this.loadProfileLabel);
            this.homeTabPage.Location = new System.Drawing.Point(4, 22);
            this.homeTabPage.Name = "homeTabPage";
            this.homeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.homeTabPage.Size = new System.Drawing.Size(672, 283);
            this.homeTabPage.TabIndex = 0;
            this.homeTabPage.Text = "Почетна";
            this.homeTabPage.UseVisualStyleBackColor = true;
            // 
            // loadStudyProgramLabel
            // 
            this.loadStudyProgramLabel.AutoSize = true;
            this.loadStudyProgramLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadStudyProgramLabel.Location = new System.Drawing.Point(433, 70);
            this.loadStudyProgramLabel.Name = "loadStudyProgramLabel";
            this.loadStudyProgramLabel.Size = new System.Drawing.Size(85, 15);
            this.loadStudyProgramLabel.TabIndex = 49;
            this.loadStudyProgramLabel.Text = "study program";
            // 
            // loadYearOfStudyLabel
            // 
            this.loadYearOfStudyLabel.AutoSize = true;
            this.loadYearOfStudyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadYearOfStudyLabel.Location = new System.Drawing.Point(433, 100);
            this.loadYearOfStudyLabel.Name = "loadYearOfStudyLabel";
            this.loadYearOfStudyLabel.Size = new System.Drawing.Size(30, 15);
            this.loadYearOfStudyLabel.TabIndex = 48;
            this.loadYearOfStudyLabel.Text = "year";
            // 
            // loadNumberOfAdmitionsLabel
            // 
            this.loadNumberOfAdmitionsLabel.AutoSize = true;
            this.loadNumberOfAdmitionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadNumberOfAdmitionsLabel.Location = new System.Drawing.Point(433, 130);
            this.loadNumberOfAdmitionsLabel.Name = "loadNumberOfAdmitionsLabel";
            this.loadNumberOfAdmitionsLabel.Size = new System.Drawing.Size(14, 15);
            this.loadNumberOfAdmitionsLabel.TabIndex = 47;
            this.loadNumberOfAdmitionsLabel.Text = "1";
            // 
            // loadStatusLabel
            // 
            this.loadStatusLabel.AutoSize = true;
            this.loadStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadStatusLabel.Location = new System.Drawing.Point(433, 160);
            this.loadStatusLabel.Name = "loadStatusLabel";
            this.loadStatusLabel.Size = new System.Drawing.Size(39, 15);
            this.loadStatusLabel.TabIndex = 46;
            this.loadStatusLabel.Text = "status";
            // 
            // loadPaymentLabel
            // 
            this.loadPaymentLabel.AutoSize = true;
            this.loadPaymentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadPaymentLabel.Location = new System.Drawing.Point(433, 190);
            this.loadPaymentLabel.Name = "loadPaymentLabel";
            this.loadPaymentLabel.Size = new System.Drawing.Size(54, 15);
            this.loadPaymentLabel.TabIndex = 45;
            this.loadPaymentLabel.Text = "payment";
            // 
            // studPaymentLabel
            // 
            this.studPaymentLabel.AutoSize = true;
            this.studPaymentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studPaymentLabel.Location = new System.Drawing.Point(276, 190);
            this.studPaymentLabel.Name = "studPaymentLabel";
            this.studPaymentLabel.Size = new System.Drawing.Size(151, 15);
            this.studPaymentLabel.TabIndex = 44;
            this.studPaymentLabel.Text = "Начин финансирања:";
            // 
            // studStatusLabel
            // 
            this.studStatusLabel.AutoSize = true;
            this.studStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studStatusLabel.Location = new System.Drawing.Point(276, 160);
            this.studStatusLabel.Name = "studStatusLabel";
            this.studStatusLabel.Size = new System.Drawing.Size(122, 15);
            this.studStatusLabel.TabIndex = 43;
            this.studStatusLabel.Text = "Статус студента:";
            // 
            // studNumberOfAdmitionsLabel
            // 
            this.studNumberOfAdmitionsLabel.AutoSize = true;
            this.studNumberOfAdmitionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studNumberOfAdmitionsLabel.Location = new System.Drawing.Point(276, 130);
            this.studNumberOfAdmitionsLabel.Name = "studNumberOfAdmitionsLabel";
            this.studNumberOfAdmitionsLabel.Size = new System.Drawing.Size(131, 15);
            this.studNumberOfAdmitionsLabel.TabIndex = 42;
            this.studNumberOfAdmitionsLabel.Text = "Број уписа године:";
            // 
            // studYearOfStudyLabel
            // 
            this.studYearOfStudyLabel.AutoSize = true;
            this.studYearOfStudyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studYearOfStudyLabel.Location = new System.Drawing.Point(276, 100);
            this.studYearOfStudyLabel.Name = "studYearOfStudyLabel";
            this.studYearOfStudyLabel.Size = new System.Drawing.Size(112, 15);
            this.studYearOfStudyLabel.TabIndex = 41;
            this.studYearOfStudyLabel.Text = "Година студија:";
            // 
            // studStudyProgramLabel
            // 
            this.studStudyProgramLabel.AutoSize = true;
            this.studStudyProgramLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studStudyProgramLabel.Location = new System.Drawing.Point(276, 70);
            this.studStudyProgramLabel.Name = "studStudyProgramLabel";
            this.studStudyProgramLabel.Size = new System.Drawing.Size(136, 15);
            this.studStudyProgramLabel.TabIndex = 40;
            this.studStudyProgramLabel.Text = "Студијски програм:";
            // 
            // loadDateOfBirthLabel
            // 
            this.loadDateOfBirthLabel.AutoSize = true;
            this.loadDateOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadDateOfBirthLabel.Location = new System.Drawing.Point(151, 70);
            this.loadDateOfBirthLabel.Name = "loadDateOfBirthLabel";
            this.loadDateOfBirthLabel.Size = new System.Drawing.Size(90, 15);
            this.loadDateOfBirthLabel.TabIndex = 39;
            this.loadDateOfBirthLabel.Text = "day month year";
            // 
            // loadIdNumberLabel
            // 
            this.loadIdNumberLabel.AutoSize = true;
            this.loadIdNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadIdNumberLabel.Location = new System.Drawing.Point(151, 100);
            this.loadIdNumberLabel.Name = "loadIdNumberLabel";
            this.loadIdNumberLabel.Size = new System.Drawing.Size(98, 15);
            this.loadIdNumberLabel.TabIndex = 38;
            this.loadIdNumberLabel.Text = "1234567890123";
            // 
            // loadGenderLabel
            // 
            this.loadGenderLabel.AutoSize = true;
            this.loadGenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadGenderLabel.Location = new System.Drawing.Point(151, 130);
            this.loadGenderLabel.Name = "loadGenderLabel";
            this.loadGenderLabel.Size = new System.Drawing.Size(46, 15);
            this.loadGenderLabel.TabIndex = 37;
            this.loadGenderLabel.Text = "gender";
            // 
            // loadPlaceOfBirthLabel
            // 
            this.loadPlaceOfBirthLabel.AutoSize = true;
            this.loadPlaceOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadPlaceOfBirthLabel.Location = new System.Drawing.Point(151, 160);
            this.loadPlaceOfBirthLabel.Name = "loadPlaceOfBirthLabel";
            this.loadPlaceOfBirthLabel.Size = new System.Drawing.Size(70, 15);
            this.loadPlaceOfBirthLabel.TabIndex = 36;
            this.loadPlaceOfBirthLabel.Text = "random city";
            // 
            // loadCitizenshipLabel
            // 
            this.loadCitizenshipLabel.AutoSize = true;
            this.loadCitizenshipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadCitizenshipLabel.Location = new System.Drawing.Point(151, 190);
            this.loadCitizenshipLabel.Name = "loadCitizenshipLabel";
            this.loadCitizenshipLabel.Size = new System.Drawing.Size(46, 15);
            this.loadCitizenshipLabel.TabIndex = 35;
            this.loadCitizenshipLabel.Text = "country";
            // 
            // studAddressLabel
            // 
            this.studAddressLabel.AutoSize = true;
            this.studAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studAddressLabel.Location = new System.Drawing.Point(7, 220);
            this.studAddressLabel.Name = "studAddressLabel";
            this.studAddressLabel.Size = new System.Drawing.Size(137, 15);
            this.studAddressLabel.TabIndex = 34;
            this.studAddressLabel.Text = "Адреса становања:";
            // 
            // studTelephoneLabel
            // 
            this.studTelephoneLabel.AutoSize = true;
            this.studTelephoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studTelephoneLabel.Location = new System.Drawing.Point(7, 250);
            this.studTelephoneLabel.Name = "studTelephoneLabel";
            this.studTelephoneLabel.Size = new System.Drawing.Size(71, 15);
            this.studTelephoneLabel.TabIndex = 33;
            this.studTelephoneLabel.Text = "Телефон:";
            // 
            // loadAddressLabel
            // 
            this.loadAddressLabel.AutoSize = true;
            this.loadAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadAddressLabel.Location = new System.Drawing.Point(151, 220);
            this.loadAddressLabel.Name = "loadAddressLabel";
            this.loadAddressLabel.Size = new System.Drawing.Size(130, 15);
            this.loadAddressLabel.TabIndex = 32;
            this.loadAddressLabel.Text = "address street number";
            // 
            // loadTelephoneLabel
            // 
            this.loadTelephoneLabel.AutoSize = true;
            this.loadTelephoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadTelephoneLabel.Location = new System.Drawing.Point(151, 250);
            this.loadTelephoneLabel.Name = "loadTelephoneLabel";
            this.loadTelephoneLabel.Size = new System.Drawing.Size(77, 15);
            this.loadTelephoneLabel.TabIndex = 31;
            this.loadTelephoneLabel.Text = "123/456-789";
            // 
            // studCitizenshipLabel
            // 
            this.studCitizenshipLabel.AutoSize = true;
            this.studCitizenshipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studCitizenshipLabel.Location = new System.Drawing.Point(7, 190);
            this.studCitizenshipLabel.Name = "studCitizenshipLabel";
            this.studCitizenshipLabel.Size = new System.Drawing.Size(113, 15);
            this.studCitizenshipLabel.TabIndex = 30;
            this.studCitizenshipLabel.Text = "Држављанство:";
            // 
            // studPlaceOfBirthLabel
            // 
            this.studPlaceOfBirthLabel.AutoSize = true;
            this.studPlaceOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studPlaceOfBirthLabel.Location = new System.Drawing.Point(7, 160);
            this.studPlaceOfBirthLabel.Name = "studPlaceOfBirthLabel";
            this.studPlaceOfBirthLabel.Size = new System.Drawing.Size(114, 15);
            this.studPlaceOfBirthLabel.TabIndex = 29;
            this.studPlaceOfBirthLabel.Text = "Мјесто рођења:";
            // 
            // studGenderLabel
            // 
            this.studGenderLabel.AutoSize = true;
            this.studGenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studGenderLabel.Location = new System.Drawing.Point(7, 130);
            this.studGenderLabel.Name = "studGenderLabel";
            this.studGenderLabel.Size = new System.Drawing.Size(37, 15);
            this.studGenderLabel.TabIndex = 28;
            this.studGenderLabel.Text = "Пол:";
            // 
            // studIdNumberLabel
            // 
            this.studIdNumberLabel.AutoSize = true;
            this.studIdNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studIdNumberLabel.Location = new System.Drawing.Point(7, 100);
            this.studIdNumberLabel.Name = "studIdNumberLabel";
            this.studIdNumberLabel.Size = new System.Drawing.Size(47, 15);
            this.studIdNumberLabel.TabIndex = 27;
            this.studIdNumberLabel.Text = "ЈМБГ:";
            // 
            // studDateOfBirthLabel
            // 
            this.studDateOfBirthLabel.AutoSize = true;
            this.studDateOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studDateOfBirthLabel.Location = new System.Drawing.Point(7, 70);
            this.studDateOfBirthLabel.Name = "studDateOfBirthLabel";
            this.studDateOfBirthLabel.Size = new System.Drawing.Size(109, 15);
            this.studDateOfBirthLabel.TabIndex = 26;
            this.studDateOfBirthLabel.Text = "Датум рођења:";
            // 
            // loadProfileLabel
            // 
            this.loadProfileLabel.AutoSize = true;
            this.loadProfileLabel.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadProfileLabel.Location = new System.Drawing.Point(8, 17);
            this.loadProfileLabel.Name = "loadProfileLabel";
            this.loadProfileLabel.Size = new System.Drawing.Size(212, 19);
            this.loadProfileLabel.TabIndex = 25;
            this.loadProfileLabel.Text = "firstName lastName (index)";
            // 
            // gradesTabPage
            // 
            this.gradesTabPage.Controls.Add(this.gradesDataGridView);
            this.gradesTabPage.Location = new System.Drawing.Point(4, 22);
            this.gradesTabPage.Name = "gradesTabPage";
            this.gradesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.gradesTabPage.Size = new System.Drawing.Size(672, 283);
            this.gradesTabPage.TabIndex = 1;
            this.gradesTabPage.Text = "Положени испити";
            this.gradesTabPage.UseVisualStyleBackColor = true;
            // 
            // gradesDataGridView
            // 
            this.gradesDataGridView.AllowUserToAddRows = false;
            this.gradesDataGridView.AllowUserToDeleteRows = false;
            this.gradesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.gradesDataGridView.Name = "gradesDataGridView";
            this.gradesDataGridView.ReadOnly = true;
            this.gradesDataGridView.Size = new System.Drawing.Size(672, 283);
            this.gradesDataGridView.TabIndex = 0;
            // 
            // attemptsTabPage
            // 
            this.attemptsTabPage.Controls.Add(this.attemptsDataGridView);
            this.attemptsTabPage.Location = new System.Drawing.Point(4, 22);
            this.attemptsTabPage.Name = "attemptsTabPage";
            this.attemptsTabPage.Size = new System.Drawing.Size(672, 283);
            this.attemptsTabPage.TabIndex = 2;
            this.attemptsTabPage.Text = "Преглед излазака";
            this.attemptsTabPage.UseVisualStyleBackColor = true;
            // 
            // attemptsDataGridView
            // 
            this.attemptsDataGridView.AllowUserToAddRows = false;
            this.attemptsDataGridView.AllowUserToDeleteRows = false;
            this.attemptsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attemptsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attemptsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.attemptsDataGridView.Name = "attemptsDataGridView";
            this.attemptsDataGridView.ReadOnly = true;
            this.attemptsDataGridView.Size = new System.Drawing.Size(672, 283);
            this.attemptsDataGridView.TabIndex = 0;
            // 
            // examsTabPage
            // 
            this.examsTabPage.Controls.Add(this.loadAttemptsLabel);
            this.examsTabPage.Controls.Add(this.attemptsLabel);
            this.examsTabPage.Controls.Add(this.loadCourseCodeLabel);
            this.examsTabPage.Controls.Add(this.courseCodeLabel);
            this.examsTabPage.Controls.Add(this.addExamRequestButton);
            this.examsTabPage.Controls.Add(this.loadActiveTermLabel);
            this.examsTabPage.Controls.Add(this.activeTermLabel);
            this.examsTabPage.Controls.Add(this.activeExamsPeriodLabel);
            this.examsTabPage.Controls.Add(this.loadActiveExamsPeriodLabel);
            this.examsTabPage.Controls.Add(this.noteLabel);
            this.examsTabPage.Controls.Add(this.unfinishedExamsDataGridView);
            this.examsTabPage.Controls.Add(this.unfinishedExamsLabel);
            this.examsTabPage.Controls.Add(this.noActivePeriodsLabel);
            this.examsTabPage.Location = new System.Drawing.Point(4, 22);
            this.examsTabPage.Name = "examsTabPage";
            this.examsTabPage.Size = new System.Drawing.Size(672, 283);
            this.examsTabPage.TabIndex = 3;
            this.examsTabPage.Text = "Пријава испита";
            this.examsTabPage.UseVisualStyleBackColor = true;
            // 
            // loadAttemptsLabel
            // 
            this.loadAttemptsLabel.AutoSize = true;
            this.loadAttemptsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadAttemptsLabel.Location = new System.Drawing.Point(569, 196);
            this.loadAttemptsLabel.Name = "loadAttemptsLabel";
            this.loadAttemptsLabel.Size = new System.Drawing.Size(48, 13);
            this.loadAttemptsLabel.TabIndex = 13;
            this.loadAttemptsLabel.Text = "number";
            // 
            // attemptsLabel
            // 
            this.attemptsLabel.AutoSize = true;
            this.attemptsLabel.Location = new System.Drawing.Point(465, 196);
            this.attemptsLabel.Name = "attemptsLabel";
            this.attemptsLabel.Size = new System.Drawing.Size(82, 13);
            this.attemptsLabel.TabIndex = 12;
            this.attemptsLabel.Text = "Број излазака:";
            // 
            // loadCourseCodeLabel
            // 
            this.loadCourseCodeLabel.AutoSize = true;
            this.loadCourseCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadCourseCodeLabel.Location = new System.Drawing.Point(569, 165);
            this.loadCourseCodeLabel.Name = "loadCourseCodeLabel";
            this.loadCourseCodeLabel.Size = new System.Drawing.Size(77, 13);
            this.loadCourseCodeLabel.TabIndex = 11;
            this.loadCourseCodeLabel.Text = "course code";
            // 
            // courseCodeLabel
            // 
            this.courseCodeLabel.AutoSize = true;
            this.courseCodeLabel.Location = new System.Drawing.Point(465, 165);
            this.courseCodeLabel.Name = "courseCodeLabel";
            this.courseCodeLabel.Size = new System.Drawing.Size(97, 13);
            this.courseCodeLabel.TabIndex = 10;
            this.courseCodeLabel.Text = "Шифра предмета:";
            // 
            // addExamRequestButton
            // 
            this.addExamRequestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addExamRequestButton.Location = new System.Drawing.Point(468, 253);
            this.addExamRequestButton.Name = "addExamRequestButton";
            this.addExamRequestButton.Size = new System.Drawing.Size(204, 30);
            this.addExamRequestButton.TabIndex = 9;
            this.addExamRequestButton.Text = "ПРИЈАВИТИ ИСПИТ";
            this.addExamRequestButton.UseVisualStyleBackColor = true;
            this.addExamRequestButton.Click += new System.EventHandler(this.addExamRequestButton_Click);
            // 
            // loadActiveTermLabel
            // 
            this.loadActiveTermLabel.AutoSize = true;
            this.loadActiveTermLabel.Location = new System.Drawing.Point(524, 48);
            this.loadActiveTermLabel.Name = "loadActiveTermLabel";
            this.loadActiveTermLabel.Size = new System.Drawing.Size(59, 13);
            this.loadActiveTermLabel.TabIndex = 7;
            this.loadActiveTermLabel.Text = "active term";
            // 
            // activeTermLabel
            // 
            this.activeTermLabel.AutoSize = true;
            this.activeTermLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeTermLabel.Location = new System.Drawing.Point(465, 48);
            this.activeTermLabel.Name = "activeTermLabel";
            this.activeTermLabel.Size = new System.Drawing.Size(54, 13);
            this.activeTermLabel.TabIndex = 6;
            this.activeTermLabel.Text = "термин:";
            // 
            // activeExamsPeriodLabel
            // 
            this.activeExamsPeriodLabel.AutoSize = true;
            this.activeExamsPeriodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeExamsPeriodLabel.Location = new System.Drawing.Point(465, 5);
            this.activeExamsPeriodLabel.Name = "activeExamsPeriodLabel";
            this.activeExamsPeriodLabel.Size = new System.Drawing.Size(110, 15);
            this.activeExamsPeriodLabel.TabIndex = 5;
            this.activeExamsPeriodLabel.Text = "ИСПИТНИ РОК:";
            // 
            // loadActiveExamsPeriodLabel
            // 
            this.loadActiveExamsPeriodLabel.AutoSize = true;
            this.loadActiveExamsPeriodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadActiveExamsPeriodLabel.Location = new System.Drawing.Point(465, 25);
            this.loadActiveExamsPeriodLabel.Name = "loadActiveExamsPeriodLabel";
            this.loadActiveExamsPeriodLabel.Size = new System.Drawing.Size(110, 15);
            this.loadActiveExamsPeriodLabel.TabIndex = 4;
            this.loadActiveExamsPeriodLabel.Text = "active exam period";
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Location = new System.Drawing.Point(465, 90);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(207, 39);
            this.noteLabel.TabIndex = 3;
            this.noteLabel.Text = "Да бисте пријавили испит, потребно је\r\nда кликнете на жељени испит, а затим\r\nприј" +
    "авите.";
            // 
            // unfinishedExamsDataGridView
            // 
            this.unfinishedExamsDataGridView.AllowUserToAddRows = false;
            this.unfinishedExamsDataGridView.AllowUserToDeleteRows = false;
            this.unfinishedExamsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.unfinishedExamsDataGridView.Location = new System.Drawing.Point(0, 23);
            this.unfinishedExamsDataGridView.Name = "unfinishedExamsDataGridView";
            this.unfinishedExamsDataGridView.ReadOnly = true;
            this.unfinishedExamsDataGridView.Size = new System.Drawing.Size(456, 260);
            this.unfinishedExamsDataGridView.TabIndex = 2;
            this.unfinishedExamsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.unfinishedExamsDataGridView_CellClick);
            // 
            // unfinishedExamsLabel
            // 
            this.unfinishedExamsLabel.AutoSize = true;
            this.unfinishedExamsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unfinishedExamsLabel.Location = new System.Drawing.Point(7, 5);
            this.unfinishedExamsLabel.Name = "unfinishedExamsLabel";
            this.unfinishedExamsLabel.Size = new System.Drawing.Size(167, 15);
            this.unfinishedExamsLabel.TabIndex = 1;
            this.unfinishedExamsLabel.Text = "НЕПОЛОЖЕНИ ИСПИТИ";
            // 
            // noActivePeriodsLabel
            // 
            this.noActivePeriodsLabel.AutoSize = true;
            this.noActivePeriodsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noActivePeriodsLabel.ForeColor = System.Drawing.Color.Red;
            this.noActivePeriodsLabel.Location = new System.Drawing.Point(6, 10);
            this.noActivePeriodsLabel.Name = "noActivePeriodsLabel";
            this.noActivePeriodsLabel.Size = new System.Drawing.Size(564, 16);
            this.noActivePeriodsLabel.TabIndex = 0;
            this.noActivePeriodsLabel.Text = "Није могуће пријавити испит! Тренутно није активан ниједан испитни рок.";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Controls.Add(this.adminTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ИНФО КИОСК";
            this.adminTabControl.ResumeLayout(false);
            this.homeTabPage.ResumeLayout(false);
            this.homeTabPage.PerformLayout();
            this.gradesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradesDataGridView)).EndInit();
            this.attemptsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.attemptsDataGridView)).EndInit();
            this.examsTabPage.ResumeLayout(false);
            this.examsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unfinishedExamsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl adminTabControl;
        private System.Windows.Forms.TabPage homeTabPage;
        private System.Windows.Forms.Label loadStudyProgramLabel;
        private System.Windows.Forms.Label loadYearOfStudyLabel;
        private System.Windows.Forms.Label loadNumberOfAdmitionsLabel;
        private System.Windows.Forms.Label loadStatusLabel;
        private System.Windows.Forms.Label loadPaymentLabel;
        private System.Windows.Forms.Label studPaymentLabel;
        private System.Windows.Forms.Label studStatusLabel;
        private System.Windows.Forms.Label studNumberOfAdmitionsLabel;
        private System.Windows.Forms.Label studYearOfStudyLabel;
        private System.Windows.Forms.Label studStudyProgramLabel;
        private System.Windows.Forms.Label loadDateOfBirthLabel;
        private System.Windows.Forms.Label loadIdNumberLabel;
        private System.Windows.Forms.Label loadGenderLabel;
        private System.Windows.Forms.Label loadPlaceOfBirthLabel;
        private System.Windows.Forms.Label loadCitizenshipLabel;
        private System.Windows.Forms.Label studAddressLabel;
        private System.Windows.Forms.Label studTelephoneLabel;
        private System.Windows.Forms.Label loadAddressLabel;
        private System.Windows.Forms.Label loadTelephoneLabel;
        private System.Windows.Forms.Label studCitizenshipLabel;
        private System.Windows.Forms.Label studPlaceOfBirthLabel;
        private System.Windows.Forms.Label studGenderLabel;
        private System.Windows.Forms.Label studIdNumberLabel;
        private System.Windows.Forms.Label studDateOfBirthLabel;
        private System.Windows.Forms.Label loadProfileLabel;
        private System.Windows.Forms.TabPage gradesTabPage;
        private System.Windows.Forms.TabPage attemptsTabPage;
        private System.Windows.Forms.TabPage examsTabPage;
        private System.Windows.Forms.DataGridView gradesDataGridView;
        private System.Windows.Forms.DataGridView attemptsDataGridView;
        private System.Windows.Forms.Label noActivePeriodsLabel;
        private System.Windows.Forms.Label unfinishedExamsLabel;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.DataGridView unfinishedExamsDataGridView;
        private System.Windows.Forms.Label loadActiveExamsPeriodLabel;
        private System.Windows.Forms.Label loadActiveTermLabel;
        private System.Windows.Forms.Label activeTermLabel;
        private System.Windows.Forms.Label activeExamsPeriodLabel;
        private System.Windows.Forms.Button addExamRequestButton;
        private System.Windows.Forms.Label loadAttemptsLabel;
        private System.Windows.Forms.Label attemptsLabel;
        private System.Windows.Forms.Label loadCourseCodeLabel;
        private System.Windows.Forms.Label courseCodeLabel;
    }
}