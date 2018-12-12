using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Selection_Capstone
{
    public class Registration
    {
    //Declare private variables for Registration Class
        private static int numCourses;
        private static string studentName;
        private static string startDate;
        private static string courseNum;
        private static string courseType;


    //Create get/set methods
        public static int getNumCourses()
        {
            return numCourses;
        }
        public static void setNumCourses(int inNumCourses)
        {
            numCourses = inNumCourses;
        }
        //Student Name
        public static string getStudentName()
        {
            return studentName;
        }
        public static void setStudentName(string inStudentName)
        {
            studentName = inStudentName;
        }
        //Start Date
        public static string getStartDate()
        {
            return startDate;
        }
        public static void setStartDate(string inStartDate)
        {
            startDate = inStartDate;
        }
        //Course Number
        public static string getCourseNum()
        {
            return courseNum;
        }
        public static void setCourseNum(string inCourseNum)
        {
            courseNum = inCourseNum;
        }
        //Course Type
        public static string getCourseType()
        {
            return courseType;
        }
        public static void setCourseType(string inCourseType)
        {
            courseType = inCourseType;
        }

        //Data Validation Methods for Int text box
        public static bool rangeCheck(TextBox textBox)
        {
            int number = 0;
        //Check first to see if the value is truly an integer; if the value is not an integer
        //validation will fail and return an error message - no values will be saved
        //If the value is an integer, the program will continue on to the nested if statement 
        //to ensure that the range is correct 
            if (int.TryParse(textBox.Text, out number))
            {
                if (number >= 1 && number <= 8)
                {
                    return true;
                }
                else
                {
                //This error is caused by a integer that is out of range
                    MessageBox.Show(
                    "Number of Courses - Out of Range: " + "\n\n" + 
                    "Please enter a whole number > 0 and <= 8 in the 'Number of Courses' entry box.",
                    "Number of Courses - Out of Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Focus();
                    return false;
                }
            }               
            else 
            {
                //This error is caused by values that are not truely integers
                MessageBox.Show(
                "Invalid Number of Courses: " + "\n\n" + 
                "Please enter a whole number > 0 and <= 8 in the 'Number of Courses' entry box.",
                "Number of Courses Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                return false;
            }
            
        }

        //First check Student Name Value to ensure that only contains letters, apostrophes and
        //a single space separating the two values. If there are no "Special Characters" the program will 
        //proceed to make sure that a space is included - if there is no space, then we are missing either
        //first name or last name
        public static bool isValidName(TextBox textBox)
        {
            //Check for regular expression characters
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, "^[a-zA-Z']+( [a-zA-Z']+)*$"))
            {
                //Check to make sure a space is present (i.e. indexOf other than -1)
                if (textBox.Text.IndexOf(" ") > -1)
                {
                    return true;
                }
                else
                {
                //This message is returned if there is no space
                    MessageBox.Show(
                    "Invalid Student Name: " + "\n\n" + 
                    "Please make sure both First and Last are present and are " +
                    "separated by a single space in the 'Student Name' entry box.",
                    "Student Name Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Focus();
                    return false;
                }
            }
            else
            {
            //This missage is returned if there are invalid characters or leading/trailing spaces
                MessageBox.Show(
                "Invalid Student Name Format:  " + "\n\n" +
                "Please enter your name (First and Last) separated by a space " +
                "in the 'Student Name' entry box. No special characters can be included except for apostrophes.",
                "Student Name Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                return false;
             
            }

        }
    }
}
