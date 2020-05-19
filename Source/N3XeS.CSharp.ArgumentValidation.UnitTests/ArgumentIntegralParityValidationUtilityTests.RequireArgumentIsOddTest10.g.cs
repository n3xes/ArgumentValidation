using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentIntegralParityValidationUtilityTests.RequireArgumentIsOddTest10.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOddTest10ThrowsArgumentNullException842()
{
	this.RequireArgumentIsOddTest10((short)32, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest10ThrowsArgumentOutOfRangeException94()
{
	this.RequireArgumentIsOddTest10((short)32, "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest10ThrowsArgumentOutOfRangeException544()
{
	this.RequireArgumentIsOddTest10((short)32, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTests))]
public void RequireArgumentIsOddTest10247()
{
	this.RequireArgumentIsOddTest10((short)73, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest10ThrowsArgumentOutOfRangeException622()
{
	this.RequireArgumentIsOddTest10((short)32, "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest10ThrowsArgumentOutOfRangeException189()
{
	this.RequireArgumentIsOddTest10((short)32, "\t\t");
}
	}
}
