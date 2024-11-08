using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserRoleMappingService
    {
        IDataResult<List<UserRoleMapping>> GetAll();
        IResult Add(UserRoleMapping userRoleMapping);
        IDataResult<UserRoleMapping> GetById(int id);
        IResult Update(UserRoleMapping userRoleMapping);
    }
}
