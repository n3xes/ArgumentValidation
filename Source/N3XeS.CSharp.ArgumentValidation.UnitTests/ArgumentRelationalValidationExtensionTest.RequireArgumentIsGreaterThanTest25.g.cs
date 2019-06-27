using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest25.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanTest25ThrowsArgumentNullException283()
{
	this.RequireArgumentIsGreaterThanTest25(0L, (string)null, new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest25ThrowsArgumentOutOfRangeException400()
{
	this.RequireArgumentIsGreaterThanTest25(0L, "", new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest25ThrowsArgumentOutOfRangeException17()
{
	this.RequireArgumentIsGreaterThanTest25(0L, "\0", new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanTest25120()
{
	this.RequireArgumentIsGreaterThanTest25(0L, "\0", default(long?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest25ThrowsArgumentOutOfRangeException271()
{
	this.RequireArgumentIsGreaterThanTest25(0L, "Ā", new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest25ThrowsArgumentOutOfRangeException188()
{
	this.RequireArgumentIsGreaterThanTest25(0L, "\t", new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest25ThrowsArgumentOutOfRangeException877()
{
	this.RequireArgumentIsGreaterThanTest25(0L, "\t\t", new long?(1L));
}
	}
}
