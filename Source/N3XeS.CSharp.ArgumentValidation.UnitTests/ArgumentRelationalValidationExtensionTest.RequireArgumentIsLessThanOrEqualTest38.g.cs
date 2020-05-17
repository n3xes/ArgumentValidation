using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest38.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsLessThanOrEqualTest38ThrowsArgumentNullException492()
{
	this.RequireArgumentIsLessThanOrEqualTest38(new uint?(1u), (string)null, 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest38ThrowsArgumentOutOfRangeException746()
{
	this.RequireArgumentIsLessThanOrEqualTest38(new uint?(1u), "", 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest38ThrowsArgumentOutOfRangeException359()
{
	this.RequireArgumentIsLessThanOrEqualTest38(new uint?(1u), "\0", 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsLessThanOrEqualTest38875()
{
	this.RequireArgumentIsLessThanOrEqualTest38(default(uint?), "\0", 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest38ThrowsArgumentOutOfRangeException984()
{
	this.RequireArgumentIsLessThanOrEqualTest38(new uint?(1u), "Ā", 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest38ThrowsArgumentOutOfRangeException348()
{
	this.RequireArgumentIsLessThanOrEqualTest38(new uint?(1u), "\t", 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest38ThrowsArgumentOutOfRangeException673()
{
	this.RequireArgumentIsLessThanOrEqualTest38(new uint?(1u), "\t\t", 0u);
}
	}
}
