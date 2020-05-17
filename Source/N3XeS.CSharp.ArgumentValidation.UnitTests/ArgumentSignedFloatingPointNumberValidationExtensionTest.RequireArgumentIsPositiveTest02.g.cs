using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentSignedFloatingPointNumberValidationExtensionTest.RequireArgumentIsPositiveTest02.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentSignedFloatingPointNumberValidationExtensionTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedFloatingPointNumberValidationExtensionTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsPositiveTest02ThrowsArgumentNullException695()
{
	this.RequireArgumentIsPositiveTest02((float)0, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedFloatingPointNumberValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsPositiveTest02ThrowsArgumentOutOfRangeException558()
{
	this.RequireArgumentIsPositiveTest02((float)0, "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedFloatingPointNumberValidationExtensionTest))]
public void RequireArgumentIsPositiveTest02705()
{
	this.RequireArgumentIsPositiveTest02((float)0, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedFloatingPointNumberValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsPositiveTest02ThrowsArgumentOutOfRangeException198()
{
	this.RequireArgumentIsPositiveTest02((float)(-1), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedFloatingPointNumberValidationExtensionTest))]
public void RequireArgumentIsPositiveTest02253()
{
	this.RequireArgumentIsPositiveTest02((float)0, "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedFloatingPointNumberValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsPositiveTest02ThrowsArgumentOutOfRangeException317()
{
	this.RequireArgumentIsPositiveTest02((float)0, "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedFloatingPointNumberValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsPositiveTest02ThrowsArgumentOutOfRangeException390()
{
	this.RequireArgumentIsPositiveTest02((float)0, "\t\t");
}
	}
}
