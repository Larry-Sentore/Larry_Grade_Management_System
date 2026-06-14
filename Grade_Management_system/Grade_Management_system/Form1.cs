namespace Grade_Management_system
{
    public partial class Form1 : Form
    {
        enum Grade { A, B, C, D, F }

        static readonly Dictionary<string, int> studentGrades = [];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void groupBox1_Enter(object sender, EventArgs e) { }

        // Add Student

        private void button6_Click(object sender, EventArgs e)
        {
            string name = add_name.Text;

            if (studentGrades.ContainsKey(name))
            {
                MessageBox.Show("Student already exists. Use Update to change their grade.");
                return;
            }

            try
            {
                int grade = int.Parse(add_grade.Text);
                studentGrades[name] = grade;
                MessageBox.Show($"Student Added");
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid grade. Please enter a number.");
            }

            add_name.Clear();
            add_grade.Clear();
        }

        // Update Student

        private void update_student_Click(object sender, EventArgs e)
        {
            string name = update_name.Text;

            if (studentGrades.ContainsKey(name))
            {
                try
                {
                    int grade = int.Parse(update_grade.Text);
                    studentGrades[name] = grade;
                    MessageBox.Show($"Student {name} updated to {grade}%.");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid grade. Please enter a number.");
                }
            }
            else
            {
                MessageBox.Show("Student not found.");
            }

            update_name.Clear();
            update_grade.Clear();
        }

        // Search Student

        private void search_Click(object sender, EventArgs e)
        {
            string name = search_name.Text;

            if (studentGrades.ContainsKey(name))
            {
                MessageBox.Show($"Student: {name}, Grade: {studentGrades[name]}");
            }
            else
            {
                MessageBox.Show("Student not found.");
            }

            search_name.Clear();
        }

        // View Students
        private void button2_Click(object sender, EventArgs e)
        {
            if (studentGrades.Count == 0)
            {
                MessageBox.Show("No students on record.");
                return;
            }

            string result = "";
            foreach (var student in studentGrades)
            {
                result += $"Student: {student.Key}, Grade: {student.Value}% ({GetLetterGrade(student.Value)})\n";
            }

            MessageBox.Show(result, "All Students");
        }

        // Get Average

        private void get_average_Click(object sender, EventArgs e)
        {
            if (studentGrades.Count > 0)
            {
                double average = studentGrades.Values.Average();
                MessageBox.Show($"Average Grade: {average}");
            }
            else
            {
                MessageBox.Show("No grades available to calculate average.");
            }
        }

        // Lowest Grade

        private void Lowest_Grade_Click(object sender, EventArgs e)
        {
            if (studentGrades.Count > 0)
            {
                var lowestGrade = studentGrades.Values.Min();
                MessageBox.Show($"Lowest Grade: {lowestGrade}");
            }
            else
            {
                MessageBox.Show("No grades available to determine lowest grade.");
            }
        }

        // Highest Grade

        private void highest_grade_Click(object sender, EventArgs e)
        {
            if (studentGrades.Count > 0)
            {
                var highestGrade = studentGrades.Values.Max();
                MessageBox.Show($"Highest Grade: {highestGrade}");
            }
            else
            {
                MessageBox.Show("No grades available to determine highest grade.");
            }
        }

        // Letter Grade Helper

        static Grade GetLetterGrade(int percentage)
        {
            if (percentage >= 90) return Grade.A;
            if (percentage >= 80) return Grade.B;
            if (percentage >= 70) return Grade.C;
            if (percentage >= 60) return Grade.D;
            return Grade.F;
        }
    }
}