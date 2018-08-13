using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class InformatiqueEntity
    {

        public string idMotCle { get; set; }
        public string description { get; set; }

        public InformatiqueEntity()
        {

        }

        public InformatiqueEntity(string idMocle, string description)
        {
            this.idMotCle = idMotCle;
            this.description = description;
        }
    }
}
