using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentSignedIntegralNumberValidationExtensionTest.RequireArgumentIsPositiveTest04.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsPositiveTest04ThrowsArgumentNullException871()
{
	this.RequireArgumentIsPositiveTest04(0L, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsPositiveTest04ThrowsArgumentOutOfRangeException522()
{
	this.RequireArgumentIsPositiveTest04(0L, "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTest))]
public void RequireArgumentIsPositiveTest04705()
{
	this.RequireArgumentIsPositiveTest04(0L, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsPositiveTest04ThrowsArgumentOutOfRangeException867()
{
	this.RequireArgumentIsPositiveTest04(long.MinValue, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTest))]
public void RequireArgumentIsPositiveTest04253()
{
	this.RequireArgumentIsPositiveTest04(0L, "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsPositiveTest04ThrowsArgumentOutOfRangeException504()
{
	this.RequireArgumentIsPositiveTest04(0L, "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsPositiveTest04ThrowsArgumentOutOfRangeException716()
{
	this.RequireArgumentIsPositiveTest04(0L, "\t\t");
}
	}
}
