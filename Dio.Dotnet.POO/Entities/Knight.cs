using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dio.Dotnet.POO.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level, string heroType) : base(name, level, heroType)
        {
        }

        public override string Attack()
        {
            return this.Name + " Fez um ataque";
        }


        public string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return this.Name + " Fez um ataque efetivo com o bonus de attack " + bonus;
            }
            else
            {
                return this.Name + " Fez um ataque fraco com STR fraco com o bonus de attack " + bonus;
            }

        }
    }
}
