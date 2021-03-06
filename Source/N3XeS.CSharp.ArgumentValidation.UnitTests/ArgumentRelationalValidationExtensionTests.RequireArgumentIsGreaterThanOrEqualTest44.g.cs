using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsGreaterThanOrEqualTest44.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanOrEqualTest44ThrowsArgumentNullException248()
{
	this.RequireArgumentIsGreaterThanOrEqualTest44
		((ushort)32, (string)null, (ushort)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest44ThrowsArgumentOutOfRangeException730()
{
	this.RequireArgumentIsGreaterThanOrEqualTest44((ushort)32, "", (ushort)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsGreaterThanOrEqualTest44866()
{
	this.RequireArgumentIsGreaterThanOrEqualTest44((ushort)32, "\0", (ushort)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest44ThrowsArgumentOutOfRangeException352()
{
	this.RequireArgumentIsGreaterThanOrEqualTest44((ushort)32, "\0", (ushort)33);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsGreaterThanOrEqualTest44762()
{
	this.RequireArgumentIsGreaterThanOrEqualTest44((ushort)32, "Ā", (ushort)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest44ThrowsArgumentOutOfRangeException640()
{
	this.RequireArgumentIsGreaterThanOrEqualTest44((ushort)32, "\t", (ushort)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest44ThrowsArgumentOutOfRangeException652()
{
	this.RequireArgumentIsGreaterThanOrEqualTest44((ushort)32, "\t\t", (ushort)32);
}
	}
}
