﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_And_A
{
    class DoublyLinkedList : LinkedList
    {
        private TwoWayNode _head;

        public new TwoWayNode Head { get => _head; set => _head = value; }

        public override void InsertAtHead(int Data)
        {
            TwoWayNode NewNode = new TwoWayNode(Data);
            NewNode.NextNode = this.Head; //On the first addition, this.head will be null, and this is how the last element's NextNode value ends up being null
            // NewNode.PreviousNode = this.Head; I think this is supposed to remain unassigned because it should point to null

            if (Head != null) //Must do null check because of list is empty head will be null
            {
                this.Head.PreviousNode = NewNode; //And then this won't execute (Nullpointer exception)
            }
            this.Head = NewNode;
        }
        public void InsertNodeAtHead(TwoWayNode NewNode)
        {
            NewNode.NextNode = this.Head;
            this.Head.PreviousNode = NewNode;
        }
        public void InsertionSortDList()

        {
            TwoWayNode current = this.Head.NextNode;
            TwoWayNode searchPointer = current.PreviousNode;

            for (int i = 0; i < this.Length() - 1; i++)
            {
                while (current.Data < searchPointer.Data && searchPointer.PreviousNode != null)
                {
                    searchPointer = searchPointer.PreviousNode;
                    //Console.WriteLine("current data: " + current.Data + " search data: " + searchPointer.Data + "search prev: " + searchPointer.PreviousNode.ToString());

                }
                //Before we move the node, we need to store our position
                TwoWayNode nodeToMove = current;
                //Move the current pointer to the next node to pick up on it on the next iteration
                current = current.NextNode;

                //this removes the current element from its unsorted place in the list by linking its previous and next elements together
                nodeToMove.PreviousNode.NextNode = nodeToMove.NextNode;

                if (nodeToMove.NextNode != null)
                {
                    nodeToMove.NextNode.PreviousNode = nodeToMove.PreviousNode;
                }

                //Commenting to save place
                //First step is to link this node to the node at the searchpointer position


                //This places the element in its sorted position
                InsertTwoWayNode(searchPointer, nodeToMove);
                //searchPointer.PreviousNode = nodeToMove;
                if (current != null)
                {
                    searchPointer = current.PreviousNode;
                }
            }
        }

        private void InsertTwoWayNode(TwoWayNode searchPointer, TwoWayNode nodeToMove)
        {
            if (nodeToMove.Data > searchPointer.Data) //If we're not at the beginning of the list
            {
                nodeToMove.PreviousNode = searchPointer;
                nodeToMove.NextNode = searchPointer.NextNode;
                if (nodeToMove.NextNode != null)
                {
                    nodeToMove.NextNode.PreviousNode = nodeToMove;
                }
                searchPointer.NextNode = nodeToMove;

            }
            else //if we are the beginning of the list
            {
                nodeToMove.NextNode = searchPointer;
                searchPointer.PreviousNode = nodeToMove;
                this.Head = nodeToMove;
                this.Head.PreviousNode = null;
            }
        }

        public override string ToString()
        {
            String Result = "{";
            TwoWayNode current = this.Head;

            while (current != null)
            {
                Result += current.ToString() + ",";
                current = current.NextNode;
            }
            Result += "}";
            return Result;
        }
        public override int Length()
        {
            int length = 0;
            TwoWayNode Current = this.Head;

            while (Current != null)
            {
                length++;
                Current = Current.NextNode;
            }
            return length;
        }

    }
}
