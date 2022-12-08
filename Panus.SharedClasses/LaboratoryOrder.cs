susing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panus.SharedClasses
{
    public class LaboratoryOrder : HospitalServiceOrder
    {

        public static string UnitName = "Laboratory";

        public LaboratoryOrder(DateTime dateOrdered, string specimenType, string testType)
        {
            this.DateOrdered = dateOrdered;
            this.SpecimenType = specimenType;
            this.TestType = testType;

        }

        public LaboratoryOrder(DateTime dateOrdered)
        {
            this.DateOrdered = dateOrdered;
        }

       
        public string SpecimenType  { get; set; }

        public string TestType { get; set; }


        public void WhatUnitAreYouIn()
        {
            Console.WriteLine(UnitName);
        }

        public static void WhatIsTheDateOfToday()
        {
            Console.WriteLine(DateTime.Now);
        } 

        public static LaboratoryOrder CreateNew()
        {
            return new LaboratoryOrder(DateTime.Now, "Blood", "Malaria");
        }

        public static string WhichSpecimenIsRequired(string testType)
        {
            switch (testType)
            {
                case "Malaria":
                    return "Blood";

                case "Typhoid":
                    return "Stool";

                case "Ebola":
                    return "Urine";

                default:
                    return "I don't know";

            }
        }
    }

    public class Animal
    {
        public virtual string Speak()
        {
            return "Animal cannot speak";
        }
    }

    public class Dog : Animal
    {
        public override string Speak()
        {
            return "I bark";
        }
    }

    public class Cat : Animal
    {
        public override string Speak()
        {
            return "I meow";
        }
    }



}
