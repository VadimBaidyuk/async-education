using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace async_education
{
    public class CreateFileStream
    {
        private const string FolderPath = "D:\\_prj\\async-education\\async-education\\async-education\\Artists\\";
        public static FileStream FileStream { get; private set; }
        
        public static void RunTask()
        {
            Thread.Sleep(new Random().Next(1000,2000));
            
            createFileTask.Start();
            createFileTask.Wait();
        }

        private static readonly Task createFileTask = new Task(CreateFile);

        private static void CreateFile() => 
            FileStream = File.Create(FolderPath + UkrainianArtistBiography.Artists
                .ElementAt(new Random().Next(0, UkrainianArtistBiography.Artists.Count)).Key);
        
    }
}