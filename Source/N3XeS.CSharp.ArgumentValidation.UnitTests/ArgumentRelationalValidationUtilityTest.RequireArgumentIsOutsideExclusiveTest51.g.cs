using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsOutsideExclusiveTest51.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest51ThrowsArgumentNullException910()
{
	this.RequireArgumentIsOutsideExclusiveTest51
		(0L, (string)null, new long?(1L), new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest51ThrowsArgumentOutOfRangeException4()
{
	this.RequireArgumentIsOutsideExclusiveTest51
		(0L, "", new long?(1L), new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest51ThrowsArgumentOutOfRangeException331()
{
	this.RequireArgumentIsOutsideExclusiveTest51
		(0L, "\0", new long?(1L), new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideExclusiveTest51504()
{
	this.RequireArgumentIsOutsideExclusiveTest51
		(0L, "\0", default(long?), new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest51ThrowsArgumentOutOfRangeException958()
{
	this.RequireArgumentIsOutsideExclusiveTest51
		(0L, "Ā", new long?(1L), new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest51ThrowsArgumentOutOfRangeException384()
{
	this.RequireArgumentIsOutsideExclusiveTest51
		(0L, "Ā", new long?(1L), new long?(-9223372036854775807L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest51ThrowsArgumentOutOfRangeException764()
{
	this.RequireArgumentIsOutsideExclusiveTest51
		(0L, "\t", new long?(1L), new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest51ThrowsArgumentOutOfRangeException659()
{
	this.RequireArgumentIsOutsideExclusiveTest51
		(0L, "Ā", new long?(1L), default(long?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest51ThrowsArgumentOutOfRangeException731()
{
	this.RequireArgumentIsOutsideExclusiveTest51
		(0L, "\t\0", new long?(2L), new long?(1L));
}
	}
}
