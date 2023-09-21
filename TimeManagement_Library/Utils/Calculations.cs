using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeManagement_Library.Model;

namespace TimeManagement_Library.Utils;  

public static class Calculations {

    public static double CalculateSelfStudyHours(this SemesterModule mod,Semester sem) {
        
        var credits = (double) mod.Number_of_Credits;

        var week_number = (double) sem.Number_of_Weeks;

        var class_hours = (double) mod.Class_hours_per_week;

        var time_in_hours = ( (credits * 10 ) / week_number) - class_hours;

        return time_in_hours;
    }

    public static double SumHours(this SelfStudy selfStudy,  List<StudySession> Source) {

        var sum = (from s in Source select s)
        .Where(it => it.Code == selfStudy.Code)
        .Sum(hours => (double)hours.Hours);

        return sum;
    }

}
