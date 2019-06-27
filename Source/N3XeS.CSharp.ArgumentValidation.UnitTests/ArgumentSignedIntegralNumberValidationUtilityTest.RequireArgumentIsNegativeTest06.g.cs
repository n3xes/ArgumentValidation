using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentSignedIntegralNumberValidationUtilityTest.RequireArgumentIsNegativeTest06.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsNegativeTest06ThrowsArgumentNullException139()
{
	this.RequireArgumentIsNegativeTest06((sbyte)0, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsNegativeTest06ThrowsArgumentOutOfRangeException783()
{
	this.RequireArgumentIsNegativeTest06((sbyte)0, "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTest))]
public void RequireArgumentIsNegativeTest06632()
{
	this.RequireArgumentIsNegativeTest06((sbyte)0, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsNegativeTest06ThrowsArgumentOutOfRangeException786()
{
	this.RequireArgumentIsNegativeTest06((sbyte)1, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTest))]
public void RequireArgumentIsNegativeTest06766()
{
	this.RequireArgumentIsNegativeTest06((sbyte)0, "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsNegativeTest06ThrowsArgumentOutOfRangeException780()
{
	this.RequireArgumentIsNegativeTest06((sbyte)0, "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsNegativeTest06ThrowsArgumentOutOfRangeException866()
{
	this.RequireArgumentIsNegativeTest06((sbyte)0, "\t\t");
}
	}
}
