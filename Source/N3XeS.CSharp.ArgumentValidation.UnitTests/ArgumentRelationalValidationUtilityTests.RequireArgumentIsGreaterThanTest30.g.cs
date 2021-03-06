using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsGreaterThanTest30.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanTest30ThrowsArgumentNullException96()
{
	this.RequireArgumentIsGreaterThanTest30
		(new sbyte?((sbyte)1), (string)null, (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest30ThrowsArgumentOutOfRangeException135()
{
	this.RequireArgumentIsGreaterThanTest30(new sbyte?((sbyte)1), "", (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsGreaterThanTest30411()
{
	this.RequireArgumentIsGreaterThanTest30(new sbyte?((sbyte)1), "\0", (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsGreaterThanTest30740()
{
	this.RequireArgumentIsGreaterThanTest30(default(sbyte?), "\0", (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest30ThrowsArgumentOutOfRangeException371()
{
	this.RequireArgumentIsGreaterThanTest30
		(new sbyte?((sbyte)(-127)), "\0", (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsGreaterThanTest30761()
{
	this.RequireArgumentIsGreaterThanTest30(new sbyte?((sbyte)1), "Ā", (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest30ThrowsArgumentOutOfRangeException55()
{
	this.RequireArgumentIsGreaterThanTest30(new sbyte?((sbyte)1), "\t", (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest30ThrowsArgumentOutOfRangeException622()
{
	this.RequireArgumentIsGreaterThanTest30(new sbyte?((sbyte)1), "\t\t", (sbyte)0);
}
	}
}
