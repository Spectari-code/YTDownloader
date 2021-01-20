using System;
using System.IO;
using VideoLibrary;

// TODO: Use something like a try catch block to display a more human friendly error message when an invalid link is pasted.

namespace YTDownloader
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var youTube = YouTube.Default; // starting point for Youtube actions.

            Console.WriteLine("Youtube Downloader\nEnter the youtube link: ");
            var id = Console.ReadLine(); //id is the link
            Console.WriteLine("Downloading...");

            var video = youTube.GetVideo(id); //download the vid
            // Add Download path.
            File.WriteAllBytes(@"C:\Users\Bligh\Downloads\" + video.FullName, video.GetBytes());
            Console.WriteLine("Finished.");

            Console.ReadKey();
            Console.WriteLine("Closing...");
        }
    }
}