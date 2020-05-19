using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsBetweenTest60.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest60ThrowsArgumentNullException290()
{
	this.RequireArgumentIsBetweenTest60
		(new sbyte?((sbyte)1), (string)null, (sbyte)0, (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest60ThrowsArgumentOutOfRangeException223()
{
	this.RequireArgumentIsBetweenTest60
		(new sbyte?((sbyte)1), "", (sbyte)0, (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest60ThrowsArgumentOutOfRangeException709()
{
	this.RequireArgumentIsBetweenTest60
		(new sbyte?((sbyte)1), "\0", (sbyte)0, (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest60511()
{
	this.RequireArgumentIsBetweenTest60(default(sbyte?), "\0", (sbyte)0, (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest60ThrowsArgumentOutOfRangeException280()
{
	this.RequireArgumentIsBetweenTest60
		(new sbyte?((sbyte)(-127)), "\0", (sbyte)0, (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest60ThrowsArgumentOutOfRangeException161()
{
	this.RequireArgumentIsBetweenTest60
		(new sbyte?((sbyte)1), "Ā", (sbyte)0, (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest60ThrowsArgumentOutOfRangeException926()
{
	this.RequireArgumentIsBetweenTest60
		(new sbyte?((sbyte)1), "\t", (sbyte)0, (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest60ThrowsArgumentOutOfRangeException422()
{
	this.RequireArgumentIsBetweenTest60
		(new sbyte?((sbyte)1), "\t\0", (sbyte)0, (sbyte)0);
}
	}
}
