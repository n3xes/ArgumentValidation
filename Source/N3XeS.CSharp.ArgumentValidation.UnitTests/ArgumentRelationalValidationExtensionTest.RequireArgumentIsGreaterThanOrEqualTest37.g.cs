using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest37.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanOrEqualTest37ThrowsArgumentNullException928()
{
	this.RequireArgumentIsGreaterThanOrEqualTest37(1u, (string)null, default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest37ThrowsArgumentOutOfRangeException77()
{
	this.RequireArgumentIsGreaterThanOrEqualTest37(1u, "", default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanOrEqualTest37452()
{
	this.RequireArgumentIsGreaterThanOrEqualTest37(1u, "\0", default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanOrEqualTest37223()
{
	this.RequireArgumentIsGreaterThanOrEqualTest37(1u, "\0", new uint?(0u));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest37ThrowsArgumentOutOfRangeException384()
{
	this.RequireArgumentIsGreaterThanOrEqualTest37(0u, "\0", new uint?(1u));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanOrEqualTest37713()
{
	this.RequireArgumentIsGreaterThanOrEqualTest37(1u, "Ā", default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest37ThrowsArgumentOutOfRangeException613()
{
	this.RequireArgumentIsGreaterThanOrEqualTest37(1u, "\t", default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest37ThrowsArgumentOutOfRangeException241()
{
	this.RequireArgumentIsGreaterThanOrEqualTest37(1u, "\n\t", default(uint?));
}
	}
}
