using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentFloatingPointNumberParityValidationUtilityTests.RequireArgumentIsEvenTest02.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsEvenTest02ThrowsArgumentNullException844()
{
	this.RequireArgumentIsEvenTest02((float)0, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentFloatingPointNumberParityValidationUtilityTests))]
public void RequireArgumentIsEvenTest02428()
{
	this.RequireArgumentIsEvenTest02((float)1, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentFloatingPointNumberParityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsEvenTest02ThrowsArgumentOutOfRangeException621()
{
	this.RequireArgumentIsEvenTest02((float)0, "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentFloatingPointNumberParityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsEvenTest02ThrowsArgumentOutOfRangeException245()
{
	this.RequireArgumentIsEvenTest02((float)0, "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentFloatingPointNumberParityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsEvenTest02ThrowsArgumentOutOfRangeException889()
{
	this.RequireArgumentIsEvenTest02((float)0, "\t\t");
}
	}
}
