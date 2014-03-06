using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    public class Video : MultimediaDocument
    {

        public int? FrameRate
        {
            get;
            protected set;
        }

        public Video(string name = null, string content = null, int? size = null, int? length = null, int? frameRate = null) :
            base(name, content, size, length)
        {
            this.FrameRate = frameRate;
        }

        public override void LoadProperty(string key, string value)
        {
            if (key == "framerate")
            {
                this.FrameRate = int.Parse(value);
            }
            base.LoadProperty(key, value);
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("framerate", this.FrameRate));
            base.SaveAllProperties(output);
        }
    }

