using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace testCreator
{   
    
    public class question
    {
        public int ID;
        public string stem;
        public string correctAnswer;
        public string distractor1;
        public string distractor2;
        public string distractor3;
        public string chosenAnswer;
    }
    public class questionBank
    {
        public int ID;
        public int duration_in_seconds;
        public int passing_score;
        public bool randomize;
        public bool report_results;
        public question[] qb = new question[3];      
    }
}
