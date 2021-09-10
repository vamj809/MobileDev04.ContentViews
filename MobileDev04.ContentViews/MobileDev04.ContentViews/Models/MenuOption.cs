namespace MobileDev04.ContentViews.Models
{
    public class MenuOption
    {
        public string Image { get; }
        public string Title { get; }
        public string Subtitle { get; }
        public MenuOption(string image, string title, string subtitle) {
            Image = image;
            Title = title;
            Subtitle = subtitle;
        }
    }
}
