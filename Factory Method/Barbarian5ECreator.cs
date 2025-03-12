namespace Factory_Method
{
    internal class Barbarian5ECreator : ICreator
    {
        public IHumanoid Create()
        {
            return new Barbarian();
        }
    }
}
