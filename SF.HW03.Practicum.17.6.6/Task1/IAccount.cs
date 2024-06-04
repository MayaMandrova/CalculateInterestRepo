using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public interface IAccount
    {
        double Balance { get; set; }
        double Interest { get; set; }
        void CalculateInterest();
    }
}
