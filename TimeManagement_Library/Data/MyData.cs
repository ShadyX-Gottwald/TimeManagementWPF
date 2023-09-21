using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TimeManagement_Library.Model;
using TimeManagement_Library.Services;
using TimeManagement_Library.Utils;

namespace TimeManagement_Library.Data; 

// Class stores Static User Data , Dummy Data as init.
public class MyData {

    public static Semester CurrentSemester = new Semester() {
        Number_of_Weeks = 15,
        StartDate = new DateTime(year: 2023, month: 08, day: 01),

        MyModules = new List<SemesterModule>() {
            new SemesterModule() { Code = "PROG6211", Name = "Programming A",
                Number_of_Credits = 15, Class_hours_per_week = 4 },
            new SemesterModule() { Code = "PROG6212", Name = "Programming B",
                Number_of_Credits = 15, Class_hours_per_week = 4 },
            new SemesterModule() { Code = "WEBDE6011", Name = "Web development",
                Number_of_Credits = 15, Class_hours_per_week = 4 },
            new SemesterModule() { Code = "DATA6211", Name = "Database II",
                Number_of_Credits = 15, Class_hours_per_week = 6 }

        }
    };

   // public static WeekStudies GetWeekStudies = new WeekStudies();

    public static List<DateTime> CurrentStudyWeek = new List<DateTime>();
    //
    public static SemesterModule CurrentSelectedModule = new SemesterModule();

    public static List<StudySession> Sessions = new List<StudySession>() {new StudySession() {Today =  DateTime.Today , Hours = 1 , Code = "PROG6211"},
             new StudySession() {Today =  DateTime.Today.AddDays(1) , Hours = 1 , Code = "PROG6211"} ,};

   
}
