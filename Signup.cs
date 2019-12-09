using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Texnologia_v1
{
    public partial class Signup : Form
    {
        String query;
        OleDbConnection conn = new OleDbConnection();
        bool username_clicked = false;
        bool password_clicked = false;
        bool confirm_clicked = false;
        bool email_clicked = false;
        public Signup()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database2.accdb";
        }

        private void Close_picturebox_MouseEnter(object sender, EventArgs e)
        {
            Close_picturebox.Image = Properties.Resources.Delete_Red;
        }

        private void Close_picturebox_MouseLeave(object sender, EventArgs e)
        {
            Close_picturebox.Image = Properties.Resources.Delete_White;
        }

        private void Close_picturebox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Lopin_form lp = new Lopin_form();
            this.Hide();
            lp.ShowDialog();
        }

        private void Signup_button_Click(object sender, EventArgs e)
        {
            // check if password is same :
            if (password_textbox.Text == confirm_textbox.Text && password_textbox.Text != "")
            {
                //check if email is in valid form!
                Regex reg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = reg.Match(email_textbox.Text);
                if (match.Success && username_textbox.Text != "admin")
                {
                        conn.Open();
                        query = "SELECT * FROM Table1 where Username='" + username_textbox.Text + "' and Email='" + email_textbox.Text + "'";

                        OleDbCommand cmd = new OleDbCommand(query, conn);
                        OleDbDataReader rdr = cmd.ExecuteReader();
                        int c = 0;
                        while (rdr.Read())
                        {
                            c = c + 1;
                        }
                        if (c != 0)
                        {
                            MessageBox.Show("This user already exists");
                            //Thn forma poy thelw na anoi3ei
                        }
                        conn.Close();
                        if (c == 0)
                        {
                            conn.Open();
                            OleDbCommand cmd1 = new OleDbCommand();
                            cmd1.Connection = conn;
                            cmd1.CommandText = "insert into Table1 (Username,Pass,Email,validate) values ('" + username_textbox.Text + "','" + password_textbox.Text + "','" + email_textbox.Text + "','"+0.ToString()+"')";

                            cmd1.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("Registration Completed ! You must wait to be validated by the admin in order to be able to sign in !");
                        }
                }
                else
                {
                    MessageBox.Show("Make sure you enter a valid e-mail address or enter an another username!");
                }
            }
            else if (password_textbox.Text == confirm_textbox.Text && password_textbox.Text == "")
            {
                MessageBox.Show("Please fill all the fields !");
            }
            else
            {
                MessageBox.Show("The two passwords do not match , check your inputs !");
            }
        }

        private void username_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void password_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void confirm_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }
        int username = 0;
        private void username_textbox_MouseEnter(object sender, EventArgs e)
        {
            if (!username_clicked)
            {
                if (username == 0)
                {
                    username_textbox.Text = "";
                    username++;
                }
                username_clicked = true;
            }
        }
        int password = 0;
        private void password_textbox_MouseEnter(object sender, EventArgs e)
        {
            if (!password_clicked)
            {
                if (password == 0)
                {
                    password_textbox.Text = "";
                    password++;
                }
                password_clicked = true;
                password_textbox.isPassword = true;
            }
        }
        int confirm = 0;
        private void confirm_textbox_MouseEnter(object sender, EventArgs e)
        {
            if (!confirm_clicked)
            {
                if (confirm == 0)
                {
                    confirm_textbox.Text = "";
                    confirm++;
                }
                confirm_clicked = true;
                confirm_textbox.isPassword = true;
            }
        }
        int email = 0;
        private void email_textbox_MouseEnter(object sender, EventArgs e)
        {
            if (!email_clicked)
            {
                if (email == 0 )
                {
                    email_textbox.Text = "";
                    email++;
                }
                email_clicked = true;
            }
        }

        private void confirm_textbox_OnValueChanged(object sender, EventArgs e)
        {
            confirm_textbox.isPassword = true;
            confirm++;
        }

        private void password_textbox_OnValueChanged(object sender, EventArgs e)
        {
            password_textbox.isPassword = true;
            password++;
        }

        private void username_textbox_OnValueChanged(object sender, EventArgs e)
        {
            username++;
        }

        private void email_textbox_OnValueChanged(object sender, EventArgs e)
        {
            email++;
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }
    }
}
