using Microsoft.Win32;
using System;
using System.Windows.Forms;

public class StartupOpener
{
    // Method to add an app to startup
    public void AddAppToStartup(string appName, string appPath)
    {
        try
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            key.SetValue(appName, appPath);
            key.Close();
            Console.WriteLine($"Added '{appName}' to startup.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to add '{appName}' to startup: {ex.Message}");
        }
    }

    // Method to prompt user to select an application
    public string SelectApplication()
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "Executable Files (*.exe)|*.exe";
        openFileDialog.Title = "Select Application";
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            return openFileDialog.FileName;
        }
        else
        {
            return null;
        }
    }
}
