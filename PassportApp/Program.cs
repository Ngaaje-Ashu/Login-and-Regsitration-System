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
            Console.WriteLine(child1.How)

            var child2 = new Person();
            child2.FirstName = "Ashu Jr";
            child2.FamilyName = "Ngwese";
            

           // ashu.Children.AddRange(new[]{child1, child2, child2});
           

            var fxn = new Functions();
            Console.WriteLine(fxn.Linear(26.775M));
            

            Console.ReadKey();
        }
    }
}
