using CoreAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAssignment.Repository
{
  public interface ILoginRepository
  {
    bool GetUser(LoginUser loginInfo);
  }
}
