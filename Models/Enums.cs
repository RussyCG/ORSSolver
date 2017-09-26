using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public enum ZType
    {
        MIN, MAX
    }

    public enum SolutionType
    {
        SIMPLEX, DUALSIMPLEX
    }

    public enum ConstraintType
    {
        LessThan, EqualTo, GreaterThan
    }
}
