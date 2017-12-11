using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Person;

namespace TheSchool
{
    public partial class Students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Person.Student student = new Student();
            //Although not explicitly defined in the Student class, it can use fields/properties/methods inherited from the base class, in this case Person
            student.First_Name = "Lee";
            student.Last_Name = "S";
            student.Date_Of_Birth = new DateTime(1980, 12, 11);

            //Fields/Properties/Methods explicitly defined in the derived class, Student. 
            student.Program = "Web Development";
            student.S_Id = "n012345678";
            student.Gpa = 2.0;

            DateTime today = DateTime.Now;
            if(student.Date_Of_Birth.DayOfYear != today.DayOfYear)  //Tried to match the birthday to today's day. Try it on your own to detect a birthday.
            {
                student.Add_Sub_Gpa(1);
            }

            lbl_dob.Text = student.Date_Of_Birth.ToString();
            lbl_f_name.Text = student.First_Name;
            lbl_l_name.Text = student.Last_Name;
            lbl_full_name.Text = student.Full_Name;
            lbl_gpa.Text = student.Gpa.ToString();
            lbl_program.Text = student.Program;
            lbl_student_num.Text = student.S_Id;
        }
    }
}