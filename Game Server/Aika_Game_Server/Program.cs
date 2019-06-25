using System;

namespace Aika_Game_Server
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                ServerSocket.Run();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
