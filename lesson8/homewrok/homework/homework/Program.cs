using Games;

bool isNext = false;
TicTacToe ticTacToe = new();

while (true) {
    if (!isNext)
        ticTacToe.Play();

    Console.Write("\nХотите сыграть ещё?\n1 - Да\n2 - Нет\nВвод: ");
    int userChoice = int.Parse(Console.ReadLine());

    isNext = !(userChoice >= 1 && userChoice <= 2);
    if (isNext) { Console.WriteLine("Вы ввели несуществующий пункт!"); }
    else if (userChoice == 2) { Console.WriteLine("Приходите ещё!)"); break; }
}