namespace Panus.SharedClasses
{
    public class EmailAddress
    {
        public EmailAddress(string address, string fullName)
        {
            this.FullName = fullName;
            this.Address = address;
        }

        public EmailAddress(string address)
        {
            this.Address = address;
        }
        public string FullName { get; set; }

        public string Address { get; set; }

    }
}
