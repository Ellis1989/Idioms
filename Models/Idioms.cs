using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace English_Idioms.Models
{
    public class Idioms
    {
        public int Id { get; set; }
        public string Idiom{ get; set; }
        public string definition { get; set; }
        public string Example { get; set; }
        public Idioms()
        {

        }
    }
}
