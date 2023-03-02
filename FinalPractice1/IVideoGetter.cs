using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPractice1
{
    public interface IVideoGetter
    {
        public abstract void WriteVideoTitleAndDescription(string url);
        public abstract void DownloadVideo(string url, string path);
    }
}
