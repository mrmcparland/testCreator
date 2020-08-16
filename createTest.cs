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
using System.Drawing.Imaging;

namespace testCreator
{
    public partial class createTest : Form
    {
        SqlConnection myConn = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;
                                                   Initial Catalog=dept_test_DB;
                                                    Integrated Security=True;");
        
        SqlCommand myComm = new SqlCommand();
        SqlDataAdapter myDA = new SqlDataAdapter();
        DataTable myDT = new DataTable();
        int question_number =1;
        int nextTestID;
        string deptName;
        string empEmail;
        string reqdFor;
        double scoreMin;
        

        public createTest(string testName, string dept, string email,string reqdForDept,string passingScore)
        {
            InitializeComponent();
            TestName.Text = testName;
            deptName = dept;
            empEmail = email;
            reqdFor = reqdForDept;
            scoreMin = Convert.ToDouble(passingScore);
        }

        private void createTest_Load(object sender, EventArgs e)
        {
            question_number = 1;
            question_nbr_lbl.Text = question_number.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myConn.Open();

            //to establish the next test_id PK
            myDA = new SqlDataAdapter("select  distinct test_name from test_names", myConn);
            myDA.Fill(myDT);
            if (nextTestID == 0)
                nextTestID = myDT.Rows.Count + 1;
            else
                nextTestID = myDT.Rows.Count;
            MessageBox.Show("Next test id will be " + nextTestID);

            //dataGridView1.DataSource = myDT;
            myDT.Clear();


            //MessageBox.Show("Next test ID will be # " + nextTestID);
            myComm = new SqlCommand("createQuestion", myConn);
            myComm.CommandType = CommandType.StoredProcedure;

            myComm.Parameters.AddWithValue("@test_id", nextTestID);
            myComm.Parameters.AddWithValue("@stem", stem.Text);
            myComm.Parameters.AddWithValue("@test_name", TestName.Text);
            myComm.Parameters.AddWithValue("@correctAnswer", correctAnswer.Text);
            myComm.Parameters.AddWithValue("@distractor1", distractor1.Text);
            myComm.Parameters.AddWithValue("@distractor2", distractor2.Text);
            myComm.Parameters.AddWithValue("@distractor3", distractor3.Text);
            myComm.Parameters.AddWithValue("@question_number", question_number);

            myComm.ExecuteNonQuery();
            myComm.Parameters.Clear();

            
            /*
            myComm = new SqlCommand("assign_test_id", myConn);
            myComm.CommandType = CommandType.StoredProcedure;

            myComm.Parameters.AddWithValue("@test_id", nextTestID);
            myComm.ExecuteNonQuery();
            myComm.Parameters.Clear();
            */

            if (question_number < 2)
            {
                myComm = new SqlCommand("publishTest", myConn);
                myComm.CommandType = CommandType.StoredProcedure;

                myComm.Parameters.AddWithValue("@test_id", nextTestID);
                myComm.Parameters.AddWithValue("@test_name", TestName.Text);
                myComm.Parameters.AddWithValue("@dept_name", deptName);
                myComm.Parameters.AddWithValue("@test_creator", empEmail);
                myComm.Parameters.AddWithValue("@date_created", DateTime.Now);
                myComm.Parameters.AddWithValue("@required_group", reqdFor);
                myComm.Parameters.AddWithValue("@passing_score", scoreMin);


                myComm.ExecuteNonQuery();
                myComm.Parameters.Clear();
            }

            myConn.Close();
            stem.Text = "";
            correctAnswer.Text = "";
            distractor1.Text = "";
            distractor2.Text = "";
            distractor3.Text = "";

            question_number = question_number + 1;

        }

        private void submitTestBtn_Click(object sender, EventArgs e)
        {
            myConn.Open();
            myDA = new SqlDataAdapter("select  distinct test_name from test_names", myConn);
            myDA.Fill(myDT);
            nextTestID = myDT.Rows.Count;
            MessageBox.Show("Question number is " + question_number +
                "; test_id is " + nextTestID);
            //dataGridView1.DataSource = myDT;
            myDT.Clear();
            if (question_number < 2)
            {
                question_number = question_number + 1;
                myComm = new SqlCommand("publishTest", myConn);
                myComm.CommandType = CommandType.StoredProcedure;

                myComm.Parameters.AddWithValue("@test_id", nextTestID);
                myComm.Parameters.AddWithValue("@test_name", TestName.Text);
                myComm.Parameters.AddWithValue("@dept_name", deptName);
                myComm.Parameters.AddWithValue("@test_creator", empEmail);
                myComm.Parameters.AddWithValue("@date_created", DateTime.Now);
                myComm.Parameters.AddWithValue("@required_group", reqdFor);
                myComm.Parameters.AddWithValue("@passing_score", scoreMin);


                myComm.ExecuteNonQuery();
                myComm.Parameters.Clear();
            }
            myComm = new SqlCommand("createQuestion", myConn);
            myComm.CommandType = CommandType.StoredProcedure;

            myComm.Parameters.AddWithValue("@test_id", nextTestID);
            myComm.Parameters.AddWithValue("@stem", stem.Text);
            myComm.Parameters.AddWithValue("@test_name", TestName.Text);
            myComm.Parameters.AddWithValue("@correctAnswer", correctAnswer.Text);
            myComm.Parameters.AddWithValue("@distractor1", distractor1.Text);
            myComm.Parameters.AddWithValue("@distractor2", distractor2.Text);
            myComm.Parameters.AddWithValue("@distractor3", distractor3.Text);
            myComm.Parameters.AddWithValue("@question_number", question_number);

            myComm.ExecuteNonQuery();
            myComm.Parameters.Clear();


            /*
            myComm = new SqlCommand("assign_test_id", myConn);
            myComm.CommandType = CommandType.StoredProcedure;

            myComm.Parameters.AddWithValue("@test_id", nextTestID);
            myComm.ExecuteNonQuery();
            myComm.Parameters.Clear();
            */

            


            mainMenu mm = new mainMenu();
            mm.Show();
            this.Close();
            

        }
    }
}
