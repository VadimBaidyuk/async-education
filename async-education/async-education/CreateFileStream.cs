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
        public static StreamWriter StreamWriter { get; private set; }
        
        public static void RunTask()
        {
            Thread.Sleep(new Random().Next(1000,2000));
            
            createFileTask.Start();
            createFileTask.Wait();
        }

        private static readonly Task createFileTask = new Task(CreateFile);

        private static void CreateFile()
        {
            var random = new Random();
            StreamWriter = new StreamWriter(FolderPath + UkrainianArtistBiography.Artists
                .ElementAt(random.Next(0, UkrainianArtistBiography.Artists.Count)));

            var text = RandomString(random.Next(1, 2000));
            StreamWriter.WriteLine(text);
        }

        private static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }
    }
}