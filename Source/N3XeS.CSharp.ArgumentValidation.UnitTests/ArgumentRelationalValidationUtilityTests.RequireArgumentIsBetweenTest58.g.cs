using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsBetweenTest58.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest58ThrowsArgumentNullException317()
{
	this.RequireArgumentIsBetweenTest58
		((sbyte)0, (string)null, new sbyte?((sbyte)1), (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest58ThrowsArgumentOutOfRangeException237()
{
	this.RequireArgumentIsBetweenTest58
		((sbyte)0, "", new sbyte?((sbyte)1), (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest58ThrowsArgumentOutOfRangeException56()
{
	this.RequireArgumentIsBetweenTest58
		((sbyte)0, "\0", new sbyte?((sbyte)1), (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest58723()
{
	this.RequireArgumentIsBetweenTest58((sbyte)0, "\0", default(sbyte?), (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest58ThrowsArgumentOutOfRangeException106()
{
	this.RequireArgumentIsBetweenTest58
		((sbyte)0, "Ā", new sbyte?((sbyte)1), (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest58ThrowsArgumentOutOfRangeException211()
{
	this.RequireArgumentIsBetweenTest58
		((sbyte)1, "Ā", new sbyte?((sbyte)1), (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest58ThrowsArgumentOutOfRangeException328()
{
	this.RequireArgumentIsBetweenTest58
		((sbyte)0, "\t", new sbyte?((sbyte)1), (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest58ThrowsArgumentOutOfRangeException855()
{
	this.RequireArgumentIsBetweenTest58
		((sbyte)0, "\t\0", new sbyte?((sbyte)1), (sbyte)0);
}
	}
}
