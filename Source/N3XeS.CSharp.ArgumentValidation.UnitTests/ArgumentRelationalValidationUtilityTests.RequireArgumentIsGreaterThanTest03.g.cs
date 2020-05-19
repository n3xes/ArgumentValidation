using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsGreaterThanTest03.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentRelationalValidationUtilityTests
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsGreaterThanTest03ThrowsArgumentNullException461()
{
	this.RequireArgumentIsGreaterThanTest03
		(default(DateTime?), (string)null, default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest03ThrowsArgumentOutOfRangeException782()
{
	this.RequireArgumentIsGreaterThanTest03
		(default(DateTime?), "", default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsGreaterThanTest03468()
{
	this.RequireArgumentIsGreaterThanTest03
		(default(DateTime?), "\0", default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsGreaterThanTest03340()
{
	this.RequireArgumentIsGreaterThanTest03
		(new DateTime?(default(DateTime)), "\0", default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest03ThrowsArgumentOutOfRangeException176()
{
	this.RequireArgumentIsGreaterThanTest03
		(new DateTime?(default(DateTime)), "\0", new DateTime?(default(DateTime)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest03ThrowsArgumentOutOfRangeException200()
{
	this.RequireArgumentIsGreaterThanTest03
		(default(DateTime?), "\t", default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsGreaterThanTest03824()
{
	this.RequireArgumentIsGreaterThanTest03
		(default(DateTime?), "Ā", default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest03ThrowsArgumentOutOfRangeException458()
{
	this.RequireArgumentIsGreaterThanTest03
		(default(DateTime?), "\t\t", default(DateTime?));
}
	}
}
