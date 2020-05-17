using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest36.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanTest36ThrowsArgumentNullException710()
{
	this.RequireArgumentIsGreaterThanTest36(0u, (string)null, 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest36ThrowsArgumentOutOfRangeException260()
{
	this.RequireArgumentIsGreaterThanTest36(0u, "", 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest36ThrowsArgumentOutOfRangeException824()
{
	this.RequireArgumentIsGreaterThanTest36(0u, "\0", 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanTest36223()
{
	this.RequireArgumentIsGreaterThanTest36(1u, "\0", 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest36ThrowsArgumentOutOfRangeException378()
{
	this.RequireArgumentIsGreaterThanTest36(0u, "Ā", 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest36ThrowsArgumentOutOfRangeException267()
{
	this.RequireArgumentIsGreaterThanTest36(0u, "\t", 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest36ThrowsArgumentOutOfRangeException157()
{
	this.RequireArgumentIsGreaterThanTest36(0u, "\t\t", 0u);
}
	}
}
