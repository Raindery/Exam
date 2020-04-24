using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Mezh.Entities
{
    class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public int Age { get; set; }

        public bool Notify { get; set; }

        public ICollection<Flat> Flat { get; set; }


        public Client() { }

        public Client(string name, string surname, int age, bool notify)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Notify = notify;
        }



        public static Client CreateClient(string name, string surname, int age, bool notify)
        {
            return new Client(name, surname, age, notify);
        }
        
    }
}
