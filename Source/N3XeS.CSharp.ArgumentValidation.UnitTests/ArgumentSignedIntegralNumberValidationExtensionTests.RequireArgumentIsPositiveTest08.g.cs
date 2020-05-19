using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentSignedIntegralNumberValidationExtensionTests.RequireArgumentIsPositiveTest08.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsPositiveTest08ThrowsArgumentNullException749()
{
	this.RequireArgumentIsPositiveTest08((short)32, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsPositiveTest08ThrowsArgumentOutOfRangeException369()
{
	this.RequireArgumentIsPositiveTest08((short)32, "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTests))]
public void RequireArgumentIsPositiveTest08954()
{
	this.RequireArgumentIsPositiveTest08((short)32, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsPositiveTest08ThrowsArgumentOutOfRangeException6()
{
	this.RequireArgumentIsPositiveTest08((short)short.MinValue, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTests))]
public void RequireArgumentIsPositiveTest0884()
{
	this.RequireArgumentIsPositiveTest08((short)32, "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsPositiveTest08ThrowsArgumentOutOfRangeException420()
{
	this.RequireArgumentIsPositiveTest08((short)32, "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsPositiveTest08ThrowsArgumentOutOfRangeException639()
{
	this.RequireArgumentIsPositiveTest08((short)32, "\t\t");
}
	}
}
