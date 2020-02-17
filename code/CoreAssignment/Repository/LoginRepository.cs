using CoreAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAssignment.Repository
{
  public class LoginRepository : ILoginRepository
  {

    public bool GetUser(LoginUser loginInfo)
    {
      bool flag = false;
      if (loginInfo.UserName == "aafreen" && loginInfo.Password == "aafreen@123")
      {
        flag = true;
      }
      return flag;
     
    }
  }
}
