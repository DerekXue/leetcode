using System;

namespace ConsoleApp70
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int MaxDepth(TreeNode root)
        {
            int lvl = 1;
            if (root.left == null && root.right == null) return 0;
            else return lvl+Math.Max(MaxDepth(root.left), MaxDepth(root.right));
        }
    }

    class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
  }
}
