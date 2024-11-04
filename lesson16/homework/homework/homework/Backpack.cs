using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework {
    delegate void ItemAdd(BackpackItem item);
    internal class BackpackItem {
        public string Name { get; set; }
        public int Volume { get; set; }

        public BackpackItem(string name, int volume) {
            Name = name;
            Volume = volume;
        }
    }
    internal class Backpack {
        public string Color { get; set; }
        public string Manufacturer { get; set; }
        public string Fabric { get; set; }
        public int Weight { get; set; }
        public int MaxVolume { get; set; }
        public BackpackItem[] Contents { get; private set; }

        public Backpack() : this(null, null, null, 0, 0, null) { }
        public Backpack(string theColorTheBackpack, string manufacturerName, string backpackFabric, 
                        int backpackWeight, int theMaxVolumeTheBackpack, BackpackItem[] theContentsTheBackpack) {
            Color = theColorTheBackpack;
            Manufacturer = manufacturerName;
            Fabric = backpackFabric;
            Weight = backpackWeight;
            MaxVolume = theMaxVolumeTheBackpack;
            Contents = theContentsTheBackpack;
        }

        public void AddItem(BackpackItem item) {
            ItemAdd itemAdd = delegate (BackpackItem item) {
                int currentVolume = 0;
                for (int i = 0; i < Contents.Length; i++) { currentVolume += Contents[i].Volume; }

                if ((currentVolume + item.Volume) <= MaxVolume) {
                    BackpackItem[] tempContents = new BackpackItem[Contents.Length + 1];
                    for (int i = 0; i < Contents.Length; i++) { tempContents[i] = Contents[i]; }

                    tempContents[Contents.Length] = item;
                    Contents = tempContents;

                    Console.WriteLine($"Элемент '{item.Name}' добавлен в рюкзак.");
                } else {
                    throw new Exception("Не удается добавить элемент. Недостаточно места.");
                }
            };
            itemAdd?.Invoke(item);
        }
    }
}
