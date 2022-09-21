using Assignment_4_2_Project;

namespace XUnitTestProject
{
    public class TeenApproverTest
    {
        [Theory]
        [InlineData(-13, 1, false)] // the day before becoming 13 - not a teenager yet
        [InlineData(-13, 0, true)]  // the day becoming 13 - now a teenager
        [InlineData(-20, 1, true)]  // the day before becoming 20 - still a teenager
        [InlineData(-20, 0, false)] // the day becoming 20 - not a teenager anymore
        public void IsTeenager(int yearAdjust, int dayAdjust, bool expected)
        {
            // arrange
            DateTime today = DateTime.Today;
            DateTime birthday = new DateTime(
            today.Year + yearAdjust,
            today.Month,
            today.Day + dayAdjust
        );
            // arrange
            TeenApprover ta = new TeenApprover();

            // act
            bool result = ta.IsTeenager(birthday);

            // assert
            Assert.Equal(expected, result);
        }
    }
}