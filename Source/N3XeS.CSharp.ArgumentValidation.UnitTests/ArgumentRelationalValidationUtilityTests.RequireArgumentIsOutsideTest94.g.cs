using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsOutsideTest94.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideTest94ThrowsArgumentNullException130()
{
	this.RequireArgumentIsOutsideTest94
		(new ushort?((ushort)33), (string)null, new ushort?((ushort)33), (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest94ThrowsArgumentOutOfRangeException908()
{
	this.RequireArgumentIsOutsideTest94
		(new ushort?((ushort)64), "", new ushort?((ushort)33), (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest94ThrowsArgumentOutOfRangeException13()
{
	this.RequireArgumentIsOutsideTest94
		(new ushort?((ushort)65), "\0", new ushort?((ushort)33), (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideTest94772()
{
	this.RequireArgumentIsOutsideTest94
		(new ushort?((ushort)65), "\0", default(ushort?), (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest94ThrowsArgumentOutOfRangeException281()
{
	this.RequireArgumentIsOutsideTest94
		(new ushort?((ushort)51), "\0", new ushort?((ushort)51), (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideTest94538()
{
	this.RequireArgumentIsOutsideTest94
		(default(ushort?), "\0", new ushort?((ushort)33), (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest94ThrowsArgumentOutOfRangeException496()
{
	this.RequireArgumentIsOutsideTest94
		(new ushort?((ushort)65), "Ȁ", new ushort?((ushort)33), (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest94ThrowsArgumentOutOfRangeException716()
{
	this.RequireArgumentIsOutsideTest94
		(new ushort?((ushort)65), "\t", new ushort?((ushort)33), (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideTest94694()
{
	this.RequireArgumentIsOutsideTest94
		(default(ushort?), "\t\0", default(ushort?), (ushort)65);
}
	}
}
