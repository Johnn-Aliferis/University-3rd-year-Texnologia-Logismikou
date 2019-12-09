namespace Texnologia_v1
{
    partial class Main_page
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_page));
            this.Title_panel = new System.Windows.Forms.Panel();
            this.Score_button = new System.Windows.Forms.Button();
            this.About_button = new System.Windows.Forms.Button();
            this.Quiz_button = new System.Windows.Forms.Button();
            this.Theory_button = new System.Windows.Forms.Button();
            this.Logout_button = new System.Windows.Forms.Button();
            this.Title_label = new System.Windows.Forms.Label();
            this.Close_picturebox = new System.Windows.Forms.PictureBox();
            this.Welcome_label = new System.Windows.Forms.Label();
            this.Name_label = new System.Windows.Forms.Label();
            this.quiz_panel = new System.Windows.Forms.Panel();
            this.question_richtextbox = new System.Windows.Forms.RichTextBox();
            this.answer_4 = new System.Windows.Forms.RadioButton();
            this.answer_3 = new System.Windows.Forms.RadioButton();
            this.answer_2 = new System.Windows.Forms.RadioButton();
            this.answer_1 = new System.Windows.Forms.RadioButton();
            this.Answer_label = new System.Windows.Forms.Label();
            this.question_label_title = new System.Windows.Forms.Label();
            this.question_label = new System.Windows.Forms.Label();
            this.timer_count_label = new System.Windows.Forms.Label();
            this.question_number_label = new System.Windows.Forms.Label();
            this.Previous_picturebox = new System.Windows.Forms.PictureBox();
            this.Next_picturebox = new System.Windows.Forms.PictureBox();
            this.Hard_picturebox = new System.Windows.Forms.PictureBox();
            this.Medium_picturebox = new System.Windows.Forms.PictureBox();
            this.Hard_label = new System.Windows.Forms.Label();
            this.Medium_label = new System.Windows.Forms.Label();
            this.Easy_label = new System.Windows.Forms.Label();
            this.Easy_picturebox = new System.Windows.Forms.PictureBox();
            this.Select_difficulty_label = new System.Windows.Forms.Label();
            this.datetimenow_label = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.last_signin = new System.Windows.Forms.Label();
            this.Theory_panel = new System.Windows.Forms.Panel();
            this.pdf_reader = new AxAcroPDFLib.AxAcroPDF();
            this.instructions_label = new System.Windows.Forms.Label();
            this.back_arrow_for_theory = new System.Windows.Forms.PictureBox();
            this.Second_theory_label = new System.Windows.Forms.Label();
            this.second_theory_picturebox = new System.Windows.Forms.PictureBox();
            this.first_theory_picturebox = new System.Windows.Forms.PictureBox();
            this.First_theory_label = new System.Windows.Forms.Label();
            this.Select_theory_label = new System.Windows.Forms.Label();
            this.Math_picturebox = new System.Windows.Forms.PictureBox();
            this.My_Scores_panel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hard_bt = new System.Windows.Forms.Button();
            this.med_bt = new System.Windows.Forms.Button();
            this.easy_bt = new System.Windows.Forms.Button();
            this.global_bt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.personal_bt = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.About_panel = new System.Windows.Forms.Panel();
            this.about_text_label = new System.Windows.Forms.Label();
            this.Title_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close_picturebox)).BeginInit();
            this.quiz_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Previous_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Next_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hard_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Medium_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Easy_picturebox)).BeginInit();
            this.Theory_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdf_reader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_arrow_for_theory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.second_theory_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_theory_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Math_picturebox)).BeginInit();
            this.My_Scores_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.About_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title_panel
            // 
            this.Title_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.Title_panel.Controls.Add(this.Score_button);
            this.Title_panel.Controls.Add(this.About_button);
            this.Title_panel.Controls.Add(this.Quiz_button);
            this.Title_panel.Controls.Add(this.Theory_button);
            this.Title_panel.Controls.Add(this.Logout_button);
            this.Title_panel.Controls.Add(this.Title_label);
            this.Title_panel.Controls.Add(this.Close_picturebox);
            this.Title_panel.Location = new System.Drawing.Point(0, 0);
            this.Title_panel.Name = "Title_panel";
            this.Title_panel.Size = new System.Drawing.Size(806, 53);
            this.Title_panel.TabIndex = 1;
            this.Title_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Title_panel_Paint);
            // 
            // Score_button
            // 
            this.Score_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Score_button.FlatAppearance.BorderSize = 0;
            this.Score_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Score_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score_button.ForeColor = System.Drawing.Color.LightBlue;
            this.Score_button.Location = new System.Drawing.Point(470, 1);
            this.Score_button.Name = "Score_button";
            this.Score_button.Size = new System.Drawing.Size(91, 51);
            this.Score_button.TabIndex = 6;
            this.Score_button.Text = "My scores";
            this.Score_button.UseVisualStyleBackColor = true;
            this.Score_button.Click += new System.EventHandler(this.Score_button_Click);
            this.Score_button.MouseEnter += new System.EventHandler(this.Score_button_MouseEnter);
            this.Score_button.MouseLeave += new System.EventHandler(this.Score_button_MouseLeave);
            // 
            // About_button
            // 
            this.About_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.About_button.FlatAppearance.BorderSize = 0;
            this.About_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About_button.ForeColor = System.Drawing.Color.LightBlue;
            this.About_button.Location = new System.Drawing.Point(581, 1);
            this.About_button.Name = "About_button";
            this.About_button.Size = new System.Drawing.Size(91, 51);
            this.About_button.TabIndex = 5;
            this.About_button.Text = "About";
            this.About_button.UseVisualStyleBackColor = true;
            this.About_button.Click += new System.EventHandler(this.About_button_Click);
            this.About_button.MouseEnter += new System.EventHandler(this.About_button_MouseEnter);
            this.About_button.MouseLeave += new System.EventHandler(this.About_button_MouseLeave);
            // 
            // Quiz_button
            // 
            this.Quiz_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Quiz_button.FlatAppearance.BorderSize = 0;
            this.Quiz_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quiz_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quiz_button.ForeColor = System.Drawing.Color.LightBlue;
            this.Quiz_button.Location = new System.Drawing.Point(360, 1);
            this.Quiz_button.Name = "Quiz_button";
            this.Quiz_button.Size = new System.Drawing.Size(91, 51);
            this.Quiz_button.TabIndex = 3;
            this.Quiz_button.Text = "Take quiz";
            this.Quiz_button.UseVisualStyleBackColor = true;
            this.Quiz_button.Click += new System.EventHandler(this.Quiz_button_Click);
            this.Quiz_button.MouseEnter += new System.EventHandler(this.Quiz_button_MouseEnter);
            this.Quiz_button.MouseLeave += new System.EventHandler(this.Quiz_button_MouseLeave);
            // 
            // Theory_button
            // 
            this.Theory_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Theory_button.FlatAppearance.BorderSize = 0;
            this.Theory_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Theory_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Theory_button.ForeColor = System.Drawing.Color.LightBlue;
            this.Theory_button.Location = new System.Drawing.Point(263, 1);
            this.Theory_button.Name = "Theory_button";
            this.Theory_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Theory_button.Size = new System.Drawing.Size(91, 51);
            this.Theory_button.TabIndex = 3;
            this.Theory_button.Text = "Theory";
            this.Theory_button.UseVisualStyleBackColor = true;
            this.Theory_button.Click += new System.EventHandler(this.Theory_button_Click);
            this.Theory_button.MouseEnter += new System.EventHandler(this.Theory_button_MouseEnter);
            this.Theory_button.MouseLeave += new System.EventHandler(this.Theory_button_MouseLeave);
            // 
            // Logout_button
            // 
            this.Logout_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout_button.FlatAppearance.BorderSize = 0;
            this.Logout_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_button.ForeColor = System.Drawing.Color.LightBlue;
            this.Logout_button.Location = new System.Drawing.Point(673, 1);
            this.Logout_button.Name = "Logout_button";
            this.Logout_button.Size = new System.Drawing.Size(91, 51);
            this.Logout_button.TabIndex = 2;
            this.Logout_button.Text = "Logout";
            this.Logout_button.UseVisualStyleBackColor = true;
            this.Logout_button.Click += new System.EventHandler(this.Logout_button_Click);
            this.Logout_button.MouseEnter += new System.EventHandler(this.Logout_button_MouseEnter);
            this.Logout_button.MouseLeave += new System.EventHandler(this.Logout_button_MouseLeave);
            // 
            // Title_label
            // 
            this.Title_label.AutoSize = true;
            this.Title_label.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_label.ForeColor = System.Drawing.Color.LightBlue;
            this.Title_label.Location = new System.Drawing.Point(12, 12);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(169, 24);
            this.Title_label.TabIndex = 1;
            this.Title_label.Text = "Math - Learning";
            // 
            // Close_picturebox
            // 
            this.Close_picturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_picturebox.Image = global::Texnologia_v1.Properties.Resources.Delete_White;
            this.Close_picturebox.Location = new System.Drawing.Point(770, 0);
            this.Close_picturebox.Name = "Close_picturebox";
            this.Close_picturebox.Size = new System.Drawing.Size(30, 30);
            this.Close_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Close_picturebox.TabIndex = 0;
            this.Close_picturebox.TabStop = false;
            this.Close_picturebox.Click += new System.EventHandler(this.Close_picturebox_Click);
            this.Close_picturebox.MouseEnter += new System.EventHandler(this.Close_picturebox_MouseEnter);
            this.Close_picturebox.MouseLeave += new System.EventHandler(this.Close_picturebox_MouseLeave);
            // 
            // Welcome_label
            // 
            this.Welcome_label.AutoSize = true;
            this.Welcome_label.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_label.ForeColor = System.Drawing.Color.LightBlue;
            this.Welcome_label.Location = new System.Drawing.Point(298, 86);
            this.Welcome_label.Name = "Welcome_label";
            this.Welcome_label.Size = new System.Drawing.Size(160, 33);
            this.Welcome_label.TabIndex = 6;
            this.Welcome_label.Text = "Welcome :";
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_label.ForeColor = System.Drawing.Color.LightBlue;
            this.Name_label.Location = new System.Drawing.Point(298, 181);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(113, 33);
            this.Name_label.TabIndex = 7;
            this.Name_label.Text = "Name !";
            // 
            // quiz_panel
            // 
            this.quiz_panel.Controls.Add(this.question_richtextbox);
            this.quiz_panel.Controls.Add(this.answer_4);
            this.quiz_panel.Controls.Add(this.answer_3);
            this.quiz_panel.Controls.Add(this.answer_2);
            this.quiz_panel.Controls.Add(this.answer_1);
            this.quiz_panel.Controls.Add(this.Answer_label);
            this.quiz_panel.Controls.Add(this.question_label_title);
            this.quiz_panel.Controls.Add(this.question_label);
            this.quiz_panel.Controls.Add(this.timer_count_label);
            this.quiz_panel.Controls.Add(this.question_number_label);
            this.quiz_panel.Controls.Add(this.Previous_picturebox);
            this.quiz_panel.Controls.Add(this.Next_picturebox);
            this.quiz_panel.Controls.Add(this.Hard_picturebox);
            this.quiz_panel.Controls.Add(this.Medium_picturebox);
            this.quiz_panel.Controls.Add(this.Hard_label);
            this.quiz_panel.Controls.Add(this.Medium_label);
            this.quiz_panel.Controls.Add(this.Easy_label);
            this.quiz_panel.Controls.Add(this.Easy_picturebox);
            this.quiz_panel.Controls.Add(this.Select_difficulty_label);
            this.quiz_panel.Location = new System.Drawing.Point(263, 53);
            this.quiz_panel.Name = "quiz_panel";
            this.quiz_panel.Size = new System.Drawing.Size(537, 395);
            this.quiz_panel.TabIndex = 8;
            this.quiz_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.quiz_panel_Paint);
            // 
            // question_richtextbox
            // 
            this.question_richtextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.question_richtextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.question_richtextbox.ForeColor = System.Drawing.Color.LightBlue;
            this.question_richtextbox.Location = new System.Drawing.Point(31, 118);
            this.question_richtextbox.Name = "question_richtextbox";
            this.question_richtextbox.Size = new System.Drawing.Size(492, 112);
            this.question_richtextbox.TabIndex = 26;
            this.question_richtextbox.Text = "";
            this.question_richtextbox.TextChanged += new System.EventHandler(this.question_richtextbox_TextChanged);
            // 
            // answer_4
            // 
            this.answer_4.AutoSize = true;
            this.answer_4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer_4.ForeColor = System.Drawing.Color.LightBlue;
            this.answer_4.Location = new System.Drawing.Point(289, 315);
            this.answer_4.Name = "answer_4";
            this.answer_4.Size = new System.Drawing.Size(39, 20);
            this.answer_4.TabIndex = 24;
            this.answer_4.TabStop = true;
            this.answer_4.Tag = "4";
            this.answer_4.Text = "D)";
            this.answer_4.UseVisualStyleBackColor = true;
            // 
            // answer_3
            // 
            this.answer_3.AutoSize = true;
            this.answer_3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer_3.ForeColor = System.Drawing.Color.LightBlue;
            this.answer_3.Location = new System.Drawing.Point(289, 274);
            this.answer_3.Name = "answer_3";
            this.answer_3.Size = new System.Drawing.Size(40, 20);
            this.answer_3.TabIndex = 23;
            this.answer_3.TabStop = true;
            this.answer_3.Tag = "3";
            this.answer_3.Text = "C)";
            this.answer_3.UseVisualStyleBackColor = true;
            // 
            // answer_2
            // 
            this.answer_2.AutoSize = true;
            this.answer_2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer_2.ForeColor = System.Drawing.Color.LightBlue;
            this.answer_2.Location = new System.Drawing.Point(39, 315);
            this.answer_2.Name = "answer_2";
            this.answer_2.Size = new System.Drawing.Size(37, 20);
            this.answer_2.TabIndex = 22;
            this.answer_2.TabStop = true;
            this.answer_2.Tag = "2";
            this.answer_2.Text = "B)";
            this.answer_2.UseVisualStyleBackColor = true;
            // 
            // answer_1
            // 
            this.answer_1.AutoSize = true;
            this.answer_1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer_1.ForeColor = System.Drawing.Color.LightBlue;
            this.answer_1.Location = new System.Drawing.Point(39, 274);
            this.answer_1.Name = "answer_1";
            this.answer_1.Size = new System.Drawing.Size(39, 20);
            this.answer_1.TabIndex = 21;
            this.answer_1.TabStop = true;
            this.answer_1.Tag = "1";
            this.answer_1.Text = "A)";
            this.answer_1.UseVisualStyleBackColor = true;
            // 
            // Answer_label
            // 
            this.Answer_label.AutoSize = true;
            this.Answer_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer_label.ForeColor = System.Drawing.Color.LightBlue;
            this.Answer_label.Location = new System.Drawing.Point(35, 233);
            this.Answer_label.Name = "Answer_label";
            this.Answer_label.Size = new System.Drawing.Size(72, 20);
            this.Answer_label.TabIndex = 20;
            this.Answer_label.Text = "Answer :";
            // 
            // question_label_title
            // 
            this.question_label_title.AutoSize = true;
            this.question_label_title.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question_label_title.ForeColor = System.Drawing.Color.LightBlue;
            this.question_label_title.Location = new System.Drawing.Point(28, 91);
            this.question_label_title.Name = "question_label_title";
            this.question_label_title.Size = new System.Drawing.Size(82, 20);
            this.question_label_title.TabIndex = 19;
            this.question_label_title.Text = "Question :";
            // 
            // question_label
            // 
            this.question_label.AutoSize = true;
            this.question_label.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.question_label.ForeColor = System.Drawing.Color.LightBlue;
            this.question_label.Location = new System.Drawing.Point(28, 128);
            this.question_label.Name = "question_label";
            this.question_label.Size = new System.Drawing.Size(97, 17);
            this.question_label.TabIndex = 18;
            this.question_label.Text = "Question_label";
            // 
            // timer_count_label
            // 
            this.timer_count_label.AutoSize = true;
            this.timer_count_label.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_count_label.ForeColor = System.Drawing.Color.LightBlue;
            this.timer_count_label.Location = new System.Drawing.Point(6, 350);
            this.timer_count_label.Name = "timer_count_label";
            this.timer_count_label.Size = new System.Drawing.Size(75, 24);
            this.timer_count_label.TabIndex = 17;
            this.timer_count_label.Text = "00 : 00";
            // 
            // question_number_label
            // 
            this.question_number_label.AutoSize = true;
            this.question_number_label.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question_number_label.ForeColor = System.Drawing.Color.LightBlue;
            this.question_number_label.Location = new System.Drawing.Point(444, 22);
            this.question_number_label.Name = "question_number_label";
            this.question_number_label.Size = new System.Drawing.Size(55, 24);
            this.question_number_label.TabIndex = 16;
            this.question_number_label.Text = "1/10";
            // 
            // Previous_picturebox
            // 
            this.Previous_picturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Previous_picturebox.Image = global::Texnologia_v1.Properties.Resources.Left_arrow;
            this.Previous_picturebox.Location = new System.Drawing.Point(389, 335);
            this.Previous_picturebox.Name = "Previous_picturebox";
            this.Previous_picturebox.Size = new System.Drawing.Size(50, 50);
            this.Previous_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Previous_picturebox.TabIndex = 15;
            this.Previous_picturebox.TabStop = false;
            this.Previous_picturebox.Click += new System.EventHandler(this.Previous_picturebox_Click);
            // 
            // Next_picturebox
            // 
            this.Next_picturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Next_picturebox.Image = global::Texnologia_v1.Properties.Resources.Right_arrow;
            this.Next_picturebox.Location = new System.Drawing.Point(473, 335);
            this.Next_picturebox.Name = "Next_picturebox";
            this.Next_picturebox.Size = new System.Drawing.Size(50, 50);
            this.Next_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Next_picturebox.TabIndex = 14;
            this.Next_picturebox.TabStop = false;
            this.Next_picturebox.Click += new System.EventHandler(this.Next_picturebox_Click);
            // 
            // Hard_picturebox
            // 
            this.Hard_picturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hard_picturebox.Image = global::Texnologia_v1.Properties.Resources.maths_full;
            this.Hard_picturebox.Location = new System.Drawing.Point(67, 260);
            this.Hard_picturebox.Name = "Hard_picturebox";
            this.Hard_picturebox.Size = new System.Drawing.Size(328, 114);
            this.Hard_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hard_picturebox.TabIndex = 13;
            this.Hard_picturebox.TabStop = false;
            this.Hard_picturebox.Click += new System.EventHandler(this.Hard_picturebox_Click);
            // 
            // Medium_picturebox
            // 
            this.Medium_picturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Medium_picturebox.Image = global::Texnologia_v1.Properties.Resources.medium;
            this.Medium_picturebox.Location = new System.Drawing.Point(300, 100);
            this.Medium_picturebox.Name = "Medium_picturebox";
            this.Medium_picturebox.Size = new System.Drawing.Size(157, 114);
            this.Medium_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Medium_picturebox.TabIndex = 12;
            this.Medium_picturebox.TabStop = false;
            this.Medium_picturebox.Click += new System.EventHandler(this.Medium_picturebox_Click);
            // 
            // Hard_label
            // 
            this.Hard_label.AutoSize = true;
            this.Hard_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hard_label.ForeColor = System.Drawing.Color.LightBlue;
            this.Hard_label.Location = new System.Drawing.Point(186, 238);
            this.Hard_label.Name = "Hard_label";
            this.Hard_label.Size = new System.Drawing.Size(86, 19);
            this.Hard_label.TabIndex = 11;
            this.Hard_label.Text = "Random :";
            // 
            // Medium_label
            // 
            this.Medium_label.AutoSize = true;
            this.Medium_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medium_label.ForeColor = System.Drawing.Color.LightBlue;
            this.Medium_label.Location = new System.Drawing.Point(296, 72);
            this.Medium_label.Name = "Medium_label";
            this.Medium_label.Size = new System.Drawing.Size(83, 19);
            this.Medium_label.TabIndex = 10;
            this.Medium_label.Text = "Medium :";
            // 
            // Easy_label
            // 
            this.Easy_label.AutoSize = true;
            this.Easy_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Easy_label.ForeColor = System.Drawing.Color.LightBlue;
            this.Easy_label.Location = new System.Drawing.Point(27, 72);
            this.Easy_label.Name = "Easy_label";
            this.Easy_label.Size = new System.Drawing.Size(51, 19);
            this.Easy_label.TabIndex = 9;
            this.Easy_label.Text = "Easy :";
            // 
            // Easy_picturebox
            // 
            this.Easy_picturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Easy_picturebox.Image = global::Texnologia_v1.Properties.Resources.easy;
            this.Easy_picturebox.Location = new System.Drawing.Point(31, 100);
            this.Easy_picturebox.Name = "Easy_picturebox";
            this.Easy_picturebox.Size = new System.Drawing.Size(157, 114);
            this.Easy_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Easy_picturebox.TabIndex = 8;
            this.Easy_picturebox.TabStop = false;
            this.Easy_picturebox.Click += new System.EventHandler(this.Easy_picturebox_Click);
            // 
            // Select_difficulty_label
            // 
            this.Select_difficulty_label.AutoSize = true;
            this.Select_difficulty_label.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_difficulty_label.ForeColor = System.Drawing.Color.LightBlue;
            this.Select_difficulty_label.Location = new System.Drawing.Point(27, 22);
            this.Select_difficulty_label.Name = "Select_difficulty_label";
            this.Select_difficulty_label.Size = new System.Drawing.Size(175, 24);
            this.Select_difficulty_label.TabIndex = 7;
            this.Select_difficulty_label.Text = "Select difficulty :";
            // 
            // datetimenow_label
            // 
            this.datetimenow_label.AutoSize = true;
            this.datetimenow_label.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimenow_label.ForeColor = System.Drawing.Color.LightBlue;
            this.datetimenow_label.Location = new System.Drawing.Point(298, 357);
            this.datetimenow_label.Name = "datetimenow_label";
            this.datetimenow_label.Size = new System.Drawing.Size(153, 33);
            this.datetimenow_label.TabIndex = 10;
            this.datetimenow_label.Text = "Welcome ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // last_signin
            // 
            this.last_signin.AutoSize = true;
            this.last_signin.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_signin.ForeColor = System.Drawing.Color.LightBlue;
            this.last_signin.Location = new System.Drawing.Point(298, 274);
            this.last_signin.Name = "last_signin";
            this.last_signin.Size = new System.Drawing.Size(187, 33);
            this.last_signin.TabIndex = 9;
            this.last_signin.Text = "Last Sign - in :";
            // 
            // Theory_panel
            // 
            this.Theory_panel.Controls.Add(this.pdf_reader);
            this.Theory_panel.Controls.Add(this.instructions_label);
            this.Theory_panel.Controls.Add(this.back_arrow_for_theory);
            this.Theory_panel.Controls.Add(this.Second_theory_label);
            this.Theory_panel.Controls.Add(this.second_theory_picturebox);
            this.Theory_panel.Controls.Add(this.first_theory_picturebox);
            this.Theory_panel.Controls.Add(this.First_theory_label);
            this.Theory_panel.Controls.Add(this.Select_theory_label);
            this.Theory_panel.Location = new System.Drawing.Point(263, 53);
            this.Theory_panel.Name = "Theory_panel";
            this.Theory_panel.Size = new System.Drawing.Size(537, 395);
            this.Theory_panel.TabIndex = 11;
            // 
            // pdf_reader
            // 
            this.pdf_reader.Enabled = true;
            this.pdf_reader.Location = new System.Drawing.Point(-2, 0);
            this.pdf_reader.Name = "pdf_reader";
            this.pdf_reader.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdf_reader.OcxState")));
            this.pdf_reader.Size = new System.Drawing.Size(537, 318);
            this.pdf_reader.TabIndex = 14;
            // 
            // instructions_label
            // 
            this.instructions_label.AutoSize = true;
            this.instructions_label.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructions_label.ForeColor = System.Drawing.Color.LightBlue;
            this.instructions_label.Location = new System.Drawing.Point(8, 335);
            this.instructions_label.Name = "instructions_label";
            this.instructions_label.Size = new System.Drawing.Size(416, 25);
            this.instructions_label.TabIndex = 7;
            this.instructions_label.Text = "To select another theory click the arrow ";
            // 
            // back_arrow_for_theory
            // 
            this.back_arrow_for_theory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_arrow_for_theory.Image = global::Texnologia_v1.Properties.Resources.Left_arrow;
            this.back_arrow_for_theory.Location = new System.Drawing.Point(473, 324);
            this.back_arrow_for_theory.Name = "back_arrow_for_theory";
            this.back_arrow_for_theory.Size = new System.Drawing.Size(50, 50);
            this.back_arrow_for_theory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back_arrow_for_theory.TabIndex = 13;
            this.back_arrow_for_theory.TabStop = false;
            this.back_arrow_for_theory.Click += new System.EventHandler(this.back_arrow_for_theory_Click);
            // 
            // Second_theory_label
            // 
            this.Second_theory_label.AutoSize = true;
            this.Second_theory_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Second_theory_label.ForeColor = System.Drawing.Color.LightBlue;
            this.Second_theory_label.Location = new System.Drawing.Point(312, 111);
            this.Second_theory_label.Name = "Second_theory_label";
            this.Second_theory_label.Size = new System.Drawing.Size(77, 21);
            this.Second_theory_label.TabIndex = 11;
            this.Second_theory_label.Text = "Second :";
            // 
            // second_theory_picturebox
            // 
            this.second_theory_picturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.second_theory_picturebox.Image = global::Texnologia_v1.Properties.Resources.math;
            this.second_theory_picturebox.Location = new System.Drawing.Point(316, 135);
            this.second_theory_picturebox.Name = "second_theory_picturebox";
            this.second_theory_picturebox.Size = new System.Drawing.Size(150, 150);
            this.second_theory_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.second_theory_picturebox.TabIndex = 10;
            this.second_theory_picturebox.TabStop = false;
            this.second_theory_picturebox.Click += new System.EventHandler(this.second_theory_picturebox_Click);
            // 
            // first_theory_picturebox
            // 
            this.first_theory_picturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.first_theory_picturebox.Image = global::Texnologia_v1.Properties.Resources._68737520_maths_wallpapers;
            this.first_theory_picturebox.Location = new System.Drawing.Point(21, 135);
            this.first_theory_picturebox.Name = "first_theory_picturebox";
            this.first_theory_picturebox.Size = new System.Drawing.Size(150, 150);
            this.first_theory_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.first_theory_picturebox.TabIndex = 9;
            this.first_theory_picturebox.TabStop = false;
            this.first_theory_picturebox.Click += new System.EventHandler(this.first_theory_picturebox_Click);
            // 
            // First_theory_label
            // 
            this.First_theory_label.AutoSize = true;
            this.First_theory_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.First_theory_label.ForeColor = System.Drawing.Color.LightBlue;
            this.First_theory_label.Location = new System.Drawing.Point(17, 111);
            this.First_theory_label.Name = "First_theory_label";
            this.First_theory_label.Size = new System.Drawing.Size(47, 21);
            this.First_theory_label.TabIndex = 8;
            this.First_theory_label.Text = "First :";
            // 
            // Select_theory_label
            // 
            this.Select_theory_label.AutoSize = true;
            this.Select_theory_label.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_theory_label.ForeColor = System.Drawing.Color.LightBlue;
            this.Select_theory_label.Location = new System.Drawing.Point(27, 22);
            this.Select_theory_label.Name = "Select_theory_label";
            this.Select_theory_label.Size = new System.Drawing.Size(150, 24);
            this.Select_theory_label.TabIndex = 7;
            this.Select_theory_label.Text = "Select theory:";
            // 
            // Math_picturebox
            // 
            this.Math_picturebox.Image = global::Texnologia_v1.Properties.Resources.maths;
            this.Math_picturebox.Location = new System.Drawing.Point(0, 53);
            this.Math_picturebox.Name = "Math_picturebox";
            this.Math_picturebox.Size = new System.Drawing.Size(264, 395);
            this.Math_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Math_picturebox.TabIndex = 1;
            this.Math_picturebox.TabStop = false;
            // 
            // My_Scores_panel
            // 
            this.My_Scores_panel.Controls.Add(this.dataGridView1);
            this.My_Scores_panel.Controls.Add(this.hard_bt);
            this.My_Scores_panel.Controls.Add(this.med_bt);
            this.My_Scores_panel.Controls.Add(this.easy_bt);
            this.My_Scores_panel.Controls.Add(this.global_bt);
            this.My_Scores_panel.Controls.Add(this.label2);
            this.My_Scores_panel.Controls.Add(this.label1);
            this.My_Scores_panel.Controls.Add(this.personal_bt);
            this.My_Scores_panel.Controls.Add(this.listView1);
            this.My_Scores_panel.Location = new System.Drawing.Point(263, 53);
            this.My_Scores_panel.Name = "My_Scores_panel";
            this.My_Scores_panel.Size = new System.Drawing.Size(537, 395);
            this.My_Scores_panel.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(469, 237);
            this.dataGridView1.TabIndex = 18;
            // 
            // hard_bt
            // 
            this.hard_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hard_bt.FlatAppearance.BorderSize = 0;
            this.hard_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.hard_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hard_bt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hard_bt.ForeColor = System.Drawing.Color.LightBlue;
            this.hard_bt.Location = new System.Drawing.Point(424, 62);
            this.hard_bt.Name = "hard_bt";
            this.hard_bt.Size = new System.Drawing.Size(75, 35);
            this.hard_bt.TabIndex = 17;
            this.hard_bt.Text = "Random";
            this.hard_bt.UseVisualStyleBackColor = true;
            this.hard_bt.Click += new System.EventHandler(this.hard_bt_Click);
            // 
            // med_bt
            // 
            this.med_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.med_bt.FlatAppearance.BorderSize = 0;
            this.med_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.med_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.med_bt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.med_bt.ForeColor = System.Drawing.Color.LightBlue;
            this.med_bt.Location = new System.Drawing.Point(314, 62);
            this.med_bt.Name = "med_bt";
            this.med_bt.Size = new System.Drawing.Size(75, 35);
            this.med_bt.TabIndex = 16;
            this.med_bt.Text = "Medium";
            this.med_bt.UseVisualStyleBackColor = true;
            this.med_bt.Click += new System.EventHandler(this.med_bt_Click);
            // 
            // easy_bt
            // 
            this.easy_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.easy_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.easy_bt.FlatAppearance.BorderSize = 0;
            this.easy_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.easy_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easy_bt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easy_bt.ForeColor = System.Drawing.Color.LightBlue;
            this.easy_bt.Location = new System.Drawing.Point(207, 61);
            this.easy_bt.Name = "easy_bt";
            this.easy_bt.Size = new System.Drawing.Size(75, 35);
            this.easy_bt.TabIndex = 15;
            this.easy_bt.Text = "Easy";
            this.easy_bt.UseVisualStyleBackColor = false;
            this.easy_bt.Click += new System.EventHandler(this.easy_bt_Click);
            // 
            // global_bt
            // 
            this.global_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.global_bt.FlatAppearance.BorderSize = 0;
            this.global_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.global_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.global_bt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.global_bt.ForeColor = System.Drawing.Color.LightBlue;
            this.global_bt.Location = new System.Drawing.Point(382, 21);
            this.global_bt.Name = "global_bt";
            this.global_bt.Size = new System.Drawing.Size(75, 35);
            this.global_bt.TabIndex = 14;
            this.global_bt.Text = "Global";
            this.global_bt.UseVisualStyleBackColor = true;
            this.global_bt.Click += new System.EventHandler(this.global_bt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightBlue;
            this.label2.Location = new System.Drawing.Point(19, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Select level :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightBlue;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select mode :";
            // 
            // personal_bt
            // 
            this.personal_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.personal_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.personal_bt.FlatAppearance.BorderSize = 0;
            this.personal_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.personal_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personal_bt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personal_bt.ForeColor = System.Drawing.Color.LightBlue;
            this.personal_bt.Location = new System.Drawing.Point(253, 20);
            this.personal_bt.Name = "personal_bt";
            this.personal_bt.Size = new System.Drawing.Size(75, 35);
            this.personal_bt.TabIndex = 12;
            this.personal_bt.Text = "Personal";
            this.personal_bt.UseVisualStyleBackColor = false;
            this.personal_bt.Click += new System.EventHandler(this.personal_bt_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.LightBlue;
            this.listView1.Location = new System.Drawing.Point(23, 111);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(490, 240);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // About_panel
            // 
            this.About_panel.Controls.Add(this.about_text_label);
            this.About_panel.Location = new System.Drawing.Point(263, 53);
            this.About_panel.Name = "About_panel";
            this.About_panel.Size = new System.Drawing.Size(537, 397);
            this.About_panel.TabIndex = 13;
            // 
            // about_text_label
            // 
            this.about_text_label.AutoSize = true;
            this.about_text_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about_text_label.ForeColor = System.Drawing.Color.LightBlue;
            this.about_text_label.Location = new System.Drawing.Point(17, 14);
            this.about_text_label.Name = "about_text_label";
            this.about_text_label.Size = new System.Drawing.Size(496, 360);
            this.about_text_label.TabIndex = 8;
            this.about_text_label.Text = resources.GetString("about_text_label.Text");
            // 
            // Main_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.About_panel);
            this.Controls.Add(this.My_Scores_panel);
            this.Controls.Add(this.Theory_panel);
            this.Controls.Add(this.datetimenow_label);
            this.Controls.Add(this.quiz_panel);
            this.Controls.Add(this.last_signin);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.Welcome_label);
            this.Controls.Add(this.Math_picturebox);
            this.Controls.Add(this.Title_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_page";
            this.Title_panel.ResumeLayout(false);
            this.Title_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close_picturebox)).EndInit();
            this.quiz_panel.ResumeLayout(false);
            this.quiz_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Previous_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Next_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hard_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Medium_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Easy_picturebox)).EndInit();
            this.Theory_panel.ResumeLayout(false);
            this.Theory_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdf_reader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_arrow_for_theory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.second_theory_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_theory_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Math_picturebox)).EndInit();
            this.My_Scores_panel.ResumeLayout(false);
            this.My_Scores_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.About_panel.ResumeLayout(false);
            this.About_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Title_panel;
        private System.Windows.Forms.PictureBox Close_picturebox;
        private System.Windows.Forms.PictureBox Math_picturebox;
        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.Button Logout_button;
        private System.Windows.Forms.Button About_button;
        private System.Windows.Forms.Button Quiz_button;
        private System.Windows.Forms.Button Theory_button;
        private System.Windows.Forms.Label Welcome_label;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Button Score_button;
        private System.Windows.Forms.Panel quiz_panel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label Select_difficulty_label;
        private System.Windows.Forms.PictureBox Hard_picturebox;
        private System.Windows.Forms.PictureBox Medium_picturebox;
        private System.Windows.Forms.Label Hard_label;
        private System.Windows.Forms.Label Medium_label;
        private System.Windows.Forms.Label Easy_label;
        private System.Windows.Forms.PictureBox Easy_picturebox;
        private System.Windows.Forms.PictureBox Previous_picturebox;
        private System.Windows.Forms.PictureBox Next_picturebox;
        private System.Windows.Forms.Label question_number_label;
        private System.Windows.Forms.Label timer_count_label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label last_signin;
        private System.Windows.Forms.Label datetimenow_label;
        private System.Windows.Forms.RadioButton answer_4;
        private System.Windows.Forms.RadioButton answer_3;
        private System.Windows.Forms.RadioButton answer_2;
        private System.Windows.Forms.RadioButton answer_1;
        private System.Windows.Forms.Label Answer_label;
        private System.Windows.Forms.Label question_label_title;
        private System.Windows.Forms.Label question_label;
		private System.Windows.Forms.RichTextBox question_richtextbox;
        private System.Windows.Forms.Panel Theory_panel;
        private System.Windows.Forms.Label Second_theory_label;
        private System.Windows.Forms.PictureBox second_theory_picturebox;
        private System.Windows.Forms.PictureBox first_theory_picturebox;
        private System.Windows.Forms.Label First_theory_label;
        private System.Windows.Forms.Label Select_theory_label;
        private System.Windows.Forms.PictureBox back_arrow_for_theory;
        private System.Windows.Forms.Label instructions_label;
        private AxAcroPDFLib.AxAcroPDF pdf_reader;
        private System.Windows.Forms.Panel My_Scores_panel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel About_panel;
        private System.Windows.Forms.Label about_text_label;
        private System.Windows.Forms.Button hard_bt;
        private System.Windows.Forms.Button med_bt;
        private System.Windows.Forms.Button easy_bt;
        private System.Windows.Forms.Button global_bt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button personal_bt;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}