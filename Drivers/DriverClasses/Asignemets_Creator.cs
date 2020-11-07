using System;
using System.Text;
using SoluciónProfe.Models.Asignements;


namespace Drivers.DriverClasses
{
    public class Asignemets_Creator
    {
        #region Static Instances
        private static string _path =
            @"G:\UNINPAHU\SI1124-500-2020_2\2do Corte\SoluciónProfe\Drivers\DriverObjects\Asignements.txt";

        private static Asignement[] _f_listOfAsignements;
        public static Asignement[] p_listOfAsignements
        {
            get
            {
                if(_f_listOfAsignements.Length == 0)
                {
                    _f_listOfAsignements = _CreateList();
                }
                return _f_listOfAsignements;
            }
            private set
            {
                _f_listOfAsignements = value;
            }
        }
        
        #endregion

        private static Asignement[] _CreateList()
        {
            string[] lines = System.IO.File.ReadAllLines(_path);
            
            Asignement[] data = new Asignement[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                data[i] = _ParseLine(lines[i]);
            }

            return data;
        }
        private static Asignement _ParseLine(string s)
        {
            string[] data = s.Split(";");
            return new Asignement(
                                semester: Convert.ToInt32(data[0]),
                                prefix: data[1],
                                number: Convert.ToInt32(data[2]) ,
                                name: data[3]);
        }
        public static new string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Asignement a in _f_listOfAsignements)
            {
                sb.AppendLine(a.ToString());
            }
            return sb.ToString();
        }
    }
}