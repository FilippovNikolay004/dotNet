using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardNamespace {
    internal class CreditCard {
        private string _FirstName;
        private string _LastName;
        private int _CVC;
        private DateTime _CardCompletionDate;
        //CreditCard() { }
        //CreditCard(string FirstName, string LastName, int CVC, DateTime CardCompletionDate) {
        //    this.FirstName = FirstName;
        //    this.LastName = LastName;
        //    this.CVC = CVC;
        //    this.CardCompletionDate = CardCompletionDate;
        //}
        private bool IsDigit(string text) {
            for (int i = 0; i < text.Length; i++) {
                if (text[i] >= '0' && text[i] <= '9') { return true; }
            }
            return false;
        }
        public string FirstName { 
            set {
                if (IsDigit(value) || value.Length == 0) {
                    throw new Exception("Invalid fistName");
                }
                _FirstName = value;
            }
        }
        public string LastName {
            set {
                if (IsDigit(value) || value.Length == 0) {
                    throw new Exception("Invalid lastName");
                }
                _LastName = value;
            }
        }
        public int CVC { 
            set {
                if (value.ToString().Length != 3) {
                    throw new Exception("Invalid CVC");
                }
                _CVC = value;
            }
        }
        public DateTime CardCompletionDate {
            set {
                if (value <= DateTime.Now) {
                    throw new Exception("Date invalid");
                }
                _CardCompletionDate = value;
            } 
        }
    }
}
