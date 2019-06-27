using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsLessThanOrEqualTest21.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsLessThanOrEqualTest21ThrowsArgumentNullException359()
{
	this.RequireArgumentIsLessThanOrEqualTest21(1, (string)null, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest21ThrowsArgumentOutOfRangeException444()
{
	this.RequireArgumentIsLessThanOrEqualTest21(1, "", default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsLessThanOrEqualTest21599()
{
	this.RequireArgumentIsLessThanOrEqualTest21(1, "\0", default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest21ThrowsArgumentOutOfRangeException618()
{
	this.RequireArgumentIsLessThanOrEqualTest21(1, "\0", new int?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsLessThanOrEqualTest2196()
{
	this.RequireArgumentIsLessThanOrEqualTest21(1, "Ā", default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest21ThrowsArgumentOutOfRangeException95()
{
	this.RequireArgumentIsLessThanOrEqualTest21(1, "\t", default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest21ThrowsArgumentOutOfRangeException596()
{
	this.RequireArgumentIsLessThanOrEqualTest21(1, "\n\t", default(int?));
}
	}
}
