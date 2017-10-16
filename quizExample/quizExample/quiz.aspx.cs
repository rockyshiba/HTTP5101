using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace quizExample
{
    public partial class quiz : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void quiz_submit_Click(object sender, EventArgs e)
        {
            //Reset the correction texts
            //Remember, when the button is pressed, all the code witihin will run
            question1_correction.Text = "";
            question2_correction.Text = "";
            question3_correction.Text = "";
            question4_correction.Text = "";
            question5_correction.Text = "";

            //The answers to the quiz
            string question1_answer = "ottawa";
            int question2_answer = 9;
            int question3_answer = 0;
            bool question4_answer = false;
            bool question5_answer = true;

            //Score initialized to 0
            int correct_answers = 0;

            //change number inputs into ints
            int question2_user;
            int question3_user;

            //The int.TryParse method tries to convert a value to int into another variable
            //Here, question2.Text is tested if it can be converted into an int
            //If it can, question2.Text will be question2_user as an int
            //This if statement is checking if int.TryParse cannot convert to int, hence if the TryParse == false
            if(int.TryParse(question2.Text, out question2_user) == false) //if question 2 input cannot be a number
            {
                //giving question 2 an incorrect int value
                question2_user = 0;
            }

            if(int.TryParse(question3.Text, out question3_user) == false) //if question 3 input cannot be a number
            {
                //giving question 3 an incorrect int value
                question3_answer = 1;
            }

            //change true/false input into boolean
            //Here's another example to validate
            //What if the user didn't select anything?
            bool question4_user;
            bool question5_user;
            //string.IsNullOrWhiteSpace takes in a string and returns true if string is either null or whitespace
            //I added the ! in front to check for the opposite outcome: if it returns false, then the statement is true
            if (!string.IsNullOrWhiteSpace(question4.Text) && !string.IsNullOrWhiteSpace(question5.Text))
            {
                question4_user = Convert.ToBoolean(question4.Text);
                question5_user = Convert.ToBoolean(question5.Text);
            }
            else
            {
                question4_user = true;
                question5_user = false;
            }

            //Question 1
            if(question1.Text.Trim().ToLower() == question1_answer)
            {
                correct_answers++;
            }
            else
            {
                question1_correction.Text = question1_answer;
            }

            //Question 2
            if(question2_user == question2_answer)
            {
                correct_answers++;
            }
            else
            {
                question2_correction.Text = question2_answer.ToString();
            }

            //Question 3
            if(question3_user == question3_answer)
            {
                correct_answers++;
            }
            else
            {
                question3_correction.Text = question3_answer.ToString();
            }

            //Question 4
            if(question4_user == question4_answer)
            {
                correct_answers++;
            }
            else
            {
                question4_correction.Text = question4_answer.ToString();
            }

            //Question 5
            if(question5_user == question5_answer)
            {
                correct_answers++;
            }
            else
            {
                question5_correction.Text = question5_answer.ToString();
            }

            if(correct_answers == 5)
            {
                feedback.Text = "Congratulations! A perfect score";
            }
            else if (correct_answers < 5 && correct_answers > 0) //if correct answers are less than 5 AND more than 0
            {
                feedback.Text = "Keep working on it";
            }
            else
            {
                feedback.Text = "Try again!";
            }
        }
    }
}