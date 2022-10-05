using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medica1.Models
{
    public class Medicine_Name
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Generic_Name> Medicine_Namegeneric_Names { get; set; }=new List<Generic_Name>();

    }
}
