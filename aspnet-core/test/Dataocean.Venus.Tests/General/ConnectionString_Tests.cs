using System.Data.SqlClient;
using Shouldly;
using Xunit;

namespace Dataocean.Venus.Tests.General
{
    public class ConnectionString_Tests
    {
        [Fact]
        public void SqlConnectionStringBuilder_Test()
        {
            var csb = new SqlConnectionStringBuilder("Server=localhost; Database=Venus; Trusted_Connection=True;");
            csb["Database"].ShouldBe("Venus");
        }
    }
}

