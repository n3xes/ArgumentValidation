using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest34.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanOrEqualTest34ThrowsArgumentNullException510()
{
	this.RequireArgumentIsGreaterThanOrEqualTest34
		(new short?((short)65), (string)null, (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest34ThrowsArgumentOutOfRangeException333()
{
	this.RequireArgumentIsGreaterThanOrEqualTest34
		(new short?((short)65), "", (short)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanOrEqualTest34384()
{
	this.RequireArgumentIsGreaterThanOrEqualTest34
		(new short?((short)65), "\0", (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanOrEqualTest34268()
{
	this.RequireArgumentIsGreaterThanOrEqualTest34(default(short?), "\0", (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest34ThrowsArgumentOutOfRangeException799()
{
	this.RequireArgumentIsGreaterThanOrEqualTest34
		(new short?((short)0), "\0", (short)33);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanOrEqualTest34884()
{
	this.RequireArgumentIsGreaterThanOrEqualTest34
		(new short?((short)65), "Ā", (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest34ThrowsArgumentOutOfRangeException450()
{
	this.RequireArgumentIsGreaterThanOrEqualTest34
		(new short?((short)65), "\t", (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest34ThrowsArgumentOutOfRangeException642()
{
	this.RequireArgumentIsGreaterThanOrEqualTest34
		(new short?((short)65), "\t\t", (short)64);
}
	}
}
