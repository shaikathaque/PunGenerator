using PunGenerator.Core.Models;
using PunGenerator.Core.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunGenerator.Core.Repositories
{
    public class PunRepository : IPunRepository
    {
        private static List<Pun> PunList = new List<Pun>();

        public List<Pun> getPunList()
        {
            PunList.Add(new Pun { Question = "Why doesn't the sun go to college?", Answer = "Because it already as 28 million degrees." });
            PunList.Add(new Pun { Question = "How do you make holy water?", Answer = "You boil the HELL out of it." });
            PunList.Add(new Pun { Question = "Why did the computer say hello?", Answer = "Because it was Adele." });

            return PunList;
        }
    }
}
