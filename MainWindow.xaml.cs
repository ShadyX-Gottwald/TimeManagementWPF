using System.Windows;
using System.Windows.Controls;
using WPF_TIME_MANAGEMENT.ViewModel;
using WPF_TIME_MANAGEMENT.Views;

namespace WPF_TIME_MANAGEMENT;


/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow :Window { 

    //ViewModels
    private SMViewModel ViewModel; 

    private SemesterViewModel SemesterViewModel; 

    //UserControls instantiation

    private UserControl showModules {  get; set;}

    private UserControl myModulesControl {get; set;}       

    private UserControl mySelfStudyHoursControl {get; set;}   

    private UserControl myNewSemester { get; set; }

    private UserControl resetSemesterControl{ get; set;}


    public MainWindow() {
       
        InitializeComponent();   
        this.ViewModel = new SMViewModel();
        
        // Load_Controls();
        //showModules.DataContext = ViewModel;       
        this.DataContext = new SemesterViewModel();
        Main_Frame.Content = new NewSemesterControl();
       
    }

    //Generate Instance for All User Controls
    private void Load_Controls() {
        //showModules = new ShowModulesControl();
        myModulesControl = new MyModulesControl();   
        myModulesControl.DataContext = SemesterViewModel;
        mySelfStudyHoursControl = new SelfStudyControl();
        mySelfStudyHoursControl.DataContext = SemesterViewModel;     
        resetSemesterControl = new NewSemesterControl();     
        
    }

    private void NewButton(object sender, RoutedEventArgs e) {
        Main_Frame.Content = new NewSemesterControl();
    }

    private void HomeBtn(object sender, RoutedEventArgs e) {
        Main_Frame.Content = new MyModulesControl();
    }

    private void ResetBtn(object sender, RoutedEventArgs e) {
        Main_Frame.Content = new ResetSemesterControl();

    }

    private void RecordDataBtn(object sender, RoutedEventArgs e) {
        Main_Frame.Content = new RecordStudyControl();
    }
}
