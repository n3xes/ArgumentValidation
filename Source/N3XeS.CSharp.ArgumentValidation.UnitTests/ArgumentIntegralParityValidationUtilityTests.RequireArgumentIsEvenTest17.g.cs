using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentIntegralParityValidationUtilityTests.RequireArgumentIsEvenTest17.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentIntegralParityValidationUtilityTests
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsEvenTest17ThrowsArgumentNullException458()
{
	this.RequireArgumentIsEvenTest17(default(ushort?), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsEvenTest17ThrowsArgumentOutOfRangeException105()
{
	this.RequireArgumentIsEvenTest17(default(ushort?), "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTests))]
public void RequireArgumentIsEvenTest17912()
{
	this.RequireArgumentIsEvenTest17(default(ushort?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTests))]
public void RequireArgumentIsEvenTest17894()
{
	this.RequireArgumentIsEvenTest17(default(ushort?), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsEvenTest17ThrowsArgumentOutOfRangeException160()
{
	this.RequireArgumentIsEvenTest17(default(ushort?), "\t\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTests))]
public void RequireArgumentIsEvenTest17253()
{
	this.RequireArgumentIsEvenTest17(new ushort?((ushort)0), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsEvenTest17ThrowsArgumentOutOfRangeException660()
{
	this.RequireArgumentIsEvenTest17(new ushort?((ushort)33), "Ā");
}
	}
}
