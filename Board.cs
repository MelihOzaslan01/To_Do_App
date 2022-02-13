using System.Collections.Generic;

namespace TodoAppCSharpConsolePatika
{
    public class Board
    {
        public List<Card> TODO = new List<Card>();
        public List<Card> IN_PROGRESS = new List<Card>();
        public List<Card> DONE = new List<Card>();

        public Board()
        {
            // vm.Genre = ((GenreEnum)book.GenreId).ToString();
            TODO.Add(new Card("�dev Yap", "Patika'daki cs-101 mod�l�n�n son �devini yap.", 1, 1));
            IN_PROGRESS.Add(new Card("DEPLOY", "Book Store uygulamas�n� yay�nla.", 2, 3));
            DONE.Add(new Card("Build Al", "Book Store uygulamas�n�n build'ini al.", 3, 4));
        }

        public List<Card> GetProperty(string str)
        {
            // asl�nda yanl��
            if (str == "TODO")
                return this.TODO;
            else if (str == "IN_PROGRESS")
                return this.IN_PROGRESS;
            else
                return this.DONE;
        }
    }
}