using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentIntegralParityValidationExtensionTests.RequireArgumentIsOddTest05.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOddTest05ThrowsArgumentNullException584()
{
	this.RequireArgumentIsOddTest05(default(int?), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest05ThrowsArgumentOutOfRangeException462()
{
	this.RequireArgumentIsOddTest05(default(int?), "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTests))]
public void RequireArgumentIsOddTest05912()
{
	this.RequireArgumentIsOddTest05(default(int?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest05ThrowsArgumentOutOfRangeException585()
{
	this.RequireArgumentIsOddTest05(new int?(0), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTests))]
public void RequireArgumentIsOddTest05894()
{
	this.RequireArgumentIsOddTest05(default(int?), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest05ThrowsArgumentOutOfRangeException726()
{
	this.RequireArgumentIsOddTest05(default(int?), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest05ThrowsArgumentOutOfRangeException444()
{
	this.RequireArgumentIsOddTest05(default(int?), "\t\t");
}
	}
}
