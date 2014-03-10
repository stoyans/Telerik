using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public abstract class OfficeDocument : EncryptableDocuments
    {

        public string Version
        {
            get;
            protected set;
        }

        public OfficeDocument(string name = null, string content = null, int? size = null, string version = null) :
            base(name, content, size)
        {
            this.Version = version;
        }

        public override void LoadProperty(string key, string value)
        {
            if (key == "version")
            {
                this.Version = value;
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("version", this.Version));
        }
    }

