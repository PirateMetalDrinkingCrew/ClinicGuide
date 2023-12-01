namespace WebAppTest.Models
{
    public class Form
    {
        public int Id { get; set; }
        public string Key { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
        public virtual Sprache Sprache { get; set; } = null!;
    }
}
