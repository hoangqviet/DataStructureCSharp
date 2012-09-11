using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructureCSharp
{
    class TrieNode
    {
        private char letter;
        private bool isWordEnd;
        private TrieNode[] theChildren;
        
        public TrieNode() { 
            letter = ' ';
            isWordEnd = false;
            theChildren = new TrieNode[10];
        }

        public TrieNode(char l) {
            letter = l;
            isWordEnd = false;
            theChildren = new TrieNode[10];
        }

        public Boolean getEnds() {
            return isWordEnd;
        }

        public TrieNode getChild(int i) { 
            return theChildren[i];
        }

        public void setEnd(bool e) {
            isWordEnd = e;
        }

        public void setChild(int i, char l) {
            theChildren[i] = new TrieNode(l);
        }

    }//end TrieNode
}//end namespace
