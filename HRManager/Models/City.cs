using System.Collections.Generic;

namespace HRManager.Models
{
    public class City
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Person> person { get; set; }
    }
}