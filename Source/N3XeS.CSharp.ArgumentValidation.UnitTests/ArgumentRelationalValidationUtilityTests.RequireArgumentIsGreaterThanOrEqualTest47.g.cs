using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsGreaterThanOrEqualTest47.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanOrEqualTest47ThrowsArgumentNullException56()
{
	this.RequireArgumentIsGreaterThanOrEqualTest47
		(default(ushort?), (string)null, default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest47ThrowsArgumentOutOfRangeException956()
{
	this.RequireArgumentIsGreaterThanOrEqualTest47
		(default(ushort?), "", default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsGreaterThanOrEqualTest47468()
{
	this.RequireArgumentIsGreaterThanOrEqualTest47
		(default(ushort?), "\0", default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsGreaterThanOrEqualTest47120()
{
	this.RequireArgumentIsGreaterThanOrEqualTest47
		(new ushort?((ushort)0), "\0", default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsGreaterThanOrEqualTest47563()
{
	this.RequireArgumentIsGreaterThanOrEqualTest47
		(new ushort?((ushort)0), "\0", new ushort?((ushort)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest47ThrowsArgumentOutOfRangeException11()
{
	this.RequireArgumentIsGreaterThanOrEqualTest47
		(new ushort?((ushort)0), "\0", new ushort?((ushort)80));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest47ThrowsArgumentOutOfRangeException207()
{
	this.RequireArgumentIsGreaterThanOrEqualTest47
		(default(ushort?), "\t", default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsGreaterThanOrEqualTest47824()
{
	this.RequireArgumentIsGreaterThanOrEqualTest47
		(default(ushort?), "Ā", default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest47ThrowsArgumentOutOfRangeException732()
{
	this.RequireArgumentIsGreaterThanOrEqualTest47
		(default(ushort?), "\t\t", default(ushort?));
}
	}
}
