namespace Business.Concrete
{
    internal class TCKimlikNoDogrulaRequestBody
    {
        private long nationalIdentity;
        private string firstName;
        private string lastName;
        private int dateOfBirthYear;

        public TCKimlikNoDogrulaRequestBody(long nationalIdentity, string firstName, string lastName, int dateOfBirthYear)
        {
            this.nationalIdentity = nationalIdentity;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirthYear = dateOfBirthYear;
        }
    }
}