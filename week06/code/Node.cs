public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1
        // If value equals current node's data, don't insert (maintain uniqueness)
        if (value == Data)
        {
            return;
        }
        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (value == Data)
        {
            return true;
        }
        
        //This is our recurssion
        // If value is less than current node, search left subtree
        else if (value < Data)
        {
            return Left != null && Left.Contains(value);
        }
        // If value is greater than current node, search right subtree
        else
        {
            return Right != null && Right.Contains(value);
        }
    }

    public int GetHeight()
    {
        // Get heights of left and right subtrees
        int leftHeight = Left?.GetHeight() ?? 0;
        int rightHeight = Right?.GetHeight() ?? 0;
        
        // Return the larger height plus 1
        //It will unconditionally go up because if branch doesn't exist, it will return 0
        return Math.Max(leftHeight, rightHeight) + 1;
    }
}