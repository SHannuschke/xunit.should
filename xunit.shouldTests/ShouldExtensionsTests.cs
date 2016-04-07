using Xunit;
using Xunit.Should;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Xunit.Should.Tests {
    public class ShouldExtensionsTests {

        class CustomEntity { public int A { get; set; } public string B { get; set; } }
        class CustomEntityComparer : IEqualityComparer<CustomEntity> {
            public bool Equals(CustomEntity x, CustomEntity y) {
                return x.A == y.A && x.B == y.B;
            }

            public int GetHashCode(CustomEntity obj) {
                return (17 * 31 + obj.GetHashCode()) * 31 + obj.B.GetHashCode();
            }
        }

        [Fact()]
        public void ShouldContainForString_StringTest() {
            "a literal string".ShouldContain("literal");
            "a literal string".ShouldContain("l");
        }

        [Fact()]
        public void ShouldNotContainForString_StringTest() {
            "a literal string".ShouldNotContain("xxx");
            "a literal string".ShouldNotContain("x");
        }

        [Fact()]
        public void ShouldContainForString_String_StringComparisonTest() {
            "a literal string".ShouldContain("LITERAL", StringComparison.OrdinalIgnoreCase);
            "a literal string".ShouldContain("L", StringComparison.OrdinalIgnoreCase);
            //TODO:
            //var xx = StringComparison.CurrentCulture;
            //xx = StringComparison.CurrentCultureIgnoreCase;
            //xx = StringComparison.InvariantCulture;
            //xx = StringComparison.InvariantCultureIgnoreCase;
            //xx = StringComparison.Ordinal;
        }

        [Fact()]
        public void ShouldNotContainForString_String_StringComparisonTest() {
            "a literal string".ShouldNotContain("XXX", StringComparison.OrdinalIgnoreCase);
            "a literal string".ShouldNotContain("X", StringComparison.OrdinalIgnoreCase);
            //TODO:
            //var xx = StringComparison.CurrentCulture;
            //xx = StringComparison.CurrentCultureIgnoreCase;
            //xx = StringComparison.InvariantCulture;
            //xx = StringComparison.InvariantCultureIgnoreCase;
            //xx = StringComparison.Ordinal;
        }

        [Fact()]
        public void ShouldContainForIEnumerableOfT_TTest() {
            IEnumerable<string> enumerable = new List<string>() { "one", "two" };
            enumerable.ShouldContain("one");
        }

        [Fact()]
        public void ShouldNotContainForIEnumerableOfT_TTest() {
            IEnumerable<string> enumerable = new List<string>() { "one", "two" };
            enumerable.ShouldNotContain("three");
        }

        [Fact()]
        public void ShouldContainForIEnumerableOfT_T_IEqualityComparerTest() {
            IEnumerable<CustomEntity> enumerable = new List<CustomEntity>() {
                new CustomEntity() { A = 1, B = "one" } ,
                new CustomEntity() { A = 2, B = "two" } };
            enumerable.ShouldContain(new CustomEntity() { A = 1, B = "one" }, new CustomEntityComparer());
        }

        [Fact()]
        public void ShouldNotContainForIEnumerableOfT_T_IEqualityComparerTest() {
            IEnumerable<CustomEntity> enumerable = new List<CustomEntity>() {
                new CustomEntity() { A = 1, B = "one" } ,
                new CustomEntity() { A = 2, B = "two" } };
            enumerable.ShouldNotContain(new CustomEntity() { A = 3, B = "three" }, new CustomEntityComparer());
        }

        [Fact()]
        public void ShouldBeEmptyTest() {
            IEnumerable enumerable = new List<string>();
            enumerable.ShouldBeEmpty();
        }

        [Fact()]
        public void ShouldNotBeEmptyTest() {
            IEnumerable<string> enumerable = new List<string>() { "one", "two" };
            enumerable.ShouldNotBeEmpty();
        }

        [Fact()]
        public void ShouldBeTest() {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ShouldBeTest1() {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ShouldNotBeTest() {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ShouldNotBeTest1() {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ShouldBeNullTest() {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ShouldNotBeNullTest() {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ShouldBeSameAsTest() {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ShouldNotBeSameAsTest() {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ShouldBeTrueTest() {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ShouldBeTrueTest1() {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ShouldBeFalseTest() {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ShouldBeFalseTest1() {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ShouldBeInRangeTest() {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ShouldNotBeInRangeTest() {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ShouldBeGreaterThanTest() {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ShouldBeGreaterThanTest1() {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ShouldBeGreaterThanOrEqualToTest() {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ShouldBeGreaterThanOrEqualToTest1() {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ShouldBeLessThanTest() {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ShouldBeLessThanTest1() {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ShouldBeLessThanOrEqualToTest() {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ShouldBeLessThanOrEqualToTest1() {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ShouldBeInstanceOfTest() {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ShouldBeInstanceOfTest1() {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ShouldNotBeInstanceOfTest() {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ShouldNotBeInstanceOfTest1() {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ShouldBeThrownByTest() {
            Assert.True(false, "This test needs an implementation");
        }
    }
}