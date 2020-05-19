using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentIntegralParityValidationUtilityTests.RequireArgumentIsEvenTest.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsEvenTestThrowsArgumentNullException919()
{
	this.RequireArgumentIsEvenTest((byte)0, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsEvenTestThrowsArgumentOutOfRangeException618()
{
	this.RequireArgumentIsEvenTest((byte)0, "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTests))]
public void RequireArgumentIsEvenTest632()
{
	this.RequireArgumentIsEvenTest((byte)0, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsEvenTestThrowsArgumentOutOfRangeException910()
{
	this.RequireArgumentIsEvenTest((byte)1, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTests))]
public void RequireArgumentIsEvenTest766()
{
	this.RequireArgumentIsEvenTest((byte)0, "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsEvenTestThrowsArgumentOutOfRangeException776()
{
	this.RequireArgumentIsEvenTest((byte)0, "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsEvenTestThrowsArgumentOutOfRangeException800()
{
	this.RequireArgumentIsEvenTest((byte)0, "\t\t");
}
	}
}
