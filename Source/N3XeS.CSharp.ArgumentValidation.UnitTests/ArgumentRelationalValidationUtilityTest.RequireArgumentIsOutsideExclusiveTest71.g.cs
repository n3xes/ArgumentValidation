using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsOutsideExclusiveTest71.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest71ThrowsArgumentNullException878()
{
	this.RequireArgumentIsOutsideExclusiveTest71
		(default(short?), (string)null, default(short?), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest71ThrowsArgumentOutOfRangeException172()
{
	this.RequireArgumentIsOutsideExclusiveTest71
		(default(short?), "", default(short?), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideExclusiveTest71668()
{
	this.RequireArgumentIsOutsideExclusiveTest71
		(default(short?), "\0", default(short?), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideExclusiveTest71716()
{
	this.RequireArgumentIsOutsideExclusiveTest71
		(new short?((short)0), "\0", default(short?), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest71ThrowsArgumentOutOfRangeException278()
{
	this.RequireArgumentIsOutsideExclusiveTest71
		(new short?((short)0), "\0", new short?((short)0), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest71ThrowsArgumentOutOfRangeException650()
{
	this.RequireArgumentIsOutsideExclusiveTest71
		(new short?((short)0), "\0", default(short?), new short?((short)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideExclusiveTest71480()
{
	this.RequireArgumentIsOutsideExclusiveTest71
		(default(short?), "Ȁ", new short?((short)65), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest71ThrowsArgumentOutOfRangeException480()
{
	this.RequireArgumentIsOutsideExclusiveTest71
		(default(short?), "\t", default(short?), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideExclusiveTest71166()
{
	this.RequireArgumentIsOutsideExclusiveTest71
		(default(short?), "\t\0", default(short?), default(short?));
}
	}
}
