using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Numerics;
using HelloWorld.Models;                                                    // To import models into main program.
using System.Data;
using Microsoft.Data.SqlClient;
using Dapper;
using HelloWorld.Data;       
using Microsoft.Extensions;
using Microsoft.EntityFrameworkCore;


namespace HelloWorld                                                         // Highest scope element. To define properties and classes which can be used from the main program.
{

    internal class Program                                                   // Main program which uses the properties and classes from namespace element.
    {

        static void Main(string[] args)                                     // Main method.
        {
            DataContextDapper dapper = new DataContextDapper();
            DataContextEF entityFramework = new DataContextEF();

            // string connectionString = "Server=localhost;Database=DotNetCourse;TrustServerCertificate=true;Trusted_Connection=true;";

            // IDbConnection dbConnection = new SqlConnection(connectionString);

            string firstSQLQuery = "Select GETDATE()";

            DateTime rightNow = dapper.LoadDataSingle<DateTime>(firstSQLQuery);

            // Console.WriteLine(rightNow);

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

            string sql = @"INSERT INTO TutorialAppschema.Computer (
                Motherboard,
                Cpucores,
                HasWiFi,
                HasLTE,
                Releasedate,
                Price,
                Videocard
                ) VALUES ( '"+ myComputer.Motherboard 
                    +"', '"+ myComputer.Cpucores 
                    +"', '" + myComputer. HasWiFi 
                    +"', '" + myComputer. HasLTE 
                    +"', '" + myComputer. Releasedate 
                    +"', '" + myComputer. Price 
                    +"', '" + myComputer. Videocard 
                    +"')";


            // entityFramework.Add(myComputer);
            // entityFramework.SaveChanges();
            // dapper.ExecuteSQL(sql);

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

            string sql2 = @"INSERT INTO TutorialAppSchema.Computer (
                Motherboard,
                Cpucores,
                HasWiFi,
                HasLTE,
                Releasedate,
                Price,
                Videocard
            ) VALUES ( '" + myComputer2.Motherboard
                +"', '"+ myComputer2.Cpucores
                +"', '"+ myComputer2.HasWiFi
                +"', '"+ myComputer2.HasLTE
                +"', '"+ myComputer2.Releasedate
                +"', '"+ myComputer2.Price
                +"', '"+ myComputer2.Videocard
                +"')";

            // entityFramework.Add(myComputer2);
            // entityFramework.SaveChanges();

            // dapper.ExecuteSQL(sql2);

            string sqlSelect = @"
                SELECT
                Computer.ComputerId,
                Computer.Motherboard,
                Computer.Cpucores,
                Computer.HasWiFi,
                Computer.HasLTE,
                Computer.Releasedate,
                Computer.Price,
                Computer.Videocard
                from TutorialAppSchema.Computer";

            IEnumerable<Computer> computers = dapper.LoadData<Computer>(sqlSelect);

            foreach (Computer eachComputer in computers)
            {
                Console.WriteLine("'"+ eachComputer.ComputerId
                +"', '" + eachComputer.Motherboard
                +"', '" + eachComputer.Cpucores 
                +"', '" + eachComputer. HasWiFi 
                +"', '" + eachComputer. HasLTE 
                +"', '" + eachComputer. Releasedate 
                +"', '" + eachComputer. Price 
                +"', '" + eachComputer. Videocard 
                );
            };

            IEnumerable<Computer>? computersEF = entityFramework.Computer?.ToList<Computer>();

            if (computersEF != null)
            {
                foreach (Computer eachComputer in computersEF)
                {
                    Console.WriteLine("'"+ eachComputer.ComputerId
                    +"', '" + eachComputer.Motherboard
                    +"', '" + eachComputer.Cpucores 
                    +"', '" + eachComputer. HasWiFi 
                    +"', '" + eachComputer. HasLTE 
                    +"', '" + eachComputer. Releasedate 
                    +"', '" + eachComputer. Price 
                    +"', '" + eachComputer. Videocard 
                    );
                };
            };
            

            // Console.WriteLine(myComputer.Motherboard);
            // Console.WriteLine(myComputer.Cpucores);

            // myComputer.Motherboard = "i3-Core";
            // myComputer.Cpucores = 4;
            // myComputer.Price = 1250.00m;

            // Console.WriteLine(myComputer.Motherboard);
            // Console.WriteLine(myComputer.Cpucores);
            // Console.WriteLine(myComputer.Price);

        }

    }
}