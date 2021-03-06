using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentIntegralParityValidationExtensionTests.RequireArgumentIsOddTest07.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentIntegralParityValidationExtensionTests
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsOddTest07ThrowsArgumentNullException832()
{
	this.RequireArgumentIsOddTest07(new long?(1L), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest07ThrowsArgumentOutOfRangeException808()
{
	this.RequireArgumentIsOddTest07(new long?(1L), "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTests))]
public void RequireArgumentIsOddTest07428()
{
	this.RequireArgumentIsOddTest07(new long?(1L), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTests))]
public void RequireArgumentIsOddTest07912()
{
	this.RequireArgumentIsOddTest07(default(long?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest07ThrowsArgumentOutOfRangeException495()
{
	this.RequireArgumentIsOddTest07(new long?(9079255744972195778L), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTests))]
public void RequireArgumentIsOddTest07834()
{
	this.RequireArgumentIsOddTest07(new long?(1L), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest07ThrowsArgumentOutOfRangeException129()
{
	this.RequireArgumentIsOddTest07(new long?(1L), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest07ThrowsArgumentOutOfRangeException434()
{
	this.RequireArgumentIsOddTest07(new long?(1L), "\t\t");
}
	}
}
