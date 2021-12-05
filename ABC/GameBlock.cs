using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Metadata;

namespace ABC
{
    public class GameBlock
    {
        private List<Block> _blocks = new List<Block>();

        public GameBlock()
        {
            _blocks = new List<Block>()
            {
                new Block('B', 'O'),
                new Block('X', 'K'),
                new Block('D', 'Q'),
                new Block('C', 'P'),
                new Block('N', 'A'),
                new Block('G', 'T'),
                new Block('R', 'E'),
                new Block('T', 'G'),
                new Block('Q', 'D'),
                new Block('F', 'S'),
                new Block('J', 'W'),
                new Block('H', 'U'),
                new Block('V', 'I'),
                new Block('A', 'N'),
                new Block('O', 'B'),
                new Block('E', 'R'),
                new Block('F', 'S'),
                new Block('L', 'Y'),
                new Block('P', 'C'),
                new Block('Z', 'M')
            };
        }

       
        public List<string> MakeWord(string word)
        {
            List<string> matchedList = new List<string>();


            for (var i=0  ; i < word.Length; i++)
            {
                int removeIndex = -1;
                for (var j=0; j< _blocks.Count; j++)
                {
                    if (_blocks[j].GetLetter1() == word[i] || _blocks[j].GetLetter2() == word[i])
                    {

                        matchedList.Add(word[i].ToString());
                        removeIndex = j;
                        /*if (matchedList.Count == word.Length)
                        {
                            return matchedList;
                        }*/
                        break;
                    }
                   
                }

                if (removeIndex > -1)
                {
                    _blocks.RemoveAt(removeIndex);
                }

               /* var block = _blocks.Find((block) => block.GetLetter1() == word[i] || block.GetLetter2() == word[i]);
                if (block != null)
                {
                    _blocks.Remove(block);
                }
                */

            }
                  
            return matchedList;
          

        }
    }
}