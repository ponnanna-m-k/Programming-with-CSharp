using System;

namespace LatestFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            // Person CFO = new Person();
            //CFO.Fname = "Mike";
            //CFO.Lname = "Scot";

            //NewPerson CEO = new NewPerson();
            //CEO.Fname = "Pavan";
            //CEO.Lname = "Ponnanna";
            //Coordinates India = new Coordinates(120, 220);
            //Console.WriteLine("Indian Coordinates are " + India.X + " "+ India.Y);

            // Enum_Demo
            //Console.WriteLine("Enum Demo output "+ EnumDemo.MyEnum.chair);

            //Try catch


            int a = 10;
            try
            {
                int b = a / 0;
            }

            catch(Exception e)
            {
                Console.WriteLine("Source of Exception : "+e.Source);
                Console.WriteLine("Reason : "+e.Message);
            }

        }
    }

    public record Person(string fname, string Lname);
    public record Person1
    {
        public string Fname { get; init; } = default!;
        public string Lname { get; init; } = default!;
    }
    public record NewPerson
    {
        public string Fname { get; set; } = default!;
        public string Lname { get; set; } = default!;
    }
}
