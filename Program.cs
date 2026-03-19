using System.Net;
using System.Diagnostics;

foreach(Process process in Process.GetProcesses())
    {
        Console.WriteLine($"ID: {process.Id}");
    }
    
Process process1 = Process.GetProcessesByName("devenv")[0];
ProcessThreadCollection processThread = process1.Threads;

foreach (ProcessThread thread in processThread)
    {
        Console.WriteLine($"ThreadId: {thread.Id}");
    }

Process.Start(@"C:\Users\23_ИП-291к\Desktop\DB Browser for SQLite.exe");
Process.Start(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\");
