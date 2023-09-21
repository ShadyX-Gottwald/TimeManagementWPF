using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeManagement_Library.Model;

using TimeManagement_Library.Utils;

namespace TimeManagement_Library.Model; 

public class Semester {   

    public int Number_of_Weeks { get; set; }   

    public DateTime StartDate { get; set; }

    public List<SemesterModule> MyModules { get; set; } = new List<SemesterModule>();

    public WeekStudies MyStudies { get; set; } = new WeekStudies();
    

    public Semester() {
       
    }

    public bool ResetSemester() {

        Task.Run(() => {

            this.Number_of_Weeks = 0;
            this.MyModules.Clear();
            return true;
        });


        return true;
    }

}
