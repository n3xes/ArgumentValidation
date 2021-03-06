using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsLessThanOrEqualTest08.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsLessThanOrEqualTest08ThrowsArgumentNullException665()
{
	this.RequireArgumentIsLessThanOrEqualTest08
		(default(decimal), (string)null, default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest08ThrowsArgumentOutOfRangeException734()
{
	this.RequireArgumentIsLessThanOrEqualTest08
		(default(decimal), "", default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsLessThanOrEqualTest08817()
{
	this.RequireArgumentIsLessThanOrEqualTest08
		(default(decimal), "\0", default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest08ThrowsArgumentOutOfRangeException333()
{
	this.RequireArgumentIsLessThanOrEqualTest08(decimal.MaxValue, "\0", 2034639888M);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsLessThanOrEqualTest08370()
{
	this.RequireArgumentIsLessThanOrEqualTest08
		(default(decimal), "Ā", default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest08ThrowsArgumentOutOfRangeException722()
{
	this.RequireArgumentIsLessThanOrEqualTest08
		(default(decimal), "\t", default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest08ThrowsArgumentOutOfRangeException376()
{
	this.RequireArgumentIsLessThanOrEqualTest08
		(default(decimal), "\t\t", default(decimal));
}
	}
}
