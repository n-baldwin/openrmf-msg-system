using Xunit;
using openrmf_msg_system.Models;
using System;

namespace tests.Models
{
    public class SystemGroupTests
    {
        [Fact]
        public void Test_NewSystemGroupIsValid()
        {
            SystemGroup system = new SystemGroup();

            // Testing
            Assert.False(system == null);
        }
    
        [Fact]
        public void Test_SystemGroupWithDataIsValid()
        {
            SystemGroup system = new SystemGroup();

            system.created = DateTime.Now;
            system.title = "My System Title";
            system.description = "This is my System description for all items.";
            system.numberOfChecklists = 3;
            system.nessusFilename = "myfileservers.nessus";
            system.rawNessusFile = "<xml></xml>";
            system.updatedOn = DateTime.Now;
            system.lastComplianceCheck = DateTime.Now;

            // Testing
            Assert.True(system.title == "My System Title");
            Assert.True(system.description == "This is my System description for all items.");
            Assert.True(system.numberOfChecklists == 3);
            Assert.True(system.nessusFilename == "myfileservers.nessus");
            Assert.True(system.rawNessusFile == "<xml></xml>");
            Assert.False(system.created == null);
            Assert.False(system.updatedOn == null);
            Assert.False(system.lastComplianceCheck == null);
        }
    }
}
