using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest29.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest29ThrowsArgumentNullException677()
{
	this.RequireArgumentIsOutsideExclusiveTest29
		(new double?(0), (string)null, 0, new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest29ThrowsArgumentOutOfRangeException860()
{
	this.RequireArgumentIsOutsideExclusiveTest29
		(new double?(0), "", 0, new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest29ThrowsArgumentOutOfRangeException182()
{
	this.RequireArgumentIsOutsideExclusiveTest29
		(new double?(0), "\0", 0, new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest29ThrowsArgumentOutOfRangeException597()
{
	this.RequireArgumentIsOutsideExclusiveTest29
		(new double?(-1), "\0", 0, new double?(-7720));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideExclusiveTest29750()
{
	this.RequireArgumentIsOutsideExclusiveTest29
		(new double?(-1), "\0", -2, new double?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest29ThrowsArgumentOutOfRangeException514()
{
	this.RequireArgumentIsOutsideExclusiveTest29
		(new double?(0), "Ā", 0, new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest29ThrowsArgumentOutOfRangeException137()
{
	this.RequireArgumentIsOutsideExclusiveTest29
		(new double?(0), "Ā", 0, default(double?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest29ThrowsArgumentOutOfRangeException357()
{
	this.RequireArgumentIsOutsideExclusiveTest29
		(new double?(0), "\t", 0, new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideExclusiveTest29876()
{
	this.RequireArgumentIsOutsideExclusiveTest29
		(default(double?), "Ā", 0, new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest29ThrowsArgumentOutOfRangeException532()
{
	this.RequireArgumentIsOutsideExclusiveTest29
		(new double?(0), "\t\0", 0, new double?(1));
}
	}
}
