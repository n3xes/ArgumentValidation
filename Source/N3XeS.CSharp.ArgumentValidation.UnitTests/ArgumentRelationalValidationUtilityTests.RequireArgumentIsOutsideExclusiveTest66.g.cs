using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsOutsideExclusiveTest66.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest66ThrowsArgumentNullException640()
{
	this.RequireArgumentIsOutsideExclusiveTest66
		((short)64, (string)null, new short?((short)65), (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest66ThrowsArgumentOutOfRangeException330()
{
	this.RequireArgumentIsOutsideExclusiveTest66
		((short)32, "", new short?((short)65), (short)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest66ThrowsArgumentOutOfRangeException710()
{
	this.RequireArgumentIsOutsideExclusiveTest66
		((short)32, "\0", new short?((short)33), (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideExclusiveTest66747()
{
	this.RequireArgumentIsOutsideExclusiveTest66
		((short)32, "\0", default(short?), (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest66ThrowsArgumentOutOfRangeException269()
{
	this.RequireArgumentIsOutsideExclusiveTest66
		((short)32, "Ā", new short?((short)65), (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest66ThrowsArgumentOutOfRangeException760()
{
	this.RequireArgumentIsOutsideExclusiveTest66
		((short)64, "Ā", new short?((short)65), (short)33);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest66ThrowsArgumentOutOfRangeException341()
{
	this.RequireArgumentIsOutsideExclusiveTest66
		((short)64, "\t", new short?((short)65), (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest66ThrowsArgumentOutOfRangeException750()
{
	this.RequireArgumentIsOutsideExclusiveTest66
		((short)32, "\t\0", new short?((short)65), (short)64);
}
	}
}
