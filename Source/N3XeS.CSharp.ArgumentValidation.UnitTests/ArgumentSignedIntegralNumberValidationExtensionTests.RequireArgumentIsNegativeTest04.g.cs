using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentSignedIntegralNumberValidationExtensionTests.RequireArgumentIsNegativeTest04.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsNegativeTest04ThrowsArgumentNullException153()
{
	this.RequireArgumentIsNegativeTest04(0L, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsNegativeTest04ThrowsArgumentOutOfRangeException223()
{
	this.RequireArgumentIsNegativeTest04(0L, "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTests))]
public void RequireArgumentIsNegativeTest04705()
{
	this.RequireArgumentIsNegativeTest04(0L, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsNegativeTest04ThrowsArgumentOutOfRangeException682()
{
	this.RequireArgumentIsNegativeTest04(1L, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTests))]
public void RequireArgumentIsNegativeTest04253()
{
	this.RequireArgumentIsNegativeTest04(0L, "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsNegativeTest04ThrowsArgumentOutOfRangeException956()
{
	this.RequireArgumentIsNegativeTest04(0L, "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsNegativeTest04ThrowsArgumentOutOfRangeException53()
{
	this.RequireArgumentIsNegativeTest04(0L, "\t\t");
}
	}
}
