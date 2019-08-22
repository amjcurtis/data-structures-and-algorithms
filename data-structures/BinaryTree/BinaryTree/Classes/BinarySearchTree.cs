namespace BinaryTree.Classes
{
	public class BinarySearchTree<T>
	{

		public Node<T> Root { get; set; }

		// Constructor for BST
		public BinarySearchTree(Node<T> node)
		{
			Root = node;
		}

		// Empty constructor so can instantiate empty BST
		public BinarySearchTree()
		{
		}

		/// <summary>
		/// Adds new node with specified value to binary search tree
		/// </summary>
		/// <param name="root">root node of binary search tree to add node to</param>
		/// <param name="value">value of the node to be added</param>
		public void Add(Node<int> root, int value)
		{
			// Instantiate new node and give it a value
			Node<int> newNode = new Node<int>(value);

			if (root == null)
			{
				root = newNode;
			}
			else
			{
				while (root != null)
				{
					if (newNode.Value < root.Value)
					{
						if (root.LeftChild == null)
						{
							root.LeftChild = newNode;
							break;
						}
						root = root.LeftChild;
					}
					else if (value > root.Value)
					{
						if (root.RightChild == null)
						{
							root.RightChild = newNode;
							break;
						}
						root = root.RightChild;
					}
					// Could add logic here to handle situation where new node's value equals root node's value
					// Currently I'm simply not adding the new node if a node with its value is already present in tree
					// Could handle it differently if I wanted to allow duplicate values in tree
				}
			}
		}

		/// <summary>
		/// Searches binary search tree for a given value and returns boolean
		/// </summary>
		/// <param name="root">root node to start search on</param>
		/// <param name="value">value to search nodes in BST for</param>
		/// <returns>true if value found in BST, else false</returns>
		public bool Contains(Node<int> root, int value)
		{
			while (root != null)
			{
				if (root.Value == value)
				{
					return true;
				}
				if (root.Value > value)
				{
					root = root.LeftChild;
				}
				else
				{
					root = root.RightChild;
				}
			}
			return false;
		}
	}
}
