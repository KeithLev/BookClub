using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookClubClassLibrary
{
    public class Rating
    {
        public string ?Name { get; set; }

        public int RatingInt
        { 
            get { return RatingInt; } 
            set 
            { 
                if (value < 10 && value > 0) 
                {
                    RatingInt = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Must be between 1 and 10");
                }
            }
        }
      
    }
}
