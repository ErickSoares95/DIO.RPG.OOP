using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dio.Dotnet.POO.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType) : base(name, level, heroType)
        {
        }
        
        public override string  Attack()
        {
            return this.Name + " Lançou magia";
        }

        public string Attack(int bonus)
        {
            if(bonus > 6)
            {
            return this.Name + " Lançou uma magia efetiva com o bonus de attack " + bonus;
            }
            else
            {
            return this.Name +  " Lançou uma magia com inteligência fraca com o bonus de attack " + bonus;
            }
        }
        
    }
}
