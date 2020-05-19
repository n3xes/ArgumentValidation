using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsBetweenExclusiveTest64.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest64ThrowsArgumentNullException592()
{
	this.RequireArgumentIsBetweenExclusiveTest64
		((short)32, (string)null, (short)32, (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest64ThrowsArgumentOutOfRangeException941()
{
	this.RequireArgumentIsBetweenExclusiveTest64
		((short)32, "", (short)32, (short)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest64ThrowsArgumentOutOfRangeException976()
{
	this.RequireArgumentIsBetweenExclusiveTest64
		((short)32, "\0", (short)32, (short)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest64ThrowsArgumentOutOfRangeException909()
{
	this.RequireArgumentIsBetweenExclusiveTest64
		((short)32, "\0", (short)32, (short)33);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenExclusiveTest64260()
{
	this.RequireArgumentIsBetweenExclusiveTest64
		((short)66, "\0", (short)32, (short)67);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest64ThrowsArgumentOutOfRangeException147()
{
	this.RequireArgumentIsBetweenExclusiveTest64
		((short)32, "Ā", (short)32, (short)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest64ThrowsArgumentOutOfRangeException334()
{
	this.RequireArgumentIsBetweenExclusiveTest64
		((short)32, "\t", (short)32, (short)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest64ThrowsArgumentOutOfRangeException677()
{
	this.RequireArgumentIsBetweenExclusiveTest64
		((short)32, "\t\0", (short)32, (short)32);
}
	}
}
