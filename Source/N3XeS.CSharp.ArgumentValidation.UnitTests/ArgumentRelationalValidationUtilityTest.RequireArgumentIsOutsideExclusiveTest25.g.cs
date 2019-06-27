using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsOutsideExclusiveTest25.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest25ThrowsArgumentNullException130()
{
	this.RequireArgumentIsOutsideExclusiveTest25(0, (string)null, 0, new double?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest25ThrowsArgumentOutOfRangeException408()
{
	this.RequireArgumentIsOutsideExclusiveTest25(0, "", 0, new double?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest25ThrowsArgumentOutOfRangeException633()
{
	this.RequireArgumentIsOutsideExclusiveTest25(0, "\0", 0, new double?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest25ThrowsArgumentOutOfRangeException600()
{
	this.RequireArgumentIsOutsideExclusiveTest25(0, "\0", 0, default(double?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest25ThrowsArgumentOutOfRangeException89()
{
	this.RequireArgumentIsOutsideExclusiveTest25(0, "Ā", 0, new double?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideExclusiveTest25579()
{
	this.RequireArgumentIsOutsideExclusiveTest25(1, "\0", 0, default(double?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest25ThrowsArgumentOutOfRangeException460()
{
	this.RequireArgumentIsOutsideExclusiveTest25(0, "\t", 0, new double?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest25ThrowsArgumentOutOfRangeException598()
{
	this.RequireArgumentIsOutsideExclusiveTest25(0, "\n\0", 0, new double?(0));
}
	}
}
