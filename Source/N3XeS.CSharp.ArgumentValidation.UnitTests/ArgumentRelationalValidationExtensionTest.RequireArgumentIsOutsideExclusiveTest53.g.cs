using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest53.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest53ThrowsArgumentNullException332()
{
	this.RequireArgumentIsOutsideExclusiveTest53
		(new long?(1L), (string)null, 0L, new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest53ThrowsArgumentOutOfRangeException575()
{
	this.RequireArgumentIsOutsideExclusiveTest53
		(new long?(1L), "", 0L, new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest53ThrowsArgumentOutOfRangeException576()
{
	this.RequireArgumentIsOutsideExclusiveTest53
		(new long?(1L), "\0", 0L, new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideExclusiveTest53579()
{
	this.RequireArgumentIsOutsideExclusiveTest53
		(new long?(1L), "\0", 0L, default(long?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest53ThrowsArgumentOutOfRangeException297()
{
	this.RequireArgumentIsOutsideExclusiveTest53
		(new long?(-9223372036854775807L), "\0", 0L, default(long?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideExclusiveTest53164()
{
	this.RequireArgumentIsOutsideExclusiveTest53
		(default(long?), "\0", 0L, new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest53ThrowsArgumentOutOfRangeException407()
{
	this.RequireArgumentIsOutsideExclusiveTest53
		(new long?(1L), "Ā", 0L, new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest53ThrowsArgumentOutOfRangeException737()
{
	this.RequireArgumentIsOutsideExclusiveTest53
		(new long?(1L), "\t", 0L, new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest53ThrowsArgumentOutOfRangeException694()
{
	this.RequireArgumentIsOutsideExclusiveTest53
		(new long?(1L), "\t\0", 0L, new long?(1L));
}
	}
}
