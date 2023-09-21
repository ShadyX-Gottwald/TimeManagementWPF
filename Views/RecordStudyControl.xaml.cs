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
using WPF_TIME_MANAGEMENT.Validations;
using TimeManagement_Library.Data;

namespace WPF_TIME_MANAGEMENT.Views; 

/// <summary>
/// Interaction logic for RecordStudyControl.xaml
/// </summary>
public partial class RecordStudyControl :UserControl {

    private Validations.Validations Validate;
    public RecordStudyControl() {
        InitializeComponent();
        this.DataContext = new SemesterViewModel();
        Validate = new Validations.Validations();

    }

    private void SaveStudyBtn(object sender, RoutedEventArgs e) {

        // Check if Semester is selected , report.   
        var selectedModule = (SemesterModule)MyModules.SelectedItem;


        if (txtDate.Text == string.Empty
            || txtHours.Text == string.Empty
            || selectedModule.Name == string.Empty) {

            MessageBox.Show("Fields must Not be empty, Select Module Below to enter \n data for");

        }
        else {

            try {

                var date = Validate.CorrectDateFormat(txtDate.Text);
                MyData.Sessions.Add( 
                    new StudySession() 
                { Code = selectedModule.Code 
                    , Hours = double.Parse(txtHours.Text) 
                    , Today = date}
                    );

                MessageBox.Show($"Session recorded! \n\n {date.ToShortDateString()} \n\n {txtHours.Text}h , {selectedModule.Code} \n");

                Console.WriteLine("Button Clicked");   


            }
            catch (Exception ex) {

                Console.WriteLine(ex.Message);
                MessageBox.Show("Illegal Date Format try again.!");

            }
            //MessageBox.Show($"{selectedModule.Code}\n\n {txtDate}");

        }
    }
}
