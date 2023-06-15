using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Node
    {
        public int Data { get; init; } //Свойство для хранения значения узла
        public Node Right { get; private set; } //Свойства для хранения ссылок на левый и правый дочерние узлы
        public Node Left { get; private set; }

        public Node(int data = 0, Node right = null, Node left = null)
        {
            this.Data = data;
            this.Right = right;
            this.Left = left;
        }

        public void SetLeft(Node node) //Методы для установки ссылок на дочерние узлы
        {
            this.Left = node;
        }

        public void SetRight(Node node)
        {
            this.Right = node;
        }
    }
}
