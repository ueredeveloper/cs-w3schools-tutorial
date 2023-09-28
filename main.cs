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
        // User name
        string name = "José";

        // User coordinates
        double lat = -15.123456789;
        double lng = -47.123456789;

        // Determine if the user is granted
        bool isGranted = true;

        /**
         * @brief Converts the boolean value to "Sim" (Yes) or "Não" (No).
         * @param isGranted The boolean value to convert.
         * @return "Sim" if the input is true, "Não" otherwise.
         */
        string ConvertIsGranted(bool isGranted)
        {
            return isGranted ? "Sim" : "Não";
        }

        // Display user information
        Console.WriteLine(
            $" Usuário: {name}" +
            $"\n Latitude: {lat}" +
            $"\n Longitude: {lng}" +
            $"\n Outorgado: {ConvertIsGranted(isGranted)}"
        );
    }
}
