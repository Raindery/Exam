using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Mezh.Entities
{
    class Flat
    {
        public int Id { get; set; }

        public string TypeRequest { get; set; }
        public int Floor { get; set; }
        public float Footage { get; set; }
        
        public DateTime BuildingDate { get; set; }

        public bool HasElevator { get; set; }


        public int TypeId { get; set; }
        public Type Type { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }


        public Flat()
        {

        }


        public Flat(string typeRequest, int floor, float footage, DateTime date, bool hasElevator, int typeId, int clientId)
        {
            TypeRequest = typeRequest;
            Floor = floor;
            Footage = footage;
            BuildingDate = date;
            HasElevator = hasElevator;
            TypeId = typeId;
            ClientId = clientId;

        }



        public static Flat CreateFlat(string typeRequest, int floor, float footage, DateTime date, bool hasElevator, int typeId, int clientId)
        {
            return new Flat(typeRequest, floor, footage, date, hasElevator, typeId, clientId);
        }


    }
}
