using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentIntegralParityValidationUtilityTests.RequireArgumentIsEvenTest05.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsEvenTest05ThrowsArgumentNullException44()
{
	this.RequireArgumentIsEvenTest05(default(int?), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTests))]
public void RequireArgumentIsEvenTest05912()
{
	this.RequireArgumentIsEvenTest05(default(int?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTests))]
public void RequireArgumentIsEvenTest05894()
{
	this.RequireArgumentIsEvenTest05(default(int?), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsEvenTest05ThrowsArgumentOutOfRangeException487()
{
	this.RequireArgumentIsEvenTest05(default(int?), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsEvenTest05ThrowsArgumentOutOfRangeException541()
{
	this.RequireArgumentIsEvenTest05(default(int?), "\t\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTests))]
public void RequireArgumentIsEvenTest05253()
{
	this.RequireArgumentIsEvenTest05(new int?(0), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsEvenTest05ThrowsArgumentOutOfRangeException8()
{
	this.RequireArgumentIsEvenTest05(new int?(1021), "Ā");
}
	}
}
