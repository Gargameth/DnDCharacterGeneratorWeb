using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DnDCharGenWeb.Pages
{
    public class AttributeGeneratorModel : PageModel
    {
        public int _str { get; set; }
        public int _dex { get; set; }
        public int _con { get; set; }
        public int _int { get; set; }
        public int _wis { get; set; }
        public int _char { get; set; }
        public void OnGet()
        {
        }
    }
}
