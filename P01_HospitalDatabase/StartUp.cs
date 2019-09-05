using Microsoft.EntityFrameworkCore;
using P01_HospitalDatabase.Data;
using System;

namespace P01_HospitalDatabase
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var connectionString = "Server=.\\SQLEXPRESS;Database=Hospital;Integrated Security=true";

            var optionsBuilder = new DbContextOptionsBuilder<HospitalContext>();

            optionsBuilder.UseSqlServer(connectionString, s => s.MigrationsAssembly("P01_HospitalDatabase"));
        }
    }
}
