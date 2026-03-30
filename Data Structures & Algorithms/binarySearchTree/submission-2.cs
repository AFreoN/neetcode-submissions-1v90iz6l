class TreeMap {
    TreeNode root;
    bool isEmpty => root == null;

    public TreeMap()
    {
        root = null;
    }

    public void Insert(int key, int val)
    {
        if (isEmpty)
        {
            root = new TreeNode(key, val);
            return;
        }

        TreeNode cur = root;
        while (true)
        {
            if (key > cur.key)
            {
                if (cur.right == null)
                {
                    cur.right = new TreeNode(key, val);
                    break;
                }
                else cur = cur.right;
            }
            else if (key < cur.key)
            {
                if (cur.left == null)
                {
                    cur.left = new TreeNode(key, val);
                    break;
                }
                else cur = cur.left;
            }
            else
            {
                cur.val = val;
                break;
            }
        }
    }

    public int Get(int key)
    {
        if (isEmpty) return -1;
        TreeNode cur = root;
        while (cur != null)
        {
            if(key < cur.key) cur = cur.left;
            else if(key > cur.key) cur = cur.right;
            else return cur.val;
        }

        return -1;
    }

    public int GetMin()
    {
        if(isEmpty) return -1;
        TreeNode cur = root;
        while(cur.left != null)
            cur = cur.left;
        return cur.val;
    }

    public int GetMax()
    {
        if(isEmpty) return -1;
        TreeNode cur = root;
        while(cur.right != null) 
            cur = cur.right;
        return cur.val;
    }

    public void Remove(int key)
    {
        root = Delete(root, key);
    }

    TreeNode Delete(TreeNode node, int key)
    {
        if (node == null) return null;

        if (key < node.key) node.left = Delete(node.left, key);
        else if (key > node.key) node.right = Delete(node.right, key);
        else
        {
            if (node.left == null) return node.right;
            if (node.right == null) return node.left;

            TreeNode successor = GetMinNode(node.right);
            node.key = successor.key;
            node.val = successor.val;

            node.right = Delete(node.right, successor.key);
        }
        return node;
    }

    TreeNode GetMinNode(TreeNode node)
    {
        if (node == null) return null;
        TreeNode cur = node;
        while (cur.left != null)
            cur = cur.left;
        return cur;
    }

    public List<int> GetInorderKeys()
    {
        if (isEmpty) return new List<int>();

        List<int> keys = new List<int>();

        void dfs(TreeNode node)
        {
            if(node == null) return;

            dfs(node.left);
            keys.Add(node.key);
            dfs(node.right);
        }

        dfs(root);
        return keys;
    }
}

public class TreeNode
{
    public int key;
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int key, int val)
    {
        this.key = key;
        this.val = val;
    }

    public TreeNode(int key, int val, TreeNode left, TreeNode right)
    {
        this.key = key;
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
