using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTMLRenderer
{
    public class HTMLElement : IElement
    {

        private IList<IElement> nestedElements;
        private string content;

        public HTMLElement(string name, string content = null)
        {
            this.Name = name;
            if (content != null)
            {
                this.TextContent = content;
            }
            
            this.nestedElements = new List<IElement>();
            
        }

        public string Name
        {
            get;
            private set;
        }

        public virtual string TextContent
        {
            get
            { 
                return this.content; 
            }
            set
            {
                if (value != null)
                {
                    this.content = value;
                }
            }
        }

        public IEnumerable<IElement> ChildElements
        {
            get { return this.nestedElements; }
        }

        public void AddElement(IElement element)
        {
            this.nestedElements.Add(element);
        }

        public virtual void Render(StringBuilder output)
        {
            output.Append("<");
            output.Append(this.Name+">");

            if (this.TextContent != null)
            {
                for (int i = 0; i < this.TextContent.Length; i++)
                {
                    char symbol = this.TextContent[i];

                    switch (symbol)
                    {

                        case '<': output.Append("$lt;");
                            break;
                        case '>': output.Append("&gt;");
                            break;
                        case '&': output.Append("&amp;");
                            break;
                        default: 
                            output.Append(symbol);
                            break;
                    }
                }
            }
            foreach (var child in this.nestedElements)
            {
                output.Append(child.ToString());
            }

            if (this.Name != null)
			{
				output.Append("</");
				output.Append(this.Name);
				output.Append(">");
			}

        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            this.Render(output);
            return output.ToString();
        }
	}

}
