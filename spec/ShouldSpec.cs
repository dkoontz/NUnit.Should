using System;
using NUnit.Framework;

[TestFixture]
public class NUnitShouldSpec {

	[Test] public void Should_Be_EqualTo() { 1.Should(Be.EqualTo(1)); }

	[Test] public void ShouldNot_Be_EqualTo() { 1.ShouldNot(Be.EqualTo(6)); }

	[Test] public void Should_Be_False() { false.Should(Be.False); }

	[Test] public void Should_Be_True() { true.Should(Be.True); }

	[Test]
	public void Should_Have_Length() {
		new string[] { "hi", "there" }.Should(Have.Member("hi"));
		new string[] { "hi", "there" }.Should(Contain.Item("hi"));
	}
	
	[Test]
	public void Should_Throw() {
		string nullString = null;
		new TestDelegate(() => nullString.ToString()).ShouldThrow<NullReferenceException>();
	}
	
	[Test]
	public void Should_Not_Throw() {
		string nullString = "";
		new TestDelegate(() => nullString.ToString()).ShouldNotThrow();
	}
}

[TestFixture]
public class HelperMethodsSpec {

	[Test] public void ShouldEqual() { 1.ShouldEqual(1); }

	[Test] public void ShouldNotEqual() { 1.ShouldNotEqual(2); }

	[Test] public void ShouldContain_TEnum() { new string[] { "hi", "there" }.ShouldContain("hi"); }

	[Test] public void ShouldNotContain_TEnum() { new string[] { "hi", "there" }.ShouldNotContain("foo"); }

	[Test] public void ShouldContain_Strings() { "Foo Bar".ShouldContain("Bar"); }

	[Test] public void ShouldNotContain_Strings() { "Foo Bar".ShouldNotContain("HiThere"); }

	[Test] public void ShouldBeFalse() { false.ShouldBeFalse(); }

	[Test] public void ShouldBeTrue() { true.ShouldBeTrue(); }
}
