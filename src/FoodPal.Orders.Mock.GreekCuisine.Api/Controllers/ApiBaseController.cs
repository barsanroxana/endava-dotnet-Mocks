using Microsoft.AspNetCore.Mvc;

namespace FoodPal.Orders.Mock.GreekCuisine.Api.Controllers
{
    [ApiController]
	[Produces("application/json")]
	[Route("v{version:apiVersion}/[controller]")]
	public class ApiBaseController : ControllerBase
	{

	}
}
