using System.ComponentModel.DataAnnotations;

namespace medica1.Models
{
    public class Generic_Name
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Short_Name { get; set; }
        public string Description { get; set; } 
        public string Created_By { get; set; }
        public string Change_by { get; set; }

        public List<Medicine_Name> Genetic_Namemedicine_Names { get; set; }= new List<Medicine_Name>();
        public List<Combination> Genericcombinations { get; set; }= new List<Combination>();


    }
}
