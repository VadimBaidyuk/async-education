using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace async_education
{
    public class CreateFolderStream
    {
        private const string FolderPath = "D:\\_prj\\async-education\\async-education\\async-education\\Folder\\";

        public static FileStream FileStream;
        public static void RunTask()
        {
            Thread.Sleep(new Random().Next(1000,20000));
            
            createFolderTask.Start();
            createFolderTask.Wait();
        }

        private static readonly Task createFolderTask = new Task(CreateFolder);

        private static void CreateFolder() => 
            FileStream = File.Create(FolderPath + UkrainianArtistBiography.Artists
                .ElementAt(new Random().Next(0, UkrainianArtistBiography.Artists.Count)).Key);
        
    }
}