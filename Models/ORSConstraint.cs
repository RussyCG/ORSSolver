using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ORSConstraint
    {
        private List<float> variables;
        private SolutionType solutionType;
        private float rhs;

        public ORSConstraint(List<float> VariablesParam, SolutionType SolutionTypeParam, float RHSParam)
        {
            this.Variables = VariablesParam;
            this.SolutionType = SolutionTypeParam;
            this.RHS = RHSParam;
        }

        public float RHS
        {
            get { return rhs; }
            set { rhs = value; }
        }

        public SolutionType SolutionType
        {
            get { return solutionType; }
            set { solutionType = value; }
        }
        
        public List<float> Variables
        {
            get { return variables; }
            set { variables = value; }
        }

    }
}
