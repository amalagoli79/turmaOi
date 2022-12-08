namespace Back_End_ER06.Classes
{
    public static class Utils
    {
        public static void BarraCarregamento(string texto){
            
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Green;

            Console.Write($"{texto}");
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"=");
                Thread.Sleep(200);    
            }
            Console.ResetColor(); 
            Console.Clear();
        }
    }
}