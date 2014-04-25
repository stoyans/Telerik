using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadTreeAndOperationsOnIt
{
    public class TreeNode<T>
    {
        public T Value { get; set; }
        public List<TreeNode<T>> Children { get; set; }

        public TreeNode()
        {
            Children = new List<TreeNode<T>>();
        }

        public bool isParent { get; set; }

        public TreeNode(T value)
            : this()
        {
            this.Value = value;
        }
        

    }
}
