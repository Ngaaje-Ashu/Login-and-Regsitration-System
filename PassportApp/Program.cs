using Panus.SharedClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PassportApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            var ashu = new Person();
            ashu.FirstName = "Ngaaje";
            ashu.FamilyName = "Ngwese";
            ashu.Height = 1.82;

            var child1 = new Person();
            child1.FirstName = "Ngaaje Jr";
            child1.FamilyName = "Ngwese";
            child1.DateOfBirth = new DateTime(1985,12,22);
            Console.WriteLine(child1.HowOldWereYou(1990));

            var child2 = new Person();
            child2.FirstName = "Ashu Jr";
            child2.FamilyName = "Ngwese";

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today);



            //ashu.Children.AddRange(new[]{child1, child2, child2});


            //var fxn = new Functions();
            // Console.WriteLine(fxn.Linear(26.775M));

            //var pharmacyOdrder = new PharmacyOrder();
            //pharmacyOdrder.CreatedBy = "Paul";
            //pharmacyOdrder.Unit = "Pharmacy";


            //var laboratoryOrder = new LaboratoryOrder();
            //laboratoryOrder.CreatedBy = "Peter";
            //laboratoryOrder.Unit = "Laboratory";
            //laboratoryOrder.SpecimenType = "Blood";

            //var consultationOrder = new OutPatientDepartmentOrder();
            //consultationOrder.Unit = "OutPatient Department";
            //consultationOrder.DoctorConsulted = "Dr.Vera";

            //List<HospitalServiceOrder> orders = new List<HospitalServiceOrder>();
            //orders.Add(pharmacyOdrder);
            //orders.Add(laboratoryOrder);
            //orders.Add(consultationOrder);

            //foreach (var order in orders)
            //{
            //    Console.WriteLine($"The unit is {order.DoctorConsulted}");
            //}

            var laboratoryOrder = new LaboratoryOrder(DateTime.Today, "blood");
            //var pharmaOrderWithParameter = new PharmacyOrder(DateTime.Today);
            Console.WriteLine(laboratoryOrder.DateOrdered);
            Console.WriteLine(laboratoryOrder.SpecimenType);
            Console.ReadKey();
        }
 
    }
}
