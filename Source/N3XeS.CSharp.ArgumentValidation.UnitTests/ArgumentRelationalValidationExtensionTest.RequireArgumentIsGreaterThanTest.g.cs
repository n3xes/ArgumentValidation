using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanTestThrowsArgumentNullException450()
{
	this.RequireArgumentIsGreaterThanTest
		(default(DateTime), (string)null, default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTestThrowsArgumentOutOfRangeException507()
{
	this.RequireArgumentIsGreaterThanTest(default(DateTime), "", default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTestThrowsArgumentOutOfRangeException527()
{
	this.RequireArgumentIsGreaterThanTest
		(default(DateTime), "\0", default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanTest664()
{
	this.RequireArgumentIsGreaterThanTest
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
		 "\0", default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTestThrowsArgumentOutOfRangeException239()
{
	this.RequireArgumentIsGreaterThanTest(default(DateTime), "Ā", default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTestThrowsArgumentOutOfRangeException905()
{
	this.RequireArgumentIsGreaterThanTest
		(default(DateTime), "\t", default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTestThrowsArgumentOutOfRangeException916()
{
	this.RequireArgumentIsGreaterThanTest
		(default(DateTime), "\t\t", default(DateTime));
}
	}
}
