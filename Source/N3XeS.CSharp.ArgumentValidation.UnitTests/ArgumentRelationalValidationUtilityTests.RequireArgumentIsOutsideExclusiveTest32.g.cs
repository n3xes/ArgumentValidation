using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsOutsideExclusiveTest32.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest32ThrowsArgumentNullException253()
{
	this.RequireArgumentIsOutsideExclusiveTest32
		((float)0, (string)null, (float)0, (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest32ThrowsArgumentOutOfRangeException95()
{
	this.RequireArgumentIsOutsideExclusiveTest32((float)0, "", (float)0, (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest32ThrowsArgumentOutOfRangeException971()
{
	this.RequireArgumentIsOutsideExclusiveTest32((float)0, "\0", (float)0, (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest32ThrowsArgumentOutOfRangeException949()
{
	this.RequireArgumentIsOutsideExclusiveTest32((float)0, "\0", (float)0, (float)1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideExclusiveTest32372()
{
	this.RequireArgumentIsOutsideExclusiveTest32
		((float)0, "\0", (float)(-1), (float)1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest32ThrowsArgumentOutOfRangeException442()
{
	this.RequireArgumentIsOutsideExclusiveTest32((float)0, "Ā", (float)0, (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest32ThrowsArgumentOutOfRangeException145()
{
	this.RequireArgumentIsOutsideExclusiveTest32((float)0, "\t", (float)0, (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest32ThrowsArgumentOutOfRangeException236()
{
	this.RequireArgumentIsOutsideExclusiveTest32
		((float)0, "\t\0", (float)0, (float)0);
}
	}
}
