using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest53.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest53ThrowsArgumentNullException714()
{
	this.RequireArgumentIsBetweenExclusiveTest53
		(new long?(1L), (string)null, 0L, new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest53ThrowsArgumentOutOfRangeException641()
{
	this.RequireArgumentIsBetweenExclusiveTest53
		(new long?(1L), "", 0L, new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest53ThrowsArgumentOutOfRangeException109()
{
	this.RequireArgumentIsBetweenExclusiveTest53
		(new long?(1L), "\0", 0L, new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenExclusiveTest53579()
{
	this.RequireArgumentIsBetweenExclusiveTest53
		(new long?(1L), "\0", 0L, default(long?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest53ThrowsArgumentOutOfRangeException437()
{
	this.RequireArgumentIsBetweenExclusiveTest53
		(new long?(-9223372036854775807L), "\0", 0L, default(long?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenExclusiveTest53164()
{
	this.RequireArgumentIsBetweenExclusiveTest53
		(default(long?), "\0", 0L, new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest53ThrowsArgumentOutOfRangeException9()
{
	this.RequireArgumentIsBetweenExclusiveTest53
		(new long?(1L), "Ā", 0L, new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest53ThrowsArgumentOutOfRangeException586()
{
	this.RequireArgumentIsBetweenExclusiveTest53
		(new long?(1L), "\t", 0L, new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest53ThrowsArgumentOutOfRangeException790()
{
	this.RequireArgumentIsBetweenExclusiveTest53
		(new long?(1L), "\t\0", 0L, new long?(1L));
}
	}
}
