using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsOddTest15.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentIntegralParityValidationExtensionTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsOddTest15ThrowsArgumentNullException574()
{
	this.RequireArgumentIsOddTest15(new ulong?(1uL), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest15ThrowsArgumentOutOfRangeException395()
{
	this.RequireArgumentIsOddTest15(new ulong?(1uL), "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
public void RequireArgumentIsOddTest15428()
{
	this.RequireArgumentIsOddTest15(new ulong?(1uL), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
public void RequireArgumentIsOddTest15912()
{
	this.RequireArgumentIsOddTest15(default(ulong?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest15ThrowsArgumentOutOfRangeException740()
{
	this.RequireArgumentIsOddTest15(new ulong?(2uL), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
public void RequireArgumentIsOddTest15834()
{
	this.RequireArgumentIsOddTest15(new ulong?(1uL), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest15ThrowsArgumentOutOfRangeException910()
{
	this.RequireArgumentIsOddTest15(new ulong?(1uL), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest15ThrowsArgumentOutOfRangeException51()
{
	this.RequireArgumentIsOddTest15(new ulong?(1uL), "\t\t");
}
	}
}
