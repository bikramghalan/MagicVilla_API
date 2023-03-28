namespace MagicVilla_VillaAPI.Logging
{
    public class Logging : ILogging
    {
        public void Log(string messsage, string type)
        {
            if (type == "error")
            {
                Console.WriteLine("Error - " + messsage);
            }
            else 
            {
                Console.WriteLine(messsage);
            }
        }
    }
}
