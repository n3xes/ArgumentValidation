using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentSignedIntegralNumberValidationUtilityTests.RequireArgumentIsNegativeTest09.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentSignedIntegralNumberValidationUtilityTests
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsNegativeTest09ThrowsArgumentNullException926()
{
	this.RequireArgumentIsNegativeTest09(default(short?), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsNegativeTest09ThrowsArgumentOutOfRangeException85()
{
	this.RequireArgumentIsNegativeTest09(default(short?), "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTests))]
public void RequireArgumentIsNegativeTest09912()
{
	this.RequireArgumentIsNegativeTest09(default(short?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTests))]
public void RequireArgumentIsNegativeTest09705()
{
	this.RequireArgumentIsNegativeTest09(new short?((short)0), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsNegativeTest09ThrowsArgumentOutOfRangeException780()
{
	this.RequireArgumentIsNegativeTest09(new short?((short)80), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTests))]
public void RequireArgumentIsNegativeTest09894()
{
	this.RequireArgumentIsNegativeTest09(default(short?), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsNegativeTest09ThrowsArgumentOutOfRangeException536()
{
	this.RequireArgumentIsNegativeTest09(default(short?), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsNegativeTest09ThrowsArgumentOutOfRangeException528()
{
	this.RequireArgumentIsNegativeTest09(default(short?), "\t\t");
}
	}
}
