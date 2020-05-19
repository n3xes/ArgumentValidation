using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsOutsideTest16.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideTest16ThrowsArgumentNullException680()
{
	this.RequireArgumentIsOutsideTest16
		(default(decimal), (string)null, default(decimal), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest16ThrowsArgumentOutOfRangeException491()
{
	this.RequireArgumentIsOutsideTest16
		(default(decimal), "", default(decimal), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideTest16582()
{
	this.RequireArgumentIsOutsideTest16
		(default(decimal), "\0", default(decimal), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest16ThrowsArgumentOutOfRangeException295()
{
	this.RequireArgumentIsOutsideTest16
		(decimal.MaxValue, "\0", 2034639888M, default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest16ThrowsArgumentOutOfRangeException128()
{
	this.RequireArgumentIsOutsideTest16
		(-76819052936496198642298613574e-19M, "\0", 1965637706M, 1M);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideTest16915()
{
	this.RequireArgumentIsOutsideTest16
		(default(decimal), "Ā", default(decimal), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest16ThrowsArgumentOutOfRangeException586()
{
	this.RequireArgumentIsOutsideTest16
		(default(decimal), "\t", default(decimal), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideTest16867()
{
	this.RequireArgumentIsOutsideTest16
		(default(decimal), "\t\0", default(decimal), default(decimal));
}
	}
}
