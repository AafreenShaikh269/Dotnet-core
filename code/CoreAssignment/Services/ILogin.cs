using CoreAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAssignment.Services
{
  public interface ILogin
  {
    Task<Boolean> LoginUser(LoginUser loginUser);
  }
}
