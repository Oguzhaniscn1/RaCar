using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Ultities.Security.Encryption
{
    public class SigningCredentailsHelper
    {
        //gelen jwt doğrularken kullanılacak algoritmayı tanıtıyoruz.
        public static SigningCredentials CreateSigningCredentails(SecurityKey securityKey)
        {
            return new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha512Signature);
        }
    }
}
