using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsOutsideExclusiveTest64.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentRelationalValidationUtilityTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsOutsideExclusiveTest64ThrowsArgumentNullException111()
{
	this.RequireArgumentIsOutsideExclusiveTest64
		((short)32, (string)null, (short)32, (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest64ThrowsArgumentOutOfRangeException5()
{
	this.RequireArgumentIsOutsideExclusiveTest64
		((short)32, "", (short)32, (short)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest64ThrowsArgumentOutOfRangeException308()
{
	this.RequireArgumentIsOutsideExclusiveTest64
		((short)32, "\0", (short)32, (short)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest64ThrowsArgumentOutOfRangeException605()
{
	this.RequireArgumentIsOutsideExclusiveTest64
		((short)32, "\0", (short)32, (short)33);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideExclusiveTest64260()
{
	this.RequireArgumentIsOutsideExclusiveTest64
		((short)66, "\0", (short)32, (short)67);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest64ThrowsArgumentOutOfRangeException712()
{
	this.RequireArgumentIsOutsideExclusiveTest64
		((short)32, "Ā", (short)32, (short)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest64ThrowsArgumentOutOfRangeException718()
{
	this.RequireArgumentIsOutsideExclusiveTest64
		((short)32, "\t", (short)32, (short)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest64ThrowsArgumentOutOfRangeException845()
{
	this.RequireArgumentIsOutsideExclusiveTest64
		((short)32, "\t\0", (short)32, (short)32);
}
	}
}
