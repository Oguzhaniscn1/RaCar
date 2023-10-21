using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Ultities.Results
{
    public interface IDataResult<T>:IResult 
    {
        //gelecek olan sınıf
        T Data { get; }

    }
}
