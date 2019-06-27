using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest85.g.cs">Copyright © N3XeS LLC 2016</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace N3XeS.CSharp.ArgumentValidation.Extensions.UnitTests
{
	public partial class ArgumentRelationalValidationExtensionTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsBetweenExclusiveTest85ThrowsArgumentNullException818()
{
	this.RequireArgumentIsBetweenExclusiveTest85
		(new ulong?(1uL), (string)null, 0uL, new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest85ThrowsArgumentOutOfRangeException654()
{
	this.RequireArgumentIsBetweenExclusiveTest85
		(new ulong?(1uL), "", 0uL, new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest85ThrowsArgumentOutOfRangeException272()
{
	this.RequireArgumentIsBetweenExclusiveTest85
		(new ulong?(1uL), "\0", 0uL, new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenExclusiveTest85579()
{
	this.RequireArgumentIsBetweenExclusiveTest85
		(new ulong?(1uL), "\0", 0uL, default(ulong?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest85ThrowsArgumentOutOfRangeException1()
{
	this.RequireArgumentIsBetweenExclusiveTest85
		(new ulong?(1uL), "\0", 9223372036854775808uL, default(ulong?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenExclusiveTest85164()
{
	this.RequireArgumentIsBetweenExclusiveTest85
		(default(ulong?), "\0", 0uL, new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest85ThrowsArgumentOutOfRangeException955()
{
	this.RequireArgumentIsBetweenExclusiveTest85
		(new ulong?(1uL), "Ā", 0uL, new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest85ThrowsArgumentOutOfRangeException61()
{
	this.RequireArgumentIsBetweenExclusiveTest85
		(new ulong?(1uL), "\t", 0uL, new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest85ThrowsArgumentOutOfRangeException30()
{
	this.RequireArgumentIsBetweenExclusiveTest85
		(new ulong?(1uL), "\t\0", 0uL, new ulong?(1uL));
}
	}
}
