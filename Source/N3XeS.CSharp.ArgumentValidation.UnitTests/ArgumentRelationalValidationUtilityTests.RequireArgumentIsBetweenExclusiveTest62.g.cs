using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsBetweenExclusiveTest62.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest62ThrowsArgumentNullException581()
{
	this.RequireArgumentIsBetweenExclusiveTest62
		(new sbyte?((sbyte)1), (string)null, new sbyte?((sbyte)1), (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest62ThrowsArgumentOutOfRangeException614()
{
	this.RequireArgumentIsBetweenExclusiveTest62
		(new sbyte?((sbyte)1), "", new sbyte?((sbyte)1), (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest62ThrowsArgumentOutOfRangeException332()
{
	this.RequireArgumentIsBetweenExclusiveTest62
		(new sbyte?((sbyte)1), "\0", new sbyte?((sbyte)1), (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenExclusiveTest62373()
{
	this.RequireArgumentIsBetweenExclusiveTest62
		(default(sbyte?), "\0", new sbyte?((sbyte)1), (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest62ThrowsArgumentOutOfRangeException441()
{
	this.RequireArgumentIsBetweenExclusiveTest62
		(new sbyte?((sbyte)1), "\0", new sbyte?((sbyte)1), (sbyte)2);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest62ThrowsArgumentOutOfRangeException320()
{
	this.RequireArgumentIsBetweenExclusiveTest62
		(new sbyte?((sbyte)1), "Ā", new sbyte?((sbyte)1), (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest62ThrowsArgumentOutOfRangeException931()
{
	this.RequireArgumentIsBetweenExclusiveTest62
		(new sbyte?((sbyte)1), "\t", new sbyte?((sbyte)1), (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest62ThrowsArgumentOutOfRangeException72()
{
	this.RequireArgumentIsBetweenExclusiveTest62
		(new sbyte?((sbyte)1), "\t\0", new sbyte?((sbyte)1), (sbyte)0);
}
	}
}
