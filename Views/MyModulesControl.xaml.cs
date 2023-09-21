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
using TimeManagement_Library.Services;
using WPF_TIME_MANAGEMENT.ViewModel;

using TimeManagement_Library.Model;

using TimeManagement_Library.Utils;



namespace WPF_TIME_MANAGEMENT.Views; 

/// <summary>
/// Interaction logic for MyModulesControl.xaml
/// </summary>
public partial class MyModulesControl :UserControl {

   
    public MyModulesControl() {

        InitializeComponent();
        this.DataContext = new SemesterViewModel();

    }

    private void SelfStudyControl_Loaded(object sender, RoutedEventArgs e) {

    }

    private void ResetSemester(object sender, RoutedEventArgs e) {
        Console.WriteLine("Reset Button Clicked");
     
    }
}
