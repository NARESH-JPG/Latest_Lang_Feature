using System;

namespace Demo_LatestLangFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Implemeting Records using C# 9.0

            //Person1 CFO = new Person1();
            //CFO.Fname = "Mike";
            //CFP.Lname = "Scot";

            NewPerson CEO = new NewPerson();
            CEO.Firstname = "Satya ";
            CEO.LastName = " Nadella";

            Coordinates India = new Coordinates(120, 220);
            Console.WriteLine("Indian Coodinates are "+India.X+India.Y);
            //India.X = 240;
            //India.Y = 240;

            Console.WriteLine(MyEnum.Red+ " is my Fav Color" );
            
           

        }
    }


    public record Person(string Fname,string LName); 
    //We can define a record with immutable Proprties (read ONly)
    public record Person1
    {
        public string First_Name { get; init; } = default !;
        public string LastName { get;   init; } = default!;

    }

    public record NewPerson
    {

        public string Firstname { get; set; } = default!;
        public string LastName { get; set; } = default!;
    }


}
