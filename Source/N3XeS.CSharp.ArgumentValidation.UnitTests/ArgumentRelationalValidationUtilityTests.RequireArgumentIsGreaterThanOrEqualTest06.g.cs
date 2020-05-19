using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsGreaterThanOrEqualTest06.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanOrEqualTest06ThrowsArgumentNullException291()
{
	this.RequireArgumentIsGreaterThanOrEqualTest06
		(new byte?((byte)1), (string)null, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest06ThrowsArgumentOutOfRangeException20()
{
	this.RequireArgumentIsGreaterThanOrEqualTest06(new byte?((byte)1), "", (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsGreaterThanOrEqualTest06411()
{
	this.RequireArgumentIsGreaterThanOrEqualTest06
		(new byte?((byte)1), "\0", (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsGreaterThanOrEqualTest06740()
{
	this.RequireArgumentIsGreaterThanOrEqualTest06(default(byte?), "\0", (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest06ThrowsArgumentOutOfRangeException2001()
{
	this.RequireArgumentIsGreaterThanOrEqualTest06
		(new byte?((byte)1), "\0", (byte)2);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsGreaterThanOrEqualTest06761()
{
	this.RequireArgumentIsGreaterThanOrEqualTest06(new byte?((byte)1), "Ā", (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest06ThrowsArgumentOutOfRangeException798()
{
	this.RequireArgumentIsGreaterThanOrEqualTest06
		(new byte?((byte)1), "\t", (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest06ThrowsArgumentOutOfRangeException358()
{
	this.RequireArgumentIsGreaterThanOrEqualTest06
		(new byte?((byte)1), "\t\t", (byte)0);
}
	}
}
