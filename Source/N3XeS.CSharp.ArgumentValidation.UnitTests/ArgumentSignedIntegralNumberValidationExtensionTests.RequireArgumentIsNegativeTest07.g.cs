using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentSignedIntegralNumberValidationExtensionTests.RequireArgumentIsNegativeTest07.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentSignedIntegralNumberValidationExtensionTests
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsNegativeTest07ThrowsArgumentNullException580()
{
	this.RequireArgumentIsNegativeTest07(new sbyte?((sbyte)1), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsNegativeTest07ThrowsArgumentOutOfRangeException551()
{
	this.RequireArgumentIsNegativeTest07(new sbyte?((sbyte)1), "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsNegativeTest07ThrowsArgumentOutOfRangeException11()
{
	this.RequireArgumentIsNegativeTest07(new sbyte?((sbyte)1), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTests))]
public void RequireArgumentIsNegativeTest07912()
{
	this.RequireArgumentIsNegativeTest07(default(sbyte?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsNegativeTest07ThrowsArgumentOutOfRangeException473()
{
	this.RequireArgumentIsNegativeTest07(new sbyte?((sbyte)1), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsNegativeTest07ThrowsArgumentOutOfRangeException638()
{
	this.RequireArgumentIsNegativeTest07(new sbyte?((sbyte)1), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsNegativeTest07ThrowsArgumentOutOfRangeException26()
{
	this.RequireArgumentIsNegativeTest07(new sbyte?((sbyte)1), "\t\t");
}
	}
}
