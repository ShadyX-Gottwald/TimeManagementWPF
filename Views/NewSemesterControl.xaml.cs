using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_TIME_MANAGEMENT.ViewModel;
using TimeManagement_Library.Model;
using TimeManagement_Library.Services;
using WPF_TIME_MANAGEMENT.Validations;
using TimeManagement_Library.Data;

namespace WPF_TIME_MANAGEMENT.Views;  

/// <summary>
/// Interaction logic for NewSemesterControl.xaml
/// </summary>
public partial class NewSemesterControl :UserControl {

    //Semester Viewmodel
    private SemesterViewModel SemesterViewmodel;

    // Validations   
    private Validations.Validations Validate {
        get;set;
    }
    public NewSemesterControl() {
        InitializeComponent();    
        Validate = new Validations.Validations();
    }

    private void Button_Click(object sender, RoutedEventArgs e) {
        //Empty Fields Trigger Error.
        if (txtNumWeeks.Text.ToString() == string.Empty ||
            txtStartDate.Text.ToString() == string.Empty) {

            MessageBox.Show("New semester fields cannot be empty. Try again!");   
           

        }
        else {
           
            try {

                //Capture Data if Valid Rewrite Current Semester
               var week_num = int.Parse(txtNumWeeks.Text);
               var start_date = Validate.CorrectDateFormat(date: txtStartDate.Text);

                MessageBox.Show( $"Starting new Semester on { start_date.ToShortDateString()}. \n\n All the best!");

                MyData.CurrentSemester = new Semester() { Number_of_Weeks = week_num , StartDate = start_date };

            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Wrong Date Format!");


            }
            

        }

    }

    
    private void SaveModuleBtn(object sender, RoutedEventArgs e) {

        if (txtCode.Text == string.Empty ||
            txtName.Text == string.Empty ||
            txtCredits.Text == string.Empty ||
            txtHours.Text == string.Empty
            ) {

            MessageBox.Show("New Module Fields Cannot Be empty. Try Again!");


        }
        else {

            //Capture Data   
            var code = txtCode.Text.ToUpper();
            var name = txtName.Text;
            var credits = int.Parse(txtCredits.Text);   
            var hours = int.Parse(txtHours.Text);

            MessageBox.Show($"Module {code} saved successfully.");

            var module = new SemesterModule() {Code = code ,Name = name 
                , Class_hours_per_week= hours , Number_of_Credits = credits };

            MyData.CurrentSemester.MyModules.Add(module);   


        }
    }
}
