using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest48.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest48ThrowsArgumentNullException543()
{
	this.RequireArgumentIsOutsideExclusiveTest48(0L, (string)null, 0L, 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest48ThrowsArgumentOutOfRangeException561()
{
	this.RequireArgumentIsOutsideExclusiveTest48(0L, "", 0L, 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest48ThrowsArgumentOutOfRangeException480()
{
	this.RequireArgumentIsOutsideExclusiveTest48(0L, "\0", 0L, 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest48ThrowsArgumentOutOfRangeException264()
{
	this.RequireArgumentIsOutsideExclusiveTest48(0L, "\0", 0L, 1L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideExclusiveTest48661()
{
	this.RequireArgumentIsOutsideExclusiveTest48(0L, "\0", long.MinValue, 1L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest48ThrowsArgumentOutOfRangeException64()
{
	this.RequireArgumentIsOutsideExclusiveTest48(0L, "Ā", 0L, 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest48ThrowsArgumentOutOfRangeException931()
{
	this.RequireArgumentIsOutsideExclusiveTest48(0L, "\t", 0L, 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest48ThrowsArgumentOutOfRangeException204()
{
	this.RequireArgumentIsOutsideExclusiveTest48(0L, "\t\0", 0L, 0L);
}
	}
}
