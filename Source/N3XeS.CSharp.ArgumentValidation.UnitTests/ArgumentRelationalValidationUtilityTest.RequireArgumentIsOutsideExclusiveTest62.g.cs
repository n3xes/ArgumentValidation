using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsOutsideExclusiveTest62.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest62ThrowsArgumentNullException972()
{
	this.RequireArgumentIsOutsideExclusiveTest62
		(new sbyte?((sbyte)1), (string)null, new sbyte?((sbyte)1), (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest62ThrowsArgumentOutOfRangeException793()
{
	this.RequireArgumentIsOutsideExclusiveTest62
		(new sbyte?((sbyte)1), "", new sbyte?((sbyte)1), (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest62ThrowsArgumentOutOfRangeException640()
{
	this.RequireArgumentIsOutsideExclusiveTest62
		(new sbyte?((sbyte)1), "\0", new sbyte?((sbyte)1), (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideExclusiveTest62373()
{
	this.RequireArgumentIsOutsideExclusiveTest62
		(default(sbyte?), "\0", new sbyte?((sbyte)1), (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest62ThrowsArgumentOutOfRangeException()
{
	this.RequireArgumentIsOutsideExclusiveTest62
		(new sbyte?((sbyte)1), "\0", new sbyte?((sbyte)1), (sbyte)2);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest62ThrowsArgumentOutOfRangeException931()
{
	this.RequireArgumentIsOutsideExclusiveTest62
		(new sbyte?((sbyte)1), "Ā", new sbyte?((sbyte)1), (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest62ThrowsArgumentOutOfRangeException906()
{
	this.RequireArgumentIsOutsideExclusiveTest62
		(new sbyte?((sbyte)1), "\t", new sbyte?((sbyte)1), (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest62ThrowsArgumentOutOfRangeException265()
{
	this.RequireArgumentIsOutsideExclusiveTest62
		(new sbyte?((sbyte)1), "\t\0", new sbyte?((sbyte)1), (sbyte)0);
}
	}
}
