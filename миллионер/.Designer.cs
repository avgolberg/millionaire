namespace миллионер
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelBackground = new System.Windows.Forms.Label();
            this.groupBoxHelp = new System.Windows.Forms.GroupBox();
            this.buttonPeople = new System.Windows.Forms.Button();
            this.buttonCallFriend = new System.Windows.Forms.Button();
            this.buttonHalfAnswers = new System.Windows.Forms.Button();
            this.panelRows = new System.Windows.Forms.Panel();
            this.labelRow1 = new System.Windows.Forms.Label();
            this.labelRow2 = new System.Windows.Forms.Label();
            this.labelRow3 = new System.Windows.Forms.Label();
            this.labelRow4 = new System.Windows.Forms.Label();
            this.labelRow5 = new System.Windows.Forms.Label();
            this.labelRow6 = new System.Windows.Forms.Label();
            this.labelRow7 = new System.Windows.Forms.Label();
            this.labelRow8 = new System.Windows.Forms.Label();
            this.labelRow9 = new System.Windows.Forms.Label();
            this.labelRow10 = new System.Windows.Forms.Label();
            this.labelRow11 = new System.Windows.Forms.Label();
            this.labelRow12 = new System.Windows.Forms.Label();
            this.labelRow13 = new System.Windows.Forms.Label();
            this.labelRow14 = new System.Windows.Forms.Label();
            this.labelRow15 = new System.Windows.Forms.Label();
            this.labelMain = new System.Windows.Forms.Label();
            this.buttonAnswerA = new System.Windows.Forms.Button();
            this.buttonAnswerB = new System.Windows.Forms.Button();
            this.buttonAnswerC = new System.Windows.Forms.Button();
            this.buttonAnswerD = new System.Windows.Forms.Button();
            this.labelRightAnswer = new System.Windows.Forms.Label();
            this.buttonPlayAgainYes = new System.Windows.Forms.Button();
            this.buttonPlayAgainNo = new System.Windows.Forms.Button();
            this.timerRightAnswers = new System.Windows.Forms.Timer(this.components);
            this.timerWrongAnswers = new System.Windows.Forms.Timer(this.components);
            this.labelFriendAnswer = new System.Windows.Forms.Label();
            this.groupBoxPeopleHelp = new System.Windows.Forms.GroupBox();
            this.progressBarPeopleHeplD = new System.Windows.Forms.ProgressBar();
            this.progressBarPeopleHeplC = new System.Windows.Forms.ProgressBar();
            this.progressBarPeopleHeplB = new System.Windows.Forms.ProgressBar();
            this.progressBarPeopleHeplA = new System.Windows.Forms.ProgressBar();
            this.labelPeopleHeplD = new System.Windows.Forms.Label();
            this.labelPeopleHeplC = new System.Windows.Forms.Label();
            this.labelPeopleHeplB = new System.Windows.Forms.Label();
            this.labelPeopleHeplA = new System.Windows.Forms.Label();
            this.pictureBoxMoney = new System.Windows.Forms.PictureBox();
            this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
            this.pictureBoxRightAnswer = new System.Windows.Forms.PictureBox();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.GameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxHelp.SuspendLayout();
            this.panelRows.SuspendLayout();
            this.groupBoxPeopleHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightAnswer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBackground
            // 
            this.labelBackground.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelBackground.Location = new System.Drawing.Point(877, 0);
            this.labelBackground.Name = "labelBackground";
            this.labelBackground.Size = new System.Drawing.Size(302, 921);
            this.labelBackground.TabIndex = 6;
            // 
            // groupBoxHelp
            // 
            this.groupBoxHelp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxHelp.Controls.Add(this.buttonPeople);
            this.groupBoxHelp.Controls.Add(this.buttonCallFriend);
            this.groupBoxHelp.Controls.Add(this.buttonHalfAnswers);
            this.groupBoxHelp.ForeColor = System.Drawing.Color.Gold;
            this.groupBoxHelp.Location = new System.Drawing.Point(861, 11);
            this.groupBoxHelp.Name = "groupBoxHelp";
            this.groupBoxHelp.Size = new System.Drawing.Size(318, 100);
            this.groupBoxHelp.TabIndex = 7;
            this.groupBoxHelp.TabStop = false;
            this.groupBoxHelp.Text = "Подсказки";
            // 
            // buttonPeople
            // 
            this.buttonPeople.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPeople.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPeople.Image = global::миллионер.Properties.Resources._3;
            this.buttonPeople.Location = new System.Drawing.Point(211, 25);
            this.buttonPeople.Name = "buttonPeople";
            this.buttonPeople.Size = new System.Drawing.Size(90, 62);
            this.buttonPeople.TabIndex = 10;
            this.buttonPeople.Tag = "EnabledTrue";
            this.buttonPeople.UseVisualStyleBackColor = false;
            this.buttonPeople.Click += new System.EventHandler(this.buttonPeople_Click);
            // 
            // buttonCallFriend
            // 
            this.buttonCallFriend.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCallFriend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCallFriend.Image = global::миллионер.Properties.Resources._2;
            this.buttonCallFriend.Location = new System.Drawing.Point(110, 25);
            this.buttonCallFriend.Name = "buttonCallFriend";
            this.buttonCallFriend.Size = new System.Drawing.Size(90, 62);
            this.buttonCallFriend.TabIndex = 9;
            this.buttonCallFriend.Tag = "EnabledTrue";
            this.buttonCallFriend.UseVisualStyleBackColor = false;
            this.buttonCallFriend.Click += new System.EventHandler(this.buttonCallFriend_Click);
            // 
            // buttonHalfAnswers
            // 
            this.buttonHalfAnswers.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonHalfAnswers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHalfAnswers.Image = global::миллионер.Properties.Resources._1;
            this.buttonHalfAnswers.Location = new System.Drawing.Point(10, 25);
            this.buttonHalfAnswers.Name = "buttonHalfAnswers";
            this.buttonHalfAnswers.Size = new System.Drawing.Size(90, 62);
            this.buttonHalfAnswers.TabIndex = 8;
            this.buttonHalfAnswers.Tag = "EnabledTrue";
            this.buttonHalfAnswers.UseVisualStyleBackColor = false;
            this.buttonHalfAnswers.Click += new System.EventHandler(this.buttonHalfAnswers_Click);
            // 
            // panelRows
            // 
            this.panelRows.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelRows.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRows.Controls.Add(this.labelRow1);
            this.panelRows.Controls.Add(this.labelRow2);
            this.panelRows.Controls.Add(this.labelRow3);
            this.panelRows.Controls.Add(this.labelRow4);
            this.panelRows.Controls.Add(this.labelRow5);
            this.panelRows.Controls.Add(this.labelRow6);
            this.panelRows.Controls.Add(this.labelRow7);
            this.panelRows.Controls.Add(this.labelRow8);
            this.panelRows.Controls.Add(this.labelRow9);
            this.panelRows.Controls.Add(this.labelRow10);
            this.panelRows.Controls.Add(this.labelRow11);
            this.panelRows.Controls.Add(this.labelRow12);
            this.panelRows.Controls.Add(this.labelRow13);
            this.panelRows.Controls.Add(this.labelRow14);
            this.panelRows.Controls.Add(this.labelRow15);
            this.panelRows.Location = new System.Drawing.Point(881, 117);
            this.panelRows.Name = "panelRows";
            this.panelRows.Size = new System.Drawing.Size(298, 583);
            this.panelRows.TabIndex = 8;
            // 
            // labelRow1
            // 
            this.labelRow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelRow1.ForeColor = System.Drawing.Color.Yellow;
            this.labelRow1.Location = new System.Drawing.Point(12, 504);
            this.labelRow1.Name = "labelRow1";
            this.labelRow1.Size = new System.Drawing.Size(273, 42);
            this.labelRow1.TabIndex = 0;
            this.labelRow1.Text = "1 -      100";
            this.labelRow1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRow2
            // 
            this.labelRow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelRow2.ForeColor = System.Drawing.Color.Yellow;
            this.labelRow2.Location = new System.Drawing.Point(12, 471);
            this.labelRow2.Name = "labelRow2";
            this.labelRow2.Size = new System.Drawing.Size(273, 42);
            this.labelRow2.TabIndex = 1;
            this.labelRow2.Text = "2 -      200";
            this.labelRow2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRow3
            // 
            this.labelRow3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelRow3.ForeColor = System.Drawing.Color.Yellow;
            this.labelRow3.Location = new System.Drawing.Point(12, 435);
            this.labelRow3.Name = "labelRow3";
            this.labelRow3.Size = new System.Drawing.Size(273, 42);
            this.labelRow3.TabIndex = 2;
            this.labelRow3.Text = "3 -      300";
            this.labelRow3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRow4
            // 
            this.labelRow4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelRow4.ForeColor = System.Drawing.Color.Yellow;
            this.labelRow4.Location = new System.Drawing.Point(12, 402);
            this.labelRow4.Name = "labelRow4";
            this.labelRow4.Size = new System.Drawing.Size(273, 42);
            this.labelRow4.TabIndex = 3;
            this.labelRow4.Text = "4 -      500";
            this.labelRow4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRow5
            // 
            this.labelRow5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelRow5.ForeColor = System.Drawing.Color.Goldenrod;
            this.labelRow5.Location = new System.Drawing.Point(12, 369);
            this.labelRow5.Name = "labelRow5";
            this.labelRow5.Size = new System.Drawing.Size(273, 42);
            this.labelRow5.TabIndex = 4;
            this.labelRow5.Text = "5 -    1 000";
            this.labelRow5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRow6
            // 
            this.labelRow6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelRow6.ForeColor = System.Drawing.Color.Yellow;
            this.labelRow6.Location = new System.Drawing.Point(12, 334);
            this.labelRow6.Name = "labelRow6";
            this.labelRow6.Size = new System.Drawing.Size(273, 42);
            this.labelRow6.TabIndex = 5;
            this.labelRow6.Text = "6 -    2 000";
            this.labelRow6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRow7
            // 
            this.labelRow7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelRow7.ForeColor = System.Drawing.Color.Yellow;
            this.labelRow7.Location = new System.Drawing.Point(12, 297);
            this.labelRow7.Name = "labelRow7";
            this.labelRow7.Size = new System.Drawing.Size(273, 42);
            this.labelRow7.TabIndex = 6;
            this.labelRow7.Text = "7 -    4 000";
            this.labelRow7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRow8
            // 
            this.labelRow8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelRow8.ForeColor = System.Drawing.Color.Yellow;
            this.labelRow8.Location = new System.Drawing.Point(12, 262);
            this.labelRow8.Name = "labelRow8";
            this.labelRow8.Size = new System.Drawing.Size(273, 42);
            this.labelRow8.TabIndex = 7;
            this.labelRow8.Text = "8 -    8 000";
            this.labelRow8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRow9
            // 
            this.labelRow9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelRow9.ForeColor = System.Drawing.Color.Yellow;
            this.labelRow9.Location = new System.Drawing.Point(12, 225);
            this.labelRow9.Name = "labelRow9";
            this.labelRow9.Size = new System.Drawing.Size(273, 42);
            this.labelRow9.TabIndex = 8;
            this.labelRow9.Text = "9 -   16 000";
            this.labelRow9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRow10
            // 
            this.labelRow10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelRow10.ForeColor = System.Drawing.Color.Goldenrod;
            this.labelRow10.Location = new System.Drawing.Point(12, 190);
            this.labelRow10.Name = "labelRow10";
            this.labelRow10.Size = new System.Drawing.Size(273, 42);
            this.labelRow10.TabIndex = 9;
            this.labelRow10.Text = "10 -   32 000";
            this.labelRow10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRow11
            // 
            this.labelRow11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelRow11.ForeColor = System.Drawing.Color.Yellow;
            this.labelRow11.Location = new System.Drawing.Point(12, 156);
            this.labelRow11.Name = "labelRow11";
            this.labelRow11.Size = new System.Drawing.Size(273, 42);
            this.labelRow11.TabIndex = 10;
            this.labelRow11.Text = "11 -   64 000";
            this.labelRow11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRow12
            // 
            this.labelRow12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelRow12.ForeColor = System.Drawing.Color.Yellow;
            this.labelRow12.Location = new System.Drawing.Point(12, 122);
            this.labelRow12.Name = "labelRow12";
            this.labelRow12.Size = new System.Drawing.Size(273, 42);
            this.labelRow12.TabIndex = 11;
            this.labelRow12.Text = "12 -  125 000";
            this.labelRow12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRow13
            // 
            this.labelRow13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelRow13.ForeColor = System.Drawing.Color.Yellow;
            this.labelRow13.Location = new System.Drawing.Point(12, 88);
            this.labelRow13.Name = "labelRow13";
            this.labelRow13.Size = new System.Drawing.Size(273, 42);
            this.labelRow13.TabIndex = 12;
            this.labelRow13.Text = "13 -  250 000";
            this.labelRow13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRow14
            // 
            this.labelRow14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelRow14.ForeColor = System.Drawing.Color.Yellow;
            this.labelRow14.Location = new System.Drawing.Point(12, 52);
            this.labelRow14.Name = "labelRow14";
            this.labelRow14.Size = new System.Drawing.Size(273, 42);
            this.labelRow14.TabIndex = 13;
            this.labelRow14.Text = "14 -  500 000";
            this.labelRow14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRow15
            // 
            this.labelRow15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelRow15.ForeColor = System.Drawing.Color.Goldenrod;
            this.labelRow15.Location = new System.Drawing.Point(12, 16);
            this.labelRow15.Name = "labelRow15";
            this.labelRow15.Size = new System.Drawing.Size(273, 42);
            this.labelRow15.TabIndex = 14;
            this.labelRow15.Text = "15 - 1 000 000";
            this.labelRow15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMain
            // 
            this.labelMain.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelMain.ForeColor = System.Drawing.Color.Yellow;
            this.labelMain.Location = new System.Drawing.Point(187, 381);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(673, 109);
            this.labelMain.TabIndex = 15;
            this.labelMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAnswerA
            // 
            this.buttonAnswerA.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAnswerA.ForeColor = System.Drawing.Color.Gold;
            this.buttonAnswerA.Location = new System.Drawing.Point(182, 512);
            this.buttonAnswerA.Name = "buttonAnswerA";
            this.buttonAnswerA.Size = new System.Drawing.Size(322, 68);
            this.buttonAnswerA.TabIndex = 16;
            this.buttonAnswerA.Text = "A: ";
            this.buttonAnswerA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnswerA.UseVisualStyleBackColor = false;
            this.buttonAnswerA.Click += new System.EventHandler(this.buttonAnswerA_Click);
            // 
            // buttonAnswerB
            // 
            this.buttonAnswerB.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAnswerB.ForeColor = System.Drawing.Color.Gold;
            this.buttonAnswerB.Location = new System.Drawing.Point(538, 512);
            this.buttonAnswerB.Name = "buttonAnswerB";
            this.buttonAnswerB.Size = new System.Drawing.Size(322, 68);
            this.buttonAnswerB.TabIndex = 17;
            this.buttonAnswerB.Text = "B: ";
            this.buttonAnswerB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnswerB.UseVisualStyleBackColor = false;
            this.buttonAnswerB.Click += new System.EventHandler(this.buttonAnswerB_Click);
            // 
            // buttonAnswerC
            // 
            this.buttonAnswerC.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAnswerC.ForeColor = System.Drawing.Color.Gold;
            this.buttonAnswerC.Location = new System.Drawing.Point(182, 604);
            this.buttonAnswerC.Name = "buttonAnswerC";
            this.buttonAnswerC.Size = new System.Drawing.Size(322, 68);
            this.buttonAnswerC.TabIndex = 18;
            this.buttonAnswerC.Text = "C: ";
            this.buttonAnswerC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnswerC.UseVisualStyleBackColor = false;
            this.buttonAnswerC.Click += new System.EventHandler(this.buttonAnswerC_Click);
            // 
            // buttonAnswerD
            // 
            this.buttonAnswerD.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAnswerD.ForeColor = System.Drawing.Color.Gold;
            this.buttonAnswerD.Location = new System.Drawing.Point(538, 604);
            this.buttonAnswerD.Name = "buttonAnswerD";
            this.buttonAnswerD.Size = new System.Drawing.Size(322, 68);
            this.buttonAnswerD.TabIndex = 19;
            this.buttonAnswerD.Text = "D: ";
            this.buttonAnswerD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnswerD.UseVisualStyleBackColor = false;
            this.buttonAnswerD.Click += new System.EventHandler(this.buttonAnswerD_Click);
            // 
            // labelRightAnswer
            // 
            this.labelRightAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelRightAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelRightAnswer.ForeColor = System.Drawing.Color.Yellow;
            this.labelRightAnswer.Location = new System.Drawing.Point(548, 325);
            this.labelRightAnswer.Name = "labelRightAnswer";
            this.labelRightAnswer.Size = new System.Drawing.Size(206, 38);
            this.labelRightAnswer.TabIndex = 21;
            this.labelRightAnswer.Text = "Правильно!!!";
            this.labelRightAnswer.Visible = false;
            // 
            // buttonPlayAgainYes
            // 
            this.buttonPlayAgainYes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPlayAgainYes.ForeColor = System.Drawing.Color.Gold;
            this.buttonPlayAgainYes.Location = new System.Drawing.Point(182, 512);
            this.buttonPlayAgainYes.Name = "buttonPlayAgainYes";
            this.buttonPlayAgainYes.Size = new System.Drawing.Size(322, 68);
            this.buttonPlayAgainYes.TabIndex = 24;
            this.buttonPlayAgainYes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPlayAgainYes.UseVisualStyleBackColor = false;
            this.buttonPlayAgainYes.Visible = false;
            this.buttonPlayAgainYes.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // buttonPlayAgainNo
            // 
            this.buttonPlayAgainNo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPlayAgainNo.ForeColor = System.Drawing.Color.Gold;
            this.buttonPlayAgainNo.Location = new System.Drawing.Point(538, 512);
            this.buttonPlayAgainNo.Name = "buttonPlayAgainNo";
            this.buttonPlayAgainNo.Size = new System.Drawing.Size(322, 68);
            this.buttonPlayAgainNo.TabIndex = 25;
            this.buttonPlayAgainNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPlayAgainNo.UseVisualStyleBackColor = false;
            this.buttonPlayAgainNo.Visible = false;
            this.buttonPlayAgainNo.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // timerRightAnswers
            // 
            this.timerRightAnswers.Interval = 3500;
            this.timerRightAnswers.Tick += new System.EventHandler(this.timerRightAnswers_Tick);
            // 
            // timerWrongAnswers
            // 
            this.timerWrongAnswers.Interval = 4000;
            this.timerWrongAnswers.Tick += new System.EventHandler(this.timerWrongAnswers_Tick);
            // 
            // labelFriendAnswer
            // 
            this.labelFriendAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelFriendAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelFriendAnswer.ForeColor = System.Drawing.Color.Yellow;
            this.labelFriendAnswer.Location = new System.Drawing.Point(342, 149);
            this.labelFriendAnswer.Name = "labelFriendAnswer";
            this.labelFriendAnswer.Size = new System.Drawing.Size(404, 80);
            this.labelFriendAnswer.TabIndex = 27;
            this.labelFriendAnswer.Text = "Думаю, правильный ответ - ";
            this.labelFriendAnswer.Visible = false;
            // 
            // groupBoxPeopleHelp
            // 
            this.groupBoxPeopleHelp.BackColor = System.Drawing.Color.Blue;
            this.groupBoxPeopleHelp.Controls.Add(this.progressBarPeopleHeplD);
            this.groupBoxPeopleHelp.Controls.Add(this.progressBarPeopleHeplC);
            this.groupBoxPeopleHelp.Controls.Add(this.progressBarPeopleHeplB);
            this.groupBoxPeopleHelp.Controls.Add(this.progressBarPeopleHeplA);
            this.groupBoxPeopleHelp.Controls.Add(this.labelPeopleHeplD);
            this.groupBoxPeopleHelp.Controls.Add(this.labelPeopleHeplC);
            this.groupBoxPeopleHelp.Controls.Add(this.labelPeopleHeplB);
            this.groupBoxPeopleHelp.Controls.Add(this.labelPeopleHeplA);
            this.groupBoxPeopleHelp.ForeColor = System.Drawing.Color.Gold;
            this.groupBoxPeopleHelp.Location = new System.Drawing.Point(681, 15);
            this.groupBoxPeopleHelp.Name = "groupBoxPeopleHelp";
            this.groupBoxPeopleHelp.Size = new System.Drawing.Size(174, 162);
            this.groupBoxPeopleHelp.TabIndex = 28;
            this.groupBoxPeopleHelp.TabStop = false;
            this.groupBoxPeopleHelp.Text = "Помощь зала";
            this.groupBoxPeopleHelp.Visible = false;
            // 
            // progressBarPeopleHeplD
            // 
            this.progressBarPeopleHeplD.Location = new System.Drawing.Point(69, 127);
            this.progressBarPeopleHeplD.Name = "progressBarPeopleHeplD";
            this.progressBarPeopleHeplD.Size = new System.Drawing.Size(97, 21);
            this.progressBarPeopleHeplD.TabIndex = 7;
            // 
            // progressBarPeopleHeplC
            // 
            this.progressBarPeopleHeplC.Location = new System.Drawing.Point(69, 97);
            this.progressBarPeopleHeplC.Name = "progressBarPeopleHeplC";
            this.progressBarPeopleHeplC.Size = new System.Drawing.Size(97, 21);
            this.progressBarPeopleHeplC.TabIndex = 6;
            // 
            // progressBarPeopleHeplB
            // 
            this.progressBarPeopleHeplB.Location = new System.Drawing.Point(69, 63);
            this.progressBarPeopleHeplB.Name = "progressBarPeopleHeplB";
            this.progressBarPeopleHeplB.Size = new System.Drawing.Size(97, 21);
            this.progressBarPeopleHeplB.TabIndex = 5;
            // 
            // progressBarPeopleHeplA
            // 
            this.progressBarPeopleHeplA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.progressBarPeopleHeplA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.progressBarPeopleHeplA.Location = new System.Drawing.Point(69, 32);
            this.progressBarPeopleHeplA.Name = "progressBarPeopleHeplA";
            this.progressBarPeopleHeplA.Size = new System.Drawing.Size(97, 21);
            this.progressBarPeopleHeplA.TabIndex = 4;
            // 
            // labelPeopleHeplD
            // 
            this.labelPeopleHeplD.AutoSize = true;
            this.labelPeopleHeplD.Location = new System.Drawing.Point(7, 128);
            this.labelPeopleHeplD.Name = "labelPeopleHeplD";
            this.labelPeopleHeplD.Size = new System.Drawing.Size(37, 20);
            this.labelPeopleHeplD.TabIndex = 3;
            this.labelPeopleHeplD.Text = "D:   ";
            // 
            // labelPeopleHeplC
            // 
            this.labelPeopleHeplC.AutoSize = true;
            this.labelPeopleHeplC.Location = new System.Drawing.Point(6, 98);
            this.labelPeopleHeplC.Name = "labelPeopleHeplC";
            this.labelPeopleHeplC.Size = new System.Drawing.Size(36, 20);
            this.labelPeopleHeplC.TabIndex = 2;
            this.labelPeopleHeplC.Text = "C:   ";
            // 
            // labelPeopleHeplB
            // 
            this.labelPeopleHeplB.AutoSize = true;
            this.labelPeopleHeplB.Location = new System.Drawing.Point(6, 64);
            this.labelPeopleHeplB.Name = "labelPeopleHeplB";
            this.labelPeopleHeplB.Size = new System.Drawing.Size(36, 20);
            this.labelPeopleHeplB.TabIndex = 1;
            this.labelPeopleHeplB.Text = "B:   ";
            // 
            // labelPeopleHeplA
            // 
            this.labelPeopleHeplA.AutoSize = true;
            this.labelPeopleHeplA.Location = new System.Drawing.Point(7, 32);
            this.labelPeopleHeplA.Name = "labelPeopleHeplA";
            this.labelPeopleHeplA.Size = new System.Drawing.Size(36, 20);
            this.labelPeopleHeplA.TabIndex = 0;
            this.labelPeopleHeplA.Text = "A:   ";
            // 
            // pictureBoxMoney
            // 
            this.pictureBoxMoney.Image = global::миллионер.Properties.Resources.Vifrash;
            this.pictureBoxMoney.Location = new System.Drawing.Point(182, 512);
            this.pictureBoxMoney.Name = "pictureBoxMoney";
            this.pictureBoxMoney.Size = new System.Drawing.Size(678, 314);
            this.pictureBoxMoney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMoney.TabIndex = 29;
            this.pictureBoxMoney.TabStop = false;
            this.pictureBoxMoney.Visible = false;
            // 
            // pictureBoxFriend
            // 
            this.pictureBoxFriend.Image = global::миллионер.Properties.Resources.zvonok;
            this.pictureBoxFriend.Location = new System.Drawing.Point(128, 149);
            this.pictureBoxFriend.Name = "pictureBoxFriend";
            this.pictureBoxFriend.Size = new System.Drawing.Size(138, 110);
            this.pictureBoxFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFriend.TabIndex = 26;
            this.pictureBoxFriend.TabStop = false;
            this.pictureBoxFriend.Visible = false;
            // 
            // pictureBoxRightAnswer
            // 
            this.pictureBoxRightAnswer.Image = global::миллионер.Properties.Resources.Безымянный;
            this.pictureBoxRightAnswer.Location = new System.Drawing.Point(752, 210);
            this.pictureBoxRightAnswer.Name = "pictureBoxRightAnswer";
            this.pictureBoxRightAnswer.Size = new System.Drawing.Size(80, 100);
            this.pictureBoxRightAnswer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxRightAnswer.TabIndex = 20;
            this.pictureBoxRightAnswer.TabStop = false;
            this.pictureBoxRightAnswer.Visible = false;
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNewGame.Image = global::миллионер.Properties.Resources._new;
            this.buttonNewGame.Location = new System.Drawing.Point(12, 49);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(90, 62);
            this.buttonNewGame.TabIndex = 2;
            this.buttonNewGame.UseVisualStyleBackColor = false;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Image = global::миллионер.Properties.Resources.Exit;
            this.buttonExit.Location = new System.Drawing.Point(108, 49);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(90, 62);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxBackground.Image = global::миллионер.Properties.Resources.mil;
            this.pictureBoxBackground.Location = new System.Drawing.Point(0, 33);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(1027, 667);
            this.pictureBoxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackground.TabIndex = 5;
            this.pictureBoxBackground.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GameToolStripMenuItem,
            this.AdminToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1176, 33);
            this.menuStrip.TabIndex = 30;
            this.menuStrip.Text = "menuStrip1";
            // 
            // GameToolStripMenuItem
            // 
            this.GameToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.GameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGameToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.GameToolStripMenuItem.ForeColor = System.Drawing.Color.Goldenrod;
            this.GameToolStripMenuItem.Name = "GameToolStripMenuItem";
            this.GameToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.GameToolStripMenuItem.Size = new System.Drawing.Size(68, 29);
            this.GameToolStripMenuItem.Text = "Игра";
            // 
            // NewGameToolStripMenuItem
            // 
            this.NewGameToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.NewGameToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem";
            this.NewGameToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+N";
            this.NewGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewGameToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.NewGameToolStripMenuItem.Text = "Новая игра";
            this.NewGameToolStripMenuItem.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Q";
            this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // AdminToolStripMenuItem
            // 
            this.AdminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddQuestionToolStripMenuItem,
            this.EditQuestionToolStripMenuItem,
            this.DeleteQuestionToolStripMenuItem});
            this.AdminToolStripMenuItem.ForeColor = System.Drawing.Color.Goldenrod;
            this.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem";
            this.AdminToolStripMenuItem.Size = new System.Drawing.Size(255, 29);
            this.AdminToolStripMenuItem.Text = "Администраторский режим";
            // 
            // AddQuestionToolStripMenuItem
            // 
            this.AddQuestionToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.AddQuestionToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.AddQuestionToolStripMenuItem.Name = "AddQuestionToolStripMenuItem";
            this.AddQuestionToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+A";
            this.AddQuestionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.AddQuestionToolStripMenuItem.Size = new System.Drawing.Size(361, 34);
            this.AddQuestionToolStripMenuItem.Text = "Добавить вопрос";
            this.AddQuestionToolStripMenuItem.Click += new System.EventHandler(this.AddQuestionToolStripMenuItem_Click);
            // 
            // EditQuestionToolStripMenuItem
            // 
            this.EditQuestionToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.EditQuestionToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.EditQuestionToolStripMenuItem.Name = "EditQuestionToolStripMenuItem";
            this.EditQuestionToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+E";
            this.EditQuestionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.EditQuestionToolStripMenuItem.Size = new System.Drawing.Size(361, 34);
            this.EditQuestionToolStripMenuItem.Text = "Редактировать вопрос";
            this.EditQuestionToolStripMenuItem.Click += new System.EventHandler(this.EditQuestionToolStripMenuItem_Click);
            // 
            // DeleteQuestionToolStripMenuItem
            // 
            this.DeleteQuestionToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.DeleteQuestionToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.DeleteQuestionToolStripMenuItem.Name = "DeleteQuestionToolStripMenuItem";
            this.DeleteQuestionToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+D";
            this.DeleteQuestionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.DeleteQuestionToolStripMenuItem.Size = new System.Drawing.Size(361, 34);
            this.DeleteQuestionToolStripMenuItem.Text = "Удалить вопрос";
            this.DeleteQuestionToolStripMenuItem.Click += new System.EventHandler(this.DeleteQuestionToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.Goldenrod;
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(141, 29);
            this.AboutToolStripMenuItem.Text = "О программе";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 700);
            this.Controls.Add(this.pictureBoxMoney);
            this.Controls.Add(this.groupBoxPeopleHelp);
            this.Controls.Add(this.labelFriendAnswer);
            this.Controls.Add(this.pictureBoxFriend);
            this.Controls.Add(this.buttonPlayAgainNo);
            this.Controls.Add(this.buttonPlayAgainYes);
            this.Controls.Add(this.labelRightAnswer);
            this.Controls.Add(this.pictureBoxRightAnswer);
            this.Controls.Add(this.buttonAnswerD);
            this.Controls.Add(this.buttonAnswerC);
            this.Controls.Add(this.buttonAnswerB);
            this.Controls.Add(this.buttonAnswerA);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.panelRows);
            this.Controls.Add(this.groupBoxHelp);
            this.Controls.Add(this.labelBackground);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.pictureBoxBackground);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кто хочет стать миллионером";
            this.groupBoxHelp.ResumeLayout(false);
            this.panelRows.ResumeLayout(false);
            this.groupBoxPeopleHelp.ResumeLayout(false);
            this.groupBoxPeopleHelp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightAnswer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.PictureBox pictureBoxBackground;
        private System.Windows.Forms.Label labelBackground;
        private System.Windows.Forms.GroupBox groupBoxHelp;
        private System.Windows.Forms.Button buttonPeople;
        private System.Windows.Forms.Button buttonCallFriend;
        private System.Windows.Forms.Button buttonHalfAnswers;
        private System.Windows.Forms.Panel panelRows;
        private System.Windows.Forms.Label labelRow1;
        private System.Windows.Forms.Label labelRow11;
        private System.Windows.Forms.Label labelRow15;
        private System.Windows.Forms.Label labelRow14;
        private System.Windows.Forms.Label labelRow13;
        private System.Windows.Forms.Label labelRow12;
        private System.Windows.Forms.Label labelRow10;
        private System.Windows.Forms.Label labelRow9;
        private System.Windows.Forms.Label labelRow8;
        private System.Windows.Forms.Label labelRow7;
        private System.Windows.Forms.Label labelRow6;
        private System.Windows.Forms.Label labelRow5;
        private System.Windows.Forms.Label labelRow4;
        private System.Windows.Forms.Label labelRow3;
        private System.Windows.Forms.Label labelRow2;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Button buttonAnswerB;
        private System.Windows.Forms.Button buttonAnswerC;
        private System.Windows.Forms.Button buttonAnswerD;
        private System.Windows.Forms.Button buttonAnswerA;
        private System.Windows.Forms.PictureBox pictureBoxRightAnswer;
        private System.Windows.Forms.Label labelRightAnswer;
        private System.Windows.Forms.Button buttonPlayAgainYes;
        private System.Windows.Forms.Button buttonPlayAgainNo;
        private System.Windows.Forms.Timer timerRightAnswers;
        private System.Windows.Forms.Timer timerWrongAnswers;
        private System.Windows.Forms.PictureBox pictureBoxFriend;
        private System.Windows.Forms.Label labelFriendAnswer;
        private System.Windows.Forms.GroupBox groupBoxPeopleHelp;
        private System.Windows.Forms.Label labelPeopleHeplA;
        private System.Windows.Forms.Label labelPeopleHeplD;
        private System.Windows.Forms.Label labelPeopleHeplC;
        private System.Windows.Forms.Label labelPeopleHeplB;
        private System.Windows.Forms.ProgressBar progressBarPeopleHeplA;
        private System.Windows.Forms.ProgressBar progressBarPeopleHeplD;
        private System.Windows.Forms.ProgressBar progressBarPeopleHeplC;
        private System.Windows.Forms.ProgressBar progressBarPeopleHeplB;
        private System.Windows.Forms.PictureBox pictureBoxMoney;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem GameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
    }
}

