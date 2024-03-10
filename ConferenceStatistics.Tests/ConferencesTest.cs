namespace ConferenceStatistics.Tests
{
    [TestClass]
    public class ConferencesTest
    {
        [TestMethod]
        public void NoFemaleConfFromAnEmptyConference()
        {
            var initialConferences = new List<Conference> { new(title: "TestConf", year: 2024, new List<Talk>()) };
            var conferences = new Conferences(initialConferences);
            var femaleConfNumber = conferences.GetFemaleConfNumber(conferenceName: "TestConf", year:2024);
            Assert.AreEqual(0, femaleConfNumber);
        }

        [TestMethod]
        public void OneFemaleConfFromAConferenceWithOneFemaleTalk()
        {
            var initialConferences = new List<Conference> { new(title: "TestConf", year: 2024, 
                talks:new List<Talk>{new(speaker:new Speaker(name:"do bart", gender:Gender.Female))}) };
            var conferences = new Conferences(initialConferences);
            var femaleConfNumber = conferences.GetFemaleConfNumber(conferenceName: "TestConf", year: 2024);
            Assert.AreEqual(1, femaleConfNumber);
        }

        [TestMethod]
        public void ZeroFemaleConfFromAConferenceWithoutFemaleTalk()
        {
            var initialConferences = new List<Conference> { new(title: "TestConf", year: 2024,
                talks:new List<Talk>{new(speaker:new Speaker(name:"do bart", gender:Gender.Male))}) };
            var conferences = new Conferences(initialConferences);
            var femaleConfNumber = conferences.GetFemaleConfNumber(conferenceName: "TestConf", year: 2024);
            Assert.AreEqual(0, femaleConfNumber);
        }

        [TestMethod]
        public void ZeroFemaleConfFromAConferenceWithManyTalksAndNoFemaleTalk()
        {
            var initialConferences = new List<Conference> { new(title: "TestConf", year: 2024,
                talks:new List<Talk>
                {
                    new(speaker:new Speaker(name:"do bart", gender:Gender.Male)),
                    new(speaker:new Speaker(name:"da bart", gender:Gender.NonBinary)),
                    new(speaker:new Speaker(name:"di bart", gender:Gender.Other))
                }) };
            var conferences = new Conferences(initialConferences);
            var femaleConfNumber = conferences.GetFemaleConfNumber(conferenceName: "TestConf", year: 2024);
            Assert.AreEqual(0, femaleConfNumber);
        }
    }
}