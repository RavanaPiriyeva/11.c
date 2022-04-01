using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Employee : Person
    {
        public Employee(string name , string surname, int age ,double salaryofhour ,int workinghour ):base(name,surname,age)
        {
            this.SalaryOfHour = salaryofhour;
            this.WorkingHour = workinghour;
        }

        public double  SalaryOfHour { get; set; }
          public int WorkingHour { get; set; }    
      public double CalculateSalary()
        {
            double allsalary = SalaryOfHour * WorkingHour;
           
            return allsalary;   
        }
      
        public override string GetInfo()
        {
            return $"{base.GetInfo() }    Salary Of Hour:{SalaryOfHour}     Working Hour:{WorkingHour}    Mounth Salary:{CalculateSalary()}";
        }
    }
}
