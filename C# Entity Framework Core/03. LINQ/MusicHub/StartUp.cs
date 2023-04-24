using System.Text;
using Microsoft.EntityFrameworkCore;
using MusicHub.Data.Models;

namespace MusicHub
{
    using System;

    using Data;
    using Initializer;

    public class StartUp
    {
        public static void Main()
        {
            MusicHubDbContext context =
                new MusicHubDbContext();

            DbInitializer.ResetDatabase(context);
            //Test your solutions here


            var result = ExportSongsAboveDuration(context, 260);
            Console.WriteLine(result);
        }

        public static string ExportAlbumsInfo(MusicHubDbContext context, int producerId)
        {

            StringBuilder sb = new StringBuilder();

            var albums = context
                .Albums
                .Where(pi => pi.ProducerId == producerId)
                .Select(a => new
                {
                    AlbumName = a.Name,
                    ReleaseDate = a.ReleaseDate.ToString("MM/dd/yyyy"),
                    ProducerName = a.Producer.Name,
                    Songs = a.Songs
                        .Select(s => new
                        {
                            SongName = s.Name,
                            SongPrice = s.Price,
                            SongWriterName = s.Writer.Name
                        })
                        .OrderByDescending(sn => sn.SongName)
                        .ThenBy(w => w.SongWriterName)
                        .ToList(),
                    AlbumPrice = a.Price
                }).ToList();

            foreach (var a in albums.OrderByDescending(a => a.AlbumPrice))
            {
                int count = 1;
                sb.AppendLine($"-AlbumName: {a.AlbumName}");
                sb.AppendLine($"-ReleaseDate: {a.ReleaseDate}");
                sb.AppendLine($"-ProducerName: {a.ProducerName}");
                sb.AppendLine("-Songs:");

                foreach (var songs in a.Songs)
                {
                    sb.AppendLine($"---#{count}");
                    sb.AppendLine($"---SongName: {songs.SongName}");
                    sb.AppendLine($"---Price: {songs.SongPrice:f2}");
                    sb.AppendLine($"---Writer: {songs.SongWriterName}");
                    count++;
                }
                sb.AppendLine($"-AlbumPrice: {a.AlbumPrice:f2}");
            }





            return sb.ToString().Trim();


        }

        public static string ExportSongsAboveDuration(MusicHubDbContext context, int duration)
        {
            StringBuilder sb = new StringBuilder();

            var songs = context.Songs
                .ToList()
                .Where(s => s.Duration.TotalSeconds > duration)
                .Select(s => new
                {
                    SongName = s.Name,
                    Performers = s.SongPerformers
                        .Select(sp => new
                        {
                            PerformerFullName = sp.Performer.FirstName + " " + sp.Performer.LastName
                        })
                        .ToList(),
                    WriterName = s.Writer.Name,
                    AlbumProducer = s.Album.Producer.Name,
                    Durations = s.Duration.ToString("c")
                })
                .OrderBy(s => s.SongName)
                .ThenBy(w => w.WriterName)
                .ToList();

            int count = 1;
            foreach (var s in songs)
            {
                sb.AppendLine($"-Song #{count}");
                sb.AppendLine($"---SongName: {s.SongName}");
                sb.AppendLine($"---Writer: {s.WriterName}");
                var performers = s.Performers.ToList();

                if (performers.Count > 0)
                {
                    foreach (var perf in s.Performers.OrderBy(p => p.PerformerFullName))
                    {
                        sb.AppendLine($"---Performer: {perf.PerformerFullName}");
                    }
                }
                sb.AppendLine($"---AlbumProducer: {s.AlbumProducer}");
                sb.AppendLine($"---Duration: {s.Durations}");

                count++;
            }

            return sb.ToString().TrimEnd();

        }
    }
}
