using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsGreaterThanOrEqualTest21.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanOrEqualTest21ThrowsArgumentNullException617()
{
	this.RequireArgumentIsGreaterThanOrEqualTest21(1, (string)null, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest21ThrowsArgumentOutOfRangeException111()
{
	this.RequireArgumentIsGreaterThanOrEqualTest21(1, "", default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsGreaterThanOrEqualTest21452()
{
	this.RequireArgumentIsGreaterThanOrEqualTest21(1, "\0", default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsGreaterThanOrEqualTest21223()
{
	this.RequireArgumentIsGreaterThanOrEqualTest21(1, "\0", new int?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest21ThrowsArgumentOutOfRangeException927()
{
	this.RequireArgumentIsGreaterThanOrEqualTest21(0, "\0", new int?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsGreaterThanOrEqualTest21713()
{
	this.RequireArgumentIsGreaterThanOrEqualTest21(1, "Ā", default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest21ThrowsArgumentOutOfRangeException547()
{
	this.RequireArgumentIsGreaterThanOrEqualTest21(1, "\t", default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest21ThrowsArgumentOutOfRangeException930()
{
	this.RequireArgumentIsGreaterThanOrEqualTest21(1, "\n\t", default(int?));
}
	}
}
