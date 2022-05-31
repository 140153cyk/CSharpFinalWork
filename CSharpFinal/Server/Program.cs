using System;

namespace GameWinForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Server.Server server = new Server.Server();
            while(true)
            {

            }
        }
    }
}