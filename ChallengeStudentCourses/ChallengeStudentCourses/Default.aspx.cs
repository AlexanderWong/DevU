using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a List of Courses (add three example Courses ...
             * make up the details).  Each Course should have at least two
             * Students enrolled in them.  Use Object and Collection
             * Initializers.  Then, iterate through each Course and print
             * out the Course's details and the Students that are enrolled in
             * each Course.
             */
            List<Course> courses = new List<Course>(){
                new Course() {CourseId = 1, Name = "Sedimentology", Students = new List<Student>() {
                    new Student() {StudentId = 001, Name = "Andrea Davila"},
                    new Student() {StudentId = 002, Name = "Jun Sasamura"}}},
                new Course() {CourseId = 2, Name = "Mineralogy", Students = new List<Student>() {
                    new Student() {StudentId = 003, Name = "Mikey Begin"},
                    new Student() {StudentId = 004, Name = "Michael Duric"}}},
                new Course() {CourseId = 3, Name = "Sociology", Students = new List<Student>() {
                    new Student() {StudentId = 005, Name = "John Ollmann"},
                    new Student() {StudentId = 006, Name = "Carli Balogh"}}}
                };
            foreach (var course in courses)
            {
                resultLabel.Text += String.Format("<br/>Course: {0} - {1}", course.CourseId, course.Name);
                foreach (var student in course.Students)
                {
                    resultLabel.Text += String.Format("<br/>&nbsp Student: {0} - {1}", student.StudentId, student.Name);

                }

            }
        }




        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a Dictionary of Students (add three example Students
             * ... make up the details).  Use the StudentId as the 
             * key.  Each student must be enrolled in two Courses.  Use
             * Object and Collection Initializers.  Then, iterate through
             * each student and print out to the web page each Student's
             * info and the Courses the Student is enrolled in.
             */
            Course course1 = new Course() { CourseId = 1, Name = "Sedimentology" };
            Course course2 = new Course() { CourseId = 2, Name = "Mineralogy" };
            Course course3 = new Course() { CourseId = 3, Name = "Sociology" };

            Dictionary<int, Student> students = new Dictionary<int, Student>()
            {
                { 001, new Student { StudentId = 001, Name = "Andrea Davila", Courses = new List<Course> { course1, course3 }} },
                { 004, new Student { StudentId = 004, Name = "Michael Duric", Courses = new List<Course> { course2, course3 }} },
                { 003, new Student { StudentId = 003, Name = "Mikey Begin", Courses = new List<Course> { course1, course2 }} }
            };

            foreach (var student in students)
            {
                resultLabel.Text += String.Format("<br/>Student: {0} - {1}", student.Value.StudentId, student.Value.Name);
                foreach (var course in student.Value.Courses)
                {
                    resultLabel.Text += String.Format("<br/>&nbsp;Course: {0} - {1}", course.CourseId, course.Name);
                }
            }
        }
        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            /*
             * We need to keep track of each Student's grade (0 to 100) in a 
             * particular Course.  This means at a minimum, you'll need to add 
             * another class, and depending on your implementation, you will 
             * probably need to modify the existing classes to accommodate this 
             * new requirement.  Give each Student a grade in each Course they
             * are enrolled in (make up the data).  Then, for each student, 
             * print out each Course they are enrolled in and their grade.
             */
            Student student = new Student();
            student.StudentId = 4;
            student.Name = "Michael Duric";
            
            student.Scores = new List<Score>()
            {
                new Score { Course = new Course {CourseId = 1, Name = "Sedimentology" }, Grade = 93 },
                new Score { Course = new Course {CourseId = 2, Name = "Mineralogy" }, Grade = 87 }
            };
            resultLabel.Text += String.Format("<br/>Student: {0} - {1}", student.StudentId, student.Name);
            foreach (var score in student.Scores)
            {
                resultLabel.Text += String.Format("<br/>Results: {0} - Grade = {1} ", score.Course.Name, score.Grade);
            }


        }
    }
}