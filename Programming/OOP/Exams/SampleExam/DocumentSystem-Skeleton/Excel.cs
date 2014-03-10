using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public class Excel : OfficeDocument
    {

        public int? NumberOfRows
        {
            get;
            protected set;
        }
        public int? NumberOfCols
        {
            get;
            protected set;
        }

        public Excel(string name = null, string content = null, int? size = null, string version = null, int? numberOfRows = null, int? numberOfCols = null) :
            base(name, content, size, version)
        {
            this.NumberOfCols = numberOfCols;
            this.NumberOfRows = numberOfRows;
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
            if (key == "rows")
            {
                this.NumberOfRows = int.Parse(value);
            }
            else if (key == "cols")
            {
                this.NumberOfCols = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("rows", this.NumberOfRows));
            output.Add(new KeyValuePair<string, object>("cols", this.NumberOfCols));
        }
    }

