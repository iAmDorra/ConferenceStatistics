namespace ConferenceStatistics.Tests
{
    [TestClass]
    public class ConferencesTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var initialConferences = new List<Conference> { new(title:"TestConf", year:2024) };
            Conferences conferences = new Conferences(initialConferences);
            var femaleConfNumber = conferences.GetFemaleConfNumber(conferenceName: "TestConf", year:2024);
            Assert.AreEqual(0, femaleConfNumber);
        }
    }
}