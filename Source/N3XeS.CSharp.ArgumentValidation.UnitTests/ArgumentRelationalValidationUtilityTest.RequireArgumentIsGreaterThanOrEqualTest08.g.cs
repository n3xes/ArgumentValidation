using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsGreaterThanOrEqualTest08.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanOrEqualTest08ThrowsArgumentNullException619()
{
	this.RequireArgumentIsGreaterThanOrEqualTest08
		(default(decimal), (string)null, default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest08ThrowsArgumentOutOfRangeException330()
{
	this.RequireArgumentIsGreaterThanOrEqualTest08
		(default(decimal), "", default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsGreaterThanOrEqualTest08563()
{
	this.RequireArgumentIsGreaterThanOrEqualTest08
		(default(decimal), "\0", default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest08ThrowsArgumentOutOfRangeException807()
{
	this.RequireArgumentIsGreaterThanOrEqualTest08
		(-76819052936496198642298613574e-19M, "\0", 1M);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsGreaterThanOrEqualTest0834()
{
	this.RequireArgumentIsGreaterThanOrEqualTest08
		(default(decimal), "Ā", default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest08ThrowsArgumentOutOfRangeException342()
{
	this.RequireArgumentIsGreaterThanOrEqualTest08
		(default(decimal), "\t", default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest08ThrowsArgumentOutOfRangeException499()
{
	this.RequireArgumentIsGreaterThanOrEqualTest08
		(default(decimal), "\t\t", default(decimal));
}
	}
}
