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
    public partial class frmCourseSelector : Form
    {
        public frmCourseSelector()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {

            try
            {
                //Check the Number of Courses and Student Name boxes to make sure they contain values and 
                //that the values are in a valid format prior to proceeding with class updates.
                if (isValidData())
                {
                    //set custom class 1 (Registration) variables
                    Registration.setNumCourses(Convert.ToInt32(txtNumCourses.Text));
                    Registration.setStudentName(txtStudentName.Text);
                    Registration.setStartDate(calClassStart.SelectionRange.Start.ToString());
                    Registration.setCourseNum(cmbCourseNum.Text);
                    if (rdoHybrid.Checked)
                    {
                        Registration.setCourseType("Hybrid");
                    }
                    else
                    {
                        Registration.setCourseType("Online");
                    }

                    //Check to see if Course Num selection has changed before updating second class
                    MyCourses.HasChanged(Registration.getCourseNum());

                    //Set custom class 2 (MyCourses) variables from Registration variables
                    MyCourses.setRegNumCourses(Registration.getNumCourses());
                    MyCourses.setRegStudentName(Registration.getStudentName());
                    MyCourses.setRegStartDate(Registration.getStartDate());
                    MyCourses.setRegCourseNum(Registration.getCourseNum());
                    MyCourses.setRegCourseType(Registration.getCourseType());
                }
            }


            //Exception handling section - Added just in case... these should not be necessary with
            //The data validation, but wanted to account for all cases. 
            catch (FormatException)
            {
                MessageBox.Show(
                    "Invalid entry format. Please enter a whole number > 0 and <= 5 in the " +
                    "'Number of Courses' entry box.",
                    "Entry Format Error");
                txtNumCourses.Focus();
            }
            catch (OverflowException)
            {
                MessageBox.Show(
                    "Overflow Error; please enter smaller numeric values (must be < 2147483648).",
                    "Overflow Error");
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Your attempt has failed; please make sure all boxes have correct data types.");
            }

      
        }

        private void frmCourseSelector_Load(object sender, EventArgs e)
        {
        //This line of code loads data into the 'cUDenverDataSet.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.cUDenverDataSet.Courses);

        }

        private void btnGet_Click(object sender, EventArgs e)
        //Write values from second class to form text boxes
        {
            txtRetNumCourses.Text = Convert.ToString(MyCourses.getRegNumCourses());
            txtRetStudentName.Text = MyCourses.getRegStudentName();
            txtRetStartDate.Text = MyCourses.getRegStartDate();
            txtRetCourseNum.Text = MyCourses.getRegCourseNum();
            txtRetCourseType.Text = MyCourses.getRegCourseType();
        }
        //Data validation for entry fields - passes two text box entries to Registration class for validation
        //if either fails, no data will be saved and an error message will be displayed (by the Regisration
        //Class). 
        private bool isValidData()
        {
            return Registration.rangeCheck(txtNumCourses)  &&
                   Registration.isValidName(txtStudentName) ;
        }
    }
}
