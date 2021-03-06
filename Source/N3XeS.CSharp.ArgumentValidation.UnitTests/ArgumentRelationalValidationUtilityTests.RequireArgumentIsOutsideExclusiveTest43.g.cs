using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsOutsideExclusiveTest43.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest43ThrowsArgumentNullException587()
{
	this.RequireArgumentIsOutsideExclusiveTest43
		(1, (string)null, default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest43ThrowsArgumentOutOfRangeException873()
{
	this.RequireArgumentIsOutsideExclusiveTest43
		(1, "", default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideExclusiveTest43358()
{
	this.RequireArgumentIsOutsideExclusiveTest43
		(1, "\0", default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest43ThrowsArgumentOutOfRangeException()
{
	this.RequireArgumentIsOutsideExclusiveTest43
		(1, "\0", default(int?), new int?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideExclusiveTest43579()
{
	this.RequireArgumentIsOutsideExclusiveTest43
		(1, "\0", new int?(0), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest43ThrowsArgumentOutOfRangeException893()
{
	this.RequireArgumentIsOutsideExclusiveTest43
		(1, "\0", new int?(512), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideExclusiveTest43365()
{
	this.RequireArgumentIsOutsideExclusiveTest43
		(1, "Ā", default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest43ThrowsArgumentOutOfRangeException894()
{
	this.RequireArgumentIsOutsideExclusiveTest43
		(1, "\t", default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideExclusiveTest43860()
{
	this.RequireArgumentIsOutsideExclusiveTest43
		(1, "\t\0", default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest43ThrowsArgumentOutOfRangeException368()
{
	this.RequireArgumentIsOutsideExclusiveTest43
		(0, "\t\t", new int?(0), new int?(1));
}
	}
}
