namespace RacingGame;

public class Methods
{
    public static void DefineArray()
    {
        //define todo o array
        for (byte y = 0; y < Program.Pista.GetLength(0); y++)
            for (byte x = 0; x < Program.Pista.GetLength(1); x++)
                Program.Pista[y, x] = " ";
    }


    public static void DrawBorder()
    {
        //top
        for (byte top = 1; top < Program.Pista.GetLength(1) - 1; top++)
        {
            Program.Pista[0, top] = "-";
            Program.Pista[6, top] = "-";
        }

        //left
        for (byte left = 1; left < 5; left++)
        {
            Program.Pista[left, 0] = "|";
            Program.Pista[6 + left, 0] = "|";
        }

        //right
        for (byte right = 1; right < 5; right++)
        {
            Program.Pista[right, Program.Pista.GetLength(1) - 1] = "|";
            Program.Pista[6 + right, Program.Pista.GetLength(1) - 1] = "|";
        }

        //bottom
        for (byte bottom = 1; bottom < Program.Pista.GetLength(1) - 1; bottom++)
        {
            Program.Pista[5, bottom] = "-";
            Program.Pista[11, bottom] = "-";
        }
    }


    public static void DrawCars()
    {
        //car 1
        for (int lawer3 = 1; lawer3 < 12; lawer3++)
        {
            Program.Pista[1, lawer3 + Program.MovCar1] = "H";
            Program.Pista[7, lawer3 + Program.MovCar2] = "█";
        }

        for (int lawer2 = 1; lawer2 < 11; lawer2++)
        {
            Program.Pista[2, lawer2 + Program.MovCar1] = "H";
            Program.Pista[8, lawer2 + Program.MovCar2] = "█";
        }

        for (int lawer1 = 1; lawer1 < 14; lawer1++)
        {
            Program.Pista[3, lawer1 + Program.MovCar1] = "H";
            Program.Pista[9, lawer1 + Program.MovCar2] = "█";
        }

        Program.Pista[4, 4 + Program.MovCar1] = "H";
        Program.Pista[4, 3 + Program.MovCar1] = "H";
        Program.Pista[4, 10 + Program.MovCar1] = "H";
        Program.Pista[4, 11 + Program.MovCar1] = "H";


        

        Program.Pista[10, 4 + Program.MovCar2] = "█";
        Program.Pista[10, 3 + Program.MovCar2] = "█";
        Program.Pista[10, 10 + Program.MovCar2] = "█";
        Program.Pista[10, 11 + Program.MovCar2] = "█";
    }


    public static void ClearRoads()
    {
        //road 1
        for (byte y = 1; y < 5; y++)
            for (byte x = 1; x < Program.Pista.GetLength(1) - 1; x++)
                Program.Pista[y, x] = " ";

        //road 2
        for (byte y = 7; y < 11; y++)
            for (byte x = 1; x < Program.Pista.GetLength(1) - 1; x++)
                Program.Pista[y, x] = " ";
    }


    public static void DrawScreen()
    {
        for (byte y = 0; y < Program.Pista.GetLength(0); y++)
        {
            for (byte x = 0; x < Program.Pista.GetLength(1); x++)
                Console.Write(Program.Pista[y, x]);

            Console.WriteLine();

        }
    }
}