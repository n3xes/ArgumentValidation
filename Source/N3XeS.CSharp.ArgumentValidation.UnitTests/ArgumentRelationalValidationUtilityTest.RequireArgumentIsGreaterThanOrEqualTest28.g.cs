using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsGreaterThanOrEqualTest28.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanOrEqualTest28ThrowsArgumentNullException381()
{
	this.RequireArgumentIsGreaterThanOrEqualTest28((sbyte)0, (string)null, (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest28ThrowsArgumentOutOfRangeException498()
{
	this.RequireArgumentIsGreaterThanOrEqualTest28((sbyte)0, "", (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsGreaterThanOrEqualTest28316()
{
	this.RequireArgumentIsGreaterThanOrEqualTest28((sbyte)0, "\0", (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest28ThrowsArgumentOutOfRangeException411()
{
	this.RequireArgumentIsGreaterThanOrEqualTest28((sbyte)0, "\0", (sbyte)1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsGreaterThanOrEqualTest28648()
{
	this.RequireArgumentIsGreaterThanOrEqualTest28((sbyte)0, "Ā", (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest28ThrowsArgumentOutOfRangeException453()
{
	this.RequireArgumentIsGreaterThanOrEqualTest28((sbyte)0, "\t", (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest28ThrowsArgumentOutOfRangeException531()
{
	this.RequireArgumentIsGreaterThanOrEqualTest28((sbyte)0, "\t\t", (sbyte)0);
}
	}
}
