using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Numerics;
using HelloWorld.Models;
using System.Data;
using Microsoft.Data.SqlClient;            // To import models into main program.

namespace HelloWorld                // Highest scope element. To define properties and classes which can be used from the main program.
{

    internal class Program                                  // Main program which uses the properties and classes from namespace element.
    {

        static void Main(string[] args)                     // Main method.
        {

            string connectionString = "Server=localhost;Database=DotNetCourse;TrustServerCertificate=true;Trusted_Connection=true;";

            IDbConnection dbConnection = new SqlConnection(connectionString);

            string firstSQLQuery = "Select GETDATE()";

            Computer myComputer = new Computer()
            {
                Motherboard = "Z690",
                Cpucores = 8,
                HasWiFi = true,
                HasLTE = true,
                Releasedate = DateTime.UtcNow,
                Price = 1950.00m,
                Videocard = ""

            };

            Computer myComputer2 = new Computer()
            {
                Motherboard = "i5P",
                Cpucores = 16,
                HasWiFi = true,
                HasLTE = true,
                Releasedate = DateTime.UtcNow,
                Price = 3950.00m,
                Videocard = ""
            };

            Console.WriteLine(myComputer.Motherboard);
            Console.WriteLine(myComputer.Cpucores);

            myComputer.Motherboard = "i3-Core";
            myComputer.Cpucores = 4;
            myComputer.Price = 1250.00m;

            Console.WriteLine(myComputer.Motherboard);
            Console.WriteLine(myComputer.Cpucores);
            Console.WriteLine(myComputer.Price);

        }

    }
}