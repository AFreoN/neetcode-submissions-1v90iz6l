class TreeMap {
    TreeNode root;
    bool isEmpty => root == null;

    public TreeMap()
    {

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
        if (isEmpty) return;

        // 1. Find the target node with its parent
        TreeNode parent = null, current = root;

        while (current != null && current.key != key)
        {
            parent = current;
            if (key < current.key) current = current.left;
            else if (key > current.key) current = current.right;
        }

        if (current == null) return;    // No key match found, so return

        // 2. Handle if node exists on only one side
        if (current.left == null || current.right == null)
        {
            TreeNode child = current.left != null ? current.left : current.right;

            if (parent == null)
            {
                root.right = null;
                root.left = null;
                root = child;
                return;
            }

            if (parent.left == current) parent.left = child;
            else parent.right = child;
            return;
        }

        // 3. Handle if node exists on both sides
        TreeNode delNode = current;
        TreeNode par = null;
        current = current.right;

        while (current.left != null)    //get the lowest possible value on the right node of deleting node
        {
            par = current;
            current = current.left;
        }

        if (par != null)
        {
            par.left = current.right;
            current.right = delNode.right;
        }

        current.left = delNode.left;

        if (parent == null)
        {
            root = current;
            return;
        }

        if (parent.left == delNode) parent.left = current;
        else parent.right = current;
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
