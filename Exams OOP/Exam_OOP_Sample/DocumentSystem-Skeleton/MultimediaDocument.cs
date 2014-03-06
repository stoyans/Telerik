using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public abstract class MultimediaDocument : BinaryDocument
    {
        public int? Length
        {
            get;
            protected set;
        }

        public MultimediaDocument(string name = null, string content = null, int? size = null, int? length = null) :
            base(name, content, size)
        {
            this.Length = length;
        }
    }

