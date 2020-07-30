using Microsoft.Data.SqlClient;
using System;

namespace VCPortalTestXUnitTest.Fixtures
{
    public class DatabaseFixtures : IDisposable
    {
        public SqlConnection Db { get; private set; }

        public DatabaseFixtures() {

            Db = new SqlConnection("Server=localhost; database = MemberOS;Integrated Security=True; MultipleActiveResultSets=True");
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
