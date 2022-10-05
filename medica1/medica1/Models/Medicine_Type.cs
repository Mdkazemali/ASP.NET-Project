using System.ComponentModel.DataAnnotations;

namespace medica1.Models
{
    public class Medicine_Type
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Combination> Medicine_TypeCombination { get; set; }=new List<Combination>();
     
    }
}
