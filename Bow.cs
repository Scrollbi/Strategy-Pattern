namespace Strategy_Pattern
{
    public class Bow : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("атака луком");
        }
    }
}
