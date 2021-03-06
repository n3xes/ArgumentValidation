using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsBetweenExclusiveTest24.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentRelationalValidationUtilityTests
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsBetweenExclusiveTest24ThrowsArgumentNullException641()
{
	this.RequireArgumentIsBetweenExclusiveTest24(0, (string)null, 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest24ThrowsArgumentOutOfRangeException338()
{
	this.RequireArgumentIsBetweenExclusiveTest24(0, "", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest24ThrowsArgumentOutOfRangeException217()
{
	this.RequireArgumentIsBetweenExclusiveTest24(0, "\0", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest24ThrowsArgumentOutOfRangeException896()
{
	this.RequireArgumentIsBetweenExclusiveTest24(0, "\0", 0, 1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenExclusiveTest24372()
{
	this.RequireArgumentIsBetweenExclusiveTest24(0, "\0", -1, 1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest24ThrowsArgumentOutOfRangeException505()
{
	this.RequireArgumentIsBetweenExclusiveTest24(0, "Ā", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest24ThrowsArgumentOutOfRangeException202()
{
	this.RequireArgumentIsBetweenExclusiveTest24(0, "\t", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest24ThrowsArgumentOutOfRangeException430()
{
	this.RequireArgumentIsBetweenExclusiveTest24(0, "\t\0", 0, 0);
}
	}
}
