namespace Texnologia_v1
{
    partial class Lopin_form
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
            this.Login_form_label = new System.Windows.Forms.Label();
            this.Login_button = new System.Windows.Forms.Button();
            this.Create_new_account_label = new System.Windows.Forms.Label();
            this.Username_title_label = new System.Windows.Forms.Label();
            this.Password_title_label = new System.Windows.Forms.Label();
            this.username_textbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.password_textbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Close_picturebox = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Close_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_form_label
            // 
            this.Login_form_label.AutoSize = true;
            this.Login_form_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Login_form_label.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_form_label.ForeColor = System.Drawing.Color.White;
            this.Login_form_label.Location = new System.Drawing.Point(31, 18);
            this.Login_form_label.Name = "Login_form_label";
            this.Login_form_label.Size = new System.Drawing.Size(70, 24);
            this.Login_form_label.TabIndex = 0;
            this.Login_form_label.Text = "Login ";
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.Login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_button.FlatAppearance.BorderSize = 0;
            this.Login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_button.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_button.Location = new System.Drawing.Point(34, 279);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(379, 42);
            this.Login_button.TabIndex = 11;
            this.Login_button.Text = "Login";
            this.toolTip1.SetToolTip(this.Login_button, "Perform Login");
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Create_new_account_label
            // 
            this.Create_new_account_label.AutoSize = true;
            this.Create_new_account_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Create_new_account_label.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_new_account_label.ForeColor = System.Drawing.Color.LightBlue;
            this.Create_new_account_label.Location = new System.Drawing.Point(255, 324);
            this.Create_new_account_label.Name = "Create_new_account_label";
            this.Create_new_account_label.Size = new System.Drawing.Size(159, 18);
            this.Create_new_account_label.TabIndex = 12;
            this.Create_new_account_label.Text = "Create a new account";
            this.Create_new_account_label.Click += new System.EventHandler(this.Create_new_account_label_Click);
            this.Create_new_account_label.MouseEnter += new System.EventHandler(this.Create_new_account_label_MouseEnter);
            this.Create_new_account_label.MouseLeave += new System.EventHandler(this.Create_new_account_label_MouseLeave);
            // 
            // Username_title_label
            // 
            this.Username_title_label.AutoSize = true;
            this.Username_title_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Username_title_label.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_title_label.ForeColor = System.Drawing.Color.White;
            this.Username_title_label.Location = new System.Drawing.Point(31, 82);
            this.Username_title_label.Name = "Username_title_label";
            this.Username_title_label.Size = new System.Drawing.Size(82, 17);
            this.Username_title_label.TabIndex = 13;
            this.Username_title_label.Text = "Username:";
            // 
            // Password_title_label
            // 
            this.Password_title_label.AutoSize = true;
            this.Password_title_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Password_title_label.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_title_label.ForeColor = System.Drawing.Color.White;
            this.Password_title_label.Location = new System.Drawing.Point(32, 166);
            this.Password_title_label.Name = "Password_title_label";
            this.Password_title_label.Size = new System.Drawing.Size(80, 17);
            this.Password_title_label.TabIndex = 14;
            this.Password_title_label.Text = "Password:";
            // 
            // username_textbox
            // 
            this.username_textbox.CausesValidation = false;
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
            this.username_textbox.Location = new System.Drawing.Point(34, 103);
            this.username_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(379, 33);
            this.username_textbox.TabIndex = 15;
            this.username_textbox.Text = "Enter your username here...";
            this.username_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.username_textbox.OnValueChanged += new System.EventHandler(this.username_textbox_OnValueChanged);
            this.username_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.username_textbox_KeyPress);
            this.username_textbox.MouseEnter += new System.EventHandler(this.username_textbox_MouseEnter);
            // 
            // password_textbox
            // 
            this.password_textbox.CausesValidation = false;
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
            this.password_textbox.Location = new System.Drawing.Point(35, 197);
            this.password_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(379, 33);
            this.password_textbox.TabIndex = 16;
            this.password_textbox.Text = "Enter your password here...";
            this.password_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password_textbox.OnValueChanged += new System.EventHandler(this.password_textbox_OnValueChanged);
            this.password_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_textbox_KeyPress);
            this.password_textbox.MouseEnter += new System.EventHandler(this.password_textbox_MouseEnter);
            // 
            // Close_picturebox
            // 
            this.Close_picturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_picturebox.Image = global::Texnologia_v1.Properties.Resources.Delete_White;
            this.Close_picturebox.Location = new System.Drawing.Point(428, 0);
            this.Close_picturebox.Name = "Close_picturebox";
            this.Close_picturebox.Size = new System.Drawing.Size(25, 25);
            this.Close_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Close_picturebox.TabIndex = 17;
            this.Close_picturebox.TabStop = false;
            this.toolTip1.SetToolTip(this.Close_picturebox, "Closes application");
            this.Close_picturebox.Click += new System.EventHandler(this.Close_picturebox_Click);
            this.Close_picturebox.MouseEnter += new System.EventHandler(this.Close_picturebox_MouseEnter);
            this.Close_picturebox.MouseLeave += new System.EventHandler(this.Close_picturebox_MouseLeave);
            // 
            // Lopin_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(453, 350);
            this.Controls.Add(this.Close_picturebox);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.Password_title_label);
            this.Controls.Add(this.Username_title_label);
            this.Controls.Add(this.Create_new_account_label);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.Login_form_label);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lopin_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Lopin_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Close_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login_form_label;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Label Create_new_account_label;
        private System.Windows.Forms.Label Username_title_label;
        private System.Windows.Forms.Label Password_title_label;
        private Bunifu.Framework.UI.BunifuMaterialTextbox username_textbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password_textbox;
        private System.Windows.Forms.PictureBox Close_picturebox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

