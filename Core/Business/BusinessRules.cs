using Core.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)
        {
            foreach (var item in logics)
            {
                if (!item.Success)
                    return item;
            }
            return null;
        }

        public static IResult Run(object checkIfCarHas5Images)
        {
            throw new NotImplementedException();
        }
    }
}
