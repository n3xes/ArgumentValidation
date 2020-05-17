using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest40.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsLessThanOrEqualTest40ThrowsArgumentNullException333()
{
	this.RequireArgumentIsLessThanOrEqualTest40(0uL, (string)null, 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest40ThrowsArgumentOutOfRangeException813()
{
	this.RequireArgumentIsLessThanOrEqualTest40(0uL, "", 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsLessThanOrEqualTest40817()
{
	this.RequireArgumentIsLessThanOrEqualTest40(0uL, "\0", 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest40ThrowsArgumentOutOfRangeException418()
{
	this.RequireArgumentIsLessThanOrEqualTest40(1uL, "\0", 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsLessThanOrEqualTest40370()
{
	this.RequireArgumentIsLessThanOrEqualTest40(0uL, "Ā", 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest40ThrowsArgumentOutOfRangeException928()
{
	this.RequireArgumentIsLessThanOrEqualTest40(0uL, "\t", 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest40ThrowsArgumentOutOfRangeException755()
{
	this.RequireArgumentIsLessThanOrEqualTest40(0uL, "\t\t", 0uL);
}
	}
}
