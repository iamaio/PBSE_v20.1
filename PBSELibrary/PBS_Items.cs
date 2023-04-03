using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBSELibrary
{
    public class PBS_Items
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string NamePlural { get; set; }
        public string Pocket { get; set; }
        public int Price { get; set; }
        public int SellPrice { get; set; }
        public string FieldUse { get; set; }
        public string BattleUse { get; set; }
        public string Consumable { get; set; }
        public string Flags { get; set; }
        public string Move { get; set; }
        public string Description { get; set; }
        public string HeldDescription { get; set; }



        public PBS_Items()
        {
            ID = null;
            Name = null;
            NamePlural = null;
            Pocket = "1";
            Price = 0;
            SellPrice = -1;
            FieldUse = null;
            BattleUse = null;
            Consumable = "true";
            Flags = "";
            Move = null;
            Description = null;
            HeldDescription = null;
        }
    }
}
