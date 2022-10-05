using System.ComponentModel.DataAnnotations;

namespace medica1.Models
{
    public class Combination
    {
        [Key]
        public string Medicine_Type { get; set; }
        public string Streanth { get; set; }
        public string Minimum_Dose { get; set; }
        public int Max_Dose { get; set; }
        public string Create_By { get; set; }
        public List<Medicine_Type> CombinationMedicine_Type { get; set; }=new List<Medicine_Type>();
        public List<Generic_Name> Combinationgeneric_Names { get; set; }=new List<Generic_Name>();
        public int ID { get; internal set; }
    }
}
