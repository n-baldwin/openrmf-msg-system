using Xunit;
using System.Threading.Tasks;
using openrmf_msg_system.Models;
using openrmf_msg_system.Data;
using Microsoft.Extensions.Options;
using MongoDB.Bson;

/*
 *  Do note:
 *  These tests will fail without a proper
 *  MongoDB setup locally. Refer to the README
 *  in this repo or https://github.com/Cingulara/openrmf-docs/blob/master/create-users-by-hand.md
 */

namespace tests.Data
{
    public class SystemGroupRepositoryTests
    {
        private readonly SystemGroupRepository _systemGroupRepository;

        public SystemGroupRepositoryTests()
        {
            Settings settings = new Settings();
            settings.ConnectionString = "mongodb://openrmf:openrmf1234!@localhost/openrmf?authSource=admin";
            settings.Database = "openrmf";

            _systemGroupRepository = new SystemGroupRepository(settings); 
        }

        [Fact]
        public async Task Test_SystemGroupRepositoryIsValid()
        {
            SystemGroup systemGroup = new SystemGroup();

            systemGroup.InternalId = ObjectId.GenerateNewId();

            // Testing
            Assert.False(_systemGroupRepository == null);

            // For most of these, we just need them to run.
            // If they run at all, then we know nothing happened
            // in the background with things such as configuration.
            // If they fail, however, they'll throw an error.
            await _systemGroupRepository.GetAllSystemGroups();
            await _systemGroupRepository.GetSystemGroup("someid");
            await _systemGroupRepository.UpdateSystemGroup("someid", systemGroup);
            await _systemGroupRepository.RemoveSystemGroup("someid");
        }
    }
}
