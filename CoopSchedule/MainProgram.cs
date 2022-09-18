using System;
using System.Windows.Forms;

namespace CoopSchedule;

internal static class MainProgram
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new CoopForm());
    }
}