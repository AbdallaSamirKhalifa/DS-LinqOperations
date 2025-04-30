

public class PriorityQueueNode
{
    public int Priority { set; get; }
    public string Name { set; get; }


    public PriorityQueueNode(string name , int priority)
    {
        Priority = priority;
        Name = name;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Priority: {Priority}.";
    }
}

