using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RiderApp.DataAccess;
using RiderApp.DTO;

namespace RiderApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        DbAccess Dbaccess;

        public AccountController(DbAccess dba)
        {
            Dbaccess = dba;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var account = Dbaccess.GetAllAccount();
            return Ok(new { Data = account });
        }

        [HttpGet("{id}")]
        public ActionResult GetById(Guid id)
        {
            var account = Dbaccess.GetAccountById(id);
            if (account != null)
            {
                return Ok(new { Data = account });
            }
            else
            {
                return NotFound(new { Data = "Account not found" });
            }
        }

        [HttpPost]
        public ActionResult AddAccount(AccountDTO account)
        {
            bool status = Dbaccess.AddAccount(account);
            if (status)
            {
                return Ok(new { Data = "Account successfully created" });
            }
            else
            {
                return BadRequest(new { Data = "Failed to create account" });
            }
        }

        [HttpPut("{id}")]
        public ActionResult UpdateAccount(Guid id, AccountDTO updatedAccount)
        {
            if (id != updatedAccount.Id)
            {
                return BadRequest(new { Data = "ID mismatch" });
            }

            bool status = Dbaccess.UpdateAccount(updatedAccount);
            if (status)
            {
                return Ok(new { Data = "Account updated successfully" });
            }
            else
            {
                return NotFound(new { Data = "Account not found" });
            }
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteAccount(Guid id)
        {
            bool status = Dbaccess.DeleteAccountById(id);
            if (status)
            {
                return Ok(new { Data = "Account deleted successfully" });
            }
            else
            {
                return NotFound(new { Data = "Account not found" });
            }
        }
    }
}
