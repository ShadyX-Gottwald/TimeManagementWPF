using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TimeManagement_Library.Model;

namespace TimeManagement_Library.Services;     

interface IModuleService {   

    List<SemesterModule> GetSemesterModules { get; }
}

public class SemesterModuleService: IModuleService {

    private readonly List<SemesterModule> _semesterModules;

    public SemesterModuleService() {    
        _semesterModules = new List<SemesterModule>();
        LoadDummyData();
    }

    private void LoadDummyData() {
        _semesterModules.Add(new SemesterModule() { Name = "Programming 2B" ,
            Code = "PROG6212" , Number_of_Credits = 15}
        );

        _semesterModules.Add(new SemesterModule() {
            Name = "Web Devemopment",
            Code = "WEBDE5012",
            Number_of_Credits = 15
        }
       );
    }

    public List<SemesterModule> GetSemesterModules => _semesterModules;
}
