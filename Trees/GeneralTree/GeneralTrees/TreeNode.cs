using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralTrees
{
    public class TreeNode<T>
    {
        public T Value { get; set; }
        public List<TreeNode<T>> Children { get; set; }

        public TreeNode(T value)
        {
            this.Value = value;
            this.Children = new List<TreeNode<T>>();
        }

        public void AddChild(TreeNode<T> child) 
        {
            Children.Add(child); 
        }

        public TreeNode<T> Find(T value)
        {

            if(EqualityComparer<T>.Default.Equals(this.Value, value))
                return this;

            foreach (var child in Children)
            {

                var found = child.Find(value);            
                if (found != null) return found;
            }
            return null;
        }

    }
}
