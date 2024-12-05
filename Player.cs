namespace Strategy_Pattern
{
    public class Player
    {
        private IWeapon _weapon;

        public Player(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public void SetWeapon(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public void Attack()
        {
            _weapon.UseWeapon();
        }
    }
}
