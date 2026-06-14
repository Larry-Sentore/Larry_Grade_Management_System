namespace Grade_Management_system
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            view_students = new Button();
            get_average = new Button();
            Lowest_Grade = new Button();
            highest_grade = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            add_grade = new TextBox();
            label4 = new Label();
            add_name = new TextBox();
            add_student = new Button();
            groupBox2 = new GroupBox();
            label1 = new Label();
            update_grade = new TextBox();
            label2 = new Label();
            update_name = new TextBox();
            update_student = new Button();
            groupBox3 = new GroupBox();
            label6 = new Label();
            search_name = new TextBox();
            search = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // view_students
            // 
            view_students.Location = new Point(612, 226);
            view_students.Name = "view_students";
            view_students.Size = new Size(142, 29);
            view_students.TabIndex = 1;
            view_students.Text = "View Students";
            view_students.UseVisualStyleBackColor = true;
            view_students.Click += button2_Click;
            // 
            // get_average
            // 
            get_average.Location = new Point(612, 285);
            get_average.Name = "get_average";
            get_average.Size = new Size(142, 29);
            get_average.TabIndex = 7;
            get_average.Text = "Get Average";
            get_average.UseVisualStyleBackColor = true;
            get_average.Click += get_average_Click;
            // 
            // Lowest_Grade
            // 
            Lowest_Grade.Location = new Point(612, 350);
            Lowest_Grade.Name = "Lowest_Grade";
            Lowest_Grade.Size = new Size(142, 29);
            Lowest_Grade.TabIndex = 8;
            Lowest_Grade.Text = "Lowest Grade";
            Lowest_Grade.UseVisualStyleBackColor = true;
            Lowest_Grade.Click += Lowest_Grade_Click;
            // 
            // highest_grade
            // 
            highest_grade.Location = new Point(612, 411);
            highest_grade.Name = "highest_grade";
            highest_grade.Size = new Size(142, 29);
            highest_grade.TabIndex = 9;
            highest_grade.Text = "Highest Grade";
            highest_grade.UseVisualStyleBackColor = true;
            highest_grade.Click += highest_grade_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(add_grade);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(add_name);
            groupBox1.Controls.Add(add_student);
            groupBox1.Location = new Point(12, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(537, 172);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Student";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(289, 38);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 11;
            label3.Text = "Enter Student Grade";
            // 
            // add_grade
            // 
            add_grade.Location = new Point(289, 70);
            add_grade.Name = "add_grade";
            add_grade.Size = new Size(223, 27);
            add_grade.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 38);
            label4.Name = "label4";
            label4.Size = new Size(142, 20);
            label4.TabIndex = 9;
            label4.Text = "Enter Student Name";
            // 
            // add_name
            // 
            add_name.Location = new Point(21, 70);
            add_name.Name = "add_name";
            add_name.Size = new Size(223, 27);
            add_name.TabIndex = 8;
            // 
            // add_student
            // 
            add_student.Location = new Point(21, 121);
            add_student.Name = "add_student";
            add_student.Size = new Size(94, 29);
            add_student.TabIndex = 7;
            add_student.Text = "Submit";
            add_student.UseVisualStyleBackColor = true;
            add_student.Click += button6_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(update_grade);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(update_name);
            groupBox2.Controls.Add(update_student);
            groupBox2.Location = new Point(12, 268);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(537, 172);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Update Student Info";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(289, 38);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 11;
            label1.Text = "Enter Student Grade";
            // 
            // update_grade
            // 
            update_grade.Location = new Point(289, 70);
            update_grade.Name = "update_grade";
            update_grade.Size = new Size(223, 27);
            update_grade.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 38);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 9;
            label2.Text = "Enter Student Name";
            // 
            // update_name
            // 
            update_name.Location = new Point(21, 70);
            update_name.Name = "update_name";
            update_name.Size = new Size(223, 27);
            update_name.TabIndex = 8;
            // 
            // update_student
            // 
            update_student.Location = new Point(21, 121);
            update_student.Name = "update_student";
            update_student.Size = new Size(94, 29);
            update_student.TabIndex = 7;
            update_student.Text = "Submit";
            update_student.UseVisualStyleBackColor = true;
            update_student.Click += update_student_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(search_name);
            groupBox3.Controls.Add(search);
            groupBox3.Location = new Point(591, 25);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(180, 159);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Search Student";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 38);
            label6.Name = "label6";
            label6.Size = new Size(142, 20);
            label6.TabIndex = 9;
            label6.Text = "Enter Student Name";
            // 
            // search_name
            // 
            search_name.Location = new Point(21, 70);
            search_name.Name = "search_name";
            search_name.Size = new Size(142, 27);
            search_name.TabIndex = 8;
            // 
            // search
            // 
            search.Location = new Point(21, 121);
            search.Name = "search";
            search.Size = new Size(94, 29);
            search.TabIndex = 7;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(800, 470);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(highest_grade);
            Controls.Add(Lowest_Grade);
            Controls.Add(get_average);
            Controls.Add(view_students);
            Name = "Form1";
            Text = "Grade Manager";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button view_students;
        private Button get_average;
        private Button Lowest_Grade;
        private Button highest_grade;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox add_grade;
        private Label label4;
        private TextBox add_name;
        private Button add_student;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox update_grade;
        private Label label2;
        private TextBox update_name;
        private Button update_student;
        private GroupBox groupBox3;
        private Label label6;
        private TextBox search_name;
        private Button search;
    }
}
