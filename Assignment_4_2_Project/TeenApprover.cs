namespace Assignment_4_2_Project
{
    public class TeenApprover
    {
        public bool IsTeenager(DateTime birthday)
        {
            DateTime today = DateTime.Today;

            return (today.AddYears(-20) < birthday && birthday <= today.AddYears(-13));    
        }
    }
}