using Microsoft.AspNetCore.Mvc;
using ModelLayer.DTO;
namespace UserRegistrationSystem.Controllers;
using BussinessLayer.Services;
[ApiController]
[Route("[controller]")]
public class UserRegistrationController : ControllerBase
{
    User user;
    ResponseModel _responseModel;
    UserRegistrationBL _registerBL;
    public UserRegistrationController(UserRegistrationBL userRegistrationBL)
    {
        _registerBL = userRegistrationBL;
    }

    [HttpGet]
    public string Get()
    {
        return "Hello from Controller";
    }

    [HttpPost]
    public IActionResult Regiteration(User user)
    {
        _responseModel = new ResponseModel();
        string check = _registerBL.check(user);

        try
        {
            bool flag = _registerBL.AddUser(user);
            if (flag)
            {
                _responseModel.email = user.email;
                _responseModel.success = true;
                _responseModel.Message = $"{user.name} {user.lname} Registered Successfully";
                return Ok(_responseModel);
            }
            _responseModel.email = user.email;
            _responseModel.success = false;
            _responseModel.Message = check + " Registration Failed!!";
            return StatusCode(400, _responseModel); ;
        }
        catch (Exception e)
        {
            return BadRequest();
        }
    }

}
