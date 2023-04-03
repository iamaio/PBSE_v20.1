using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBSELibrary
{
    public class Errors
    {
        public string Description { get; set; }

        public Errors(string Error_Description)
        {
            Description = Error_Description;
        }

        public static List<Errors> ErrorList = new List<Errors>();
    }
}
