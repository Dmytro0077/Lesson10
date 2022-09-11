using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    class NameBook
    {
        string nameBook;
        string authorBook;
        string genreBook;
    }

    class IDBook//name of class it would be better to do not start from I. now it looks as interface
    {
        long idBook;
    }

    class StatusBook
    {
        public enum statusBook
        {
            знаходиться_у_бібліотеці = 1,//enum values should be in english
            скоро_зявиться_у_бібліотеці,
            видано_на_руки,
            пошкоджено,
            не_має_у_наявності,
        }
    }

    class RatingBook
    {
        public enum statusBook
        {
            відмінно = 5,//enum values should be in english
            добре = 4,
            задовільно = 3,
            незадовільно = 2,
            взагалі_не_раджу_читати = 1,
        }
    }
}
