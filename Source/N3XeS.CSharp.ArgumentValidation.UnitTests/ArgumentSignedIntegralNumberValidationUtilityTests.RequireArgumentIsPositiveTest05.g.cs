using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentSignedIntegralNumberValidationUtilityTests.RequireArgumentIsPositiveTest05.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsPositiveTest05ThrowsArgumentNullException384()
{
	this.RequireArgumentIsPositiveTest05(new long?(1L), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsPositiveTest05ThrowsArgumentOutOfRangeException407()
{
	this.RequireArgumentIsPositiveTest05(new long?(1L), "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTests))]
public void RequireArgumentIsPositiveTest05428()
{
	this.RequireArgumentIsPositiveTest05(new long?(1L), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTests))]
public void RequireArgumentIsPositiveTest05912()
{
	this.RequireArgumentIsPositiveTest05(default(long?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsPositiveTest05ThrowsArgumentOutOfRangeException534()
{
	this.RequireArgumentIsPositiveTest05(new long?(long.MinValue), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTests))]
public void RequireArgumentIsPositiveTest05834()
{
	this.RequireArgumentIsPositiveTest05(new long?(1L), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsPositiveTest05ThrowsArgumentOutOfRangeException872()
{
	this.RequireArgumentIsPositiveTest05(new long?(1L), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsPositiveTest05ThrowsArgumentOutOfRangeException748()
{
	this.RequireArgumentIsPositiveTest05(new long?(1L), "\t\t");
}
	}
}
