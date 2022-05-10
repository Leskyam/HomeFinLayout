namespace HomeFinCommonTypes
{
    [Serializable]
    public class User
    {
        System.Guid Id { get; set; }
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

    }
}