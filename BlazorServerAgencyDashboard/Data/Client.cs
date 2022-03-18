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



        /// <summary>
        /// Confirms clients readiness for agency submissions
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Calculates the clients age and returns boolean result
        /// </summary>
        /// <returns></returns>
        public bool ClientIsMinor()
        {
            int currentYear = DateTime.Now.Year;
            int birthyear = Convert.ToInt32(Birthdate.Value.Year);
            Age = currentYear - birthyear;

            if (Age < 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*Not sure if there is use for this yet/anymore*/
        public int GetAge()
        {
            int currentYear = DateTime.Now.Year;
            int age = currentYear - Birthdate.Value.Year;
            Age = age;
            return (int)Age;
        }


    }
}
