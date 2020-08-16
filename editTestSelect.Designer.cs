namespace testCreator
{
    partial class editTestSelect
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.testGridView = new System.Windows.Forms.DataGridView();
            this.deptTests = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.questionsDGV = new System.Windows.Forms.DataGridView();
            this.answersDGV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.testGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(29, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Test";
            // 
            // testGridView
            // 
            this.testGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testGridView.Location = new System.Drawing.Point(480, 60);
            this.testGridView.Name = "testGridView";
            this.testGridView.Size = new System.Drawing.Size(183, 114);
            this.testGridView.TabIndex = 2;
            // 
            // deptTests
            // 
            this.deptTests.AutoSize = true;
            this.deptTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptTests.Location = new System.Drawing.Point(247, 9);
            this.deptTests.Name = "deptTests";
            this.deptTests.Size = new System.Drawing.Size(0, 25);
            this.deptTests.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(758, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Questions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(711, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Answers";
            // 
            // questionsDGV
            // 
            this.questionsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questionsDGV.Location = new System.Drawing.Point(669, 60);
            this.questionsDGV.Name = "questionsDGV";
            this.questionsDGV.Size = new System.Drawing.Size(324, 114);
            this.questionsDGV.TabIndex = 7;
            // 
            // answersDGV
            // 
            this.answersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.answersDGV.Location = new System.Drawing.Point(480, 238);
            this.answersDGV.Name = "answersDGV";
            this.answersDGV.Size = new System.Drawing.Size(523, 150);
            this.answersDGV.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(10, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 94);
            this.button1.TabIndex = 9;
            this.button1.Text = "Commit Edits";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(469, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Changes made to questions and answers will be recorded";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(472, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "upon clicking \"Commit Edit\" button. While other fields may";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(444, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "appear editable, changes to them will not be recorded.";
            // 
            // editTestSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.answersDGV);
            this.Controls.Add(this.questionsDGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deptTests);
            this.Controls.Add(this.testGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "editTestSelect";
            this.Text = "editTestSelect";
            this.Load += new System.EventHandler(this.editTestSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answersDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView testGridView;
        private System.Windows.Forms.Label deptTests;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView questionsDGV;
        private System.Windows.Forms.DataGridView answersDGV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}