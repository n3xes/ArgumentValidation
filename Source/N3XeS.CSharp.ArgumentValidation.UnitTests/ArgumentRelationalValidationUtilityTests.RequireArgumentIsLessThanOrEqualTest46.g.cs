using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsLessThanOrEqualTest46.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsLessThanOrEqualTest46ThrowsArgumentNullException997()
{
	this.RequireArgumentIsLessThanOrEqualTest46
		(new ushort?((ushort)65), (string)null, (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest46ThrowsArgumentOutOfRangeException126()
{
	this.RequireArgumentIsLessThanOrEqualTest46
		(new ushort?((ushort)65), "", (ushort)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest46ThrowsArgumentOutOfRangeException44()
{
	this.RequireArgumentIsLessThanOrEqualTest46
		(new ushort?((ushort)65), "\0", (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsLessThanOrEqualTest46947()
{
	this.RequireArgumentIsLessThanOrEqualTest46(default(ushort?), "\0", (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest46ThrowsArgumentOutOfRangeException736()
{
	this.RequireArgumentIsLessThanOrEqualTest46
		(new ushort?((ushort)65), "Ā", (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest46ThrowsArgumentOutOfRangeException448()
{
	this.RequireArgumentIsLessThanOrEqualTest46
		(new ushort?((ushort)65), "\t", (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest46ThrowsArgumentOutOfRangeException277()
{
	this.RequireArgumentIsLessThanOrEqualTest46
		(new ushort?((ushort)65), "\t\t", (ushort)64);
}
	}
}
