using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Word : OfficeDocument, IEditable
{
    public int? NumberOfCharacters
    {
        get;
        protected set;
    }

    public Word(string name = null, string content = null, int? size = null, string version = null, int? numberOfCharacters = null):
        base(name, content, size, version)
    {
        this.NumberOfCharacters = numberOfCharacters;
    }


    public void ChangeContent(string newContent)
    {
        this.Content = newContent;
    }

    public override bool IsEncrypted
    {
        get
        {
            return base.IsEncrypted;
        }
    }

    public override void Encrypt()
    {
        base.Encrypt();
    }

    public override void Decrypt()
    {
        base.Decrypt();
    }

    public override void LoadProperty(string key, string value)
    {
        if (key == "chars")
        {
            this.NumberOfCharacters = int.Parse(value);
        }
        else
        {
            base.LoadProperty(key, value);
        }
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        base.SaveAllProperties(output);
        output.Add(new KeyValuePair<string, object>("chars", this.NumberOfCharacters));
    }
}

