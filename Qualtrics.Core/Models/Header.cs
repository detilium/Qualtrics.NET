namespace Qualtrics.Core.Models
{
    public class Header
    {
        public string FromEmail { get; set; }
        public string FromName { get; set; }
        public string ReplyToEmail { get; set; }
        public string Subject { get; set; }

        public Header()
        { }

        public Header(string subject)
        {
            FromEmail = "analyse@detfagligehus.dk";
            FromName = "Det Faglige Hus";
            ReplyToEmail = "analyse@detfagligehus.dk";
            Subject = subject;
        }
    }
}
