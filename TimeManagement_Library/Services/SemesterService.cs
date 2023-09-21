using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TimeManagement_Library.Model;
using TimeManagement_Library.Utils;

using TimeManagement_Library.Data;


namespace TimeManagement_Library.Services;

interface ISemesterService {

    List<SemesterModule> GetSemesterModules {get; }

    List<SelfStudy> HoursRemaining {get;}

    List<RemainingSessions> Remaining {get;}


    bool ResetSemester();

}

public class SemesterService :ISemesterService {

    public SemesterService() {

    }

    public List<SemesterModule> GetSemesterModules => MyData.CurrentSemester.MyModules ;

    public List<SelfStudy> HoursRemaining => _selfStudies();

    public Semester CurrentSemester  => MyData.CurrentSemester;

    public List<RemainingSessions> Remaining => _remainingSessions();

    private  List<SelfStudy> _selfStudies() {

        //For each module Calculates , Per Week Study Hours of it.
        if (MyData.CurrentSemester.MyModules.Count > 1 || MyData.CurrentSemester.MyModules.Count == 1) {
            var modules = (from mod in MyData.CurrentSemester.MyModules select mod)
                   .Select(it => new SelfStudy() {
                       Code = it.Code,
                       Name = it.Name,
                       Number_of_Credits = it.Number_of_Credits,
                       SelfStudyHours = it.CalculateSelfStudyHours(MyData.CurrentSemester)
                   }
         )
         .ToList();

            return modules;
        }



        return new List<SelfStudy>();

    }

    private List<RemainingSessions> _remainingSessions() {

        var modules = (from mod in MyData.CurrentSemester.MyModules select mod)
                  .Select(it => new SelfStudy() {
                      Code = it.Name,
                      Name = it.Code,
                      Number_of_Credits = it.Number_of_Credits,
                      SelfStudyHours = it.CalculateSelfStudyHours(MyData.CurrentSemester)
                  }
        )
        .ToList();



        return modules.Select(it => new RemainingSessions() {
            Code = it.Code,
            Hours = (it.SelfStudyHours - it.SumHours(MyData.Sessions))
        }).ToList();
    }

   public bool ResetSemester() {

       Task.Run(() => {

           // MyData.CurrentSemester = new Semester();
            return true;
        });
       
  
        return true;
    }

}
