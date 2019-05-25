using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatingNexio.Models
{
    public class Pair
    {
        public Person Man { get; set; }
        public Person Woman { get; set; }
        public bool Matching { get; set; }

        public Pair()
        {
        }

        public Pair (Person man, Person woman)
        {
            this.Man = man;
            this.Woman = woman;
            this.Matching = IsMatch();
        }

        public bool IsMatch()
        {
            int points = 0;
            if (Man.Height - Woman.Height >= 0.10)
                points++;

            if (Math.Abs((Man.BirthDate - Woman.BirthDate).TotalDays) / 365.2425 <= 5)
                points++;

            if (Man.EyeColour == Woman.EyeColour)
                points++;

            return points >= 2;
        }
    }
}