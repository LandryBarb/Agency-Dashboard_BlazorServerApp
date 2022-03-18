namespace BlazorServerAgencyDashboard.Data
{
    public class Client
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public int? Age { get; set; }
        public DateTime? Birthdate { get; set; }
        public bool HasHeadShots { get; set; } = false;

        public bool CanSubmit()
        {
            if (HasHeadShots && Age > 18)
            {

                return true;


            }
            else
            {
                return false;
            }
        }

        //public int GetAge()
        //{
        //    int year = DateTime.Now.Year;
        //    int age = year - (int)(Birthdate?.Year);
        //    return age;
        //}

    }
}
