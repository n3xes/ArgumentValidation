using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsBetweenExclusiveTest85.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest85ThrowsArgumentNullException654()
{
	this.RequireArgumentIsBetweenExclusiveTest85
		(new ulong?(1uL), (string)null, 0uL, new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest85ThrowsArgumentOutOfRangeException267()
{
	this.RequireArgumentIsBetweenExclusiveTest85
		(new ulong?(1uL), "", 0uL, new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest85ThrowsArgumentOutOfRangeException451()
{
	this.RequireArgumentIsBetweenExclusiveTest85
		(new ulong?(1uL), "\0", 0uL, new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenExclusiveTest85579()
{
	this.RequireArgumentIsBetweenExclusiveTest85
		(new ulong?(1uL), "\0", 0uL, default(ulong?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest85ThrowsArgumentOutOfRangeException782()
{
	this.RequireArgumentIsBetweenExclusiveTest85
		(new ulong?(1uL), "\0", 9223372036854775808uL, default(ulong?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenExclusiveTest85164()
{
	this.RequireArgumentIsBetweenExclusiveTest85
		(default(ulong?), "\0", 0uL, new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest85ThrowsArgumentOutOfRangeException702()
{
	this.RequireArgumentIsBetweenExclusiveTest85
		(new ulong?(1uL), "Ā", 0uL, new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest85ThrowsArgumentOutOfRangeException969()
{
	this.RequireArgumentIsBetweenExclusiveTest85
		(new ulong?(1uL), "\t", 0uL, new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest85ThrowsArgumentOutOfRangeException915()
{
	this.RequireArgumentIsBetweenExclusiveTest85
		(new ulong?(1uL), "\t\0", 0uL, new ulong?(1uL));
}
	}
}
