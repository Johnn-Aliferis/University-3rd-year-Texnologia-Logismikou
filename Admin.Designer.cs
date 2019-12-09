namespace Texnologia_v1
{
    partial class Admin
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
            this.panel_validation = new System.Windows.Forms.Panel();
            this.all_users_label = new System.Windows.Forms.Label();
            this.bt_validate = new System.Windows.Forms.Button();
            this.id_label = new System.Windows.Forms.Label();
            this.text_validate = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel_start = new System.Windows.Forms.Panel();
            this.label_welcome_admin = new System.Windows.Forms.Label();
            this.validate_bt = new System.Windows.Forms.Button();
            this.quest_bt = new System.Windows.Forms.Button();
            this.panel_quest = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_answer = new System.Windows.Forms.ComboBox();
            this.label_answer = new System.Windows.Forms.Label();
            this.Insert_question_button = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tb_d = new System.Windows.Forms.TextBox();
            this.tb_c = new System.Windows.Forms.TextBox();
            this.tb_b = new System.Windows.Forms.TextBox();
            this.tb_a = new System.Windows.Forms.TextBox();
            this.tb_quest = new System.Windows.Forms.TextBox();
            this.labeld = new System.Windows.Forms.Label();
            this.labelc = new System.Windows.Forms.Label();
            this.labelb = new System.Windows.Forms.Label();
            this.labela = new System.Windows.Forms.Label();
            this.label_quest = new System.Windows.Forms.Label();
            this.panel_Title = new System.Windows.Forms.Panel();
            this.llabel_admin_menu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Close_picturebox = new System.Windows.Forms.PictureBox();
            this.Back_picturebox = new System.Windows.Forms.PictureBox();
            this.admin_logout = new System.Windows.Forms.PictureBox();
            this.Back_from_data_picturebox = new System.Windows.Forms.PictureBox();
            this.panel_validation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_start.SuspendLayout();
            this.panel_quest.SuspendLayout();
            this.panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back_from_data_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_validation
            // 
            this.panel_validation.Controls.Add(this.all_users_label);
            this.panel_validation.Controls.Add(this.Back_from_data_picturebox);
            this.panel_validation.Controls.Add(this.bt_validate);
            this.panel_validation.Controls.Add(this.id_label);
            this.panel_validation.Controls.Add(this.text_validate);
            this.panel_validation.Controls.Add(this.dataGridView1);
            this.panel_validation.Location = new System.Drawing.Point(0, 54);
            this.panel_validation.Margin = new System.Windows.Forms.Padding(2);
            this.panel_validation.Name = "panel_validation";
            this.panel_validation.Size = new System.Drawing.Size(880, 393);
            this.panel_validation.TabIndex = 6;
            this.panel_validation.Visible = false;
            // 
            // all_users_label
            // 
            this.all_users_label.AutoSize = true;
            this.all_users_label.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all_users_label.ForeColor = System.Drawing.Color.Silver;
            this.all_users_label.Location = new System.Drawing.Point(327, 108);
            this.all_users_label.Name = "all_users_label";
            this.all_users_label.Size = new System.Drawing.Size(226, 23);
            this.all_users_label.TabIndex = 9;
            this.all_users_label.Text = "All users are validated !";
            // 
            // bt_validate
            // 
            this.bt_validate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_validate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.bt_validate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_validate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_validate.ForeColor = System.Drawing.Color.LightBlue;
            this.bt_validate.Location = new System.Drawing.Point(435, 13);
            this.bt_validate.Margin = new System.Windows.Forms.Padding(2);
            this.bt_validate.Name = "bt_validate";
            this.bt_validate.Size = new System.Drawing.Size(202, 26);
            this.bt_validate.TabIndex = 4;
            this.bt_validate.Text = "Validate user !";
            this.bt_validate.UseVisualStyleBackColor = true;
            this.bt_validate.Click += new System.EventHandler(this.bt_validate_Click);
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.id_label.ForeColor = System.Drawing.Color.LightBlue;
            this.id_label.Location = new System.Drawing.Point(38, 17);
            this.id_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(205, 18);
            this.id_label.TabIndex = 3;
            this.id_label.Text = "Enter ID of user to validate :";
            // 
            // text_validate
            // 
            this.text_validate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.text_validate.Location = new System.Drawing.Point(277, 13);
            this.text_validate.Margin = new System.Windows.Forms.Padding(2);
            this.text_validate.Name = "text_validate";
            this.text_validate.Size = new System.Drawing.Size(114, 26);
            this.text_validate.TabIndex = 1;
            this.text_validate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_validate_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 63);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(632, 266);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel_start
            // 
            this.panel_start.Controls.Add(this.label3);
            this.panel_start.Controls.Add(this.admin_logout);
            this.panel_start.Controls.Add(this.label_welcome_admin);
            this.panel_start.Controls.Add(this.validate_bt);
            this.panel_start.Controls.Add(this.quest_bt);
            this.panel_start.Location = new System.Drawing.Point(82, 54);
            this.panel_start.Margin = new System.Windows.Forms.Padding(2);
            this.panel_start.Name = "panel_start";
            this.panel_start.Size = new System.Drawing.Size(788, 394);
            this.panel_start.TabIndex = 5;
            // 
            // label_welcome_admin
            // 
            this.label_welcome_admin.AutoSize = true;
            this.label_welcome_admin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_welcome_admin.ForeColor = System.Drawing.Color.Silver;
            this.label_welcome_admin.Location = new System.Drawing.Point(18, 13);
            this.label_welcome_admin.Name = "label_welcome_admin";
            this.label_welcome_admin.Size = new System.Drawing.Size(691, 23);
            this.label_welcome_admin.TabIndex = 9;
            this.label_welcome_admin.Text = "Welcome Admin ! Do you want to validate a user or add a new question ? ";
            // 
            // validate_bt
            // 
            this.validate_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.validate_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.validate_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validate_bt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validate_bt.ForeColor = System.Drawing.Color.LightBlue;
            this.validate_bt.Location = new System.Drawing.Point(145, 115);
            this.validate_bt.Margin = new System.Windows.Forms.Padding(2);
            this.validate_bt.Name = "validate_bt";
            this.validate_bt.Size = new System.Drawing.Size(142, 69);
            this.validate_bt.TabIndex = 0;
            this.validate_bt.Text = "validate";
            this.validate_bt.UseVisualStyleBackColor = true;
            this.validate_bt.Click += new System.EventHandler(this.validate_bt_Click);
            // 
            // quest_bt
            // 
            this.quest_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quest_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.quest_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quest_bt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quest_bt.ForeColor = System.Drawing.Color.LightBlue;
            this.quest_bt.Location = new System.Drawing.Point(391, 115);
            this.quest_bt.Margin = new System.Windows.Forms.Padding(2);
            this.quest_bt.Name = "quest_bt";
            this.quest_bt.Size = new System.Drawing.Size(142, 69);
            this.quest_bt.TabIndex = 1;
            this.quest_bt.Text = "add question";
            this.quest_bt.UseVisualStyleBackColor = true;
            this.quest_bt.Click += new System.EventHandler(this.quest_bt_Click);
            // 
            // panel_quest
            // 
            this.panel_quest.Controls.Add(this.Back_picturebox);
            this.panel_quest.Controls.Add(this.label2);
            this.panel_quest.Controls.Add(this.label1);
            this.panel_quest.Controls.Add(this.cb_answer);
            this.panel_quest.Controls.Add(this.label_answer);
            this.panel_quest.Controls.Add(this.Insert_question_button);
            this.panel_quest.Controls.Add(this.radioButton2);
            this.panel_quest.Controls.Add(this.radioButton1);
            this.panel_quest.Controls.Add(this.tb_d);
            this.panel_quest.Controls.Add(this.tb_c);
            this.panel_quest.Controls.Add(this.tb_b);
            this.panel_quest.Controls.Add(this.tb_a);
            this.panel_quest.Controls.Add(this.tb_quest);
            this.panel_quest.Controls.Add(this.labeld);
            this.panel_quest.Controls.Add(this.labelc);
            this.panel_quest.Controls.Add(this.labelb);
            this.panel_quest.Controls.Add(this.labela);
            this.panel_quest.Controls.Add(this.label_quest);
            this.panel_quest.Location = new System.Drawing.Point(11, 54);
            this.panel_quest.Margin = new System.Windows.Forms.Padding(2);
            this.panel_quest.Name = "panel_quest";
            this.panel_quest.Size = new System.Drawing.Size(867, 397);
            this.panel_quest.TabIndex = 2;
            this.panel_quest.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(67, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Enter possible answers :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(67, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Choose Level for question :";
            // 
            // cb_answer
            // 
            this.cb_answer.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_answer.FormattingEnabled = true;
            this.cb_answer.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cb_answer.Location = new System.Drawing.Point(424, 263);
            this.cb_answer.Margin = new System.Windows.Forms.Padding(2);
            this.cb_answer.Name = "cb_answer";
            this.cb_answer.Size = new System.Drawing.Size(92, 24);
            this.cb_answer.TabIndex = 15;
            // 
            // label_answer
            // 
            this.label_answer.AutoSize = true;
            this.label_answer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_answer.ForeColor = System.Drawing.Color.Silver;
            this.label_answer.Location = new System.Drawing.Point(287, 261);
            this.label_answer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_answer.Name = "label_answer";
            this.label_answer.Size = new System.Drawing.Size(133, 19);
            this.label_answer.TabIndex = 14;
            this.label_answer.Text = "Correct Answer :";
            // 
            // Insert_question_button
            // 
            this.Insert_question_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Insert_question_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.Insert_question_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Insert_question_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Insert_question_button.ForeColor = System.Drawing.Color.Silver;
            this.Insert_question_button.Location = new System.Drawing.Point(320, 320);
            this.Insert_question_button.Margin = new System.Windows.Forms.Padding(2);
            this.Insert_question_button.Name = "Insert_question_button";
            this.Insert_question_button.Size = new System.Drawing.Size(257, 49);
            this.Insert_question_button.TabIndex = 12;
            this.Insert_question_button.Text = "Insert Question";
            this.Insert_question_button.UseVisualStyleBackColor = true;
            this.Insert_question_button.Click += new System.EventHandler(this.Insert_question_button_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.radioButton2.ForeColor = System.Drawing.Color.Silver;
            this.radioButton2.Location = new System.Drawing.Point(536, 92);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(83, 24);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Medium";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.radioButton1.ForeColor = System.Drawing.Color.Silver;
            this.radioButton1.Location = new System.Drawing.Point(372, 92);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 24);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Easy";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // tb_d
            // 
            this.tb_d.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tb_d.Location = new System.Drawing.Point(666, 189);
            this.tb_d.Margin = new System.Windows.Forms.Padding(2);
            this.tb_d.Name = "tb_d";
            this.tb_d.Size = new System.Drawing.Size(151, 26);
            this.tb_d.TabIndex = 9;
            // 
            // tb_c
            // 
            this.tb_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tb_c.Location = new System.Drawing.Point(468, 189);
            this.tb_c.Margin = new System.Windows.Forms.Padding(2);
            this.tb_c.Name = "tb_c";
            this.tb_c.Size = new System.Drawing.Size(151, 26);
            this.tb_c.TabIndex = 8;
            // 
            // tb_b
            // 
            this.tb_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tb_b.Location = new System.Drawing.Point(266, 189);
            this.tb_b.Margin = new System.Windows.Forms.Padding(2);
            this.tb_b.Name = "tb_b";
            this.tb_b.Size = new System.Drawing.Size(151, 26);
            this.tb_b.TabIndex = 7;
            // 
            // tb_a
            // 
            this.tb_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tb_a.Location = new System.Drawing.Point(91, 189);
            this.tb_a.Margin = new System.Windows.Forms.Padding(2);
            this.tb_a.Name = "tb_a";
            this.tb_a.Size = new System.Drawing.Size(132, 26);
            this.tb_a.TabIndex = 6;
            // 
            // tb_quest
            // 
            this.tb_quest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tb_quest.Location = new System.Drawing.Point(299, 25);
            this.tb_quest.Margin = new System.Windows.Forms.Padding(2);
            this.tb_quest.Name = "tb_quest";
            this.tb_quest.Size = new System.Drawing.Size(428, 26);
            this.tb_quest.TabIndex = 5;
            // 
            // labeld
            // 
            this.labeld.AutoSize = true;
            this.labeld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labeld.ForeColor = System.Drawing.Color.Silver;
            this.labeld.Location = new System.Drawing.Point(637, 189);
            this.labeld.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeld.Name = "labeld";
            this.labeld.Size = new System.Drawing.Size(25, 20);
            this.labeld.TabIndex = 4;
            this.labeld.Text = "4)";
            // 
            // labelc
            // 
            this.labelc.AutoSize = true;
            this.labelc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelc.ForeColor = System.Drawing.Color.Silver;
            this.labelc.Location = new System.Drawing.Point(439, 189);
            this.labelc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelc.Name = "labelc";
            this.labelc.Size = new System.Drawing.Size(25, 20);
            this.labelc.TabIndex = 3;
            this.labelc.Text = "3)";
            // 
            // labelb
            // 
            this.labelb.AutoSize = true;
            this.labelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelb.ForeColor = System.Drawing.Color.Silver;
            this.labelb.Location = new System.Drawing.Point(237, 189);
            this.labelb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelb.Name = "labelb";
            this.labelb.Size = new System.Drawing.Size(25, 20);
            this.labelb.TabIndex = 2;
            this.labelb.Text = "2)";
            // 
            // labela
            // 
            this.labela.AutoSize = true;
            this.labela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labela.ForeColor = System.Drawing.Color.Silver;
            this.labela.Location = new System.Drawing.Point(62, 189);
            this.labela.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labela.Name = "labela";
            this.labela.Size = new System.Drawing.Size(25, 20);
            this.labela.TabIndex = 1;
            this.labela.Text = "1)";
            // 
            // label_quest
            // 
            this.label_quest.AutoSize = true;
            this.label_quest.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_quest.ForeColor = System.Drawing.Color.Silver;
            this.label_quest.Location = new System.Drawing.Point(67, 28);
            this.label_quest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_quest.Name = "label_quest";
            this.label_quest.Size = new System.Drawing.Size(214, 19);
            this.label_quest.TabIndex = 0;
            this.label_quest.Text = "Enter a new question here :";
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.panel_Title.Controls.Add(this.Close_picturebox);
            this.panel_Title.Controls.Add(this.llabel_admin_menu);
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(880, 53);
            this.panel_Title.TabIndex = 7;
            // 
            // llabel_admin_menu
            // 
            this.llabel_admin_menu.AutoSize = true;
            this.llabel_admin_menu.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llabel_admin_menu.ForeColor = System.Drawing.Color.Silver;
            this.llabel_admin_menu.Location = new System.Drawing.Point(7, 13);
            this.llabel_admin_menu.Name = "llabel_admin_menu";
            this.llabel_admin_menu.Size = new System.Drawing.Size(132, 23);
            this.llabel_admin_menu.TabIndex = 0;
            this.llabel_admin_menu.Text = "Admin Menu ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(693, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Logout ";
            // 
            // Close_picturebox
            // 
            this.Close_picturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_picturebox.Image = global::Texnologia_v1.Properties.Resources.Delete_White;
            this.Close_picturebox.Location = new System.Drawing.Point(850, 0);
            this.Close_picturebox.Name = "Close_picturebox";
            this.Close_picturebox.Size = new System.Drawing.Size(30, 30);
            this.Close_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Close_picturebox.TabIndex = 8;
            this.Close_picturebox.TabStop = false;
            this.Close_picturebox.Click += new System.EventHandler(this.Close_picturebox_Click);
            this.Close_picturebox.MouseEnter += new System.EventHandler(this.Close_picturebox_MouseEnter);
            this.Close_picturebox.MouseLeave += new System.EventHandler(this.Close_picturebox_MouseLeave);
            // 
            // Back_picturebox
            // 
            this.Back_picturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_picturebox.Image = global::Texnologia_v1.Properties.Resources.Undo;
            this.Back_picturebox.Location = new System.Drawing.Point(3, 316);
            this.Back_picturebox.Name = "Back_picturebox";
            this.Back_picturebox.Size = new System.Drawing.Size(50, 50);
            this.Back_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Back_picturebox.TabIndex = 9;
            this.Back_picturebox.TabStop = false;
            this.Back_picturebox.Click += new System.EventHandler(this.Back_picturebox_Click);
            // 
            // admin_logout
            // 
            this.admin_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.admin_logout.Image = global::Texnologia_v1.Properties.Resources.admin_logout;
            this.admin_logout.Location = new System.Drawing.Point(707, 316);
            this.admin_logout.Name = "admin_logout";
            this.admin_logout.Size = new System.Drawing.Size(50, 50);
            this.admin_logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.admin_logout.TabIndex = 9;
            this.admin_logout.TabStop = false;
            this.admin_logout.Click += new System.EventHandler(this.admin_logout_Click);
            // 
            // Back_from_data_picturebox
            // 
            this.Back_from_data_picturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_from_data_picturebox.Image = global::Texnologia_v1.Properties.Resources.Undo;
            this.Back_from_data_picturebox.Location = new System.Drawing.Point(14, 342);
            this.Back_from_data_picturebox.Name = "Back_from_data_picturebox";
            this.Back_from_data_picturebox.Size = new System.Drawing.Size(50, 50);
            this.Back_from_data_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Back_from_data_picturebox.TabIndex = 10;
            this.Back_from_data_picturebox.TabStop = false;
            this.Back_from_data_picturebox.Click += new System.EventHandler(this.Back_from_data_picturebox_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(881, 462);
            this.Controls.Add(this.panel_Title);
            this.Controls.Add(this.panel_quest);
            this.Controls.Add(this.panel_start);
            this.Controls.Add(this.panel_validation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel_validation.ResumeLayout(false);
            this.panel_validation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_start.ResumeLayout(false);
            this.panel_start.PerformLayout();
            this.panel_quest.ResumeLayout(false);
            this.panel_quest.PerformLayout();
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back_from_data_picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_validation;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel_start;
        private System.Windows.Forms.Button validate_bt;
        private System.Windows.Forms.Button quest_bt;
        private System.Windows.Forms.Button bt_validate;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.TextBox text_validate;
        private System.Windows.Forms.Panel panel_quest;
        private System.Windows.Forms.Button Insert_question_button;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox tb_d;
        private System.Windows.Forms.TextBox tb_c;
        private System.Windows.Forms.TextBox tb_b;
        private System.Windows.Forms.TextBox tb_a;
        private System.Windows.Forms.TextBox tb_quest;
        private System.Windows.Forms.Label labeld;
        private System.Windows.Forms.Label labelc;
        private System.Windows.Forms.Label labelb;
        private System.Windows.Forms.Label labela;
        private System.Windows.Forms.Label label_quest;
        private System.Windows.Forms.Label label_answer;
        private System.Windows.Forms.ComboBox cb_answer;
        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.Label llabel_admin_menu;
        private System.Windows.Forms.PictureBox Close_picturebox;
        private System.Windows.Forms.Label label_welcome_admin;
        private System.Windows.Forms.PictureBox Back_picturebox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Back_from_data_picturebox;
        private System.Windows.Forms.Label all_users_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox admin_logout;
    }
}