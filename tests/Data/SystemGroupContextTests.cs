using Xunit;
using openrmf_msg_system.Models;
using openrmf_msg_system.Data;
using Microsoft.Extensions.Options;

/*
 *  Do note:
 *  These tests will fail without a proper
 *  MongoDB setup locally. Refer to the README
 *  in this repo or https://github.com/Cingulara/openrmf-docs/blob/master/create-users-by-hand.md
 */

namespace tests.Data
{
    public class SystemGroupContextTests
    {
        private readonly SystemGroupContext _systemGroupContext;

        public SystemGroupContextTests()
        {
            Settings settings = new Settings();
            settings.ConnectionString = "mongodb://openrmf:openrmf1234!@localhost/openrmf?authSource=admin";
            settings.Database = "openrmf";

            _systemGroupContext = new SystemGroupContext(settings);
        }

        [Fact]
        public void Test_SystemGroupContextIsValid()
        {
            // Testing
            Assert.False(_systemGroupContext == null);
            Assert.False(_systemGroupContext.SystemGroups == null);
        }
    }
}
