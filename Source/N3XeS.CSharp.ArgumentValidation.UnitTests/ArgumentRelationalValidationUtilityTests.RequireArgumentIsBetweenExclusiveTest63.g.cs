using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsBetweenExclusiveTest63.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest63ThrowsArgumentNullException890()
{
	this.RequireArgumentIsBetweenExclusiveTest63
		(new sbyte?((sbyte)1), (string)null, 
		 new sbyte?((sbyte)1), new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest63ThrowsArgumentOutOfRangeException328()
{
	this.RequireArgumentIsBetweenExclusiveTest63
		(new sbyte?((sbyte)1), "", new sbyte?((sbyte)1), new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest63ThrowsArgumentOutOfRangeException375()
{
	this.RequireArgumentIsBetweenExclusiveTest63
		(new sbyte?((sbyte)1), "\0", new sbyte?((sbyte)1), new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest63ThrowsArgumentOutOfRangeException381()
{
	this.RequireArgumentIsBetweenExclusiveTest63
		(new sbyte?((sbyte)1), "\0", new sbyte?((sbyte)1), default(sbyte?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenExclusiveTest63451()
{
	this.RequireArgumentIsBetweenExclusiveTest63
		(new sbyte?((sbyte)2), "\0", new sbyte?((sbyte)1), new sbyte?((sbyte)3));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenExclusiveTest6352()
{
	this.RequireArgumentIsBetweenExclusiveTest63
		(new sbyte?((sbyte)1), "\0", default(sbyte?), default(sbyte?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest63ThrowsArgumentOutOfRangeException378()
{
	this.RequireArgumentIsBetweenExclusiveTest63
		(new sbyte?((sbyte)1), "\t", new sbyte?((sbyte)1), new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenExclusiveTest63930()
{
	this.RequireArgumentIsBetweenExclusiveTest63
		(default(sbyte?), "\0", new sbyte?((sbyte)1), new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest63ThrowsArgumentOutOfRangeException76()
{
	this.RequireArgumentIsBetweenExclusiveTest63
		(new sbyte?((sbyte)1), "Ā", new sbyte?((sbyte)1), new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest63ThrowsArgumentOutOfRangeException470()
{
	this.RequireArgumentIsBetweenExclusiveTest63
		(new sbyte?((sbyte)1), "\t\0", new sbyte?((sbyte)1), new sbyte?((sbyte)1));
}
	}
}
