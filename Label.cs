namespace DisplayClasses
{
    public class Label
    {

        public int x;
        public int y;
        int lenght;
        public string text;
        public string background;
        public string foreground;

        public Label()
        {

          

        }

        public Label(int _x, int _y, int _lenght, string _text, string _background, string _foreground)
        {

            x = _x;
            y = _y;
            lenght = _lenght;
            text = _text;
            background = _background;
            foreground = _foreground;

        }

        public Label(int _x, int _y, int _lenght, string _text)
        {

            x = _x;
            y = _y;
            lenght = _lenght;
            text = _text;
           

        }
    }
}
