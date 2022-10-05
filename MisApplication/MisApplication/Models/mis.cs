using System.ComponentModel.DataAnnotations;

namespace MisApplication.Models
{
    public class mis
    {
        [Key]
        public int Id { get; set; }
        public string EMO { get; set; }
        public string Admission { get; set; }
        public string Discharge { get; set; }
        public string NVD { get; set; }
        public string SB { get; set; }
        public string Dialysis { get; set; }
        public string Physiotherapy { get; set; }
        public string EPI { get; set; }
        public string Dressing { get; set; }
        public string Nebulizer { get; set; }
        public string InjectionPush { get; set; }
        public string Stich { get; set; }
        public string CS { get; set; }
        public string DandC { get; set; }
        public string Surgery { get; set; }
        public string USG { get; set; }
        public string Xray { get; set; }
        public string ECG { get; set; }
        public string CTG { get; set; }
        public string Lab { get; set; }
        public string PFquentity { get; set; }
        public string PFvalue { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime Date { get; set; }= DateTime.Now;
    }
}
