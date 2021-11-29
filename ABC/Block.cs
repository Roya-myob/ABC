namespace ABC
{
    public class Block
    {
        private char _letter1;
        private char _letter2;
        


        public Block(char letter1, char letter2)
        {
            _letter1 = letter1;
            _letter2 = letter2;

        }
        

        public char GetLetter1()
        {
            return _letter1;
        }

        public char GetLetter2()
        {
            return _letter2;
        }
        
        
    }
    
}