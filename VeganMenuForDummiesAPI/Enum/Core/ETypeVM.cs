namespace Domain.Enum.Core
{
    public class ETypeVM
    {
        public string Value { get; private set; }
        public string Text { get; private set; }

        public ETypeVM(string text, string value)
        {
            Value= value;
            Text = text;
        }

        public ETypeVM(string text, Guid valueId)
        {
            Value = valueId.ToString();
            Text = text;
        }   
    }
}
