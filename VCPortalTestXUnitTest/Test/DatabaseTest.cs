using VCPortalTestXUnitTest.Fixtures;
using Xunit;

namespace VCPortalTestXUnitTest.Test
{
    public class DatabaseTest : IClassFixture<DatabaseFixtures>
    {
        DatabaseFixtures dbFixtures;

        public DatabaseTest(DatabaseFixtures fixture) {

            dbFixtures = fixture;
        }

        [Fact]
        public void TestSQLConnection() {

            dbFixtures.Db.Open();
        }

    }
}
