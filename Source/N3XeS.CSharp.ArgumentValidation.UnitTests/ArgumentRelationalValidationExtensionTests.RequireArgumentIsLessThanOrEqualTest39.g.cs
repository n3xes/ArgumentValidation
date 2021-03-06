using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsLessThanOrEqualTest39.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentRelationalValidationExtensionTests
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsLessThanOrEqualTest39ThrowsArgumentNullException636()
{
	this.RequireArgumentIsLessThanOrEqualTest39
		(default(uint?), (string)null, default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest39ThrowsArgumentOutOfRangeException790()
{
	this.RequireArgumentIsLessThanOrEqualTest39(default(uint?), "", default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsLessThanOrEqualTest3997()
{
	this.RequireArgumentIsLessThanOrEqualTest39
		(default(uint?), "\0", default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsLessThanOrEqualTest3929()
{
	this.RequireArgumentIsLessThanOrEqualTest39(new uint?(0u), "\0", default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsLessThanOrEqualTest39817()
{
	this.RequireArgumentIsLessThanOrEqualTest39(new uint?(0u), "\0", new uint?(0u));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest39ThrowsArgumentOutOfRangeException232()
{
	this.RequireArgumentIsLessThanOrEqualTest39(new uint?(1u), "\0", new uint?(0u));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest39ThrowsArgumentOutOfRangeException369()
{
	this.RequireArgumentIsLessThanOrEqualTest39
		(default(uint?), "\t", default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsLessThanOrEqualTest39539()
{
	this.RequireArgumentIsLessThanOrEqualTest39(default(uint?), "Ā", default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest39ThrowsArgumentOutOfRangeException53()
{
	this.RequireArgumentIsLessThanOrEqualTest39
		(default(uint?), "\t\t", default(uint?));
}
	}
}
