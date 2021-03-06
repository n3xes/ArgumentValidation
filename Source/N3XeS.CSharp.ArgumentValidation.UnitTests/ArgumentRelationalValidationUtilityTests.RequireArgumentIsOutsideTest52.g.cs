using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsOutsideTest52.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideTest52ThrowsArgumentNullException220()
{
	this.RequireArgumentIsOutsideTest52(new long?(1L), (string)null, 0L, 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest52ThrowsArgumentOutOfRangeException331()
{
	this.RequireArgumentIsOutsideTest52(new long?(1L), "", 0L, 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest52ThrowsArgumentOutOfRangeException859()
{
	this.RequireArgumentIsOutsideTest52(new long?(1L), "\0", 0L, 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideTest52760()
{
	this.RequireArgumentIsOutsideTest52(default(long?), "\0", 0L, 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest52ThrowsArgumentOutOfRangeException208()
{
	this.RequireArgumentIsOutsideTest52
		(new long?(-9223372036854775807L), "\0", 0L, 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest52ThrowsArgumentOutOfRangeException370()
{
	this.RequireArgumentIsOutsideTest52(new long?(1L), "Ā", 0L, 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest52ThrowsArgumentOutOfRangeException148()
{
	this.RequireArgumentIsOutsideTest52(new long?(1L), "\t", 0L, 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest52ThrowsArgumentOutOfRangeException271()
{
	this.RequireArgumentIsOutsideTest52(new long?(1L), "\t\0", 0L, 0L);
}
	}
}
