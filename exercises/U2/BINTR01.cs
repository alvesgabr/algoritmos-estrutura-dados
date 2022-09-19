using System;

class Tree
{
  public int data;          // data content of n node
  public Tree left, right;  // children, left & right

  /**
   * ctor
   * @param data, node content
   */
  public Tree(int data)
  {
    this.data = data;
    this.left = null;
    this.right = null;
  }

  /**
  * ctor
  * @param data, node content
  * @param left, left child
  * @param right, right child
  */
  public Tree(int data, Tree left, Tree right)
  {
    this.data = data;
    this.left = left;
    this.right = right;
  }

  /**
  * simple rotation left
  * @param node, unbalanced node
  */
  public Tree LeftTurn(Tree node)
  {
    Tree currRight = node.right;    // right node pointer
    Tree nodeLeft = currRight.left; // left node pointer of currRight
    // rotating nodes from parent of currRight to left child of currRight
    currRight.left = node;
    node.right = nodeLeft;
    return currRight;
  }
  
  /**
  * simple rotation right
  * @param node, unbalanced node
  * same behaviour as previous method, but reversed
  * same comments as previous method
  */
  public Tree RightTurn(Tree node)
  {
    Tree currLeft = node.left;
    Tree nodeRight = currLeft.right;
    currLeft.right = node;
    node.left = nodeRight;
    return currLeft;
  }

  /**
  * double rotation left
  * @param node, unbalanced node
  */
  public Tree RightLeftTurn(Tree node)
  {
    // simple right turn to align grand->parent->child
    node.right = RightTurn(node.right);
    // simple left turn to move grand as child
    return LeftTurn(node);
  }

  /**
  * double rotation right
  * @param node, unbalanced node
  * same comments as previous method
  */
  public Tree LeftRightTurn(Tree node)
  {
    node.left = LeftTurn(node.left);
    return RightTurn(node);
  }

}

class BINTR01
{
  static void Main(string[] args)
  {

  }
}

/**
  class notes

  // ----- Definition ----- //
> binary trees uses a parent:child concept,

> parent nodes are called internal nodes and,
  nodes with no children are external or leaves

> tree height = n edges till target node

> balanced tree = mirror of subtree of acceptable diff +- 1

> worst case scenario for a search in bintree = θ(lg2 of nodes),
  balanc bintree: 1024 nodes = 10 comparisons max / worst case,
  linear bintree: 1024 nodes = 1024 comparisons max/ worst case

> sorted bintree: 
  left child = c<P, 
  right child = c>P,
  P = parent node, c = child

  // ----- Algorithms ----- //
> search algorithm:
  recursive comparison with x to n,
    x = given value, n = root node,
    if x == n : return true,
    elif x > n : n = right child, continue,
    elif x < n : n = left child, continue,
    else n == null : return false, empty tree

> running algorithm:
  recursive ordered method:
    - go left child,
    - print data,
    - go right child
  
  recursive post ordered method:
    - go left child,
    - go right child,
    - print data

  recursive pre ordered method:
    - print data,
    - go left child,
    - go right child
  
  all recursive methods shall run from line 1 for each node,
   - ordered method sorts the tree if its proper built,
   - post ordered prints furtherst data in left subtree first,
   - then it prints furtherst data in right subtree in recursive,
   - pre ordered prints left subtrees in recursive first, then right subt

> insertion algorithm:
  use search algorithm,
    x = given value, n = root node,
    if n == null : n = x,
    lif n != null && x > n : n = right child, continue,
    lif n != null && x < n : n = left child, continue,
    else n == x : 'duplicate data'

> removal algorithm:
  use search algorithm to find given value,
  in case its an external node, assign null,
    n = root node, x = given value, n == x = true,
    if n.left && n.right == null : n = null,
  both childs in previous line are null, safe to remove
  
  either left child exist but right doesnt, n = left child,
  or left child doesnt exist but right does, n = right child,
    elif n.left != null && n.right == null : n = n.left,
    elif n.left == null && n.right != null : n = n.right

  if both child exist, there are two options,
    replace with the highest value from left subtree,
    replice with the lowest value from right subtree

  both end nodes, be it hv or lv only have 0 or 1 child!
  highest value from left subtree = hv = root.left,
    while hv.right != null, hv = hv.right,
    if hv.left != null, hv.Parent.right = hv.left

  lowest value from right subtree = lv = root.right,
    while lv.left != null, lv = lv.left','
    if lv.right != null, lv.Parent.left = lv.right
  
  // ----- Rotations & AVL ----- //
> basic rotation principle: rotate counterweight,
  i.e.: {G.3 -> P.6 -> C.9} => {C.3 <- P.6 -> C.9},
  _lines 36 -> 59

> double rotation: when grand:chid is parent:child reversed,
  i.e.: {G.3 -> P.9 <- C.6} => {C.3 <- P.6 -> C.9},
  i.e.: {G.9 <- P.3 -> C.6} => {C.3 <- P.6 -> C.9},
  _lines 65 -> 82

> AVL BST
  avl bst are self-balancing binary search tree,
  invented by Georgy Adelson-Velskii and Evgenii Landis in 1962

  avl_valude(n) = rightHeight(n) - leftHeight(n),

  LeftTurn: avl_value = 2, node.right = 1 || 0,
  RightLeftTurn: avl_value = 2, node.right = -1,
  
  RightTurn: avl_value = -2, node.left = -1 || 0,
  LeftRightTurn: avl_value = -2, node.left = 1  
**/