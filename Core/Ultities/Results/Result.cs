using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Ultities.Results
{
    public class Result : IResult
    {
        //business katmanında metodlarımızı bu ctorlara göre yazacağız.
        //mesajlı geri dönüş
        //This in manası bu çalıştığı zaman alt tarafta olan tek success parametereli cctor çalışsın,kapsasın.
        public Result(bool success,string message):this(success)
        {
            Message = message;
        }
        //mesajsız geri dönüş
        public Result(bool success)
        {
            Success = success;
        }
        //bu dönüşlerin olumlu olan successresult ve olumsuz dönüş olan 
        //errorresult u oluşturup bu sınıftan kalıtım aldıracağız.







        public bool Success { get; }

        public string Message { get; }
    }
}
