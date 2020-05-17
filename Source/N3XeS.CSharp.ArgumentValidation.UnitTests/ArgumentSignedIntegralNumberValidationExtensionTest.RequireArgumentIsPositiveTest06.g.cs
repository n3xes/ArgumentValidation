using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentSignedIntegralNumberValidationExtensionTest.RequireArgumentIsPositiveTest06.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentSignedIntegralNumberValidationExtensionTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsPositiveTest06ThrowsArgumentNullException257()
{
	this.RequireArgumentIsPositiveTest06((sbyte)0, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsPositiveTest06ThrowsArgumentOutOfRangeException552()
{
	this.RequireArgumentIsPositiveTest06((sbyte)0, "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTest))]
public void RequireArgumentIsPositiveTest06632()
{
	this.RequireArgumentIsPositiveTest06((sbyte)0, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsPositiveTest06ThrowsArgumentOutOfRangeException78()
{
	this.RequireArgumentIsPositiveTest06((sbyte)sbyte.MinValue, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTest))]
public void RequireArgumentIsPositiveTest06766()
{
	this.RequireArgumentIsPositiveTest06((sbyte)0, "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsPositiveTest06ThrowsArgumentOutOfRangeException394()
{
	this.RequireArgumentIsPositiveTest06((sbyte)0, "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsPositiveTest06ThrowsArgumentOutOfRangeException814()
{
	this.RequireArgumentIsPositiveTest06((sbyte)0, "\t\t");
}
	}
}
