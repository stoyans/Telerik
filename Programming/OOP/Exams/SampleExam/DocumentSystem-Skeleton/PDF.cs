using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public class PDF : EncryptableDocuments
    {
        public int? NumberOfPages
        {
            get;
            protected set;
        }

        public PDF(string name = null, string content = null, int? size = null, int? numberOfPages = null) :
            base(name, content, size)
        {
            this.NumberOfPages = numberOfPages;
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
            if (key == "pages")
            {
                this.NumberOfPages = Int32.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("pages", this.NumberOfPages));
        }
    }

