namespace BinaryTree
{
  class Program
  {
    static void Main()
    {
      BinarySearchTree bst = new BinarySearchTree();
      bst.Insert(5);
      bst.Insert(3);
      bst.Insert(7);
      bst.Insert(2);
      bst.Insert(4);
      bst.Insert(6);
      bst.Insert(8);

      bst.Display();
      System.Console.WriteLine("Search for 7: " + bst.Search(7));
      System.Console.WriteLine("Search for 9: " + bst.Search(9));

      bst.Remove(5);
      bst.Display();
    }
  }
  class Node
  {
    public int data;
    public Node left;
    public Node right;

    public Node(int data)
    {
      this.data = data;
      left = right = null;
    }
  }
  class BinarySearchTree
  {
    Node root;

    public void Insert(int data)
    {
        Node newNode = new Node(data);
        if (root == null)
        {
            root = newNode;
        }
        else
        {
            root = InsertHelper(root, newNode);
        }
    }
  private Node InsertHelper(Node root, Node newNode)
  {
    if (root == null)
    {
      root = newNode;
    }
    else if (root.data > newNode.data)
    {
      root.left = InsertHelper(root.left, newNode);
    }
    else
    {
      root.right = InsertHelper(root.right, newNode);
    }

    return root;
  }

  public void Display()
  {
    DisplayHelper(root);
    System.Console.WriteLine();
  }
  private void DisplayHelper(Node root)
  {
    if (root != null)
    {
      DisplayHelper(root.left);
      System.Console.Write(root.data + " ");
      DisplayHelper(root.right);
    }
  }

  public bool Search(int data)
  {
      return SearchHelper(root, data);
  }
  private bool SearchHelper(Node root, int data)
  {
    if (root == null)
      return false;
    else if (root.data == data)
      return true;
    else if (root.data > data)
      return SearchHelper(root.left, data);
    else
      return SearchHelper(root.right, data);
  }

  public void Remove(int data)
  {
    root = RemoveHelper(root, data);
  }
  private Node RemoveHelper(Node root, int data)
  {
    if (root == null) return root;
    if (data < root.data) root.left = RemoveHelper(root.left, data);
    else if (data > root.data) root.right = RemoveHelper(root.right, data);
    else
    {
      if (root.left == null) return root.right;
      else if (root.right == null) return root.left;

      root.data = MinValue(root.right);
      root.right = RemoveHelper(root.right, root.data);
    }

    return root;
  }

  private int MinValue(Node root)
  {
    int minValue = root.data;
    while (root.left != null)
      {
        minValue = root.left.data;
        root = root.left;
      }

    return minValue;
  }
  }
}