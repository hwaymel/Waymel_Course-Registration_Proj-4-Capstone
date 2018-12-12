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
    public static class MyCourses
    {
        //Declare private variables for MyCourses Class
        private static int regNumCourses;
        private static string regStudentName;
        private static string regStartDate;
        private static string regCourseNum;
        private static string regCourseType;

        
        //Create get/set methods
        public static int getRegNumCourses()
        {
            return regNumCourses;
        }
        public static void setRegNumCourses(int inRegNumCourses)
        {
            regNumCourses = inRegNumCourses;
        }
        //Student Name
        public static string getRegStudentName()
        {
            return regStudentName;
        }
        public static void setRegStudentName(string inRegStudentName)
        {
            regStudentName = inRegStudentName;
        }
        //Registered Start Date
        public static string getRegStartDate()
        {
            return regStartDate;
        }
        public static void setRegStartDate(string inRegStartDate)
        {
            regStartDate = inRegStartDate;
        }
        //Registered Course Num
        public static string getRegCourseNum()
        {
            return regCourseNum;
        }
        public static void setRegCourseNum(string inRegCourseNum)
        {
            regCourseNum = inRegCourseNum;
        }
            //Course Type
        public static string getRegCourseType()
        {
            return regCourseType;
        }
        public static void setRegCourseType(string inRegCourseType)
        {
            regCourseType = inRegCourseType;
        }

        //Check to see if a different Course Number has been selected by comparing the courseNum in 
        //the Registration class with the existing Course Number in the MyCourses class
        public static bool HasChanged(string inCourseNum)
        {
            if (inCourseNum == regCourseNum)
            {
                return false;
            }
            else
            {
            //The course number has changed; notify users with popup - new course will be saved. 
                MessageBox.Show("Your original course selection has changed." + "\n\n" +
                    "\t" + "Original Value:" + "\t" + regCourseNum + "\n" +
                    "\t" + "New Value:" + "\t" + inCourseNum, 
                    "Course Number has Changed",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
        }
    }
}
