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

namespace testCreator
{
    public partial class editTestSelect : Form
    {
        SqlConnection myConn = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;
                                                    Initial Catalog=dept_test_DB;
                                                    Integrated Security=True;");
        SqlDataAdapter myDA = new SqlDataAdapter();
        DataTable myDT = new DataTable();
        SqlCommand myComm = new SqlCommand();
        private DataSet tblDataset;
        private DataTable tblTests, tblQuestions, tblAnswers;
        string selectedDept;
        List<string> stemNames = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection myConn = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;
                                                    Initial Catalog=dept_test_DB;
                                                    Integrated Security=True;");
            myConn.Open();
            DataTable myDT = new DataTable();
            SqlCommand myComm = new SqlCommand("testEditUpdate_Stems",myConn);
            myComm.CommandType = CommandType.StoredProcedure;

            foreach(DataRow myRow in tblQuestions.Rows)
            {
                stemNames.Add(myRow["stem"].ToString());
                if(myRow.RowState == DataRowState.Modified)
                {
                    stemNames.Remove(myRow["stem"].ToString());
                    if (stemNames.Contains(myRow["stem"].ToString()))
                    {
                        
                        MessageBox.Show("This question already exists, please re-phrase");
                        stemNames.Clear();
                        return;
                    }
                    

                    myComm.Parameters.AddWithValue("@stem", myRow["stem"]);
                    myComm.Parameters.AddWithValue("@test_name",myRow["test_name"]);
                    myComm.Parameters.AddWithValue("@question_number", myRow["question_number"]);

                    myComm.ExecuteNonQuery();
                    myComm.Parameters.Clear();
                    
                }
                

            }
            myConn.Close();


        }

        public editTestSelect(string dept)
        {
            InitializeComponent();
            selectedDept = dept;
            

        }

        private void editTestSelect_Load(object sender, EventArgs e)
        {
            //prep the tables for relation setup
            tblTests = new DataTable("tblTests");
            tblQuestions = new DataTable("tblQuestions");
            tblAnswers = new DataTable("tblAnswers");

            myConn.Open();
            myDA = new SqlDataAdapter("select * from test_names where dept_name = '" + selectedDept + "'", myConn);
            //tblTests = new DataTable();
            myDA.Fill(tblTests);
            //testGridView.DataSource = myDT;

            myDA = new SqlDataAdapter("select question_number,test_id,test_name, stem from test_elements", myConn);
            myDA.Fill(tblQuestions);

            myDA = new SqlDataAdapter("select stem, question_number, correct_answer, distractor_1, distractor_2, distractor_3 from test_elements", myConn);
            myDA.Fill(tblAnswers);

            deptTests.Text = "Tests for " + selectedDept;

            //add appropriate tables to dataset
            tblDataset = new DataSet();
            tblDataset.Tables.Add(tblTests);

            tblDataset.Tables.Add(tblQuestions);
            tblDataset.Tables.Add(tblAnswers);
            tblDataset.Relations.Add("test_question_relation", tblTests.Columns["test_id"], tblQuestions.Columns["test_id"], false);
            tblDataset.Relations.Add("question_answer_relation", tblQuestions.Columns["stem"], tblAnswers.Columns["stem"], false);

            //add binding source
            BindingSource bsTest = new BindingSource();
            bsTest.DataSource = tblDataset;
            bsTest.DataMember = "tblTests";

            BindingSource bsQuest = new BindingSource();
            bsQuest.DataSource = bsTest;
            bsQuest.DataMember = "test_question_relation";

            BindingSource bsAnswer = new BindingSource();
            bsAnswer.DataSource = bsQuest;
            bsAnswer.DataMember = "question_answer_relation";

            testGridView.DataSource = bsTest;
            questionsDGV.DataSource = bsQuest;
            answersDGV.DataSource = bsAnswer;

            testGridView.Columns["test_id"].Visible = false;
            questionsDGV.Columns["test_id"].Visible = false;
            answersDGV.Columns["stem"].Visible = false;
            testGridView.Columns["date_created"].Visible = false;
            testGridView.Columns["required_group"].Visible = false;
            testGridView.Columns["dept_name"].Visible = false;
            testGridView.Columns["passing_score"].Visible = false;
            testGridView.Columns["test_creator"].Visible = false;
            questionsDGV.Columns["test_name"].Visible = false;
            answersDGV.Columns["question_number"].Visible = false;
            testGridView.Columns["test_name"].ReadOnly = true;
            questionsDGV.Columns["test_name"].ReadOnly = true;
            
        }
    }
}
    