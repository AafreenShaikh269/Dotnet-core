using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAssignment.Models;
using CoreAssignment.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreAssignment.Controllers
{
  [Route("api/[controller]/[action]")]
  [ApiController]
  public class LoginController : ControllerBase
  {
    private readonly ILogin _service;

    public LoginController(ILogin service)
    {
      _service = service;
    }

    // POST api/values
    [HttpPost]  
    public void EmployeePost([FromBody] LoginUser value)
    {
    }

    [HttpGet]
    [Route("UserIn")]
    public ActionResult<string> Get()
    {
      return "value";
    }

    [HttpPost]
    [Route("UserLogin")]
    public async Task<bool> UserLogin([FromBody] LoginUser loginInfo)
    {
      try
      {
        return await _service.LoginUser(loginInfo);
      }
      catch (Exception e)
      {
        Console.WriteLine(e);
      }
      return true;
    }

  }
}