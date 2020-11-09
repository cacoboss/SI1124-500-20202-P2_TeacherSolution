using System;
using SoluciónProfe.Drivers.DriverClasses;
using SoluciónProfe.Models.Asignements;

namespace SoluciónProfe
{
    class Program
    {
        static string s;

        static void Main(string[] args)
        {
            //Asignemets_Creator.Start();
            //s = Asignemets_Creator.ToString();
            //System.Console.WriteLine(s);

            //Students_Creator.Start();
            
            Students_Creator.AddAsignementList(
                Asignemets_Creator.p_listOfAsignements);
            s = Students_Creator.ToString();
            System.Console.WriteLine(s);
        }
    }
}
