using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsGreaterThanTest24.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanTest24ThrowsArgumentNullException949()
{
	this.RequireArgumentIsGreaterThanTest24(0L, (string)null, 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest24ThrowsArgumentOutOfRangeException853()
{
	this.RequireArgumentIsGreaterThanTest24(0L, "", 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest24ThrowsArgumentOutOfRangeException893()
{
	this.RequireArgumentIsGreaterThanTest24(0L, "\0", 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsGreaterThanTest24223()
{
	this.RequireArgumentIsGreaterThanTest24(1L, "\0", 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest24ThrowsArgumentOutOfRangeException151()
{
	this.RequireArgumentIsGreaterThanTest24(0L, "Ā", 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest24ThrowsArgumentOutOfRangeException438()
{
	this.RequireArgumentIsGreaterThanTest24(0L, "\t", 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest24ThrowsArgumentOutOfRangeException237()
{
	this.RequireArgumentIsGreaterThanTest24(0L, "\t\t", 0L);
}
	}
}
