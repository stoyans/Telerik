using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Audio : MultimediaDocument
{

    public int? SampleRate
    {
        get;
        protected set;
    }

    public Audio(string name = null, string content = null, int? size = null, int? length = null, int? sampleRate = null) :
        base(name, content, size, length)
    {
        this.SampleRate = sampleRate;
    }

    public override void LoadProperty(string key, string value)
    {
        if (key == "samplerate")
        {
            this.SampleRate = int.Parse(value);
        }
        base.LoadProperty(key, value);
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("samplerate", this.SampleRate));
        base.SaveAllProperties(output);
    }
}

