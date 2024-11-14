using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace additionalTask {
    internal class Passport {
        public string Series { get; set; }
        public string Number { get; set; }
        public DateTime IssueDate { get; set; }
        public string IssuingAuthority { get; set; }
        public DateTime ExpirationDate { get; set; }

        public Passport(string series, string number, DateTime issueDate, string issuingAuthority, DateTime expirationDate) {
            Series = series;
            Number = number;
            IssueDate = issueDate;
            IssuingAuthority = issuingAuthority;
            ExpirationDate = expirationDate;
        }
    }
}
