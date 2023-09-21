using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeManagement_Library.Utils; 

// Class Stores , mapping Class Obj to provide Calculation of Time per Module.
// 

public class SelfStudy : INotifyPropertyChanged {


    private string _code;
    public string Code {
        get {
            return _code;
        } 
        set { 
            _code = value;OnPropertyChanged("Code");
        } 
    }

    private string _name;
    public string Name {
        get {
            return _code;
        }
        set {
            _code = value;
            OnPropertyChanged("Name");
        }
    }

    private int _number_of_Credits;  


    public int Number_of_Credits {

        get {
            return _number_of_Credits;
        }
        set {
            _number_of_Credits = value;
            OnPropertyChanged("Number_of_Credits");
        }
    }

    public double _selfStudyHours;
    public double SelfStudyHours {
        get {
            return _selfStudyHours;
        }
        set {
            _selfStudyHours = value;
            OnPropertyChanged("SelfStudyHours");
        }
    }


    public SelfStudy() {

    }

    public event PropertyChangedEventHandler? PropertyChanged;

    public void OnPropertyChanged(string propertyName) { 
        if(PropertyChanged != null) {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName)); }
    }

    public override string ToString() {
        return $"Code: {Code} , Name: {Name} , Credits: {Number_of_Credits} , Hours: {SelfStudyHours}";
    }

}
