namespace DI_Demo
{
    public class Player
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public HairColor HairColor { get; set; }
        public int Strength { get; set; }
        public string Race { get; set; }

    }

    public enum Gender
    {
        Male=0,
        Female=1,
    }

    public enum HairColor
    {
        violate=0,
        indigo=1,
        blue=2,
        green=3,
        yellow=4,
        orange=5,
        red=6,
        white=7,
        black=8
    }
}
