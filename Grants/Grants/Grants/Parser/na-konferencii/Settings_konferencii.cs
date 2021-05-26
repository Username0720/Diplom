
namespace Grants.Parser.na_konferencii
{
    class Settings_konferencii
    {
        public Settings_konferencii(int start, int end)
        {
            StartPoint = start;
            EndPoint = end;
        }
        public string BaseUrl { get; set; } = "https://na-konferencii.ru";

        public string Prefix { get; set; } = "page{CurrentId}";

        public int StartPoint { get; set; }

        public int EndPoint { get; set; }
    }
}
