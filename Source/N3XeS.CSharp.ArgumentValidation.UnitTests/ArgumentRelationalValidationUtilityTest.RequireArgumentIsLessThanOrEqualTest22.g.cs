using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsLessThanOrEqualTest22.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsLessThanOrEqualTest22ThrowsArgumentNullException457()
{
	this.RequireArgumentIsLessThanOrEqualTest22(new int?(1), (string)null, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest22ThrowsArgumentOutOfRangeException517()
{
	this.RequireArgumentIsLessThanOrEqualTest22(new int?(1), "", 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest22ThrowsArgumentOutOfRangeException108()
{
	this.RequireArgumentIsLessThanOrEqualTest22(new int?(1), "\0", 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsLessThanOrEqualTest22875()
{
	this.RequireArgumentIsLessThanOrEqualTest22(default(int?), "\0", 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest22ThrowsArgumentOutOfRangeException478()
{
	this.RequireArgumentIsLessThanOrEqualTest22(new int?(1), "Ā", 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest22ThrowsArgumentOutOfRangeException546()
{
	this.RequireArgumentIsLessThanOrEqualTest22(new int?(1), "\t", 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest22ThrowsArgumentOutOfRangeException510()
{
	this.RequireArgumentIsLessThanOrEqualTest22(new int?(1), "\t\t", 0);
}
	}
}
