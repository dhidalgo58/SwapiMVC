using Microsoft.AspNetCore.Mvc;

namespace SwapiMvc.Controllers	
{
	public class PeopleController : Controller
	{
		public IActionResult Index() 
		{ 
			return View(); 		
		}
	}
}
