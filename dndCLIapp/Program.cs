using System;

namespace DndApp
{
    class Program
    {
        public const string apiUrl = "https://www.dnd5eapi.co";
        static void Main()
        {
            DndApp app = new DndApp(apiUrl);
            app.Run();
            
        }
    }
}
