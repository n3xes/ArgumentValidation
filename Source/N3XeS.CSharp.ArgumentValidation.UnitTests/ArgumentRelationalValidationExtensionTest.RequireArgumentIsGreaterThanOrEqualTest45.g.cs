using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest45.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanOrEqualTest45ThrowsArgumentNullException725()
{
	this.RequireArgumentIsGreaterThanOrEqualTest45
		((ushort)65, (string)null, default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest45ThrowsArgumentOutOfRangeException533()
{
	this.RequireArgumentIsGreaterThanOrEqualTest45((ushort)65, "", default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanOrEqualTest45208()
{
	this.RequireArgumentIsGreaterThanOrEqualTest45
		((ushort)65, "\0", default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanOrEqualTest45933()
{
	this.RequireArgumentIsGreaterThanOrEqualTest45
		((ushort)65, "\0", new ushort?((ushort)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest45ThrowsArgumentOutOfRangeException269()
{
	this.RequireArgumentIsGreaterThanOrEqualTest45
		((ushort)32, "\0", new ushort?((ushort)33));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanOrEqualTest45884()
{
	this.RequireArgumentIsGreaterThanOrEqualTest45
		((ushort)65, "Ā", default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest45ThrowsArgumentOutOfRangeException420()
{
	this.RequireArgumentIsGreaterThanOrEqualTest45
		((ushort)65, "\t", default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest45ThrowsArgumentOutOfRangeException589()
{
	this.RequireArgumentIsGreaterThanOrEqualTest45
		((ushort)65, "\n\t", default(ushort?));
}
	}
}
