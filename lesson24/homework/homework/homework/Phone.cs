using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework {
    internal class Phone {
        public string PhoneName { get; set; }
        public string Manufacturer { get; set; }
        public int Price { get; set; }
        public DateTime ReleaseDate { get; set; }

        public Phone() : this(null, null, 0, DateTime.Now) {}
        public Phone(string phoneName, string manufacturer, int price, DateTime releaseDate) {
            PhoneName = phoneName;
            Manufacturer = manufacturer;
            Price = price;
            ReleaseDate = releaseDate;
        }

        public override string ToString() {
            return $"Название телефона: {PhoneName}\n" +
                $"Производитель: {Manufacturer}\n" +
                $"Цена: {Price}\n" +
                $"Дата выпуска: {ReleaseDate}";
        }
        public override int GetHashCode() {
            return HashCode.Combine(PhoneName, Manufacturer, Price, ReleaseDate);
        }
    }
}
