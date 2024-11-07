using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework {
    internal abstract class SeaInhabitants {
        public string Name { get; set; }
    }

    class Jellyfish :SeaInhabitants {
        public Jellyfish() { Name = "Медуза"; }
    }

    class Shark :SeaInhabitants {
        public Shark() { Name = "Акула"; }
    }

    class Dolphin :SeaInhabitants {
        public Dolphin() { Name = "Дельфин"; }
    }

    class Whale :SeaInhabitants {
        public Whale() { Name = "Кит"; }
    }

    class Octopus :SeaInhabitants {
        public Octopus() { Name = "Осьминог"; }
    }
}
