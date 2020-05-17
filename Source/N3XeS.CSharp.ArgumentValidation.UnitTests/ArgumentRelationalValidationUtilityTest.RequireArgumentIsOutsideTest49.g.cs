using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsOutsideTest49.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideTest49ThrowsArgumentNullException494()
{
	this.RequireArgumentIsOutsideTest49(0L, (string)null, 0L, new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest49ThrowsArgumentOutOfRangeException843()
{
	this.RequireArgumentIsOutsideTest49(0L, "", 0L, new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest49ThrowsArgumentOutOfRangeException449()
{
	this.RequireArgumentIsOutsideTest49(0L, "\0", 0L, new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest49158()
{
	this.RequireArgumentIsOutsideTest49(0L, "\0", 0L, default(long?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest49ThrowsArgumentOutOfRangeException105()
{
	this.RequireArgumentIsOutsideTest49(0L, "Ā", 0L, new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest49ThrowsArgumentOutOfRangeException241()
{
	this.RequireArgumentIsOutsideTest49(1L, "Ā", 0L, new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest49ThrowsArgumentOutOfRangeException968()
{
	this.RequireArgumentIsOutsideTest49(0L, "\t", 0L, new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest49ThrowsArgumentOutOfRangeException721()
{
	this.RequireArgumentIsOutsideTest49(0L, "\t\0", 0L, new long?(1L));
}
	}
}
