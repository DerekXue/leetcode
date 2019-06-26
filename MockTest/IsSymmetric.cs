using System;

namespace ConsoleApp72
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public bool IsSymmetric(TreeNode root)
        {
            if (root==null) return true;
            TreeNode left = root.left;
            TreeNode right = root.right;
            bool answer = helper(left, right);
            return answer;
        }

        static public bool helper(TreeNode left,TreeNode right)
        {
            if (left == null && right == null) return true;
            if (left == null || right == null) return false;
            if (left.val != right.val) return false;
            else return helper(left.left, right.right) && helper(left.right, right.left);
        }

    }

    public class TreeNode
    {
     public int val;
     public TreeNode left;
     public TreeNode right;
      public TreeNode(int x) { val = x; }
  }
}
