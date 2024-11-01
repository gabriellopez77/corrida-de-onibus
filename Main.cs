namespace RacingGame;

public class Program
{
    public static string[,] Pista = new string[12, 120];
    public static int MovCar1 = 0;
    public static int MovCar2 = 0;

    static void Main()
    {
        Random random = new Random();
        Methods.DefineArray();
        Methods.DrawBorder();
        while (true)
        {
            Methods.DrawCars();
            Methods.DrawScreen();
            Methods.ClearRoads();

            ConsoleKeyInfo key;
            key = Console.ReadKey();



            if (key.KeyChar == 'd')
                MovCar1++;

            else if (key.KeyChar == 'a' && MovCar1 > 0)
                MovCar1--;

            else if (key.KeyChar == 'r')
                MovCar2++;

            else if (key.KeyChar == 'e' && MovCar2 > 0)
                MovCar2--;

            if (MovCar1 == Pista.GetLength(1) - 14)
            {
                Console.WriteLine("Carro 1 Ganhou!");
                break;
            }

            if (MovCar2 == Pista.GetLength(1) - 14)
            {
                Console.WriteLine("Carro 2 Ganhou!");
                break;
            }

            Console.Clear();
        }
        Console.ReadLine();
    }
}

