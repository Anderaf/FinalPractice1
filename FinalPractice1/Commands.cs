using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPractice1
{
    public abstract class Command
    {
        public abstract void Run();
        public abstract void Cancel();
    }
    public class VideoTitleAndDescriptionCommand : Command
    {
        string url;

        IVideoGetter videoGetter;

        public VideoTitleAndDescriptionCommand(string url, IVideoGetter videoGetter)
        {
            this.url = url;
            this.videoGetter = videoGetter;
        }

        public override void Cancel()
        {
            throw new NotImplementedException();
        }

        public override void Run()
        {
            videoGetter.WriteVideoTitleAndDescription(url);
        }
    }
    public class VideoDownloadCommand : Command
    {
        string url;
        string path;

        IVideoGetter videoGetter;

        public VideoDownloadCommand(string url, string path, IVideoGetter videoGetter)
        {
            this.url = url;
            this.path = path;
            this.videoGetter = videoGetter;
        }

        public override void Cancel()
        {
            throw new NotImplementedException();
        }

        public override void Run()
        {
            videoGetter.DownloadVideo(url, path);
        }
    }
}
