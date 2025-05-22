using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SummonerSaveFileEditor.Services
{
    public static class SettingsManager
    {
        private const string WINDOW_SECTION = "Window";
        private const string PATHS_SECTION = "Paths";

        // Save window position and size
        public static void SaveWindowState(Form form)
        {
            if (form.WindowState == FormWindowState.Normal)
            {
                IniSettings.WriteInt(WINDOW_SECTION, "Left", form.Left);
                IniSettings.WriteInt(WINDOW_SECTION, "Top", form.Top);
                IniSettings.WriteInt(WINDOW_SECTION, "Width", form.Width);
                IniSettings.WriteInt(WINDOW_SECTION, "Height", form.Height);
            }
            else
            {
                // Save the restored position if minimized or maximized
                IniSettings.WriteInt(WINDOW_SECTION, "Left", form.RestoreBounds.Left);
                IniSettings.WriteInt(WINDOW_SECTION, "Top", form.RestoreBounds.Top);
                IniSettings.WriteInt(WINDOW_SECTION, "Width", form.RestoreBounds.Width);
                IniSettings.WriteInt(WINDOW_SECTION, "Height", form.RestoreBounds.Height);
            }
            // Save window state
            IniSettings.WriteInt(WINDOW_SECTION, "State", (int)form.WindowState);
        }

        // Apply saved window position and size
        public static void ApplyWindowState(Form form)
        {
            int width = IniSettings.ReadInt(WINDOW_SECTION, "Width", -1);
            int height = IniSettings.ReadInt(WINDOW_SECTION, "Height", -1);
            
            // Only apply if we have saved settings
            if (width > 0 && height > 0)
            {
                int left = IniSettings.ReadInt(WINDOW_SECTION, "Left", 0);
                int top = IniSettings.ReadInt(WINDOW_SECTION, "Top", 0);
                
                // Check if the saved position is visible on current screen setup
                bool isVisible = false;
                foreach (Screen screen in Screen.AllScreens)
                {
                    Rectangle intersection = Rectangle.Intersect(
                        screen.WorkingArea,
                        new Rectangle(left, top, width, height));
                    
                    if (intersection.Width > 50 && intersection.Height > 50)
                    {
                        isVisible = true;
                        break;
                    }
                }

                if (isVisible)
                {
                    form.Left = left;
                    form.Top = top;
                    form.Width = width;
                    form.Height = height;
                    
                    // Restore window state if saved
                    int state = IniSettings.ReadInt(WINDOW_SECTION, "State", -1);
                    if (state >= 0 && state <= 2) // Normal, Minimized, Maximized
                    {
                        form.WindowState = (FormWindowState)state;
                    }
                }
            }
        }

        // Save the last used folder for save files
        public static void SaveLastFolder(string path)
        {
            if (!string.IsNullOrEmpty(path))
            {
                IniSettings.WriteString(PATHS_SECTION, "LastSaveFolder", path);
            }
        }

        // Get the last used folder, or null if none saved
        public static string GetLastFolder()
        {
            string lastFolder = IniSettings.ReadString(PATHS_SECTION, "LastSaveFolder", "");
            if (string.IsNullOrEmpty(lastFolder) || !Directory.Exists(lastFolder))
                return null; // Return null instead of a default

            return lastFolder;
        }

        // Get the last used folder with fallback path
        public static string GetLastFolderWithFallback(string defaultFolder = null)
        {
            string folder = GetLastFolder();
            if (folder == null)
                return defaultFolder ?? Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            return folder;
        }

        // Save game installation path
        public static void SaveGamePath(string path)
        {
            if (!string.IsNullOrEmpty(path))
            {
                IniSettings.WriteString(PATHS_SECTION, "GameInstallPath", path);
            }
        }

        // Get game installation path
        public static string GetGamePath()
        {
            return IniSettings.ReadString(PATHS_SECTION, "GameInstallPath", "");
        }
    }
}