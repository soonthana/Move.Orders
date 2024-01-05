using Microsoft.AspNetCore.Mvc;

namespace Move.Orders.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    public ActionResult Get()
    {
        var result = "Hello Test";

        return Ok(result);
    }
}