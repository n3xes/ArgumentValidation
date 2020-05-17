using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentSignedIntegralNumberValidationUtilityTest.RequireArgumentIsNegativeTest04.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentSignedIntegralNumberValidationUtilityTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsNegativeTest04ThrowsArgumentNullException961()
{
	this.RequireArgumentIsNegativeTest04(0L, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsNegativeTest04ThrowsArgumentOutOfRangeException440()
{
	this.RequireArgumentIsNegativeTest04(0L, "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTest))]
public void RequireArgumentIsNegativeTest04705()
{
	this.RequireArgumentIsNegativeTest04(0L, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsNegativeTest04ThrowsArgumentOutOfRangeException752()
{
	this.RequireArgumentIsNegativeTest04(1L, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTest))]
public void RequireArgumentIsNegativeTest04253()
{
	this.RequireArgumentIsNegativeTest04(0L, "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsNegativeTest04ThrowsArgumentOutOfRangeException12()
{
	this.RequireArgumentIsNegativeTest04(0L, "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsNegativeTest04ThrowsArgumentOutOfRangeException991()
{
	this.RequireArgumentIsNegativeTest04(0L, "\t\t");
}
	}
}
