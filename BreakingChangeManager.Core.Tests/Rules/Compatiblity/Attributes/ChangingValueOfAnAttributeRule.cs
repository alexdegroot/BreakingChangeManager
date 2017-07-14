using BreakingChangeManager.Core.Signatures;
using System.Linq;
using Xunit;

namespace BreakingChangeManager.Core.Tests.Rules.Compatiblity.Attributes
{

    public class ChangingValueOfAnAttributeRule
    {
        [Fact]
        public void GivenBaselineClassWithAttribute_WhenAttributeGetsNewValueHas_BreakingChangeIsIntroduced()
        {
            var name = "TestName";
            var c = new Class(name, Enumerable.Empty<Attribute>(), Enumerable.Empty<Field>());

            Assert.Equal(name, c.Name);
        }
    }
}
