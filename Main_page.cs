using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Texnologia_v1
{
    public partial class Main_page : Form
    {
        OleDbConnection connection = new OleDbConnection();
        int seconds = 0;
        int minutes = 0;
        string time;
        int question_number = 1;
        int current_mode = 1;
        int current_level = 1;
        string level = "easy";
        String query;
        string username;
        public Main_page(string name,string time,int id)
        {
            username = name;
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database2.accdb";
            quiz_panel.Visible = false;
            My_Scores_panel.Visible = false;
            Theory_panel.Visible = false;
            About_panel.Visible = false;
            // using view.details because it shows our columns in the ListView!
            ColumnHeader header1,header2,header3,header4;
            header1 = new ColumnHeader();
            header2 = new ColumnHeader();
            header3 = new ColumnHeader();
            header4 = new ColumnHeader();

            header1.Text = "Username";
            header2.Text = "Score";
            header3.Text = "Submit Date";
            header4.Text = "Time of quiz";
            header1.Width = 100;
            header2.Width = 70;
            header3.Width = 185;
            header4.Width = 120;
            listView1.Columns.Add(header1);
            listView1.Columns.Add(header2);
            listView1.Columns.Add(header3);
            listView1.Columns.Add(header4);
            listView1.View = View.Details;
            Name_label.Text = name + " !";
            DateTime now = DateTime.Now;
            String last = now.ToString();
            if (time == "0")
            {
                connection.Open();
                query = "UPDATE Table1 SET [lasttime] = ? WHERE ID = ?";
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                var accessUpdateCommand = new OleDbCommand(query, connection);
                accessUpdateCommand.Parameters.AddWithValue("lasttime", last);
                accessUpdateCommand.Parameters.AddWithValue("ID", id);
                adapter.UpdateCommand = accessUpdateCommand;
                adapter.UpdateCommand.ExecuteNonQuery();
                connection.Close();
                datetimenow_label.Text = "now";
            }
            else
            {
                datetimenow_label.Text = time;
                connection.Open();
                query = "UPDATE Table1 SET [lasttime] = ? WHERE ID = ?";
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                var accessUpdateCommand = new OleDbCommand(query, connection);
                accessUpdateCommand.Parameters.AddWithValue("lasttime", last);
                accessUpdateCommand.Parameters.AddWithValue("ID", id);
                adapter.UpdateCommand = accessUpdateCommand;
                adapter.UpdateCommand.ExecuteNonQuery();
                connection.Close();
            }
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
        // Logout button events !
        private void Logout_button_MouseEnter(object sender, EventArgs e)
        {
            Logout_button.ForeColor = Color.Goldenrod;
        }

        private void Logout_button_MouseLeave(object sender, EventArgs e)
        {
            Logout_button.ForeColor = Color.LightBlue;
        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        //about button from menu events !
        private void About_button_MouseEnter(object sender, EventArgs e)
        {
            About_button.ForeColor = Color.Goldenrod;
        }

        private void About_button_MouseLeave(object sender, EventArgs e)
        {
            About_button.ForeColor = Color.LightBlue;
        }
        //Quiz button events !
        private void Quiz_button_MouseEnter(object sender, EventArgs e)
        {
            Quiz_button.ForeColor = Color.Goldenrod;
        }

        private void Quiz_button_MouseLeave(object sender, EventArgs e)
        {
            Quiz_button.ForeColor = Color.LightBlue;
        }
        //Theory button events !
        private void Theory_button_MouseEnter(object sender, EventArgs e)
        {
            Theory_button.ForeColor = Color.Goldenrod;
        }

        private void Theory_button_MouseLeave(object sender, EventArgs e)
        {
           Theory_button.ForeColor = Color.LightBlue;
        }
        //take quiz button from menu !
        private void Quiz_button_Click(object sender, EventArgs e)
        {
            score = 0;
            arithmos = 0;
            arithmos2 = 0;
            readyForsubmit = false;
            Next_picturebox.Image = Properties.Resources.Right_arrow;
            Next_picturebox.Enabled = true;
            Previous_picturebox.Enabled = true;
            question_number_label.Text = "1/10";
            metritis = 0;
            Array.Clear(tag_answer,0,10);
            seconds = 0;
            minutes = 0;
            question_number = 1;
            About_panel.Visible = false;
            quiz_panel.Visible = true;
            My_Scores_panel.Visible = false;
            Select_difficulty_label.Visible = true;
            Easy_label.Visible = true;
            Medium_label.Visible = true;
            Hard_label.Visible = true;
            Easy_picturebox.Visible = true;
            Medium_picturebox.Visible = true;
            Hard_picturebox.Visible = true;
            Next_picturebox.Visible = false;
            Previous_picturebox.Visible = false;
            question_number_label.Visible = false;
            timer_count_label.Visible = false;
            datetimenow_label.Visible = false;
            last_signin.Visible = false;
            question_label_title.Visible = false;
            question_label.Visible = false;
			question_richtextbox.Visible = false;
			Answer_label.Visible = false;
            answer_1.Visible = false;
            answer_2.Visible = false;
            answer_3.Visible = false;
            answer_4.Visible = false;
            question_richtextbox.ReadOnly = true;
            Theory_panel.Visible = false;
        }
        //Score Button events !
        private void Score_button_MouseEnter(object sender, EventArgs e)
        {
            Score_button.ForeColor = Color.Goldenrod;
        }

        private void Score_button_MouseLeave(object sender, EventArgs e)
        {
            Score_button.ForeColor = Color.LightBlue;
        }
		//difficulty level selected!
		int[] x = new int[10];
		string[] arr4 = new string[10];
        int arithmos = 0;
        string query2;
		private void Easy_picturebox_Click(object sender, EventArgs e)
        {
            connection.Open();
            query2 = "SELECT * FROM Table2";
            OleDbCommand cmd2 = new OleDbCommand(query2, connection);
            OleDbDataReader rdr2 = cmd2.ExecuteReader();
            while (rdr2.Read())
            {
                arithmos++;
            }
            connection.Close();
            level = "easy";
            Random r = new Random();
            int k = 0;
            for (int i = 0; i < x.Length; i++)
            {
                bool f = false;
                while (f == false)
                {
                    k = r.Next(1, arithmos);
                    if (!x.Contains(k))
                    {
                        x[i] = k;
                        f = true;
                    }
                }
            }
            connection.Open();
            query = "SELECT * FROM Table2 where ID=" + x[0] + "";
            OleDbCommand cmd = new OleDbCommand(query, connection);
            OleDbDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
				question_richtextbox.Text = rdr.GetString(1);
                answer_1.Text = rdr.GetString(2);
                answer_2.Text = rdr.GetString(3);
                answer_3.Text = rdr.GetString(4);
                answer_4.Text = rdr.GetString(5);
                correctAnswers[0] = Int32.Parse(rdr.GetString(6));
            }
            connection.Close();
            timer1.Start();

            //do functions to start the test !
            Select_difficulty_label.Text ="Difficulty : "+ level;
            Easy_label.Visible = false;
            Medium_label.Visible = false;
            Hard_label.Visible = false;
            Easy_picturebox.Visible = false;
            Medium_picturebox.Visible = false;
            Hard_picturebox.Visible = false;
            Next_picturebox.Visible = true;
            Previous_picturebox.Visible = false;
            question_number_label.Visible = true;
            timer_count_label.Visible = true;
            timer1.Enabled = true;
            question_label_title.Visible = true;
            question_label.Visible = true;
			question_richtextbox.Visible = true;
			Answer_label.Visible = true;
            answer_1.Visible = true;
            answer_2.Visible = true;
            answer_3.Visible = true;
            answer_4.Visible = true;
        }

        private void Medium_picturebox_Click(object sender, EventArgs e)
        {
            connection.Open();
            query2 = "SELECT * FROM Table3";
            OleDbCommand cmd2 = new OleDbCommand(query2, connection);
            OleDbDataReader rdr2 = cmd2.ExecuteReader();
            while (rdr2.Read())
            {
                arithmos++;
            }
            connection.Close();
            level = "medium";
            Random r = new Random();
            int k = 0;
            for (int i = 0; i < x.Length; i++)
            {
                bool f = false;
                while (f == false)
                {
                    k = r.Next(1, arithmos);
                    if (!x.Contains(k))
                    {
                        x[i] = k;
                        f = true;
                    }
                }
            }
            connection.Open();
            query = "SELECT * FROM Table3 where ID=" + x[0] + "";
            OleDbCommand cmd = new OleDbCommand(query, connection);
            OleDbDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                question_richtextbox.Text = rdr.GetString(1);
                answer_1.Text = rdr.GetString(2);
                answer_2.Text = rdr.GetString(3);
                answer_3.Text = rdr.GetString(4);
                answer_4.Text = rdr.GetString(5);
                correctAnswers[0] = Int32.Parse(rdr.GetString(6));
            }
            connection.Close();
            timer1.Start();

            // do function to start the test !
            Select_difficulty_label.Text = "Difficulty : " + level;
            Easy_label.Visible = false;
            Medium_label.Visible = false;
            Hard_label.Visible = false;
            Easy_picturebox.Visible = false;
            Medium_picturebox.Visible = false;
            Hard_picturebox.Visible = false;
            Next_picturebox.Visible = true;
            Previous_picturebox.Visible = false;
            question_number_label.Visible = true;
            timer_count_label.Visible = true;
            timer1.Enabled = true;
            question_label_title.Visible = true;
            question_label.Visible = true;
			question_richtextbox.Visible = true;
			Answer_label.Visible = true;
            answer_1.Visible = true;
            answer_2.Visible = true;
            answer_3.Visible = true;
            answer_4.Visible = true;
        }
        string query3;
        int arithmos2 = 0;
        private void Hard_picturebox_Click(object sender, EventArgs e)
        {
            //for table 2
            connection.Open();
            query2 = "SELECT * FROM Table2";
            OleDbCommand cmd2 = new OleDbCommand(query2, connection);
            OleDbDataReader rdr2 = cmd2.ExecuteReader();
            while (rdr2.Read())
            {
                arithmos++;
            }
            //for table 3
            connection.Close();
            connection.Open();
            query3 = "SELECT * FROM Table3";
            OleDbCommand cmd3 = new OleDbCommand(query3, connection);
            OleDbDataReader rdr3 = cmd3.ExecuteReader();
            while (rdr3.Read())
            {
                arithmos2++;
            }
            connection.Close();
            level = "hard";
            Random r = new Random();
            int k = 0;
            for (int i = 0; i < 5; i++)
            {
                bool f = false;
                while (f == false)
                {
                    k = r.Next(1, arithmos);
                    if (!x.Contains(k))
                    {
                        x[i] = k;
                        f = true;
                    }
                }
            }
            for (int i = 5; i < x.Length; i++)
            {
                bool f = false;
                while (f == false)
                {
                    k = r.Next(1, arithmos2);
                    if (!x.Contains(k))
                    {
                        x[i] = k;
                        f = true;
                    }
                }
            }
            connection.Open();
            query = "SELECT * FROM Table2 where ID=" + x[0] + "";
            OleDbCommand cmd = new OleDbCommand(query, connection);
            OleDbDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                question_richtextbox.Text = rdr.GetString(1);
                answer_1.Text = rdr.GetString(2);
                answer_2.Text = rdr.GetString(3);
                answer_3.Text = rdr.GetString(4);
                answer_4.Text = rdr.GetString(5);
                correctAnswers[0] = Int32.Parse(rdr.GetString(6));
            }
            connection.Close();
            timer1.Start();

            // do function to start the test !
            Select_difficulty_label.Text = "Difficulty : " + level;
            Easy_label.Visible = false;
            Medium_label.Visible = false;
            Hard_label.Visible = false;
            Easy_picturebox.Visible = false;
            Medium_picturebox.Visible = false;
            Hard_picturebox.Visible = false;
            Next_picturebox.Visible = true;
            Previous_picturebox.Visible = false ;
            question_number_label.Visible = true;
            timer_count_label.Visible = true;
            timer1.Enabled = true;
            question_label_title.Visible = true;
            question_label.Visible = true;
			question_richtextbox.Visible = true;
			Answer_label.Visible = true;
            answer_1.Visible = true;
            answer_2.Visible = true;
            answer_3.Visible = true;
            answer_4.Visible = true;
        }
        int[] tag_answer = new int[10];
        int metritis = 0;
        bool readyForsubmit;
        int score = 0;
        int[] correctAnswers = new int[10];
        private void Next_picturebox_Click(object sender, EventArgs e)
        {
            /* BEFORE GOES TO NEXT LEVEL */

            //Put it in array
            foreach (RadioButton btn in quiz_panel.Controls.OfType<RadioButton>())
            {
                if (btn.Checked == true)
                {
                    tag_answer[metritis] = Int32.Parse(btn.Tag.ToString());
                    btn.Checked = false; //uncheck
                }
            }

            if (readyForsubmit)
            {
                timer1.Stop();
                Next_picturebox.Enabled = false;
                Previous_picturebox.Enabled = false;
                MessageBox.Show("Quiz successfully completed !");
                //submit score and bla bla
                time = timer_count_label.Text;
                int pointer = 0;
                foreach (int correctAnswer in correctAnswers)
                {
                    if (correctAnswer == tag_answer[pointer])
                        score++;
                    pointer++;
                }
                MessageBox.Show("Your score is : "+score.ToString()+"/10");
                int lvl = 0;
                DateTime now = DateTime.Now;
                String last = now.ToString();
                connection.Open();
                OleDbCommand cmd1 = new OleDbCommand();//+score+" '" + password_textbox.Text + "','" + email_textbox.Text + "')";
                cmd1.Connection = connection;
                if (level == "easy")
                {
                    lvl = 1;
                    cmd1.CommandText = "insert into Table4(username,score,levelPlayed,datePlayed,timescore1) values('" + username + "'," + score + "," + lvl + ",'" + last + "','" + time + "')";
                }
                else if (level == "medium")
                {
                    lvl = 2;
                    cmd1.CommandText = "insert into Table4(username,score,levelPlayed,datePlayed,timescore1) values('" + username + "'," + score + "," + lvl + ",'" + last + "','" + time + "')";
                }
                else
                {
                    lvl = 3;
                    cmd1.CommandText = "insert into Table4(username,score,levelPlayed,datePlayed,timescore1) values('" + username + "'," + score + "," + lvl + ",'" + last + "','" + time + "')";
                }
                cmd1.ExecuteNonQuery();
                connection.Close();

            }

            //goes next
            if (question_number < 10)
            {
                Next_picturebox.Visible = true;
                question_number++;
                question_number_label.Text = question_number + "/10";
            }
            if (question_number == 10)
            {
                Next_picturebox.Image = Properties.Resources.check;
                readyForsubmit = true;
            }
            if (question_number != 1)
            {
                Previous_picturebox.Visible = true;
            }
            

            metritis++;
			connection.Open();
			if (metritis >= 0 && metritis < 10)
			{
                if (level == "easy")
                {
                    query = "SELECT * FROM Table2 where ID=" + x[metritis] + "";
                }
                else if (level == "medium")
                {
                    query = "SELECT * FROM Table3 where ID=" + x[metritis] + "";
                }
                else if (level == "hard")
                {
                    if (metritis >= 0 && metritis < 5)
                    {
                        query = "SELECT * FROM Table2 where ID=" + x[metritis] + "";
                    }
                    else
                    {
                        query = "SELECT * FROM Table3 where ID=" + x[metritis] + "";
                    }
                }
                OleDbCommand cmd = new OleDbCommand(query, connection);
                OleDbDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {
                    question_richtextbox.Text = rdr.GetString(1);
                    answer_1.Text = rdr.GetString(2);
                    answer_2.Text = rdr.GetString(3);
                    answer_3.Text = rdr.GetString(4);
                    answer_4.Text = rdr.GetString(5);
                    correctAnswers[metritis] = Int32.Parse(rdr.GetString(6));
                }
            }
            connection.Close();

            //next level show the answer if it was answered before
            if (!readyForsubmit)
            {
                if (tag_answer[metritis] == 1)
                    answer_1.Checked = true;
                else if (tag_answer[metritis] == 2)
                    answer_2.Checked = true;
                else if (tag_answer[metritis] == 3)
                    answer_3.Checked = true;
                else if (tag_answer[metritis] == 4)
                    answer_4.Checked = true;
            }
        }

        private void Previous_picturebox_Click(object sender, EventArgs e)
        {
            if (question_number == 10)
            {
                Next_picturebox.Image = Properties.Resources.Right_arrow;
                readyForsubmit = false;
            }
            //uncheck
            foreach (RadioButton btn in quiz_panel.Controls.OfType<RadioButton>())
            {
                if (btn.Checked == true)
                    btn.Checked = false; //uncheck
            }

            if (question_number>1)
            {
                Previous_picturebox.Visible = true;
                question_number--;
                question_number_label.Text = question_number + "/10";
            }
            if (question_number == 1)
            {
                Previous_picturebox.Visible = false;
            }
            if (question_number != 10)
            {
                Next_picturebox.Visible = true;
            }
            metritis--;
			connection.Open();
			if (metritis >= 0 && metritis < 10)
			{
                if (level == "easy")
                {
                    query = "SELECT * FROM Table2 where ID=" + x[metritis] + "";
                }
                else if (level == "medium")
                {
                    query = "SELECT * FROM Table3 where ID=" + x[metritis] + "";
                }
                else if (level == "hard")
                {
                    if (metritis >= 0 && metritis < 5)
                    {
                        query = "SELECT * FROM Table2 where ID=" + x[metritis] + "";
                    }
                    else
                    {
                        query = "SELECT * FROM Table3 where ID=" + x[metritis] + "";
                    }
                }
                OleDbCommand cmd = new OleDbCommand(query, connection);
                OleDbDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    question_richtextbox.Text = rdr.GetString(1);
                    answer_1.Text = rdr.GetString(2);
                    answer_2.Text = rdr.GetString(3);
                    answer_3.Text = rdr.GetString(4);
                    answer_4.Text = rdr.GetString(5);
                }
            }
            connection.Close();
            if (!readyForsubmit)
            {
                if (tag_answer[metritis] == 1)
                    answer_1.Checked = true;
                else if (tag_answer[metritis] == 2)
                    answer_2.Checked = true;
                else if (tag_answer[metritis] == 3)
                    answer_3.Checked = true;
                else if (tag_answer[metritis] == 4)
                    answer_4.Checked = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //set up timer 
            seconds++;
            if(seconds == 60)
            {
                minutes++;
                seconds = 0;
            }
            if (seconds < 10 && minutes < 10)
            {
                timer_count_label.Text = "0"+minutes+ " : "+ "0"+ seconds;
            }
            else if (seconds <10 && minutes >= 10)
            {
                timer_count_label.Text = minutes + " : " + "0" + seconds;
            }
            else if (seconds >= 10 && minutes <10)
            {
                timer_count_label.Text = "0" + minutes + " : "+ seconds;
            }
            else if (seconds >= 10 && minutes >=10)
            {
                timer_count_label.Text = minutes + " : " + seconds;
            }
        }

		private void question_richtextbox_TextChanged(object sender, EventArgs e)
		{

		}

        private void quiz_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Theory_button_Click(object sender, EventArgs e)
        {
            About_panel.Visible = false;
            instructions_label.Visible = false;
            back_arrow_for_theory.Visible = false;
            pdf_reader.Visible = false;
            quiz_panel.Visible = false;
            My_Scores_panel.Visible = false;
            Theory_panel.Visible = true;
            First_theory_label.Visible = true;
            first_theory_picturebox.Visible = true;
            Second_theory_label.Visible = true;
            second_theory_picturebox.Visible = true;
        }
        //Events for picturebox clicks from theory panel!
        private void first_theory_picturebox_Click(object sender, EventArgs e)
        {
            pdf_reader.LoadFile("Theory_first_level.pdf");
            instructions_label.Visible = true;
            back_arrow_for_theory.Visible = true;
            pdf_reader.Visible = true;
            First_theory_label.Visible = false;
            first_theory_picturebox.Visible = false;
            Second_theory_label.Visible = false;
            second_theory_picturebox.Visible = false;
        }

        private void second_theory_picturebox_Click(object sender, EventArgs e)
        {
            pdf_reader.LoadFile("Theory_second_level.pdf");
            instructions_label.Visible = true;
            back_arrow_for_theory.Visible = true;
            pdf_reader.Visible = true;
            First_theory_label.Visible = false;
            first_theory_picturebox.Visible = false;
            Second_theory_label.Visible = false;
            second_theory_picturebox.Visible = false;
        }

        private void back_arrow_for_theory_Click(object sender, EventArgs e)
        {
            instructions_label.Visible = false;
            back_arrow_for_theory.Visible = false;
            pdf_reader.Visible = false;
            First_theory_label.Visible = true;
            first_theory_picturebox.Visible = true;
            Second_theory_label.Visible = true;
            second_theory_picturebox.Visible = true;
        }

        private void Title_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Score_button_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            listView1.Visible = true;
            My_Scores_panel.Visible = true;
            quiz_panel.Visible = false;
            Theory_panel.Visible = false;
            About_panel.Visible = false;
            Calculate(current_mode, current_level);
        }

        private void About_button_Click(object sender, EventArgs e)
        {
            About_panel.Visible = true;
            quiz_panel.Visible = false;
            Theory_panel.Visible = false;
            My_Scores_panel.Visible = false;
        }
        private void Calculate(int mode, int level)
        {
            dataGridView1.Visible = false;
            listView1.Items.Clear();
            connection.Open();

            //OleDbCommand cmd = new OleDbCommand(query, connection);
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = connection;
            if (mode == 1 && level == 1)
            {
                query = "SELECT username,score,datePlayed,timescore1 FROM Table4 where levelPlayed=" + 1 + " AND username = '" + username + "' ORDER BY score DESC";
                //MessageBox.Show(username);
            }

            else if (mode == 1 && level == 2)
            {
                query = "SELECT username,score,datePlayed,timescore1 FROM Table4 where levelPlayed=" + 2 + " AND username = '" + username + "' ORDER BY score DESC";
            }
            else if (mode == 1 && level == 3)
            {
                query = "SELECT username,score,datePlayed,timescore1 FROM Table4 where levelPlayed=" + 3 + " AND username = '" + username + "' ORDER BY score DESC";
            }
            else if (mode == 2 && level == 1)
            {
                query = "SELECT username,score,datePlayed,timescore1 FROM Table4 where levelPlayed=" + 1 + " ORDER BY score DESC";
            }
            else if (mode == 2 && level == 2)
            {
                query = "SELECT username,score,datePlayed,timescore1 FROM Table4 where levelPlayed=" + 2 + " ORDER BY score DESC";
            }
            else if (mode == 2 && level == 3)
            {
                query = "SELECT username,score,datePlayed,timescore1 FROM Table4 where levelPlayed=" + 3 + " ORDER BY score DESC";
            }
            cmd.CommandText = query;
            //OleDbDataReader rdr = cmd.ExecuteReader();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            for (int i=0;i<dataGridView1.Rows.Count-1;i++)
            {
                var item1 = new ListViewItem(new[] { dataGridView1.Rows[i].Cells[0].Value.ToString(), dataGridView1.Rows[i].Cells[1].Value.ToString() + "/10", dataGridView1.Rows[i].Cells[2].Value.ToString(), dataGridView1.Rows[i].Cells[3].Value.ToString() });
                listView1.Items.Add(item1);
            }
            connection.Close();
        }

        private void personal_bt_Click(object sender, EventArgs e)
        {
            global_bt.BackColor = Color.FromArgb(26,32,40);
            personal_bt.BackColor = Color.FromArgb(22, 50, 90);
            current_mode = 1;
            Calculate(current_mode, current_level);
        }

        private void global_bt_Click(object sender, EventArgs e)
        {
            global_bt.BackColor = Color.FromArgb(22, 50, 90);
            personal_bt.BackColor = Color.FromArgb(26, 32, 40);
            current_mode = 2;
            Calculate(current_mode, current_level);
        }

        private void easy_bt_Click(object sender, EventArgs e)
        {
            easy_bt.BackColor = Color.FromArgb(22, 50, 90);
            med_bt.BackColor  = Color.FromArgb(26, 32, 40);
            hard_bt.BackColor = Color.FromArgb(26, 32, 40);
            current_level = 1;
            Calculate(current_mode, current_level);
        }

        private void med_bt_Click(object sender, EventArgs e)
        {
            easy_bt.BackColor = Color.FromArgb(26, 32, 40);
            med_bt.BackColor = Color.FromArgb(22, 50, 90);
            hard_bt.BackColor = Color.FromArgb(26, 32, 40);
            current_level = 2;
            Calculate(current_mode, current_level);
        }

        private void hard_bt_Click(object sender, EventArgs e)
        {
            easy_bt.BackColor = Color.FromArgb(26, 32, 40);
            med_bt.BackColor  = Color.FromArgb(26, 32, 40);
            hard_bt.BackColor = Color.FromArgb(22, 50, 90);
            current_level = 3;
            Calculate(current_mode, current_level);
        }
    }
}
