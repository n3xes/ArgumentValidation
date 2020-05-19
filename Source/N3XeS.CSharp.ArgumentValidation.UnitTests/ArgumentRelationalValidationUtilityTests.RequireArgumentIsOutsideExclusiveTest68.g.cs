using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsOutsideExclusiveTest68.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest68ThrowsArgumentNullException769()
{
	this.RequireArgumentIsOutsideExclusiveTest68
		(new short?((short)65), (string)null, (short)32, (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest68ThrowsArgumentOutOfRangeException607()
{
	this.RequireArgumentIsOutsideExclusiveTest68
		(new short?((short)65), "", (short)32, (short)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest68ThrowsArgumentOutOfRangeException197()
{
	this.RequireArgumentIsOutsideExclusiveTest68
		(new short?((short)65), "\0", (short)32, (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideExclusiveTest68684()
{
	this.RequireArgumentIsOutsideExclusiveTest68
		(default(short?), "\0", (short)32, (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideExclusiveTest68930()
{
	this.RequireArgumentIsOutsideExclusiveTest68
		(new short?((short)80), "\0", (short)32, (short)81);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest68ThrowsArgumentOutOfRangeException594()
{
	this.RequireArgumentIsOutsideExclusiveTest68
		(new short?((short)0), "\0", (short)65, (short)33);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest68ThrowsArgumentOutOfRangeException()
{
	this.RequireArgumentIsOutsideExclusiveTest68
		(new short?((short)65), "Ā", (short)32, (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest68ThrowsArgumentOutOfRangeException600()
{
	this.RequireArgumentIsOutsideExclusiveTest68
		(new short?((short)65), "\t", (short)32, (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest68ThrowsArgumentOutOfRangeException752()
{
	this.RequireArgumentIsOutsideExclusiveTest68
		(new short?((short)65), "\t\0", (short)32, (short)64);
}
	}
}
