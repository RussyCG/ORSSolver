using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ORSObjectiveFunction
    {
        private List<float> coefficients;
        private ZType zType;

        public ORSObjectiveFunction(List<float> CoefficientsParam, ZType ZTypeParam)
        {
            this.Coefficients = CoefficientsParam;
            this.ZType = ZTypeParam;
        }

        public ZType ZType
        {
            get { return zType; }
            set { zType = value; }
        }

        public List<float> Coefficients
        {
            get { return coefficients; }
            set { coefficients = value; }
        }

    }
}
