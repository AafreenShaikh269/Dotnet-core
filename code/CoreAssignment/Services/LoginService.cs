using CoreAssignment.Models;
using CoreAssignment.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAssignment.Services
{
  public class LoginService : ILogin
  {
    private readonly ILoginRepository _repository;


    public LoginService(ILoginRepository repository)
    {
      this._repository = repository;
    }

    public Task<bool> Login()
    {
      throw new NotImplementedException();
    }

    public bool LoginUser(LoginUser loginInfo)
    {

      var data = _repository.GetUser(loginInfo);
      return data;
    }

    Task<bool> ILogin.LoginUser(LoginUser loginUser)
    {
      throw new NotImplementedException();
    }
  }
}
