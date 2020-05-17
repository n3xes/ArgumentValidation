using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsOutsideExclusiveTest60.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest60ThrowsArgumentNullException385()
{
	this.RequireArgumentIsOutsideExclusiveTest60
		(new sbyte?((sbyte)1), (string)null, (sbyte)0, (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest60ThrowsArgumentOutOfRangeException325()
{
	this.RequireArgumentIsOutsideExclusiveTest60
		(new sbyte?((sbyte)1), "", (sbyte)0, (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest60ThrowsArgumentOutOfRangeException307()
{
	this.RequireArgumentIsOutsideExclusiveTest60
		(new sbyte?((sbyte)1), "\0", (sbyte)0, (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideExclusiveTest60511()
{
	this.RequireArgumentIsOutsideExclusiveTest60
		(default(sbyte?), "\0", (sbyte)0, (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideExclusiveTest6034()
{
	this.RequireArgumentIsOutsideExclusiveTest60
		(new sbyte?((sbyte)2), "\0", (sbyte)0, (sbyte)3);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest60ThrowsArgumentOutOfRangeException32501()
{
	this.RequireArgumentIsOutsideExclusiveTest60
		(new sbyte?((sbyte)0), "\0", (sbyte)0, (sbyte)1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest60ThrowsArgumentOutOfRangeException248()
{
	this.RequireArgumentIsOutsideExclusiveTest60
		(new sbyte?((sbyte)1), "Ā", (sbyte)0, (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest60ThrowsArgumentOutOfRangeException613()
{
	this.RequireArgumentIsOutsideExclusiveTest60
		(new sbyte?((sbyte)1), "\t", (sbyte)0, (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest60ThrowsArgumentOutOfRangeException776()
{
	this.RequireArgumentIsOutsideExclusiveTest60
		(new sbyte?((sbyte)1), "\t\0", (sbyte)0, (sbyte)0);
}
	}
}
