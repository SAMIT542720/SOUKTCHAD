using SOUKTCHAD.Models;

namespace SOUKTCHAD.Data.ModelViews
{
    public class NewProductDropDownVM
    {
        public NewProductDropDownVM()
        {
            Catigories = new List<CATIGORY>();
        }
        public List<CATIGORY> Catigories { get; set; }
    }
}
