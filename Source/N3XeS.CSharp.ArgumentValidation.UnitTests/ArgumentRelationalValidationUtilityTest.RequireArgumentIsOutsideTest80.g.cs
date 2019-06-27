using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsOutsideTest80.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideTest80ThrowsArgumentNullException251()
{
	this.RequireArgumentIsOutsideTest80(0uL, (string)null, 0uL, 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest80ThrowsArgumentOutOfRangeException407()
{
	this.RequireArgumentIsOutsideTest80(0uL, "", 0uL, 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest80582()
{
	this.RequireArgumentIsOutsideTest80(0uL, "\0", 0uL, 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest80ThrowsArgumentOutOfRangeException668()
{
	this.RequireArgumentIsOutsideTest80(1uL, "\0", 0uL, 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest80ThrowsArgumentOutOfRangeException937()
{
	this.RequireArgumentIsOutsideTest80(1uL, "\0", 9223372036854775808uL, 2uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest80915()
{
	this.RequireArgumentIsOutsideTest80(0uL, "Ā", 0uL, 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest80ThrowsArgumentOutOfRangeException194()
{
	this.RequireArgumentIsOutsideTest80(0uL, "\t", 0uL, 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest80867()
{
	this.RequireArgumentIsOutsideTest80(0uL, "\t\0", 0uL, 0uL);
}
	}
}
