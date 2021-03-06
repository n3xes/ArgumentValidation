using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsOutsideExclusiveTest22.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest22ThrowsArgumentNullException686()
{
	this.RequireArgumentIsOutsideExclusiveTest22
		(new decimal?(0e-4M), (string)null, new decimal?(0e-4M), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest22ThrowsArgumentOutOfRangeException833()
{
	this.RequireArgumentIsOutsideExclusiveTest22
		(new decimal?(0e-4M), "", new decimal?(0e-4M), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest22ThrowsArgumentOutOfRangeException529()
{
	this.RequireArgumentIsOutsideExclusiveTest22
		(new decimal?(0e-4M), "\0", new decimal?(0e-4M), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideExclusiveTest22646()
{
	this.RequireArgumentIsOutsideExclusiveTest22
		(default(decimal?), "\0", new decimal?(0e-4M), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest22ThrowsArgumentOutOfRangeException548()
{
	this.RequireArgumentIsOutsideExclusiveTest22
		(new decimal?(-76819052936496198642298613574e-19M), "\0", 
		 new decimal?(0e-4M), 1M);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest22ThrowsArgumentOutOfRangeException182()
{
	this.RequireArgumentIsOutsideExclusiveTest22
		(new decimal?(0e-4M), "䀀", new decimal?(0e-4M), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest22ThrowsArgumentOutOfRangeException84()
{
	this.RequireArgumentIsOutsideExclusiveTest22
		(new decimal?(0e-4M), "\t", new decimal?(0e-4M), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest22ThrowsArgumentOutOfRangeException895()
{
	this.RequireArgumentIsOutsideExclusiveTest22
		(new decimal?(0e-4M), "\t\0", new decimal?(0e-4M), default(decimal));
}
	}
}
