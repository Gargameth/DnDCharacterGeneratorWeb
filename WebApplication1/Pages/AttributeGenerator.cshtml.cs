using DnDCharGenWeb.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace DnDCharGenWeb.Pages
{
    [BindProperties]
    public class AttributeGeneratorModel : PageModel
    {
        public string _str
        {
            get => DataManager._str;
            set => DataManager._str = value;
        }
        public string _dex
        {
            get => DataManager._dex;
            set => DataManager._dex = value;
        }
        public string _con
        {
            get => DataManager._con;
            set => DataManager._con = value;
        }
        public string _int
        {
            get => DataManager._int;
            set => DataManager._int = value;
        }
        public string _wis
        {
            get => DataManager._wis;
            set => DataManager._wis = value;
        }
        public string _char
        {
            get => DataManager._char;
            set => DataManager._char = value;
        }
        public IActionResult OnPost()
        {
            return Redirect("/Index");
        }
        public void OnGet()
        {
        }
    }
}
