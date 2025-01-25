namespace proj1.Model
{
    public class PersonalInfoRepository : IPersonalInfoRepository
    {
        private PersonalInfo _personalInfo;
         public PersonalInfoRepository()
        {
            _personalInfo = new PersonalInfo()

            {
                Name = "Kavyashree",
                PhoneNumber = 9148869788,
                RollNo = 21
            };
        }
        public PersonalInfo GetPersonalInfo()
        {
            return _personalInfo;
        }
    }
}
