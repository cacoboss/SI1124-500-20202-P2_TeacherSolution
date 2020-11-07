using System;
using SoluciónProfe.Models.Asignements;

namespace SoluciónProfe.Models.People
{
    public class Student : Person
    {
        protected uint _studentID;
        protected string _email;

        private Asignement[] _listOfAsignements;

        private GroupClass[] _currentAsignements;
    }
}