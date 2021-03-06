using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsOutsideExclusiveTest38.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest38ThrowsArgumentNullException313()
{
	this.RequireArgumentIsOutsideExclusiveTest38
		(new float?((float)0), (string)null, new float?((float)1), (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest38ThrowsArgumentOutOfRangeException145()
{
	this.RequireArgumentIsOutsideExclusiveTest38
		(new float?((float)0), "", new float?((float)1), (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest38ThrowsArgumentOutOfRangeException268()
{
	this.RequireArgumentIsOutsideExclusiveTest38
		(new float?((float)0), "\0", new float?((float)1), (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideExclusiveTest38648()
{
	this.RequireArgumentIsOutsideExclusiveTest38
		(default(float?), "\0", new float?((float)1), (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest38ThrowsArgumentOutOfRangeException589()
{
	this.RequireArgumentIsOutsideExclusiveTest38
		(new float?((float)(-1)), "\0", new float?((float)1), (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest38ThrowsArgumentOutOfRangeException248()
{
	this.RequireArgumentIsOutsideExclusiveTest38
		(new float?((float)0), "Ā", new float?((float)1), (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest38ThrowsArgumentOutOfRangeException682()
{
	this.RequireArgumentIsOutsideExclusiveTest38
		(new float?((float)0), "\t", new float?((float)1), (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest38ThrowsArgumentOutOfRangeException744()
{
	this.RequireArgumentIsOutsideExclusiveTest38
		(new float?((float)0), "\t\0", new float?((float)1), (float)0);
}
	}
}
