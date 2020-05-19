using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsOutsideExclusiveTest30.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest30ThrowsArgumentNullException300()
{
	this.RequireArgumentIsOutsideExclusiveTest30
		(new double?(0), (string)null, new double?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest30ThrowsArgumentOutOfRangeException887()
{
	this.RequireArgumentIsOutsideExclusiveTest30
		(new double?(0), "", new double?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest30ThrowsArgumentOutOfRangeException647()
{
	this.RequireArgumentIsOutsideExclusiveTest30
		(new double?(0), "\0", new double?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideExclusiveTest30648()
{
	this.RequireArgumentIsOutsideExclusiveTest30
		(default(double?), "\0", new double?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest30ThrowsArgumentOutOfRangeException570()
{
	this.RequireArgumentIsOutsideExclusiveTest30
		(new double?(-1), "\0", new double?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest30ThrowsArgumentOutOfRangeException613()
{
	this.RequireArgumentIsOutsideExclusiveTest30
		(new double?(0), "Ā", new double?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest30ThrowsArgumentOutOfRangeException375()
{
	this.RequireArgumentIsOutsideExclusiveTest30
		(new double?(0), "\t", new double?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest30ThrowsArgumentOutOfRangeException54()
{
	this.RequireArgumentIsOutsideExclusiveTest30
		(new double?(0), "\t\0", new double?(1), 0);
}
	}
}
