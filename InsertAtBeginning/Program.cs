using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InsertAtBeginning
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class Solution
    {
        public ListNode InsertAtBeginning(ListNode head, ListNode newElement)
        {
            ListNode newNode = new ListNode();
            newNode.val = newElement.val;
            newNode.next = head;
            head = newNode;

            return head;
        }
    }
}