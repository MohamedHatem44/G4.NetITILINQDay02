using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G4.NetITILINQDay02
{
    public class EmpComp : IEqualityComparer<Employee>
    {
        /*--------------------------------------------------------*/
        public bool Equals(Employee? x, Employee? y)
        {
            return x.Id == y.Id && x.Name == y.Name;
        }
        /*--------------------------------------------------------*/

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return obj.Id;
        }
        /*--------------------------------------------------------*/
    }
}
