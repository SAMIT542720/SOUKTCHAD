using System.ComponentModel.DataAnnotations;

namespace SOUKTCHAD.Models
{
    public class CATIGORY
    {
        [Key]
        public int CATIGORYID { get; set; }
        public string? Name { get; set; }
        //relations
        public List<PRODUCT>? PRODUCTS { get; set; }
    }
}
