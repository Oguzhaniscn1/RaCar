using Core.Ultities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Ultities.Business
{
    public class BusinessRules
    {                               //IResult dizisi
        public static IResult Run(params IResult[] logics)
        {
            foreach (var logic in logics)
            {//kuralları gez kurala uymayan varsa döndür
                if (!logic.Success)
                {

                    return logic;
                }
            }
            return null;
        }
    }
}
