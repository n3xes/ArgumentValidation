using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest49.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest49ThrowsArgumentNullException729()
{
	this.RequireArgumentIsOutsideExclusiveTest49
		(0L, (string)null, 0L, new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest49ThrowsArgumentOutOfRangeException639()
{
	this.RequireArgumentIsOutsideExclusiveTest49(0L, "", 0L, new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest49ThrowsArgumentOutOfRangeException14()
{
	this.RequireArgumentIsOutsideExclusiveTest49(0L, "\0", 0L, new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest49ThrowsArgumentOutOfRangeException628()
{
	this.RequireArgumentIsOutsideExclusiveTest49
		(0L, "\0", 0L, new long?(-9223372036854775807L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideExclusiveTest49661()
{
	this.RequireArgumentIsOutsideExclusiveTest49
		(0L, "\0", long.MinValue, new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest49ThrowsArgumentOutOfRangeException658()
{
	this.RequireArgumentIsOutsideExclusiveTest49(0L, "Ā", 0L, new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest49ThrowsArgumentOutOfRangeException181()
{
	this.RequireArgumentIsOutsideExclusiveTest49(0L, "Ā", 0L, default(long?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest49ThrowsArgumentOutOfRangeException802()
{
	this.RequireArgumentIsOutsideExclusiveTest49(0L, "\t", 0L, new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest49ThrowsArgumentOutOfRangeException807()
{
	this.RequireArgumentIsOutsideExclusiveTest49(0L, "\t\0", 0L, new long?(1L));
}
	}
}
