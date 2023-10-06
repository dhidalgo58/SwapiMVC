using System.Net.Http;
using Microsoft.AspNetCore.Mvc;

namespace SwapiMvc.Controllers	
{
	public class PeopleController : Controller
	{
		private readonly HttpClient _httpClient;
		public PeopleController(IHttpClientFactory httpClientFactory) 
		{ 
			_httpClient = httpClientFactory.CreateClient("swapi");
		}
		
		public IActionResult Index() 
		{ 
			return View(); 		
		}
	}
}
