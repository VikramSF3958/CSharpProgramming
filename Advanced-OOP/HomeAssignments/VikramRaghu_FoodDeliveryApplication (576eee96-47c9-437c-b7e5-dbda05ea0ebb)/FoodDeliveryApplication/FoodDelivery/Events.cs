
namespace FoodDelivery
{   
    public delegate void EventHandler();
    public class Events
    {   
        public static event EventHandler eventlink = null;
        public static void Subscribe()
        {
            eventlink += new EventHandler(FilesData.Create);
            eventlink += new EventHandler(FilesData.Read);
            eventlink += new EventHandler(MainMenuClass.MainMenu);
            eventlink += new EventHandler(FilesData.Write);
        }

        public static void StartEvent()
        {
            Subscribe();
            eventlink();
        }
    }
}