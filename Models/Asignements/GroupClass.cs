using SoluciónProfe;
using SoluciónProfe.Models.People;

namespace SoluciónProfe.Models.Asignements
{
    public class GroupClass : Asignement
    {
        public int group;
        public Teacher teacher;
        public Schedule[] schedule = new Schedule[3];
    }
}