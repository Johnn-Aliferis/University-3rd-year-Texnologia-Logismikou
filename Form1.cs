using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Texnologia_v1
{
    public partial class Lopin_form : Form
    {
        bool username_clicked = false;
        bool password_clicked = false;
        OleDbConnection connection = new OleDbConnection();
        private string name, time;
        private int id;
        public Lopin_form()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database2.accdb";
        }

        //close button events!
        private void Close_picturebox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Close_picturebox_MouseEnter(object sender, EventArgs e)
        {
            Close_picturebox.Image = Properties.Resources.Delete_Red;
        }

        private void Close_picturebox_MouseLeave(object sender, EventArgs e)
        {
            Close_picturebox.Image = Properties.Resources.Delete_White;
        }
        //Create a new account label events!
        private void Create_new_account_label_Click(object sender, EventArgs e)
        {
            Signup sgn = new Signup();
            this.Hide();
            sgn.ShowDialog();

        }

        private void Create_new_account_label_MouseEnter(object sender, EventArgs e)
        {
            Create_new_account_label.ForeColor = Color.AliceBlue;
        }

        private void Create_new_account_label_MouseLeave(object sender, EventArgs e)
        {
            Create_new_account_label.ForeColor = Color.LightBlue;
        }
        //Login button events !
        int val;
        private void Login_button_Click(object sender, EventArgs e)
        {
                connection.Open();
                String query = "SELECT * FROM Table1 where Username='" + username_textbox.Text + "' and Pass='" + password_textbox.Text + "'";
                OleDbCommand cmd = new OleDbCommand(query, connection);
                OleDbDataReader rdr = cmd.ExecuteReader();
                int c = 0;
                while (rdr.Read())
                {
                    c = c + 1;
                    name = rdr.GetString(1);
                    id = rdr.GetInt32(0);
                    time = rdr.GetString(4);
                    val = rdr.GetInt32(5);
                }
            if (c == 1)
            {
                if (name == "admin")
                {
                    MessageBox.Show("Welcome admin");
                    Admin adm = new Admin();
                    this.Hide();
                    adm.ShowDialog();

                }
                else
                {
                    if (val!=0)
                    {
                        MessageBox.Show("Login Successful !");
                        Main_page mnm = new Main_page(name, time, id);
                        this.Hide();
                        mnm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("This account must be first validated by the admin !");
                    }
                }
            }
            if (c == 0)
                {
                    MessageBox.Show("Username and password is false or you don't have access");
                    username_textbox.Text = "";
                    password_textbox.Text = "";
                }
                connection.Close();
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
                password_textbox.isPassword=true;
                e.Handled = true;
            }
        }
        int counter = 0;
        private void password_textbox_MouseEnter(object sender, EventArgs e)
        {
            if (!password_clicked)
            {
                password_clicked = true;
                password_textbox.isPassword = true;
                if (counter == 0)
                {
                    counter++;
                    password_textbox.Text = "";
                    // if user does not move mouse and use tab for inputs !
                }
            }
        }

        private void password_textbox_OnValueChanged(object sender, EventArgs e)
        {
            password_textbox.isPassword = true;
            counter++;
        }
        int k = 0; 
        private void username_textbox_MouseEnter(object sender, EventArgs e)
        {
            if (!username_clicked)
            {
                if (k == 0)
                {
                    k++;
                    username_textbox.Text = "";
                }
                username_clicked = true;
            }
        }

        private void Lopin_form_Load(object sender, EventArgs e)
        {

        }

        private void username_textbox_OnValueChanged(object sender, EventArgs e)
        {
            k++;
        }
    }

}
