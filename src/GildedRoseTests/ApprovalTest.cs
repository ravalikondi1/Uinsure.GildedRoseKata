using GildedRose.Console;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using VerifyXunit;
using Xunit;

namespace GildedRose.UnitTests
{
    public class ApprovalTest
    {
        [Fact]
        public Task ThirtyDays()
        {
            var fakeoutput = new StringBuilder();
            System.Console.SetOut(new StringWriter(fakeoutput));
            System.Console.SetIn(new StringReader("a\n"));

            Program.Main();
            var output = fakeoutput.ToString();

            return Verifier.Verify(output);
        }
    }
}
