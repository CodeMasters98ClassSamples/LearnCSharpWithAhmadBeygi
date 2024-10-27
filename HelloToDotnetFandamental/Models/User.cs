namespace HelloToDotnetFandamental.Models
{
    internal class User
    {
        //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public bool Gender { get; set; }
        public short Age { get; set; }

        //Methods ? 
        public string ShowDetail()
        {
            return $"My Detail : My firstName is {FirstName} and My Lastname is {LastName}";
        }
    }
}
