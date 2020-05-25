using Xunit;
using openrmf_msg_system.Models;
using System;

namespace tests.Models
{
    public class ArtifactTests
    {
        [Fact]
        public void Test_NewArtifactIsValid()
        {
            Artifact artifact = new Artifact();

            // Testing
            Assert.False(artifact == null);
        }
    
        [Fact]
        public void Test_ArtifactWithDataIsValid()
        {
            Artifact artifact = new Artifact();

            artifact.created = DateTime.Now;
            artifact.systemGroupId = "875678654gghjghjkgu658";
            artifact.hostName = "myHost";
            artifact.stigType = "Google Chrome";
            artifact.stigRelease = "R13";
            artifact.version = "1";
            artifact.rawChecklist = "<xml></xml>";
            artifact.updatedOn = DateTime.Now;

            // Testing
            Assert.True(artifact.systemGroupId == "875678654gghjghjkgu658");
            Assert.True(artifact.hostName == "myHost");
            Assert.True(artifact.stigType == "Google Chrome");
            Assert.True(artifact.stigRelease == "R13");
            Assert.True(artifact.version == "1");
            Assert.True(artifact.rawChecklist == "<xml></xml>");
            Assert.False(artifact.created == null);
            Assert.False(artifact.updatedOn == null);
        }
    }
}
