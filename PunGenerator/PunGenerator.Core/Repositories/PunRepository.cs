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
            PunList.Add(new Pun { Question = "What word begins and ends with e, but only has a letter in it?", Answer = "Envelope." });
            PunList.Add(new Pun { Question = "What did the mother tomato say to the child tomato?", Answer = "Ketchup." });
            PunList.Add(new Pun { Question = "Why did the duck cross the road?", Answer = "Because the chicken took a day off." });
            PunList.Add(new Pun { Question = "Why did the duck cross the road?", Answer = "To prove that it's no chicken." });
            PunList.Add(new Pun { Question = "What do you call a butt inside another butt?", Answer = "An assassin." });
            PunList.Add(new Pun { Question = "Why can't bicycles stand up on their own?", Answer = "Because they are two tyred." });
            PunList.Add(new Pun { Question = "A burger and a bowl of salad race each other. Who wins?", Answer = "The burger, because it is a fast food." });

            return PunList;
        }
    }
}
