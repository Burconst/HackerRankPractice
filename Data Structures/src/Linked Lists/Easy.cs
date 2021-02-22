using System;
using System.Collections.Generic;

namespace DataStructures.LinkedLists
{
    // Addition
    public class SinglyLinkedListNode 
    {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData) {
            this.data = nodeData;
            this.next = null;
        }
    }

    public class SinglyLinkedList 
    {
        public SinglyLinkedListNode head;

        public SinglyLinkedList() {
            this.head = null;
        }

    }

    public class DoublyLinkedListNode 
    {
        public int data;
        public DoublyLinkedListNode next;
        public DoublyLinkedListNode prev;

        public DoublyLinkedListNode(int nodeData) {
            this.data = nodeData;
            this.next = null;
            this.prev = null;
        }
    }

    public class DoublyLinkedList 
    {
        public DoublyLinkedListNode head;
        public DoublyLinkedListNode tail;

        public DoublyLinkedList() {
            this.head = null;
            this.tail = null;
        }

        public void InsertNode(int nodeData) {
            DoublyLinkedListNode node = new DoublyLinkedListNode(nodeData);

            if (this.head == null) {
                this.head = node;
            } else {
                this.tail.next = node;
                node.prev = this.tail;
            }

            this.tail = node;
        }
    }

    public static class Easy
    {

        // Print the Elements of a Linked List
        // Source: https://www.hackerrank.com/challenges/print-the-elements-of-a-linked-list/problem
        public static void PrintLinkedList(SinglyLinkedListNode head) 
        {
            while(head != null) 
            {
                Console.WriteLine(head.data);
                head = head.next;
            }
        }

        // Insert a Node at the Tail of a Linked List
        // Source: https://www.hackerrank.com/challenges/insert-a-node-at-the-tail-of-a-linked-list/problem
        public static SinglyLinkedListNode InsertNodeAtTail(SinglyLinkedListNode head, int data) 
        {
            var newNode = new SinglyLinkedListNode(data);
            if(head == null) return newNode;
            if(head.next == null) 
            {
                head.next = newNode;
                return head;
            }
            var tmpNode = head;
            while (tmpNode.next != null)
            {
                tmpNode = tmpNode.next;
            }
            tmpNode.next = newNode;
            return head;
        }

        // Insert a node at a specific position in a linked list
        // Source: https://www.hackerrank.com/challenges/insert-a-node-at-a-specific-position-in-a-linked-list/problem 
        public static SinglyLinkedListNode InsertNodeAtPosition(SinglyLinkedListNode head, int data, int position) 
        {
            var newNode = new SinglyLinkedListNode(data);
            if(head == null) return newNode;
            if(position == 0) 
            {
                newNode.next = head;
                return newNode;
            }
            var tmpNode = head;
            while(position > 1)
            {
                tmpNode = tmpNode.next;
                position--;
            }
            newNode.next = tmpNode.next;
            tmpNode.next = newNode;
            return head;
        }

        // Delete a Node
        // Source: https://www.hackerrank.com/challenges/delete-a-node-from-a-linked-list/problem
        public static SinglyLinkedListNode DeleteNode(SinglyLinkedListNode head, int position) 
        {
            if(head == null) return head;
            if(position == 0) 
            {
                return head.next;
            }
            var tmpNode = head;
            while(position > 1)
            {
                tmpNode = tmpNode.next;
                position--;
            }
            tmpNode.next = tmpNode.next.next;
            return head;
        }

        // Print in Reverse
        // Source: https://www.hackerrank.com/challenges/print-the-elements-of-a-linked-list-in-reverse/problem
        public static void reversePrint(SinglyLinkedListNode head) 
        {
            if(head == null) return;
            var output = new System.Text.StringBuilder();
            while(head != null)
            {
                output.Insert(0,head.data+"\n");
                head = head.next;
            }
            Console.Write(output.ToString());
        }
        

        // Reverse a linked list
        // Source: https://www.hackerrank.com/challenges/reverse-a-linked-list/problem
        public static SinglyLinkedListNode Reverse(SinglyLinkedListNode head) 
        {
            if (head == null) return null;
            if (head.next == null) return head;
            SinglyLinkedListNode prevNode = null;
            while(head.next != null) 
            {
                var tmp = head.next;
                head.next = prevNode;
                prevNode = head;
                head = tmp;
            }
            head.next = prevNode;
            return head;
        }


        // Compare two linked lists
        // Source: https://www.hackerrank.com/challenges/compare-two-linked-lists/problem
        public static bool CompareLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2) 
        {
            if(((head1 == null) && (head2 != null)) || ((head1 != null) && (head2 == null))) return false;
            while ((head1 != null) && (head2 != null))
            {
                if(head1.data != head2.data) return false;
                head1 = head1.next; head2 = head2.next;
                if(((head1 == null) && (head2 != null)) || ((head1 != null) && (head2 == null))) return false;
            }
            return true;
        }

        // Merge two sorted linked lists
        // Source: https://www.hackerrank.com/challenges/merge-two-sorted-linked-lists/problem
        public static SinglyLinkedListNode MergeLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {
            var newHead = head1.data < head2.data ? head1 : head2;
            if(head1.data < head2.data) 
            {
                head1 = head1.next;
            }
            else 
            {
                head2 = head2.next;
            }
            var tmp = newHead;
            while(head1 != null && head2 != null) 
            {
                if(head1.data < head2.data) 
                {
                    tmp.next = head1;
                    head1 = head1.next;
                } 
                else 
                {
                    tmp.next = head2;
                    head2 = head2.next;
                }
                tmp = tmp.next;
            }
            if(head1 == null) 
            {
                tmp.next = head2;
            }
            else if(head2 == null) 
            {
                tmp.next = head1;
            }

            return newHead;
        }

        // Get Node Value
        // Source: https://www.hackerrank.com/challenges/get-the-value-of-the-node-at-a-specific-position-from-the-tail/problem
        public static int GetNode(SinglyLinkedListNode head, int positionFromTail) 
        {
            var tmp = head;
            int length = 0;
            while(tmp != null) 
            {
                length++;
                tmp = tmp.next;
            }
            int positionFromHead = length - positionFromTail - 1;
            tmp = head;
            while(positionFromHead != 0) 
            {
                positionFromHead--;
                tmp = tmp.next;
            }
            return tmp.data;
        }

        // Delete duplicate-value nodes from a sorted linked list
        // Source: https://www.hackerrank.com/challenges/delete-duplicate-value-nodes-from-a-sorted-linked-list/problem
        static SinglyLinkedListNode removeDuplicates(SinglyLinkedListNode head) 
        {
            var tmp = head;
            while (tmp.next != null)
            {
                if(tmp.data == tmp.next.data) 
                {
                    tmp.next = tmp.next.next;
                }
                else
                {
                    tmp = tmp.next;
                }  
            }
            return head;
        }

        // Find Merge Point of Two Lists
        // Source: https://www.hackerrank.com/challenges/find-the-merge-point-of-two-joined-linked-lists/problem
        public static int FindMergeNode(SinglyLinkedListNode head1, SinglyLinkedListNode head2) 
        {
            var tmpRes = head1;
            while(tmpRes != null) 
            {
                var tmp = head2;
                while(tmp != null) 
                {
                    if(object.ReferenceEquals(tmp, tmpRes)) 
                    {
                        return tmp.data;
                    }
                    tmp = tmp.next;
                }
                tmpRes = tmpRes.next;
            }
            return -1;
        }

        // Inserting a Node Into a Sorted Doubly Linked List
        // Source: https://www.hackerrank.com/challenges/insert-a-node-into-a-sorted-doubly-linked-list/problem
        public static DoublyLinkedListNode SortedInsert(DoublyLinkedListNode head, int data) 
        {
            var tmp = head;
            var newNode = new DoublyLinkedListNode(data);
            if (head.data > newNode.data) 
            {
                newNode.next = head;
                head.prev = newNode;
                return newNode;
            }
            while (tmp.next != null && tmp.data < data) 
            {
            tmp = tmp.next;
            }
            if (tmp.next == null && tmp.data < newNode.data)
            {
                tmp.next = newNode;
                newNode.prev = tmp;
            }
            else
            {
                newNode.next = tmp;
                newNode.prev = tmp.prev;
                tmp.prev = newNode;
                newNode.prev.next = newNode;
            }
            return head;
        }

        // Reverse a doubly linked list
        // Source: https://www.hackerrank.com/challenges/reverse-a-doubly-linked-list/problem
        public static DoublyLinkedListNode Reverse(DoublyLinkedListNode head)
        {
            var newHead = head;
            while(newHead.next != null) 
            {
                var tmp = newHead;
                newHead = newHead.next;
                var tmp2 = tmp.prev;
                tmp.prev = tmp.next;
                tmp.next = tmp2;
            }
            newHead.next = newHead.prev;
            newHead.prev = null;
            return newHead;
        }
    }
}
