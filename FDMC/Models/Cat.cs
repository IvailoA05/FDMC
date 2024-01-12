using System.ComponentModel.DataAnnotations;

namespace FDMC.Models
{
    public class Cat
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        public string imageUrl { get; set; }
        public Cat()
        {

        }
    }
}
