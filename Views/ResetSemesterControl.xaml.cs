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
using TimeManagement_Library.Services;
using TimeManagement_Library.Data;

namespace WPF_TIME_MANAGEMENT.Views;  

/// <summary>
/// Interaction logic for ResetSemesterControl.xaml
/// </summary>
public partial class ResetSemesterControl :UserControl {    

    private SemesterViewModel ViewModel {get; set; }
    private SemesterService Service;
    public ResetSemesterControl(  ) {
        InitializeComponent();
        this.DataContext = new SemesterViewModel();

    }

   
    private void ResetBtnClick(object sender, RoutedEventArgs e) {

 
    }

    private void SaveWeekClick(object sender, RoutedEventArgs e) {
       var selected =  cldSample.SelectedDates;
        //User Must Select Entire Study Week
        if (selected.Count == 1 || selected.Count == 0) {
            MessageBox.Show("Drag to select entire study week");
        }
        else {    

            // Selected Week Confirmation
            var message = $" Study Week from \n\n {selected.First().ToShortDateString()} \n to" +
                $" {selected.Last().ToShortDateString()} \n\n Not Your Selection? Select Again!";

            MyData.CurrentStudyWeek = new List<DateTime>(selected);

            //Get Dates From Recorded Study session , to Blackout in Calender
           // var Dates = (from d in MyData.Sessions select d)
             //   .Select(it => it.Today)
             //   .ToList();

            //First Date  and last .    
           // var first = Dates.First();
           // var last = Dates.First();


           // cldSample.BlackoutDates.Add(new CalendarDateRange(first ,last));  

            MessageBox.Show(message);
        }
    }
}
