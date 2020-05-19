using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentFloatingPointNumberParityValidationUtilityTests.RequireArgumentIsOddTest.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentFloatingPointNumberParityValidationUtilityTests
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentFloatingPointNumberParityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsOddTestThrowsArgumentNullException835()
{
	this.RequireArgumentIsOddTest(0, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentFloatingPointNumberParityValidationUtilityTests))]
public void RequireArgumentIsOddTest705()
{
	this.RequireArgumentIsOddTest(0, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentFloatingPointNumberParityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTestThrowsArgumentOutOfRangeException535()
{
	this.RequireArgumentIsOddTest(0.93272612498137941, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentFloatingPointNumberParityValidationUtilityTests))]
public void RequireArgumentIsOddTest253()
{
	this.RequireArgumentIsOddTest(0, "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentFloatingPointNumberParityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTestThrowsArgumentOutOfRangeException89()
{
	this.RequireArgumentIsOddTest(0, "\t\t");
}
	}
}
