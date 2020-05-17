using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsOutsideExclusiveTest94.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest94ThrowsArgumentNullException470()
{
	this.RequireArgumentIsOutsideExclusiveTest94
		(new ushort?((ushort)33), (string)null, new ushort?((ushort)33), (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest94ThrowsArgumentOutOfRangeException396()
{
	this.RequireArgumentIsOutsideExclusiveTest94
		(new ushort?((ushort)64), "", new ushort?((ushort)33), (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest94ThrowsArgumentOutOfRangeException189()
{
	this.RequireArgumentIsOutsideExclusiveTest94
		(new ushort?((ushort)65), "\0", new ushort?((ushort)33), (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideExclusiveTest94538()
{
	this.RequireArgumentIsOutsideExclusiveTest94
		(default(ushort?), "\0", new ushort?((ushort)33), (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest94ThrowsArgumentOutOfRangeException109()
{
	this.RequireArgumentIsOutsideExclusiveTest94
		(new ushort?((ushort)0), "\0", new ushort?((ushort)33), (ushort)65);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest94ThrowsArgumentOutOfRangeException864()
{
	this.RequireArgumentIsOutsideExclusiveTest94
		(new ushort?((ushort)65), "Ȁ", new ushort?((ushort)33), (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest94ThrowsArgumentOutOfRangeException808()
{
	this.RequireArgumentIsOutsideExclusiveTest94
		(new ushort?((ushort)65), "\t", new ushort?((ushort)33), (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideExclusiveTest94694()
{
	this.RequireArgumentIsOutsideExclusiveTest94
		(default(ushort?), "\t\0", default(ushort?), (ushort)65);
}
	}
}
