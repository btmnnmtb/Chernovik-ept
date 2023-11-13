using System;
using System.IO;
using System.Runtime.CompilerServices;
DriveInfo[] drives = DriveInfo.GetDrives();
foreach (DriveInfo drive in drives)
{
    Console.WriteLine($"  Название: {drive.Name}" + $"Объем диска: {drive.TotalSize}" + $"  Свободное пространство: {drive.TotalFreeSpace}");


}



Menu Show = new Menu();
int pos = Show.Show();

if (pos == 0)
{
    ShowPapka("D:\\");

}
if (pos == 1)
{
    ShowPapk("C:\\");
}
if (pos == 2)
{
    ShowPapk("Z:\\");
}
void ShowPapka(string s)
{

    while (true)
    {
        Console.Clear();
        string[] paths = Directory.GetDirectories(s);
        foreach (string path in paths)
        {
            Console.WriteLine("  " + path);

        }
        Menu Show = new Menu();
        int pos = Show.Show();
        if (pos == -90)
            return;
        
        ShowPapka(paths[pos]);





    }
}

void ShowPapk(string s)
{

    while (true)
    {
        Console.Clear();
        string[] paths = Directory.GetDirectories(s);
        foreach (string path in paths)
        {
            Console.WriteLine("  " + path);

        }
        Menu Show = new Menu();
        int pos = Show.Show();
        if (pos == -90)
            return;

        ShowPapka(paths[pos]);





    }
}

void ShowPap(string s)
{

    while (true)
    {
        Console.Clear();
        string[] paths = Directory.GetDirectories(s);
        foreach (string path in paths)
        {
            Console.WriteLine("  " + path);

        }
        Menu Show = new Menu();
        int pos = Show.Show();
        if (pos == -90)
            return;

        ShowPapka(paths[pos]);





    }
}