using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using TimeManagement_Library.Model;
using TimeManagement_Library.Services;
using TimeManagement_Library.Utils;
//using WPF_TIME_MANAGEMENT.Data;   
using TimeManagement_Library.Data;

namespace WPF_TIME_MANAGEMENT.ViewModel;

public class SemesterViewModel :INotifyPropertyChanged {

    //SemesterModule Buisiness Logic
    public SemesterService SemesterService {get; set; }

    //Get Collection from Semester
    private ObservableCollection<SemesterModule> _semesterModules;
    public ObservableCollection<SemesterModule> SemesterModules {
        get { return _semesterModules; } 

        set {
            _semesterModules = value ;OnPropertyChanged("SemesterModules");
        }
    }


    private ObservableCollection<SelfStudy> _studyHours;
    public ObservableCollection<SelfStudy> StudyHours {
        get {
            return _studyHours;
        }

        set {
            _studyHours = value;
            OnPropertyChanged("StudyHours");
        }
    }

    public ObservableCollection<Semester> Semesters {get;set;}

    private ObservableCollection<DateTime>? _week;   
    public ObservableCollection<DateTime>? Week {
        get {   
            return _week; 
        }
        set {
            _week = value;OnPropertyChanged("Week");
        }
    }

    private ObservableCollection<RemainingSessions> _remainingSessions;

    public ObservableCollection<RemainingSessions> RemainingSessions {
        get {
            return _remainingSessions;
        }
        set {
            _remainingSessions = value;
            OnPropertyChanged("RemainingSessions");
        }
    }



    public SemesterViewModel() {

        SemesterService = new SemesterService();

        // _semesterModules = new ObservableCollection<SemesterModule>(SemesterService.GetSemesterModules);   
        _semesterModules = new ObservableCollection<SemesterModule>(MyData.CurrentSemester.MyModules);

        // StudyHours = new ObservableCollection<SelfStudy>(SemesterService.HoursRemaining);    

        _studyHours = new ObservableCollection<SelfStudy>(SemesterService.HoursRemaining);

        Semesters = new ObservableCollection<Semester> { SemesterService.CurrentSemester};

        _week = new ObservableCollection<DateTime> (MyData.CurrentStudyWeek);

        _remainingSessions = new ObservableCollection<RemainingSessions>(SemesterService.Remaining);


    }    

    public SemesterService SService { get;}
    public event PropertyChangedEventHandler? PropertyChanged;    

    private void OnPropertyChanged(string propertyName) {

        if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        
    }
}
