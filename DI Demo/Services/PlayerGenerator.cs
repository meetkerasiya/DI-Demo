namespace DI_Demo.Services
{
    public class PlayerGenerator : IPlayerGenerator
    {
        private readonly string[] _boysNames = { "Jay", "Krupal", "Meet", "Bhayo", "Mitesh" };
        private readonly string[] _girlsNames = { "Hemaxi", "Sonali", "Shruti", "Ray", "Foram" };

        public Player CreateNewPlayer()
        {
            string playerName;
            var random = new Random();

            var playerNameIndex = random.Next(5);
            var playerGenderIndex = random.Next(2);
            var playerHairColorIndex = random.Next(9);
            var playerAge = random.Next(20, 25);
            var strength = random.Next(10, 22);

            if (playerGenderIndex == 0)
            {
                playerName = _boysNames[playerNameIndex];
            }
            else
            {
                playerName = _girlsNames[playerNameIndex];
            }

            return new Player
            {
                Name = playerName,
                Gender = (Gender)playerGenderIndex,
                HairColor = (HairColor)playerHairColorIndex,
                Age = playerAge,
                Strength = strength,
                Race = "Human"
            };
        }


    }
}
