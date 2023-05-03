using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAddition
{
    public interface IMathAddition<T>
    {
        T Perform(T value1, T value2);
    }
}
