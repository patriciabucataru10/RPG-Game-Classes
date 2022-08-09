using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
   public class Weapon : Item
    {
     
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
        public Weapon ( int id, string name, string nameplural, int mindmg, int maxdmg ) : base(id,name,nameplural)
        {
            MinimumDamage = mindmg;
            MaximumDamage = maxdmg;
        }
    }
}
