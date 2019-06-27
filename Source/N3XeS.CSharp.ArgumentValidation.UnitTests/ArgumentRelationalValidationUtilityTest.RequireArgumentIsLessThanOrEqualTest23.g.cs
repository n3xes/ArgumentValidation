using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsLessThanOrEqualTest23.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsLessThanOrEqualTest23ThrowsArgumentNullException994()
{
	this.RequireArgumentIsLessThanOrEqualTest23
		(default(int?), (string)null, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest23ThrowsArgumentOutOfRangeException60()
{
	this.RequireArgumentIsLessThanOrEqualTest23(default(int?), "", default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsLessThanOrEqualTest2397()
{
	this.RequireArgumentIsLessThanOrEqualTest23(default(int?), "\0", default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsLessThanOrEqualTest2329()
{
	this.RequireArgumentIsLessThanOrEqualTest23(new int?(0), "\0", default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsLessThanOrEqualTest23817()
{
	this.RequireArgumentIsLessThanOrEqualTest23(new int?(0), "\0", new int?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest23ThrowsArgumentOutOfRangeException926()
{
	this.RequireArgumentIsLessThanOrEqualTest23(new int?(1), "\0", new int?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest23ThrowsArgumentOutOfRangeException898()
{
	this.RequireArgumentIsLessThanOrEqualTest23(default(int?), "\t", default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsLessThanOrEqualTest23539()
{
	this.RequireArgumentIsLessThanOrEqualTest23(default(int?), "Ā", default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest23ThrowsArgumentOutOfRangeException310()
{
	this.RequireArgumentIsLessThanOrEqualTest23
		(default(int?), "\t\t", default(int?));
}
	}
}
