namespace testCreator
{
    partial class createTest
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
            this.stem = new System.Windows.Forms.TextBox();
            this.distractor1 = new System.Windows.Forms.TextBox();
            this.distractor3 = new System.Windows.Forms.TextBox();
            this.distractor2 = new System.Windows.Forms.TextBox();
            this.correctAnswer = new System.Windows.Forms.TextBox();
            this.question = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nextQbtn = new System.Windows.Forms.Button();
            this.submitTestBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TestName = new System.Windows.Forms.Label();
            this.question_nbr_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stem
            // 
            this.stem.Location = new System.Drawing.Point(187, 42);
            this.stem.Multiline = true;
            this.stem.Name = "stem";
            this.stem.Size = new System.Drawing.Size(585, 77);
            this.stem.TabIndex = 0;
            // 
            // distractor1
            // 
            this.distractor1.Location = new System.Drawing.Point(187, 204);
            this.distractor1.Multiline = true;
            this.distractor1.Name = "distractor1";
            this.distractor1.Size = new System.Drawing.Size(585, 40);
            this.distractor1.TabIndex = 2;
            // 
            // distractor3
            // 
            this.distractor3.Location = new System.Drawing.Point(187, 333);
            this.distractor3.Multiline = true;
            this.distractor3.Name = "distractor3";
            this.distractor3.Size = new System.Drawing.Size(585, 40);
            this.distractor3.TabIndex = 4;
            // 
            // distractor2
            // 
            this.distractor2.Location = new System.Drawing.Point(187, 269);
            this.distractor2.Multiline = true;
            this.distractor2.Name = "distractor2";
            this.distractor2.Size = new System.Drawing.Size(585, 40);
            this.distractor2.TabIndex = 3;
            // 
            // correctAnswer
            // 
            this.correctAnswer.Location = new System.Drawing.Point(187, 144);
            this.correctAnswer.Multiline = true;
            this.correctAnswer.Name = "correctAnswer";
            this.correctAnswer.Size = new System.Drawing.Size(585, 40);
            this.correctAnswer.TabIndex = 1;
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question.Location = new System.Drawing.Point(32, 58);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(94, 24);
            this.question.TabIndex = 5;
            this.question.Text = "Question";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Distractor 3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Distractor 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "Distractor 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "Correct Answer";
            // 
            // nextQbtn
            // 
            this.nextQbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextQbtn.Location = new System.Drawing.Point(14, 395);
            this.nextQbtn.Name = "nextQbtn";
            this.nextQbtn.Size = new System.Drawing.Size(300, 43);
            this.nextQbtn.TabIndex = 5;
            this.nextQbtn.Text = "Next Question";
            this.nextQbtn.UseVisualStyleBackColor = true;
            this.nextQbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // submitTestBtn
            // 
            this.submitTestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitTestBtn.Location = new System.Drawing.Point(517, 395);
            this.submitTestBtn.Name = "submitTestBtn";
            this.submitTestBtn.Size = new System.Drawing.Size(255, 43);
            this.submitTestBtn.TabIndex = 6;
            this.submitTestBtn.Text = "Submit Test";
            this.submitTestBtn.UseVisualStyleBackColor = true;
            this.submitTestBtn.Click += new System.EventHandler(this.submitTestBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Test Name:";
            // 
            // TestName
            // 
            this.TestName.AutoSize = true;
            this.TestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestName.Location = new System.Drawing.Point(331, 9);
            this.TestName.Name = "TestName";
            this.TestName.Size = new System.Drawing.Size(0, 24);
            this.TestName.TabIndex = 19;
            // 
            // question_nbr_lbl
            // 
            this.question_nbr_lbl.AutoSize = true;
            this.question_nbr_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question_nbr_lbl.Location = new System.Drawing.Point(132, 66);
            this.question_nbr_lbl.Name = "question_nbr_lbl";
            this.question_nbr_lbl.Size = new System.Drawing.Size(0, 25);
            this.question_nbr_lbl.TabIndex = 20;
            // 
            // createTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.question_nbr_lbl);
            this.Controls.Add(this.TestName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitTestBtn);
            this.Controls.Add(this.nextQbtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.question);
            this.Controls.Add(this.correctAnswer);
            this.Controls.Add(this.distractor2);
            this.Controls.Add(this.distractor3);
            this.Controls.Add(this.distractor1);
            this.Controls.Add(this.stem);
            this.Name = "createTest";
            this.Text = "createTest";
            this.Load += new System.EventHandler(this.createTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stem;
        private System.Windows.Forms.TextBox distractor1;
        private System.Windows.Forms.TextBox distractor3;
        private System.Windows.Forms.TextBox distractor2;
        private System.Windows.Forms.TextBox correctAnswer;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button nextQbtn;
        private System.Windows.Forms.Button submitTestBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TestName;
        private System.Windows.Forms.Label question_nbr_lbl;
    }
}