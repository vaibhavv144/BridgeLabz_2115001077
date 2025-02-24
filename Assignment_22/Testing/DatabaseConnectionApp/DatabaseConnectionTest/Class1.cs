using NUnit.Framework;
using DatabaseConnectionApp;

namespace DatabaseConnectionTest
{
    [TestFixture]
    public class DatabaseConnectionTests
    {
        private DatabaseConnection _dbConnection;

        [SetUp]
        public void SetUp()
        {
            _dbConnection = new DatabaseConnection();
        }

        [Test]
        public void Connect_WhenCalled_SetsIsConnectedToTrue()
        {
            _dbConnection.Connect();
            Assert.That(_dbConnection.IsConnected, Is.True);
        }

        [Test]
        public void Disconnect_WhenCalled_SetsIsConnectedToFalse()
        {
            _dbConnection.Connect();
            _dbConnection.Disconnect();
            Assert.That(_dbConnection.IsConnected, Is.False);
        }

        [Test]
        public void Disconnect_WithoutCallingConnect_SetsIsConnectedToFalse()
        {
            _dbConnection.Disconnect();
            Assert.That(_dbConnection.IsConnected, Is.False);
        }

        [Test]
        public void Connect_AfterDisconnect_SetsIsConnectedToTrue()
        {
            _dbConnection.Connect();
            _dbConnection.Disconnect();
            _dbConnection.Connect();
            Assert.That(_dbConnection.IsConnected, Is.True);
        }
    }
}