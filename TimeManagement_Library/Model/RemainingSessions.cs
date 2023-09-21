using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeManagement_Library.Model;  

public  class RemainingSessions :INotifyPropertyChanged{

    
        public string Code {get; set; }

        public double Hours { get; set; }

    public event PropertyChangedEventHandler? PropertyChanged;

    public override string ToString() {
            return $"{Code},{Hours}h";
        }
    }
