namespace Console_Toys
{
    public interface IToy
    {
        public string Name { get; set; }

        public string Play();

    }

    public class PS5 : IToy
    {
        public string Name { get; set; } = "PS5";

        public string Play()
        {
            return "好玩";
        }

    }
    public class Lego : IToy
    {
        public string Name { get; set; } = "Lego";

        public string Play()
        {
            return "中好玩";
        }

    }
    public class Uno : IToy
    {
        public string Name { get; set; } = "Uno";

        public string Play()
        {
            return "已退流行";
        }
    }
}
