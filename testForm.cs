using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace testCreator
{
    
    public partial class testForm : Form
    {
        
        //public int arraySize = new int();
        questionBank myBank = new questionBank();
        question thisQuestion = new question();
        private static Random random = new Random();
        int current_item_index = 0;
        int min_index = 0;
        int correct_option;
        int max_index;
        
        


        public testForm(string employeeDept,string chosenTest)
        {
            InitializeComponent();
            
            lblTestName.Text = chosenTest;

        }

        private void testForm_Load(object sender, EventArgs e)
        {
            
            SqlConnection myConn = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;
                                                        Initial Catalog=dept_test_DB;
                                                        Integrated Security=True;");
            myConn.Open();
            SqlDataAdapter myDA = new SqlDataAdapter("select * from test_elements where test_name ='" + lblTestName.Text + "'", myConn);
            DataTable myDT = new DataTable();
            myDA.Fill(myDT);
            //dataGridView1.DataSource = myDT;
            myConn.Close();
            int arrayCount = myDT.Select().Length;
            //assign questions to stemList
            Array.Resize<question>(ref myBank.qb, arrayCount);
            max_index = myDT.Rows.Count;
            MessageBox.Show("Max index is " + max_index );

            //int i = 0;
            foreach (DataRow myRow in myDT.Rows)
            {
                myBank.qb[current_item_index] = new question();
                myBank.qb[current_item_index].ID = current_item_index + 1;
                myBank.qb[current_item_index].stem = myRow["stem"].ToString();
                myBank.qb[current_item_index].correctAnswer = myRow["correct_answer"].ToString();
                myBank.qb[current_item_index].distractor1 = myRow["distractor_1"].ToString();
                myBank.qb[current_item_index].distractor2 = myRow["distractor_2"].ToString();
                myBank.qb[current_item_index].distractor3 = myRow["distractor_3"].ToString();
                if (current_item_index < myDT.Rows.Count)
                {
                    current_item_index = current_item_index + 1;
                }

            }
            optionA.Checked = false;
            current_item_index = 0;
            //MessageBox.Show("Current item index is " + myBank.qb[0].distractor1);
            //stem.Text = myBank.qb[current_item_index].stem;
            //option_a_text.Text = myBank.qb[current_item_index].correctAnswer;

            set_navigation_buttons();          //load_the_bank();

             randomize_the_bank();
             paint_the_screen();
        }
        public void load_the_bank()
        {
            
        }
        public void randomize_the_bank()
        {
            for(int i = myBank.qb.Length-1; i >=0;i--)
            {
                thisQuestion = myBank.qb[i];
                int randomIndex = random.Next(i + 1);

                myBank.qb[i] = new question();
                myBank.qb[i] = myBank.qb[randomIndex];
                myBank.qb[randomIndex] = thisQuestion;
            }
        }
        public void paint_the_screen()
        {
            question_lbl.Text = Convert.ToString(current_item_index +1);
            set_navigation_buttons();
            //not a T/F q

            stem.Text = myBank.qb[current_item_index].stem;
                optionA.Enabled = true;
                optionA.Visible = true;
                optionA.Checked = false;
                optionB.Enabled = true;
                optionB.Visible = true;
                optionB.Checked = false;
                optionC.Enabled = true;
                optionC.Visible = true;
                optionC.Checked = false;
                optionD.Enabled = true;
                optionD.Visible = true;
            optionD.Checked = false;

                correct_option = random.Next(3);
                switch(correct_option)
                {
                    case 0:
                        {
                            option_a_text.Text = myBank.qb[current_item_index].correctAnswer;
                            option_b_text.Text = myBank.qb[current_item_index].distractor1;
                            option_c_text.Text = myBank.qb[current_item_index].distractor2;
                            option_d_text.Text = myBank.qb[current_item_index].distractor3;
                            if (myBank.qb[current_item_index].chosenAnswer == myBank.qb[current_item_index].correctAnswer)
                                optionA.Checked = true;
                            else if (myBank.qb[current_item_index].chosenAnswer == myBank.qb[current_item_index].distractor1)
                                optionB.Checked = true;
                            else if (myBank.qb[current_item_index].chosenAnswer == myBank.qb[current_item_index].distractor2)
                                optionC.Checked = true;
                            else if (myBank.qb[current_item_index].chosenAnswer == myBank.qb[current_item_index].distractor3)
                                optionD.Checked = true;
                        }
                        break;
                    case 1:
                        {
                            option_a_text.Text = myBank.qb[current_item_index].distractor1;
                            option_b_text.Text = myBank.qb[current_item_index].correctAnswer;
                            option_c_text.Text = myBank.qb[current_item_index].distractor2;
                            option_d_text.Text = myBank.qb[current_item_index].distractor3;
                            if (myBank.qb[current_item_index].chosenAnswer == myBank.qb[current_item_index].distractor1)
                                optionA.Checked = true;
                            else if (myBank.qb[current_item_index].chosenAnswer == myBank.qb[current_item_index].correctAnswer)
                                optionB.Checked = true;
                            else if (myBank.qb[current_item_index].chosenAnswer == myBank.qb[current_item_index].distractor2)
                                optionC.Checked = true;
                            else if (myBank.qb[current_item_index].chosenAnswer == myBank.qb[current_item_index].distractor3)
                                optionD.Checked = true;
                        }
                        break;
                    case 2:
                        {
                            option_a_text.Text = myBank.qb[current_item_index].distractor1;
                            option_b_text.Text = myBank.qb[current_item_index].distractor2;
                            option_c_text.Text = myBank.qb[current_item_index].correctAnswer;
                            option_d_text.Text = myBank.qb[current_item_index].distractor3;
                            if (myBank.qb[current_item_index].chosenAnswer == myBank.qb[current_item_index].distractor1)
                                optionA.Checked = true;
                            else if (myBank.qb[current_item_index].chosenAnswer == myBank.qb[current_item_index].distractor2)
                                optionB.Checked = true;
                            else if (myBank.qb[current_item_index].chosenAnswer == myBank.qb[current_item_index].correctAnswer)
                                optionC.Checked = true;
                            else if (myBank.qb[current_item_index].chosenAnswer == myBank.qb[current_item_index].distractor3)
                                optionD.Checked = true;
                        }
                        break;
                    case 3:
                        {
                            option_a_text.Text = myBank.qb[current_item_index].distractor1;
                            option_b_text.Text = myBank.qb[current_item_index].distractor2;
                            option_c_text.Text = myBank.qb[current_item_index].distractor3;
                            option_d_text.Text = myBank.qb[current_item_index].correctAnswer;
                            if (myBank.qb[current_item_index].chosenAnswer == myBank.qb[current_item_index].distractor1)
                                optionA.Checked = true;
                            else if (myBank.qb[current_item_index].chosenAnswer == myBank.qb[current_item_index].distractor2)
                                optionB.Checked = true;
                            else if (myBank.qb[current_item_index].chosenAnswer == myBank.qb[current_item_index].distractor3)
                                optionC.Checked = true;
                            else if (myBank.qb[current_item_index].chosenAnswer == myBank.qb[current_item_index].correctAnswer)
                                optionD.Checked = true;
                        }
                        break;
                
                
            }
        }
        public void set_navigation_buttons()
        {
            if(current_item_index == min_index)
            {
                first_item_btn.Visible = false;
                prev_item_btn.Visible = false;
                next_item_btn.Visible = true;
                last_item_btn.Visible = true;
            }
            else if (current_item_index == max_index-1)
            {
                first_item_btn.Visible = true;
                prev_item_btn.Visible = true;
                next_item_btn.Visible = false;
                last_item_btn.Visible = false;
            }
            else
            {
                first_item_btn.Visible = true;
                prev_item_btn.Visible = true;
                next_item_btn.Visible = true;
                last_item_btn.Visible = true;
            }
        }
        public void record_previous_answer()
        {
            if (optionA.Checked == true)
                myBank.qb[current_item_index].chosenAnswer = option_a_text.Text;
            else if (optionB.Checked == true)
                myBank.qb[current_item_index].chosenAnswer = option_b_text.Text;
            else if (optionC.Checked == true)
                myBank.qb[current_item_index].chosenAnswer = option_c_text.Text;
            else if (optionD.Checked == true)
                myBank.qb[current_item_index].chosenAnswer = option_d_text.Text;
        }
        private void next_item_btn_Click(object sender, EventArgs e)
        {
            record_previous_answer();
            if (current_item_index < max_index)
                current_item_index = current_item_index + 1;
            paint_the_screen();

        }

        private void last_item_btn_Click(object sender, EventArgs e)
        {
            record_previous_answer();
            current_item_index = max_index-1;
            paint_the_screen();
        }

        private void prev_item_btn_Click(object sender, EventArgs e)
        {
            record_previous_answer();
            if (current_item_index > min_index)
                current_item_index = current_item_index - 1;
            paint_the_screen();
        }

        private void first_item_btn_Click(object sender, EventArgs e)
        {
            record_previous_answer();
            current_item_index = min_index;
            paint_the_screen();
        }
    }
}
