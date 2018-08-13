using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class InformatiqueManager
    {

        public static IEnumerable<informatique> GetList() { return new ORM().informatique.ToList(); }
    }
}
