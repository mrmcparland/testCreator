namespace testCreator
{
    partial class testNameDesc
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
            this.label1 = new System.Windows.Forms.Label();
            this.testNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.testDescText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.reqForCombo = new System.Windows.Forms.ComboBox();
            this.Next_btn = new System.Windows.Forms.Button();
            this.Prev_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.passingScoreCbo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test Name:";
            // 
            // testNameText
            // 
            this.testNameText.Location = new System.Drawing.Point(228, 57);
            this.testNameText.Name = "testNameText";
            this.testNameText.Size = new System.Drawing.Size(248, 20);
            this.testNameText.TabIndex = 1;
            this.testNameText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description:";
            // 
            // testDescText
            // 
            this.testDescText.Location = new System.Drawing.Point(230, 133);
            this.testDescText.Multiline = true;
            this.testDescText.Name = "testDescText";
            this.testDescText.Size = new System.Drawing.Size(248, 51);
            this.testDescText.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Required For:";
            // 
            // reqForCombo
            // 
            this.reqForCombo.FormattingEnabled = true;
            this.reqForCombo.Items.AddRange(new object[] {
            "All Employees",
            "All Managers",
            "HR Personnel",
            "IT Personnel",
            "Finance Personnel",
            "Supply Chain Personnel",
            "Operations Personnel"});
            this.reqForCombo.Location = new System.Drawing.Point(230, 198);
            this.reqForCombo.Name = "reqForCombo";
            this.reqForCombo.Size = new System.Drawing.Size(246, 21);
            this.reqForCombo.TabIndex = 6;
            // 
            // Next_btn
            // 
            this.Next_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_btn.Location = new System.Drawing.Point(213, 317);
            this.Next_btn.Name = "Next_btn";
            this.Next_btn.Size = new System.Drawing.Size(112, 59);
            this.Next_btn.TabIndex = 7;
            this.Next_btn.Text = "Next";
            this.Next_btn.UseVisualStyleBackColor = true;
            this.Next_btn.Click += new System.EventHandler(this.Next_btn_Click);
            // 
            // Prev_btn
            // 
            this.Prev_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prev_btn.Location = new System.Drawing.Point(49, 317);
            this.Prev_btn.Name = "Prev_btn";
            this.Prev_btn.Size = new System.Drawing.Size(115, 59);
            this.Prev_btn.TabIndex = 8;
            this.Prev_btn.Text = "Previous";
            this.Prev_btn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(366, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 59);
            this.button1.TabIndex = 9;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(554, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Passing Score:";
            // 
            // passingScoreCbo
            // 
            this.passingScoreCbo.FormattingEnabled = true;
            this.passingScoreCbo.Items.AddRange(new object[] {
            "100",
            "95",
            "90",
            "85",
            "80",
            "75",
            "70",
            "65",
            "60",
            "55",
            "50"});
            this.passingScoreCbo.Location = new System.Drawing.Point(232, 252);
            this.passingScoreCbo.Name = "passingScoreCbo";
            this.passingScoreCbo.Size = new System.Drawing.Size(52, 21);
            this.passingScoreCbo.TabIndex = 12;
            // 
            // testNameDesc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passingScoreCbo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Prev_btn);
            this.Controls.Add(this.Next_btn);
            this.Controls.Add(this.reqForCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.testDescText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.testNameText);
            this.Controls.Add(this.label1);
            this.Name = "testNameDesc";
            this.Text = "testNameDesc";
            this.Load += new System.EventHandler(this.testNameDesc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox testNameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox testDescText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox reqForCombo;
        private System.Windows.Forms.Button Next_btn;
        private System.Windows.Forms.Button Prev_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox passingScoreCbo;
    }
}