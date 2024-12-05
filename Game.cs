namespace Strategy_Pattern
{
    public class Game
    {
        private Player _player;

        public Game()
        {
            _player = new Player(new Sword());
        }

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("Оружие: 1- меч, 2 - лук, 3 - топор, 4 - атаковать, 5 - выход");
                var choice = Console.ReadLine();

                if (choice == "1")
                {
                    _player.SetWeapon(new Sword());
                    Console.WriteLine("Выбран меч");
                }
                else if (choice == "2")
                {
                    _player.SetWeapon(new Bow());
                    Console.WriteLine("Выбран лук");
                }
                else if (choice == "3")
                {
                    _player.SetWeapon(new Axe());
                    Console.WriteLine("Выбран топор");
                }
                else if (choice == "4") _player.Attack();
                
                else if (choice == "5") return;
                
                else Console.WriteLine("Неверный выбор.");
                
            }

        }
    }
}
