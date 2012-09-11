using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructureCSharp
{
    class Trie
    {
        private TrieNode root;
        public Trie() {
            root = new TrieNode(' ');
        }

        public void insert(string num) {
            TrieNode here = root;
            foreach (char c in num){
                if (here.getChild((int)c) == null){
                    TrieNode newChild = new TrieNode(c);
                    here.setChild((int)c, c);
                }
                here = here.getChild((int)c);
            }
            here.getChild((int)num[num.Length-1]).setEnd(true);//set isWordEnd = true
        }//end insert
    }
}
