namespace HRManager.Models
{
    public class Person
    {
        public int ID { get; set; }
        public int CityID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual City City { get; set; }
    }
}