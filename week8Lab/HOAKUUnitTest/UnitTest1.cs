using System;
using Xunit;
using week6Lab.Models.Messages;

namespace HOAKUUnitTest
{
    public class UnitTest1
    {
        FakeMessageRepo repo = new FakeMessageRepo();
        MessageViewModel ViewModel = new MessageViewModel();
        [Fact]
        public void GetSentMessage()
        {

            ViewModel.message = repo.GetSentMessageBySubject("Test");
            Assert.True(ViewModel.message.Subject == repo.Sent[0].Subject);
        }
        [Fact]
        public void AddMessageToFake()
        {
            repo.Sent.Add(new week6Lab.Models.Message() { User = new User() { Fname = "test" }, Msg = "TEST", Priority = false });
            Assert.True(repo.Sent.Count > 1);
        }
        [Fact]
        public void MessageReceived()
        {
            Assert.True(repo.Received.Count > 0);
        }
    }
}
