using System.Collections.ObjectModel;
using System.ComponentModel;
using TimeManagement_Library.Model;
using TimeManagement_Library.Services;

namespace WPF_TIME_MANAGEMENT.ViewModel;

public class SMViewModel: INotifyPropertyChanged {     

    //SemesterModule Buisiness Logic
    public SemesterModuleService SemesterMService {get; set; }   

    //Get Collection from Semester
    public ObservableCollection<SemesterModule> SemesterModules {get; set; }
    public SMViewModel() {      

        SemesterMService = new SemesterModuleService();

        SemesterModules = new ObservableCollection<SemesterModule>(SemesterMService.GetSemesterModules);

    }

    public event PropertyChangedEventHandler? PropertyChanged;
}
