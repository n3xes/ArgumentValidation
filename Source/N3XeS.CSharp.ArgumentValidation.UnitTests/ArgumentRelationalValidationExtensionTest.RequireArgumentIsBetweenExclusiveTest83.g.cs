using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest83.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest83ThrowsArgumentNullException506()
{
	this.RequireArgumentIsBetweenExclusiveTest83
		(0uL, (string)null, new ulong?(1uL), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest83ThrowsArgumentOutOfRangeException77()
{
	this.RequireArgumentIsBetweenExclusiveTest83
		(0uL, "", new ulong?(1uL), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest83ThrowsArgumentOutOfRangeException942()
{
	this.RequireArgumentIsBetweenExclusiveTest83
		(0uL, "\0", new ulong?(1uL), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenExclusiveTest83504()
{
	this.RequireArgumentIsBetweenExclusiveTest83
		(0uL, "\0", default(ulong?), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest83ThrowsArgumentOutOfRangeException617()
{
	this.RequireArgumentIsBetweenExclusiveTest83
		(0uL, "Ā", new ulong?(1uL), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest83ThrowsArgumentOutOfRangeException822()
{
	this.RequireArgumentIsBetweenExclusiveTest83
		(9223372036854775808uL, "Ā", new ulong?(1uL), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest83ThrowsArgumentOutOfRangeException499()
{
	this.RequireArgumentIsBetweenExclusiveTest83
		(0uL, "\t", new ulong?(1uL), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest83ThrowsArgumentOutOfRangeException962()
{
	this.RequireArgumentIsBetweenExclusiveTest83
		(0uL, "Ā", new ulong?(1uL), default(ulong?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest83ThrowsArgumentOutOfRangeException764()
{
	this.RequireArgumentIsBetweenExclusiveTest83
		(0uL, "\t\0", new ulong?(2uL), new ulong?(1uL));
}
	}
}
