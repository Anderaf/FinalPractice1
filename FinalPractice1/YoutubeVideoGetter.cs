using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos;

namespace FinalPractice1
{
    public class YoutubeVideoGetter : IVideoGetter
    {
        public void WriteVideoTitleAndDescription(string url)
        {
            var videos = new YoutubeClient().Videos;
            var video = videos.GetAsync(url).Result;
            Console.WriteLine("Название: " + video.Title);
            Console.WriteLine("Описание: " + video.Description);
        }
        public async void DownloadVideo(string url, string path)
        {
            var videos = new YoutubeClient().Videos;
            await videos.DownloadAsync(url, path, builder => builder.SetPreset(ConversionPreset.UltraFast));
        }
    }
}
