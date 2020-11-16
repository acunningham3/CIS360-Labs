using System;
using System.Collections;
using System.Linq.Expressions;

namespace Implementation_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region Expression 1
            Tree Tree1 = new Tree();
            string exp1 = "abc++d*ef-g/*";
            char[] expChar1 = exp1.ToCharArray();

            Node root1 = Tree1.constructTree(expChar1);

            Console.WriteLine("Expression 1: {0}", exp1);
            Console.Write("Prefix: ");
                Tree1.preOrder(root1);
            Console.WriteLine();
            Console.Write("Infix: ");
                Tree1.inOrder(root1);
            Console.WriteLine();
            Console.Write("Postfix: ");
                Tree1.postOrder(root1);
            #endregion

            Console.WriteLine();
            Console.WriteLine();

            #region Expression 2
            Tree Tree2 = new Tree();
            string exp2 = "ab-cde-*+f/g+";
            char[] expChar2 = exp2.ToCharArray();

            Node root2 = Tree2.constructTree(expChar2);

            Console.WriteLine("Expression 2: {0}", exp2);
            Console.Write("Prefix: ");
                Tree2.preOrder(root2);
            Console.WriteLine();
            Console.Write("Infix: ");
                Tree2.inOrder(root2);
            Console.WriteLine();
            Console.Write("Postfix: ");
                Tree2.postOrder(root2);
            #endregion

            Console.WriteLine();
        }
    }

    class Node
    {
        public Node left
        { get; set; }

        public Node right
        { get; set; }

        public char data
        { get; set; }
    }

    class Tree
    {
        public Node constructTree(char[] postfix)
        {
            Stack stack = new Stack();
            Node N, N1, N2;

            for(int i = 0; i < postfix.Length; i++)
            {
                //If current item is an operand, push to stack
                if(!isOperator(postfix[i]))
                {
                    N = new Node { data = postfix[i] };
                    stack.Push(N);
                }
                else //If operator make top two nodes children of current node
                {
                    N = new Node { data = postfix[i] };

                    N1 = (Node)stack.Pop();
                    N2 = (Node)stack.Pop();

                    N.right = N1;
                    N.left = N2;

                    //Push back to stack
                    stack.Push(N);
                }
            }

            //Set N to top node and remove from stack
            N = (Node)stack.Peek();
            stack.Pop();
            return N;
        }

        //Check is current char is an operator
        public bool isOperator(char c)
        {
            if (c == '+' || c == '-' || c == '/' || c == '*')
                return true;
            return false;
        }

        //Method for pre-order traversal
        public void preOrder(Node N)
        {
            if (N != null)
            {
                Console.Write(N.data + "");
                preOrder(N.left);
                preOrder(N.right);
            }
        }

        //Method for in-order traversal
        public void inOrder(Node N)
        {
            if (N != null)
            {
                inOrder(N.left);
                Console.Write(N.data + "");
                inOrder(N.right);
            }
        }

        //Method for post-order traversal
        public void postOrder(Node N)
        {
            if (N != null)
            {
                postOrder(N.left);
                postOrder(N.right);
                Console.Write(N.data + "");
            }
        }


    }
}
