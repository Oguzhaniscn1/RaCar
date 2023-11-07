using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Ultities.Security.JWT
{
    public interface ITokenHelper
    {
        //ilgili kullanınıcı için claimlere bakarak token oluşturacak userin sahip olduğu claimlerin tokende izi bulunacak.
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);

    }
}
