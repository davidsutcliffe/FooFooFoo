using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FooDomain;
using NUnit;
using NUnit.Framework;

namespace FooDomainTest
{
    [TestFixture]
    public class FooGeneratorTest
    {
        //a comment
        [Test]
        public void GeneratingFooForKnownFooIdGetsCorrectFoo()
        {
            var foo = new FooGenerator();
            Assert.That(foo.GetFoo(1), Is.EqualTo("a"));
            Assert.That(foo.GetFoo(2), Is.EqualTo("b"));
            Assert.That(foo.GetFoo(3), Is.EqualTo("c"));
        }

        [Test]
        public void GeneratingFooForUnknownFooIdGetsCorrectFoo()
        {
            var foo = new FooGenerator();
            Assert.That(foo.GetFoo(4), Is.EqualTo("z"));
            Assert.That(foo.GetFoo(999), Is.EqualTo("z"));
        }
    }
}
