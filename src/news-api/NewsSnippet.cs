namespace news_api
{
    public class NewsSnippet
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public DateTime PublicationDate { get; set; }
        public string? SummaryText { get; set; }
        public string? ImageUrl { get; set; }
    }
}
