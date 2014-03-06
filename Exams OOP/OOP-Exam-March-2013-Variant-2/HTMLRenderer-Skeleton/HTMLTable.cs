using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTMLRenderer
{
    public class HTMLTable : HTMLElement, ITable
    {
        private int rows;
        private int cols;
        private IElement[,] tableElements;

        public HTMLTable(int rows, int cols) :
            base("table")
        {
            this.Rows = rows;
            this.Cols = cols;
            this.tableElements = new IElement[rows, cols];
        }

        public int Rows
        {
            get { return this.rows; }
            set
            {
                if (value <=0)
                {
                    throw new ArgumentOutOfRangeException("rows", 0, "Positive number required.");
                }
                this.rows = value;
            }
        }

        public int Cols
        {
            get { return this.cols; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("cols", 0, "Positive number required.");
                }
                this.cols = value;
            }
        }

        public IElement this[int row, int col]
        {
            get
            {
                return tableElements[row, col];
            }
            set
            {
                this.tableElements[row, col] = value;
            }
        }
        public override string TextContent
        {
            get
            {
                return null;
            }
            set
            {
                throw new InvalidOperationException("Tables cannot have text content");
            }
        }

        public override void Render(StringBuilder output)
        {
            output.Append("<table>");
            for (int row = 0; row < this.Rows; row++)
            {
                output.Append("<tr>");
                for (int col = 0; col < this.Cols; col++)
                {
                    output.Append("<td>");
                    output.Append(this.tableElements[row, col].ToString());
                    output.Append("</td>");
                }
                output.Append("</tr>");
            }
            output.Append("</table>");
        }
    }
}
