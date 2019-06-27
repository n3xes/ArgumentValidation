using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsGreaterThanTest32.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanTest32ThrowsArgumentNullException907()
{
	this.RequireArgumentIsGreaterThanTest32((short)32, (string)null, (short)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest32ThrowsArgumentOutOfRangeException512()
{
	this.RequireArgumentIsGreaterThanTest32((short)32, "", (short)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest32ThrowsArgumentOutOfRangeException724()
{
	this.RequireArgumentIsGreaterThanTest32((short)32, "\0", (short)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsGreaterThanTest32155()
{
	this.RequireArgumentIsGreaterThanTest32((short)33, "\0", (short)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest32ThrowsArgumentOutOfRangeException225()
{
	this.RequireArgumentIsGreaterThanTest32((short)32, "Ā", (short)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest32ThrowsArgumentOutOfRangeException630()
{
	this.RequireArgumentIsGreaterThanTest32((short)32, "\t", (short)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest32ThrowsArgumentOutOfRangeException549()
{
	this.RequireArgumentIsGreaterThanTest32((short)32, "\t\t", (short)32);
}
	}
}
