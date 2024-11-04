using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework {
    internal class TeamLeader {
        private IPart part = null;

        public IPart Part { set { part = value; } }

        public void BuildFullFeaturedProduct() {
            part.Basement();
            part.Walls();
            part.Walls();
            part.Walls();
            part.Walls();
            part.Door();
            part.Window();
            part.Window();
            part.Window();
            part.Window();
            part.Roof();
        }
    }
}
