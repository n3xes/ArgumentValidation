using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest47.g.cs">Copyright © N3XeS LLC 2016</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace N3XeS.CSharp.ArgumentValidation.Extensions.UnitTests
{
	public partial class ArgumentRelationalValidationExtensionTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsOutsideExclusiveTest47ThrowsArgumentNullException603()
{
	this.RequireArgumentIsOutsideExclusiveTest47
		(default(int?), (string)null, default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest47ThrowsArgumentOutOfRangeException464()
{
	this.RequireArgumentIsOutsideExclusiveTest47
		(default(int?), "", default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideExclusiveTest47668()
{
	this.RequireArgumentIsOutsideExclusiveTest47
		(default(int?), "\0", default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideExclusiveTest47716()
{
	this.RequireArgumentIsOutsideExclusiveTest47
		(new int?(0), "\0", default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest47ThrowsArgumentOutOfRangeException628()
{
	this.RequireArgumentIsOutsideExclusiveTest47
		(new int?(0), "\0", new int?(0), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest47ThrowsArgumentOutOfRangeException321()
{
	this.RequireArgumentIsOutsideExclusiveTest47
		(new int?(0), "\0", default(int?), new int?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideExclusiveTest47703()
{
	this.RequireArgumentIsOutsideExclusiveTest47
		(default(int?), "Ā", default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest47ThrowsArgumentOutOfRangeException825()
{
	this.RequireArgumentIsOutsideExclusiveTest47
		(default(int?), "\t", default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideExclusiveTest47166()
{
	this.RequireArgumentIsOutsideExclusiveTest47
		(default(int?), "\t\0", default(int?), default(int?));
}
	}
}
