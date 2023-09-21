using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeManagement_Library.Model;  

public class SemesterModule {     

    public string Code { get; set; }

    public string Name {get; set; }   

    public int Number_of_Credits {get; set; }


    public int Class_hours_per_week {get; set; }



    public override string ToString() {
        return $"{Code} , {Name}";
    }



    public  SemesterModule() {  

   }

    //Class Hours Per week.


}
