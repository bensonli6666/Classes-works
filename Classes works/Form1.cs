using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes_works
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Outbtn_Click(object sender, EventArgs e)
        {
            Student stu1 = new Student("Jo", 15389, "2/11/1998");

            Student stu2 = new Student("Sam", 15783, "1/2/1998");

            Outlbl.Text = "Student 2's date of birth is: " + stu2.Dob + "\r\n" + "Student 1's student ID is: " + stu1.StudentID;
        }
    }
}
