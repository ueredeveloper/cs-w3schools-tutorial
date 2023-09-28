using System;

/**
 * @brief This class contains the main entry point for the program.
 */
class HelloWorld
{
    /**
     * @brief The main method of the program.
     * @param args The command-line arguments.
     */
    static void Main(string[] args)
    {
        // user name
        string name = "José";
        // User coordinates
        double lat = -15.123456789;
        double lng = -47.123456789;

        // Determine if the user is granted
        bool isGranted = true;

     string ConvertIsGranted(bool isGranted) {
      return isGranted ? "Sim" : "Não";
    }

    Console.WriteLine(
      $" Usuário: {name}" +
      $"\n Latitude: {lat}" +
      $"\n Longitude: {lng}" +
      $"\n Outorgado: {ConvertIsGranted(isGranted)}"
    );
    }
}
