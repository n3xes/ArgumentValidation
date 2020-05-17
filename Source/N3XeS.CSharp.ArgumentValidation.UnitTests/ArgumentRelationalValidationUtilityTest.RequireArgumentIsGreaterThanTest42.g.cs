using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsGreaterThanTest42.g.cs">Copyright © N3XeS LLC 2016</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace N3XeS.CSharp.ArgumentValidation.Utilities.UnitTests
{
	public partial class ArgumentRelationalValidationUtilityTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsGreaterThanTest42ThrowsArgumentNullException459()
{
	this.RequireArgumentIsGreaterThanTest42(new ulong?(1uL), (string)null, 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest42ThrowsArgumentOutOfRangeException692()
{
	this.RequireArgumentIsGreaterThanTest42(new ulong?(1uL), "", 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsGreaterThanTest42223()
{
	this.RequireArgumentIsGreaterThanTest42(new ulong?(1uL), "\0", 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsGreaterThanTest4239()
{
	this.RequireArgumentIsGreaterThanTest42(default(ulong?), "\0", 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest42ThrowsArgumentOutOfRangeException734()
{
	this.RequireArgumentIsGreaterThanTest42
		(new ulong?(1uL), "\0", 9223372036854775808uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsGreaterThanTest42808()
{
	this.RequireArgumentIsGreaterThanTest42(new ulong?(1uL), "Ā", 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest42ThrowsArgumentOutOfRangeException715()
{
	this.RequireArgumentIsGreaterThanTest42(new ulong?(1uL), "\t", 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest42ThrowsArgumentOutOfRangeException996()
{
	this.RequireArgumentIsGreaterThanTest42(new ulong?(1uL), "\t\t", 0uL);
}
	}
}
