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
            //Console.WriteLine("Hello");
            //var ashu = new Person();
            //ashu.FirstName = "Ngaaje";
            //ashu.FamilyName = "Ngwese";
            //ashu.Height = 1.82;

            //var child1 = new Person();
            //child1.FirstName = "Ngaaje Jr";
            //child1.FamilyName = "Ngwese";
            //child1.DateOfBirth = new DateTime(1985,12,22);
            //Console.WriteLine(child1.HowOldWereYou(1990));

            //var child2 = new Person();
            //child2.FirstName = "Ashu Jr";
            //child2.FamilyName = "Ngwese";

            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine(DateTime.Today);



            ////ashu.Children.AddRange(new[]{child1, child2, child2});


            ////var fxn = new Functions();
            //// Console.WriteLine(fxn.Linear(26.775M));

            ////var pharmacyOdrder = new PharmacyOrder();
            ////pharmacyOdrder.CreatedBy = "Paul";
            ////pharmacyOdrder.Unit = "Pharmacy";


            ////var laboratoryOrder = new LaboratoryOrder();
            ////laboratoryOrder.CreatedBy = "Peter";
            ////laboratoryOrder.Unit = "Laboratory";
            ////laboratoryOrder.SpecimenType = "Blood";

            ////var consultationOrder = new OutPatientDepartmentOrder();
            ////consultationOrder.Unit = "OutPatient Department";
            ////consultationOrder.DoctorConsulted = "Dr.Vera";

            ////List<HospitalServiceOrder> orders = new List<HospitalServiceOrder>();
            ////orders.Add(pharmacyOdrder);
            ////orders.Add(laboratoryOrder);
            ////orders.Add(consultationOrder);

            ////foreach (var order in orders)
            ////{
            ////    Console.WriteLine($"The unit is {order.DoctorConsulted}");
            ////}

            //var laboratoryOrder = new LaboratoryOrder(DateTime.Today, "blood");
            ////var pharmaOrderWithParameter = new PharmacyOrder(DateTime.Today);
            //Console.WriteLine(laboratoryOrder.DateOrdered);
            //Console.WriteLine(laboratoryOrder.SpecimenType);




            //var laboratoryOrder = new LaboratoryOrder(new DateTime(2022, 11, 20), "Blood","Malaria");
            //Console.WriteLine(laboratoryOrder.DateOrdered);
            //Console.WriteLine(laboratoryOrder.SpecimenType);
            //Console.WriteLine(laboratoryOrder.TestType);
            //Console.WriteLine(LaboratoryOrder.UnitName);

            //var laboratoryOrder2 = new LaboratoryOrder(new DateTime(2021, 11, 20), "Urine", "Typhoid");
            //Console.WriteLine(laboratoryOrder2.DateOrdered);
            //Console.WriteLine(laboratoryOrder2.SpecimenType);
            //Console.WriteLine(laboratoryOrder2.TestType);
            //Console.WriteLine(LaboratoryOrder.UnitName);
            //laboratoryOrder2.WhatUnitAreYouIn();

            //LaboratoryOrder.WhatIsTheDateOfToday();


            //var expiryDate = new DateTime(2022, 10, 30).AddDays(7);
            //Console.WriteLine(expiryDate);

            //var labOrder = LaboratoryOrder.CreateNew();
            //Console.WriteLine(labOrder.SpecimenType);

            //var sicknessType = "HIV";
            //var specimenType = LaboratoryOrder.WhichSpecimenIsRequired(sicknessType);
            //Console.WriteLine(specimenType);


            //var cat = new Cat();
            //Console.Write(cat.Speak());


            var message = new EmailMessage
            {
                SenderEmailAddress = "panus@omnicapital.cm",
                RecieverEmailAddress = "coc@gmail.com",
                MessageBody = "I hope MediTrak is running well at your facility",
                Subject = "Client Check-in"
            };


            var courrier = new EmailCourier(message);
            courrier.MessageSent += Courrier_MessageSent;
            courrier.MessageDelivered += Courrier_MessageDelivered;
            courrier.Send();
            Console.WriteLine(courrier.Delivered());
            Console.WriteLine(courrier.DateDelivered);

            Console.ReadKey();
        }

        private static void Courrier_MessageSent(DateTime dateSent, EmailMessage message)
        {
            Console.WriteLine($"The date sent was {dateSent} and the message was {message.MessageBody}");
        }

        private static void Courrier_MessageDelivered(DateTime dateDelivered)
        {
            Console.WriteLine($"The date delivered was {dateDelivered}");

        }
    }
}
