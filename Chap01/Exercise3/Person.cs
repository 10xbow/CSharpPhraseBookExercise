using System;

namespace Exercise3
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public int GetAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - BirthDay.Year;
            if (today < BirthDay.AddYears(age))
            {
                age--;
            }
            return age;
        }
    }
}
