using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panus.SharedClasses
{
    public class Person
    {
        public string FirstName
        {
            get;
            set;
        }

        public string FamilyName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public double Height { get; set; }

        public string PhoneNumber { get; set; }

        public List<Person> Children { get; set; } 

        public string Speak()
        {
            return $"My full name is {FirstName} {FamilyName} and I have {this.Children.Count} Children";
        }

        public string HowOldWereYou(int year)
        {
            if (!this.DateOfBirth.HasValue)
            {
                return "Sorry I do not have a date of birth,I cannnot tell you how old I was";
            }
            else
            {
                return string.Empty;
            }
        }

        /*public string Count()
        {
            return $"My full name is {FirstName} {FamilyName} and I Have ";
        }*/
    }
    
    public class Functions
    {
        //f(x) = ax + b
        // let the value of x=3, a=10 and b=5...Ans=35, where x is the parameter and the argument is 3
        // let x=4,a=10 and b=5...Ans =45
        public decimal Linear(decimal x)
        {
            return  10 * x + 5;
        }
    }
}
