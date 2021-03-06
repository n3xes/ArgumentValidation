using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsLessThanTest28.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsLessThanTest28ThrowsArgumentNullException762()
{
	this.RequireArgumentIsLessThanTest28((sbyte)0, (string)null, (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest28ThrowsArgumentOutOfRangeException361()
{
	this.RequireArgumentIsLessThanTest28((sbyte)0, "", (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest28ThrowsArgumentOutOfRangeException129()
{
	this.RequireArgumentIsLessThanTest28((sbyte)0, "\0", (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsLessThanTest28843()
{
	this.RequireArgumentIsLessThanTest28((sbyte)0, "\0", (sbyte)1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest28ThrowsArgumentOutOfRangeException426()
{
	this.RequireArgumentIsLessThanTest28((sbyte)0, "Ā", (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest28ThrowsArgumentOutOfRangeException81()
{
	this.RequireArgumentIsLessThanTest28((sbyte)0, "\t", (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest28ThrowsArgumentOutOfRangeException328()
{
	this.RequireArgumentIsLessThanTest28((sbyte)0, "\t\t", (sbyte)0);
}
	}
}
