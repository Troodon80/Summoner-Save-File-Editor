using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace SummonerSaveFileEditor.Services
{
    public static class IniSettings
    {
        private static string _iniPath;

        // Win32 API for INI file operations
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        private static extern int GetPrivateProfileString(
            string section, string key, string defaultValue,
            StringBuilder returnValue, int size, string filePath);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        private static extern bool WritePrivateProfileString(
            string section, string key, string value, string filePath);

        // Initialize settings path
        static IniSettings()
        {
            string exePath = AppDomain.CurrentDomain.BaseDirectory;
            _iniPath = Path.Combine(exePath, "settings.ini");
        }

        // Read a string value from INI file
        public static string ReadString(string section, string key, string defaultValue = "")
        {
            StringBuilder sb = new StringBuilder(512);
            GetPrivateProfileString(section, key, defaultValue, sb, sb.Capacity, _iniPath);
            return sb.ToString();
        }

        // Write a string value to INI file
        public static void WriteString(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, _iniPath);
        }

        // Read an integer value from INI file
        public static int ReadInt(string section, string key, int defaultValue = 0)
        {
            string value = ReadString(section, key, defaultValue.ToString());
            return int.TryParse(value, out int result) ? result : defaultValue;
        }

        // Write an integer value to INI file
        public static void WriteInt(string section, string key, int value)
        {
            WriteString(section, key, value.ToString());
        }

        // Read a boolean value from INI file
        public static bool ReadBool(string section, string key, bool defaultValue = false)
        {
            string value = ReadString(section, key, defaultValue.ToString());
            return bool.TryParse(value, out bool result) ? result : defaultValue;
        }

        // Write a boolean value to INI file
        public static void WriteBool(string section, string key, bool value)
        {
            WriteString(section, key, value.ToString());
        }
    }
}