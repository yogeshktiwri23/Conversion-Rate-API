using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.DabaseLayer.Model
{
    [Table("ConversionRate")]
    public class ConversionRate
    {
        public int Id { get; set; }
        public string ConversionType { get; set; } // e.g., "Length", "Weight", "Temperature"
        public string FromUnit { get; set; }
        public string ToUnit { get; set; }
        public double Rate { get; set; }
    }


}
