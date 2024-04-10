// See https://aka.ms/new-console-template for more information
using System.Reflection;
using Menelabs;

FileSystemSafeWatcher safeWatcher = new FileSystemSafeWatcher("C:\\temp");
safeWatcher.Filters.Add("*.txt");
safeWatcher.Filters.Add("*.csv");