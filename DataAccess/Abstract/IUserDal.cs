using Core.DataAccess;
using Core.Entities.Concrete;

using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUserDal: IEntityRepository<User>
    {
        List<RentalDetailDto> GetRentalDetails();
  
        List<OperationClaim> GetClaims(User user);
    }
}

