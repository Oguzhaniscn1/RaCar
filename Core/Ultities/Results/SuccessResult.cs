using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Ultities.Results
{
    public class SuccessResult : Result
    {
        //olumlu dönüş zaten sınıfımız olduğu için true yi defult olarak veriyoruz mesajı bus te ekleteceğiz.
        //base in manası result sınıfına göndermektir
        public SuccessResult(string message) : base(true,message)
        {

        }
        //olumlu dönüş zaten sınıfımızıın amacaı ve şimdide mesajsız olumlu dönüş yaptık SuccesResult()=>True defult
        public SuccessResult():base(true)
        {

            
        }
    }
}
