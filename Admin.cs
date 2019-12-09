using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Texnologia_v1
{
    public partial class Admin : Form
    {
        OleDbConnection connection = new OleDbConnection();
        public Admin()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database2.accdb";
        }

        private void validate_bt_Click(object sender, EventArgs e)
        {
            all_users_label.Visible = false;
            panel_start.Visible = false;
            panel_validation.Visible = true;
            connection.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = connection;
            string query = "SELECT * FROM Table1 where validate=" + 0;
            cmd.CommandText = query;

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            if (dataGridView1.Rows.Count-1  == 0)
            {
                dataGridView1.Visible = false;
                all_users_label.Visible = true;
                bt_validate.Enabled = false;
                text_validate.Enabled = false;
            }
            else
            {
                dataGridView1.Visible = true;
                bt_validate.Enabled = true;
                text_validate.Enabled = true;
            }
            connection.Close();
        }
        int c2 = 0;
        int c1 = 0;
        int id;
        int count = 0;
        ArrayList lst = new ArrayList();
        ArrayList lst2 = new ArrayList();
        private void bt_validate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text_validate.Text) == false)
            {
                try
                {
                    id = Int32.Parse(text_validate.Text);
                }
                catch
                {
                    MessageBox.Show("Check your inputs !");
                }
                try
                {
                    connection.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = connection;
                    string query2 = "SELECT ID,validate FROM Table1 WHERE ID=" + id;
                    OleDbCommand cmd1 = new OleDbCommand(query2,connection);
                    OleDbDataReader reader = cmd1.ExecuteReader();
                    while (reader.Read())
                    {
                        c1 = reader.GetInt32(0);
                        c2 = reader.GetInt32(1);
                        lst.Add(c1);
                        lst2.Add(c2);
                    }
                    if (!lst.Contains(id))
                    {
                        MessageBox.Show("This ID  does not exist!");
                    }
                    else if (lst.Contains(id))
                    {
                        int indexItem = lst.IndexOf(id);
                        if (lst2[indexItem].ToString() != "0" )
                        {
                            MessageBox.Show("This user is already validated!");
                        }
                        else
                        {
                            string query = "UPDATE Table1 SET validate=" + 1 + " WHERE ID=" + id;
                            cmd.CommandText = query;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("User is now validated");
                            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                        }
                    }
                    //DataTable dt = new DataTable();
                    //da.Fill(dt);
                    

                    connection.Close();
                    validate_bt_Click(sender ,e);
                }
                catch
                {
                    MessageBox.Show("This ID does not exist !");
                }
            }
            else
            {
                MessageBox.Show("Please insert an ID");
            }
            
            
        }

        private void quest_bt_Click(object sender, EventArgs e)
        {
            panel_validation.Visible = false;
            panel_start.Visible = false;
            panel_quest.Visible = true;

        }

        private void Insert_question_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_quest.Text) == false && string.IsNullOrWhiteSpace(tb_a.Text) == false && string.IsNullOrWhiteSpace(tb_b.Text) == false && string.IsNullOrWhiteSpace(tb_c.Text) == false && string.IsNullOrWhiteSpace(tb_d.Text) == false && string.IsNullOrWhiteSpace(cb_answer.Text) == false && (radioButton1.Checked==true || radioButton1.Checked==true))
            {
                if (radioButton1.Checked)
                {


                    connection.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = connection;
                    string query = "INSERT INTO Table2 (Question,Answer1,Answer2,Answer3,Answer4,Correct) VALUES ('" + tb_quest.Text + "' ,'" + tb_a.Text + "' ,'" + tb_b.Text + "' ,'" + tb_c.Text + " ','" + tb_d.Text + "' ,'" + cb_answer.Text + "')";
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("User is now validated");
                    // OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    MessageBox.Show("Question successfully added to easy level !");
                    connection.Close();
                }


                else if (radioButton2.Checked)
                {
                    connection.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = connection;
                    string query = "INSERT INTO Table3 (Question,Answer1,Answer2,Answer3,Answer4,Correct) VALUES ('" + tb_quest.Text + "' ,'" + tb_a.Text + "' ,'" + tb_b.Text + "' ,'" + tb_c.Text + " ','" + tb_d.Text + "' ,'" + cb_answer.Text + "')";
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("User is now validated");
                    //OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    MessageBox.Show("Question successfully added to medium level!");
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Make sure you have entered all the required information !");
            }
                    //DataTable dt = new DataTable();
                    //da.Fill(dt);


                    
            
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

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

        private void Back_picturebox_Click(object sender, EventArgs e)
        {
            panel_validation.Visible = false;
            panel_start.Visible = true;
            panel_quest.Visible = false;
            tb_quest.Text = "" ;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            tb_a.Text = "";
            tb_b.Text = "";
            tb_c.Text = "";
            tb_d.Text = "";
            cb_answer.SelectedIndex = -1;
        }

        private void Back_from_data_picturebox_Click(object sender, EventArgs e)
        {
            panel_validation.Visible = false;
            panel_start.Visible = true;
            panel_quest.Visible = false;
            text_validate.Text = "";
        }

        private void text_validate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void admin_logout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
