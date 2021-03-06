using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsOutsideExclusiveTest13.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest13ThrowsArgumentNullException798()
{
	this.RequireArgumentIsOutsideExclusiveTest13
		(new byte?((byte)1), (string)null, (byte)0, new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest13ThrowsArgumentOutOfRangeException346()
{
	this.RequireArgumentIsOutsideExclusiveTest13
		(new byte?((byte)1), "", (byte)0, new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest13ThrowsArgumentOutOfRangeException38()
{
	this.RequireArgumentIsOutsideExclusiveTest13
		(new byte?((byte)1), "\0", (byte)0, new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideExclusiveTest13224()
{
	this.RequireArgumentIsOutsideExclusiveTest13
		(new byte?((byte)1), "\0", (byte)0, default(byte?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest13ThrowsArgumentOutOfRangeException963()
{
	this.RequireArgumentIsOutsideExclusiveTest13
		(new byte?((byte)1), "\0", (byte)128, default(byte?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideExclusiveTest13132()
{
	this.RequireArgumentIsOutsideExclusiveTest13
		(default(byte?), "\0", (byte)0, new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest13ThrowsArgumentOutOfRangeException699()
{
	this.RequireArgumentIsOutsideExclusiveTest13
		(new byte?((byte)1), "Ā", (byte)0, new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest13ThrowsArgumentOutOfRangeException337()
{
	this.RequireArgumentIsOutsideExclusiveTest13
		(new byte?((byte)1), "\t", (byte)0, new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest13ThrowsArgumentOutOfRangeException82()
{
	this.RequireArgumentIsOutsideExclusiveTest13
		(new byte?((byte)1), "\t\0", (byte)0, new byte?((byte)1));
}
	}
}
