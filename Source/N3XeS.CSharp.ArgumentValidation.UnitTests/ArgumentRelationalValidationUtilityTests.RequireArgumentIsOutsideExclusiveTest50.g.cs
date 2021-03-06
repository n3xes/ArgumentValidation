using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsOutsideExclusiveTest50.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest50ThrowsArgumentNullException248()
{
	this.RequireArgumentIsOutsideExclusiveTest50
		(0L, (string)null, new long?(1L), 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest50ThrowsArgumentOutOfRangeException581()
{
	this.RequireArgumentIsOutsideExclusiveTest50(0L, "", new long?(1L), 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest50ThrowsArgumentOutOfRangeException889()
{
	this.RequireArgumentIsOutsideExclusiveTest50(0L, "\0", new long?(1L), 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest50ThrowsArgumentOutOfRangeException273()
{
	this.RequireArgumentIsOutsideExclusiveTest50(0L, "\0", new long?(1L), 1L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideExclusiveTest50661()
{
	this.RequireArgumentIsOutsideExclusiveTest50
		(0L, "\0", new long?(long.MinValue), 1L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest50ThrowsArgumentOutOfRangeException238()
{
	this.RequireArgumentIsOutsideExclusiveTest50(0L, "Ā", new long?(1L), 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideExclusiveTest50504()
{
	this.RequireArgumentIsOutsideExclusiveTest50(0L, "\0", default(long?), 1L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest50ThrowsArgumentOutOfRangeException598()
{
	this.RequireArgumentIsOutsideExclusiveTest50(0L, "\t", new long?(1L), 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest50ThrowsArgumentOutOfRangeException955()
{
	this.RequireArgumentIsOutsideExclusiveTest50(0L, "\t\0", new long?(1L), 0L);
}
	}
}
