using DnDCharGenWeb.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DnDCharGenWeb.Pages
{
    public class CharacterSheetModel : PageModel
    {
        public string _str => DataManager._str;
        public string _dex => DataManager._dex;
        public string _con => DataManager._con;
        public string _int => DataManager._int;
        public string _wis => DataManager._wis;
        public string _char => DataManager._char;
        public void OnGet()
        {
        }
    }
}
