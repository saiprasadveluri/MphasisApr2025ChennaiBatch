using Microsoft.AspNetCore.Mvc;
using RideAggrigationAPI.DataAccess;
using RideAggrigationAPI.DTO;

[Route("api/[controller]")]
[ApiController]
public class CustomerController : ControllerBase
{
    private readonly DbAccess _db;

    public CustomerController(DbAccess db)
    {
        _db = db;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var data = _db.GetAllCustomers();
        return Ok(new { Data = data });
    }

    [HttpGet("{id}")]
    public IActionResult GetById(Guid id)
    {
        var customer = _db.GetCustomerById(id);
        if (customer == null) return NotFound();
        return Ok(new { Data = customer });
    }

    [HttpPost]
    public IActionResult Add(CustomerAddDTO input)
    {
        bool status = _db.AddCustomer(input);
        return Ok(new { Data = status ? "Added Successfully" : "Error" });
    }
}