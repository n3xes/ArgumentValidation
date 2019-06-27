using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest40.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanOrEqualTest40ThrowsArgumentNullException397()
{
	this.RequireArgumentIsGreaterThanOrEqualTest40(0uL, (string)null, 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest40ThrowsArgumentOutOfRangeException477()
{
	this.RequireArgumentIsGreaterThanOrEqualTest40(0uL, "", 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanOrEqualTest40563()
{
	this.RequireArgumentIsGreaterThanOrEqualTest40(0uL, "\0", 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest40ThrowsArgumentOutOfRangeException151()
{
	this.RequireArgumentIsGreaterThanOrEqualTest40(0uL, "\0", 1uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanOrEqualTest4034()
{
	this.RequireArgumentIsGreaterThanOrEqualTest40(0uL, "Ā", 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest40ThrowsArgumentOutOfRangeException75()
{
	this.RequireArgumentIsGreaterThanOrEqualTest40(0uL, "\t", 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest40ThrowsArgumentOutOfRangeException255()
{
	this.RequireArgumentIsGreaterThanOrEqualTest40(0uL, "\t\t", 0uL);
}
	}
}
