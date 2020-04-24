using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Mezh.Entities
{
    class Type
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Flat> Flats { get; set; }



        public Type()
        {

        }


        public Type(string name)
        {
            Name = name;
        }

        public static Type CreateType(string name)
        {
            return new Type(name);
        }
    }
}
