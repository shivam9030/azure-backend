using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")] // Responds to /order
public class OrderController : ControllerBase
{
    [HttpGet]
    public IActionResult GetOrder()
    {
        var order = new
        {
            OrderId = 101,
            ProductName = "Chocolate Cake",
            Quantity = 2,
            Price = 299
        };

        return Ok(order);
    }
}
