namespace Texnologia_v1
{
    partial class Signup
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
            this.Title_label = new System.Windows.Forms.Label();
            this.Close_picturebox = new System.Windows.Forms.PictureBox();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.confirm_password_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.username_textbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.password_textbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.confirm_textbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.email_textbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Signup_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Close_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // Title_label
            // 
            this.Title_label.AutoSize = true;
            this.Title_label.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_label.ForeColor = System.Drawing.Color.White;
            this.Title_label.Location = new System.Drawing.Point(25, 9);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(83, 24);
            this.Title_label.TabIndex = 0;
            this.Title_label.Text = "Sign up";
            // 
            // Close_picturebox
            // 
            this.Close_picturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_picturebox.Image = global::Texnologia_v1.Properties.Resources.Delete_White;
            this.Close_picturebox.Location = new System.Drawing.Point(420, 0);
            this.Close_picturebox.Name = "Close_picturebox";
            this.Close_picturebox.Size = new System.Drawing.Size(25, 25);
            this.Close_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Close_picturebox.TabIndex = 1;
            this.Close_picturebox.TabStop = false;
            this.Close_picturebox.Click += new System.EventHandler(this.Close_picturebox_Click);
            this.Close_picturebox.MouseEnter += new System.EventHandler(this.Close_picturebox_MouseEnter);
            this.Close_picturebox.MouseLeave += new System.EventHandler(this.Close_picturebox_MouseLeave);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.ForeColor = System.Drawing.Color.White;
            this.username_label.Location = new System.Drawing.Point(25, 66);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(95, 19);
            this.username_label.TabIndex = 2;
            this.username_label.Text = "Username :";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.Color.White;
            this.password_label.Location = new System.Drawing.Point(25, 148);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(88, 19);
            this.password_label.TabIndex = 3;
            this.password_label.Text = "Password :";
            // 
            // confirm_password_label
            // 
            this.confirm_password_label.AutoSize = true;
            this.confirm_password_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_password_label.ForeColor = System.Drawing.Color.White;
            this.confirm_password_label.Location = new System.Drawing.Point(25, 236);
            this.confirm_password_label.Name = "confirm_password_label";
            this.confirm_password_label.Size = new System.Drawing.Size(155, 19);
            this.confirm_password_label.TabIndex = 4;
            this.confirm_password_label.Text = "Confirm password :";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.ForeColor = System.Drawing.Color.White;
            this.email_label.Location = new System.Drawing.Point(25, 324);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(60, 19);
            this.email_label.TabIndex = 5;
            this.email_label.Text = "Email :";
            // 
            // username_textbox
            // 
            this.username_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username_textbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.username_textbox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.username_textbox.HintText = "";
            this.username_textbox.isPassword = false;
            this.username_textbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.username_textbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.username_textbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.username_textbox.LineThickness = 3;
            this.username_textbox.Location = new System.Drawing.Point(29, 91);
            this.username_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(379, 31);
            this.username_textbox.TabIndex = 6;
            this.username_textbox.Text = "Example : john34";
            this.username_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.username_textbox.OnValueChanged += new System.EventHandler(this.username_textbox_OnValueChanged);
            this.username_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.username_textbox_KeyPress);
            this.username_textbox.MouseEnter += new System.EventHandler(this.username_textbox_MouseEnter);
            // 
            // password_textbox
            // 
            this.password_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_textbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.password_textbox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.password_textbox.HintText = "";
            this.password_textbox.isPassword = false;
            this.password_textbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.password_textbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.password_textbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.password_textbox.LineThickness = 3;
            this.password_textbox.Location = new System.Drawing.Point(29, 173);
            this.password_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(379, 31);
            this.password_textbox.TabIndex = 7;
            this.password_textbox.Text = "Enter password here...";
            this.password_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password_textbox.OnValueChanged += new System.EventHandler(this.password_textbox_OnValueChanged);
            this.password_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_textbox_KeyPress);
            this.password_textbox.MouseEnter += new System.EventHandler(this.password_textbox_MouseEnter);
            // 
            // confirm_textbox
            // 
            this.confirm_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirm_textbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.confirm_textbox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.confirm_textbox.HintText = "";
            this.confirm_textbox.isPassword = false;
            this.confirm_textbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.confirm_textbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.confirm_textbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.confirm_textbox.LineThickness = 3;
            this.confirm_textbox.Location = new System.Drawing.Point(29, 261);
            this.confirm_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.confirm_textbox.Name = "confirm_textbox";
            this.confirm_textbox.Size = new System.Drawing.Size(379, 31);
            this.confirm_textbox.TabIndex = 8;
            this.confirm_textbox.Text = "Confirm password...";
            this.confirm_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.confirm_textbox.OnValueChanged += new System.EventHandler(this.confirm_textbox_OnValueChanged);
            this.confirm_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.confirm_textbox_KeyPress);
            this.confirm_textbox.MouseEnter += new System.EventHandler(this.confirm_textbox_MouseEnter);
            // 
            // email_textbox
            // 
            this.email_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email_textbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.email_textbox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.email_textbox.HintText = "";
            this.email_textbox.isPassword = false;
            this.email_textbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.email_textbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.email_textbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.email_textbox.LineThickness = 3;
            this.email_textbox.Location = new System.Drawing.Point(29, 349);
            this.email_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(379, 31);
            this.email_textbox.TabIndex = 9;
            this.email_textbox.Text = "Example : someone@gmail.com";
            this.email_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.email_textbox.OnValueChanged += new System.EventHandler(this.email_textbox_OnValueChanged);
            this.email_textbox.MouseEnter += new System.EventHandler(this.email_textbox_MouseEnter);
            // 
            // Signup_button
            // 
            this.Signup_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.Signup_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Signup_button.FlatAppearance.BorderSize = 0;
            this.Signup_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Signup_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup_button.Location = new System.Drawing.Point(81, 426);
            this.Signup_button.Name = "Signup_button";
            this.Signup_button.Size = new System.Drawing.Size(121, 33);
            this.Signup_button.TabIndex = 10;
            this.Signup_button.Text = "Sign up";
            this.Signup_button.UseVisualStyleBackColor = false;
            this.Signup_button.Click += new System.EventHandler(this.Signup_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.Back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_button.FlatAppearance.BorderSize = 0;
            this.Back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.Location = new System.Drawing.Point(242, 426);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(121, 33);
            this.Back_button.TabIndex = 11;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(444, 474);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Signup_button);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.confirm_textbox);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.confirm_password_label);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.Close_picturebox);
            this.Controls.Add(this.Title_label);
            this.ForeColor = System.Drawing.Color.LightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Signup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Close_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.PictureBox Close_picturebox;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label confirm_password_label;
        private System.Windows.Forms.Label email_label;
        private Bunifu.Framework.UI.BunifuMaterialTextbox username_textbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password_textbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox confirm_textbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox email_textbox;
        private System.Windows.Forms.Button Signup_button;
        private System.Windows.Forms.Button Back_button;
    }
}