using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework {
    delegate void MyDelegateVoid();
    delegate bool MyDelegateBool();

    class VoidSourceEvent {
        public event MyDelegateVoid Event;
        public void GeneratorEvent() {
            Console.WriteLine("Произошло событие!");
            Event?.Invoke();
        }
    }

    class BoolSourceEvent {
        public event MyDelegateBool Event;
        public void GeneratorEvent() {
            Console.WriteLine("Произошло событие!");
            Event?.Invoke();
        }
    }

    internal class CreditCard {
        public string CardNumber { get; set; }
        public string FirstNamePerson { get; set; }
        public string LastNamePerson { get; set; }
        public DateTime CardValidityPeriod { get; set; }
        public int PIN { get; set; }
        public int CreditLimit { get; set; }
        public int TheAmountMoney { get; set; }

        public CreditCard() : this (null, null, null, 0, 0, 0) { }
        public CreditCard(string cardNumber, string firstNamePerson, string lastNamePerson, int pIN, int creditLimit, int theAmountMoney) {
            CardNumber = cardNumber;
            FirstNamePerson = firstNamePerson;
            LastNamePerson = lastNamePerson;
            CardValidityPeriod = DateTime.Now.AddYears(10);
            PIN = pIN;
            CreditLimit = creditLimit;
            TheAmountMoney = theAmountMoney;
        }


        // Метод для ввода PIN
        public bool EnterPin() {
            int numberAttempts = 0;
            bool isNext = false;

            do {
                Console.Write("Введите PIN: ");
                int tempPIN = int.Parse(Console.ReadLine());

                isNext = !(tempPIN == PIN);

                if (isNext) { numberAttempts++; Console.WriteLine("Неверный PIN!\n"); }
                if (numberAttempts == 3) { Console.WriteLine("Карта заблокирована!"); return false; };
            } while (isNext);

            Console.WriteLine("PIN верный!");
            return true;
        }

        // Метод для вывода информации
        public void Print() {
            Console.Write($"Номер каты: ");
            for (int i = 0; i < CardNumber.Length; i++) {
                if (i < 13) { Console.Write($"*{ (((i + 1) % 4) == 0 ? " " : "") }"); } 
                else { Console.Write(CardNumber[i]); }
            }
            Console.WriteLine($"\nИмя: {FirstNamePerson}");
            Console.WriteLine($"Фамилия: {LastNamePerson}");
            Console.WriteLine($"Срок карты: {CardValidityPeriod}");
            Console.WriteLine("PIN карты: ****");
            Console.WriteLine($"Кредитный лимит: {CreditLimit}");
            Console.WriteLine($"Счёт: {TheAmountMoney}");
        }



        // Метод для пополнения счёта
        public void DepositAmount(int amount) {
            if (amount <= 0) { Console.WriteLine("Введите значение больше 0"); return; }
            TheAmountMoney += amount;
        }

        // Метод для расхода денег со счёта
        public void WithdrawAmount(int amount) {
            if (amount > TheAmountMoney) { Console.WriteLine("Вы ввели значение превышающий ваш счёт"); }
            else if (amount <= 0) { Console.WriteLine("Введите значение больше 0"); return; }
            TheAmountMoney -= amount;
        }

        // Метод для старта использования кредитных денег
        public void StartCreditUsage() {
            Console.WriteLine("Вы начали использовать кредитные средства.");
        }

        // Метод для достижения заданной суммы денег
        public bool ReachTargetAmount(int target) {
            if (TheAmountMoney >= target) {
                Console.WriteLine("Целевая сумма достигнута!");
                return true;
            }

            Console.WriteLine("Целевая сумма пока не достигнута.");
            return false;
        }

        // Метод для смены PIN
        public void ChangePin() { 
            if (!EnterPin()) { return; }

            bool isNext = false;
            string tempPIN = null;

            do {
                Console.Write("Введите новый PIN: ");
                tempPIN = Console.ReadLine();

                isNext = !(tempPIN.Length > 0 && tempPIN.Length <= 4);

                if (isNext) { Console.WriteLine("Макс. размер пин-кода 4 цифры"); }
            } while (isNext);

            PIN = int.Parse(tempPIN);
        }
    }
}
