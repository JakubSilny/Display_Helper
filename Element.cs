namespace DisplayClasses
{
    public class Element
    {

        public int x;
        public int y;
        int lenght;
        public object oobject;
        public string background;
        public string foreground;

        public Element()
        {



        }

        public Element(int _x, int _y, int _lenght, string _object, string _background, string _foreground)
        {

            x = _x;
            y = _y;
            lenght = _lenght;
            oobject = _object;
            background = _background;
            foreground = _foreground;
        }

        public Element(int _x, int _y, int _lenght, string _object)
        {

            x = _x;
            y = _y;
            lenght = _lenght;
            oobject = _object;
            
        }
    }
}
