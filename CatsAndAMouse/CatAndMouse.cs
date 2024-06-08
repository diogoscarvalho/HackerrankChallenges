namespace CatsAndAMouse
{
    internal class CatAndMouse
    {
        private const string firstCat = "Cat A";
        private const string secondCat = "Cat B";
        private const string mouse = "Mouse C";

        internal static string WhoWins(int firstCatPosition, int secondCatPosition, int mousePosition)
        {
            int firstCatToMouse = Math.Abs(mousePosition - firstCatPosition);
            int secondCatToMouse = Math.Abs(mousePosition - secondCatPosition);
            
            if (firstCatToMouse - secondCatToMouse == 0)
                return mouse;
            else if (firstCatToMouse - secondCatToMouse < 0)
                return firstCat;
            else 
                return secondCat;


        }
    }
}
