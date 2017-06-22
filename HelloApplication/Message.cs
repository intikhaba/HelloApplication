namespace HelloApplication
{
    public class Message
    {
        private string _message;

        public Message(string _message)
        {
            this._message = _message;
        }

        public string Display()
        {
            if (string.IsNullOrEmpty(_message))
            {
                throw new System.Exception("No message specified.");
            }
            else
            {
                return _message;
            }
        }
    }
}