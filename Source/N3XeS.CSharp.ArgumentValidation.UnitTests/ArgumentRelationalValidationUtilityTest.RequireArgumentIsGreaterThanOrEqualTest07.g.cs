using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsGreaterThanOrEqualTest07.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanOrEqualTest07ThrowsArgumentNullException750()
{
	this.RequireArgumentIsGreaterThanOrEqualTest07
		(new byte?((byte)1), (string)null, new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest07ThrowsArgumentOutOfRangeException422()
{
	this.RequireArgumentIsGreaterThanOrEqualTest07
		(new byte?((byte)1), "", new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsGreaterThanOrEqualTest0797()
{
	this.RequireArgumentIsGreaterThanOrEqualTest07
		(new byte?((byte)1), "\0", new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsGreaterThanOrEqualTest07783()
{
	this.RequireArgumentIsGreaterThanOrEqualTest07
		(new byte?((byte)1), "\0", default(byte?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest07ThrowsArgumentOutOfRangeException198()
{
	this.RequireArgumentIsGreaterThanOrEqualTest07
		(new byte?((byte)2), "\0", new byte?((byte)3));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsGreaterThanOrEqualTest0781()
{
	this.RequireArgumentIsGreaterThanOrEqualTest07
		(new byte?((byte)1), "Ā", new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsGreaterThanOrEqualTest07998()
{
	this.RequireArgumentIsGreaterThanOrEqualTest07
		(default(byte?), "Ā", new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest07ThrowsArgumentOutOfRangeException189()
{
	this.RequireArgumentIsGreaterThanOrEqualTest07
		(new byte?((byte)1), "\t", new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest07ThrowsArgumentOutOfRangeException737()
{
	this.RequireArgumentIsGreaterThanOrEqualTest07
		(new byte?((byte)1), "\t\t", new byte?((byte)1));
}
	}
}
