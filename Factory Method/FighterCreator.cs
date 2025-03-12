namespace Factory_Method
{
    internal class FighterCreator : ICreator
    {
        public IHumanoid Create()
        {
            return new Fighter();
        }
    }
}
