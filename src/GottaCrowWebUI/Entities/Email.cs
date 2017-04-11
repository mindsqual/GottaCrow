namespace GottaCrowWebUI.Entities
{
    public interface IEmail
    {
        int Id { get; set; }
        string FullEmail { get; set; }
    }

    public class Email : IEmail
    {
        public int Id { get; set; }
        public Email(string email)
        {
            FullEmail = email;
        }
        public string FullEmail { get; set; }

        public Person Person { get; set; }
    }
}
