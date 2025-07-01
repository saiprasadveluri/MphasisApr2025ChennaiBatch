using Microsoft.AspNetCore.Mvc;
using OnlinePharmacyAppAPI.DTO;
using OnlinePharmacyAppAPI.Services;

namespace OnlinePharmacyAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemsController: Controller
    {
            Unity _unity;
            public OrderItemsController(Unity dba)
            {
                _unity = dba;
            }
            [HttpGet]
            public ActionResult GetAll()
            {
                List<OrderItemDTO> lst = _unity.OrderItemService.GetAllOrderItems();
                return Ok(new { Data = lst });
            }

            [HttpPost]
            public ActionResult AddOrderItem(OrderItemDTO inp)
            {
                bool Status = _unity.OrderItemService.AddNewOrderItem(inp);
                return Ok(new { Data = "Success in Adding OrderItem" });

            }
        [HttpPut("{id}")]
        public ActionResult UpdateOrderItem(OrderItemDTO inp, int id)
        {
            inp.OrderItemId = id;
            bool Status = _unity.OrderItemService.UpdateOrderItem(inp);
            return Ok(new { Data = "Success in Updating OrderItem" });

        }
        [HttpDelete("{orderItemId}")]
        public ActionResult DeleteOrderItem(int orderItemId)
        {
            bool result = _unity.OrderItemService.DeleteOrderItem(orderItemId);
            if (!result)
                return NotFound(new { Error = "OrderItem not found or could not be deleted" });

            return Ok(new { Data = "OrderItem deleted successfully" });
        }
    }
}
