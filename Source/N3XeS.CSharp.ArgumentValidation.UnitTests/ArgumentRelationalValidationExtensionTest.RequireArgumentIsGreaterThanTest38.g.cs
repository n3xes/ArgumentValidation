using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest38.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanTest38ThrowsArgumentNullException71()
{
	this.RequireArgumentIsGreaterThanTest38(new uint?(1u), (string)null, 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest38ThrowsArgumentOutOfRangeException645()
{
	this.RequireArgumentIsGreaterThanTest38(new uint?(1u), "", 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanTest38223()
{
	this.RequireArgumentIsGreaterThanTest38(new uint?(1u), "\0", 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanTest3839()
{
	this.RequireArgumentIsGreaterThanTest38(default(uint?), "\0", 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest38ThrowsArgumentOutOfRangeException916()
{
	this.RequireArgumentIsGreaterThanTest38(new uint?(0u), "\0", 1u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanTest38808()
{
	this.RequireArgumentIsGreaterThanTest38(new uint?(1u), "Ā", 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest38ThrowsArgumentOutOfRangeException747()
{
	this.RequireArgumentIsGreaterThanTest38(new uint?(1u), "\t", 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest38ThrowsArgumentOutOfRangeException781()
{
	this.RequireArgumentIsGreaterThanTest38(new uint?(1u), "\t\t", 0u);
}
	}
}
