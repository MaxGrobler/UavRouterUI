using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UavRouteUI.Models;
using UavRouteUI.Services;

namespace UavRouteUI.Pages;

public class IndexModel : PageModel // just inherits mvc functionality 
{
    public List<Uav> Uavs { get; set; } = new();
 
    public void OnGet()//does this once a get request is sent from http
    {
        UavData myUavService = new UavData();
        List<Uav> myUavs = myUavService.GetUavs();
        Uavs = myUavs;
    }
}
