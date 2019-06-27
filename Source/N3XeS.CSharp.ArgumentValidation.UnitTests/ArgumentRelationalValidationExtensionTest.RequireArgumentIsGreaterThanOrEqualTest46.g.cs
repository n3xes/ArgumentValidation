using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest46.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanOrEqualTest46ThrowsArgumentNullException839()
{
	this.RequireArgumentIsGreaterThanOrEqualTest46
		(new ushort?((ushort)65), (string)null, (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest46ThrowsArgumentOutOfRangeException129()
{
	this.RequireArgumentIsGreaterThanOrEqualTest46
		(new ushort?((ushort)65), "", (ushort)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanOrEqualTest46384()
{
	this.RequireArgumentIsGreaterThanOrEqualTest46
		(new ushort?((ushort)65), "\0", (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanOrEqualTest46268()
{
	this.RequireArgumentIsGreaterThanOrEqualTest46
		(default(ushort?), "\0", (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest46ThrowsArgumentOutOfRangeException489()
{
	this.RequireArgumentIsGreaterThanOrEqualTest46
		(new ushort?((ushort)0), "\0", (ushort)33);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanOrEqualTest46884()
{
	this.RequireArgumentIsGreaterThanOrEqualTest46
		(new ushort?((ushort)65), "Ā", (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest46ThrowsArgumentOutOfRangeException435()
{
	this.RequireArgumentIsGreaterThanOrEqualTest46
		(new ushort?((ushort)65), "\t", (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest46ThrowsArgumentOutOfRangeException884()
{
	this.RequireArgumentIsGreaterThanOrEqualTest46
		(new ushort?((ushort)65), "\t\t", (ushort)64);
}
	}
}
