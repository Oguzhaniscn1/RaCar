using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Ultities.Results
{
    public class ErrorResult : Result
    {

        //olummsuz geri dönüş sınıfımızın amacı false yi defult olarak belirtiyoruz.
        //mesajlı ve mesajsız olarak iki geri dönüş tipi belirlioruz bunları
        //business katmanında kullanacağız =>ErrorResult();->mesajsız false dönüş, ErrorRersult("işleminiz hatalı");
        //base nin manası result sınıfında göndermektir.
        public ErrorResult(string message) : base(false, message)
        {

        }
        public ErrorResult():base(false) 
        {
            
        }
    }
}
