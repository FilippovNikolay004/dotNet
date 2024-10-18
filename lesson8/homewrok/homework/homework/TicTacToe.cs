using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games {
    internal class TicTacToe {
        private char[] freeFields = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private char[] graphicField = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private int userSymbol = 0;
        private int userChoice = 0;
        private int pcChoice = 0;
        Random r = new Random();

        public void Play() {
            ClearConsole();
            PrintInfo();
            UserChoiceSymbol();

            for (int i = 0; i < freeFields.Length - 4; i++) {
                if (i == 0) { ClearConsole(); PrintFields(); }

                UserChoice();

                if (CheckWin() && i >= 2) { break; }

                if (i < freeFields.Length - 5) {
                    PcChoice();

                    if (CheckWin() && i >= 2) { break; }
                }
            }

            Console.WriteLine("Game OVER");
            GameReset();
        }

        public void PrintInfo() {
            Console.WriteLine("      ========== ИГРА ==========");
            Console.WriteLine("========== КРЕСТИКИ НОЛИКИ ==========");
        }
        public bool CheckWin() {
            string result = WhoIsWin();

            if (result == "User") {
                ClearConsole();
                PrintFields();
                Console.WriteLine("User Win!");
                return true;
            } else if (result == "Robot") {
                ClearConsole();
                PrintFields();
                Console.WriteLine("Robot Win!");
                return true;
            }

            ClearConsole();
            PrintFields();
            return false;
        }

        public void PrintFields() {
            for (int i = 0; i < this.graphicField.Length; i++) {
                Console.Write(graphicField[i] + " ");

                if (((i + 1) % 3) == 0 && i != 0) { Console.WriteLine(""); }
            }
        }

        public void ClearConsole() { Console.Clear(); }

        public string WhoIsWin() {
            // Првоерки по горизонтали
            for (int i = 0; i < freeFields.Length - 2; i += 3) {
                if (freeFields[i] == 'u' && freeFields[i + 1] == 'u' && freeFields[i + 2] == 'u') {
                    return "User";
                } else if (freeFields[i] == 'r' && freeFields[i + 1] == 'r' && freeFields[i + 2] == 'r') {
                    return "Robot";
                }
            }

            // Проверки по вертикали
            for (int i = 0; i < freeFields.Length - 6; i++) {
                if (freeFields[i] == 'u' && freeFields[i + 3] == 'u' && freeFields[i + 6] == 'u') {
                    return "User";
                } else if (freeFields[i] == 'r' && freeFields[i + 3] == 'r' && freeFields[i + 6] == 'r') {
                    return "Robot";
                }
            }

            // Проверки по диагонали
            if (freeFields[0] == 'u' && freeFields[4] == 'u' && freeFields[8] == 'u' ||
                    freeFields[2] == 'u' && freeFields[4] == 'u' && freeFields[6] == 'u') {
                return "User";
            } else if (freeFields[0] == 'r' && freeFields[4] == 'r' && freeFields[8] == 'r' ||
                    freeFields[2] == 'r' && freeFields[4] == 'r' && freeFields[6] == 'r') {
                return "Robot";
            } 
            
            return "Nothing";
        }

        public bool isFreeFields(int choice) {
            if (freeFields[choice] == 'r' || freeFields[choice] == 'u') {  return false; }
            return true;
        }

        public void UserChoiceSymbol() {
            bool isNext = true;

            do {
                Console.Write("Выберите символ:\n1. X\n2. O\nВвод: ");
                userSymbol = int.Parse(Console.ReadLine());

                isNext = !(userSymbol >= 1 && userSymbol <= 2);
                if (isNext) { Console.WriteLine("Вы ввели несуществующий пункт!\n"); }
            } while (isNext);
        }

        public void UserChoice() {
            bool isNext = true;

            do {
                Console.Write("Выберите клетку: ");
                userChoice = int.Parse(Console.ReadLine());

                isNext = userChoice >= freeFields.Length || userChoice <= 0;
                if (isNext) {
                    Console.WriteLine("Вы выбрали не существующую клетку!\n");
                    continue;
                }
                userChoice--;

                isNext = !(isFreeFields(userChoice));

                if (isNext) { Console.WriteLine("Выберите свободну клетку!\n"); }
            } while (isNext);

            freeFields[userChoice] = 'u';
            graphicField[userChoice] = userSymbol == 1 ? 'X' : 'O';
        }

        public void PcChoice() {
            bool isNext = true;

            Console.WriteLine("Ходит робот!");
            
            do {
                pcChoice = r.Next(0, (freeFields.Length - 1));
                isNext = !(isFreeFields(pcChoice));
            } while (isNext);

            freeFields[pcChoice] = 'r';
            graphicField[pcChoice] = userSymbol != 1 ? 'X' : 'O';
        }

        public void GameReset() {
            for (int i = 0; i < freeFields.Length; i++) {
                freeFields[i] = (char)(i + '1');
                graphicField[i] = freeFields[i];
            }
        }
    }
}