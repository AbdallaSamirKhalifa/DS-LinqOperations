public class BinaryTreeNode<T>
{
    public T Value { get; set; }// the value stored in the node
    public BinaryTreeNode<T> Left { get; set; }// References to the left child 
    public BinaryTreeNode<T> Right { get; set; }//References to the right child

    public BinaryTreeNode(T value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}
