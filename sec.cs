using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of StartupOpener
        StartupOpener opener = new StartupOpener();

        // Prompt user to select an application
        string selectedAppPath = opener.SelectApplication();
        if (!string.IsNullOrEmpty(selectedAppPath))
        {
            Console.WriteLine($"Selected application path: {selectedAppPath}");

            // Add the selected app to startup
            opener.AddAppToStartup("SelectedApp", selectedAppPath);
        }
        else
        {
            Console.WriteLine("No application selected.");
        }

        Console.ReadLine(); // Keep console window open until Enter is pressed
    }
}
