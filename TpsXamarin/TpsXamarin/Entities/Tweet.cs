using System;
using System.Collections.Generic;
using System.Text;

namespace TpsXamarin.Entities
{
    public class Tweet
    {
        public int Id { get; set; }
        public User User { get; set; }
        public DateTime DateCreation { get; set; }
        public String Text { get; set; }
    }
}
