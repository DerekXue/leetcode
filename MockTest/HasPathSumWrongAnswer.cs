using System;

namespace ConsoleApp73
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[] { 5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, 1 };
            TreeNode tree = new TreeNode(values);
            Console.WriteLine("Hello World!");
        }

        public bool HasPathSum(TreeNode root, int sum)
        {
            int counter = 0;
            if (root == null) return false;
            TreeNode left = root.left;
            TreeNode right = root.right;
            return dps(left, counter, sum)||dps(right,counter,sum);
        }

        public static bool dps(TreeNode current,int counter,int sum)
        {
            if (current == null)
            {
                if (counter == sum)
                {
                    counter = 0;
                    return true;
                }
                else
                {
                    counter = 0;
                    return false;
                }         
            }
            else counter += current.val;
            return dps(current.left, counter, sum) && dps(current.right, counter, sum);
        }
    }

    class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int[] values) : this(values, 0) { }

        TreeNode(int[] values, int index)
        {
            Load(this, values, index);
        }

        void Load(TreeNode tree, int[] values, int index)
        {
            this.val = values[index];
            if (index * 2 + 1 < values.Length)
            {
                this.left = new TreeNode(values, index * 2 + 1);
            }
            if (index * 2 + 2 < values.Length)
            {
                this.right = new TreeNode(values, index * 2 + 2);
            }
        }
    }
}
