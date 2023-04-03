using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBSELibrary
{
    public class Config_Flags
    {
        public string ID { get; set; }
        public string Description { get; set; }

        public string Identification
        {
            get
            {
                return $"{ ID }: { Description } ";
            }
        }

        public Config_Flags()
        {
            ID = null;
            Description = null;
        }
    }
}
