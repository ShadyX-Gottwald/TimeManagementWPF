using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WPF_TIME_MANAGEMENT.Validations;

public class Validations {

    public  DateTime CorrectDateFormat(string date) {

        return DateTime.Parse(date); 
    }
}
