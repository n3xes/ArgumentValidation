using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsGreaterThanTest46.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentRelationalValidationExtensionTests
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsGreaterThanTest46ThrowsArgumentNullException968()
{
	this.RequireArgumentIsGreaterThanTest46
		(new ushort?((ushort)65), (string)null, (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest46ThrowsArgumentOutOfRangeException934()
{
	this.RequireArgumentIsGreaterThanTest46(new ushort?((ushort)65), "", (ushort)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsGreaterThanTest46384()
{
	this.RequireArgumentIsGreaterThanTest46
		(new ushort?((ushort)65), "\0", (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsGreaterThanTest46268()
{
	this.RequireArgumentIsGreaterThanTest46(default(ushort?), "\0", (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest46ThrowsArgumentOutOfRangeException32()
{
	this.RequireArgumentIsGreaterThanTest46
		(new ushort?((ushort)0), "\0", (ushort)33);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsGreaterThanTest46884()
{
	this.RequireArgumentIsGreaterThanTest46
		(new ushort?((ushort)65), "Ā", (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest46ThrowsArgumentOutOfRangeException636()
{
	this.RequireArgumentIsGreaterThanTest46
		(new ushort?((ushort)65), "\t", (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest46ThrowsArgumentOutOfRangeException404()
{
	this.RequireArgumentIsGreaterThanTest46
		(new ushort?((ushort)65), "\t\t", (ushort)64);
}
	}
}
