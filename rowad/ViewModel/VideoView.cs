using System;
using System.Collections.Generic;
using System.Text;
using rowad.Model;

namespace rowad.ViewModel
{
    class VideoView
    {
        public List<VideoClass> videoClasses { get; set; }
        public VideoView()
        {
            videoClasses = new VideoClass().GetVideoClasses();
        }
    }
}
