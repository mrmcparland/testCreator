namespace testCreator
{
    partial class mainMenu
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
            this.createTest = new System.Windows.Forms.Button();
            this.editTest = new System.Windows.Forms.Button();
            this.takeTest = new System.Windows.Forms.Button();
            this.deptCombo = new System.Windows.Forms.ComboBox();
            this.deptLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.empEmail = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createTest
            // 
            this.createTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTest.Location = new System.Drawing.Point(24, 228);
            this.createTest.Name = "createTest";
            this.createTest.Size = new System.Drawing.Size(319, 185);
            this.createTest.TabIndex = 9;
            this.createTest.Text = "Create Test";
            this.createTest.Click += new System.EventHandler(this.createTest_Click);
            // 
            // editTest
            // 
            this.editTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTest.Location = new System.Drawing.Point(410, 23);
            this.editTest.Name = "editTest";
            this.editTest.Size = new System.Drawing.Size(289, 185);
            this.editTest.TabIndex = 1;
            this.editTest.Text = "Edit Test";
            this.editTest.UseVisualStyleBackColor = true;
            this.editTest.Click += new System.EventHandler(this.editTest_Click);
            // 
            // takeTest
            // 
            this.takeTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takeTest.Location = new System.Drawing.Point(410, 228);
            this.takeTest.Name = "takeTest";
            this.takeTest.Size = new System.Drawing.Size(289, 185);
            this.takeTest.TabIndex = 9;
            this.takeTest.Text = "Take Test";
            this.takeTest.Click += new System.EventHandler(this.takeTest_Click);
            // 
            // deptCombo
            // 
            this.deptCombo.FormattingEnabled = true;
            this.deptCombo.Items.AddRange(new object[] {
            "HR",
            "Finance",
            "Operations",
            "Supply Chain",
            "IT"});
            this.deptCombo.Location = new System.Drawing.Point(52, 45);
            this.deptCombo.Name = "deptCombo";
            this.deptCombo.Size = new System.Drawing.Size(121, 21);
            this.deptCombo.TabIndex = 3;
            // 
            // deptLbl
            // 
            this.deptLbl.AutoSize = true;
            this.deptLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptLbl.Location = new System.Drawing.Point(48, 23);
            this.deptLbl.Name = "deptLbl";
            this.deptLbl.Size = new System.Drawing.Size(203, 20);
            this.deptLbl.TabIndex = 4;
            this.deptLbl.Text = "Select Your Department";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Employee Email:";
            // 
            // empEmail
            // 
            this.empEmail.Location = new System.Drawing.Point(54, 99);
            this.empEmail.Name = "empEmail";
            this.empEmail.Size = new System.Drawing.Size(100, 20);
            this.empEmail.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(52, 155);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(102, 20);
            this.textBox2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.empEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deptLbl);
            this.Controls.Add(this.deptCombo);
            this.Controls.Add(this.takeTest);
            this.Controls.Add(this.editTest);
            this.Controls.Add(this.createTest);
            this.Name = "mainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createTest;
        private System.Windows.Forms.Button editTest;
        private System.Windows.Forms.Button takeTest;
        private System.Windows.Forms.ComboBox deptCombo;
        private System.Windows.Forms.Label deptLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox empEmail;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}

