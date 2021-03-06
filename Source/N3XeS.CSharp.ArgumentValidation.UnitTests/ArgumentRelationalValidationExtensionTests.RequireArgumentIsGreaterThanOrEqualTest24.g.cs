using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsGreaterThanOrEqualTest24.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanOrEqualTest24ThrowsArgumentNullException44()
{
	this.RequireArgumentIsGreaterThanOrEqualTest24(0L, (string)null, 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest24ThrowsArgumentOutOfRangeException139()
{
	this.RequireArgumentIsGreaterThanOrEqualTest24(0L, "", 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsGreaterThanOrEqualTest24563()
{
	this.RequireArgumentIsGreaterThanOrEqualTest24(0L, "\0", 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest24ThrowsArgumentOutOfRangeException996()
{
	this.RequireArgumentIsGreaterThanOrEqualTest24(0L, "\0", 1L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsGreaterThanOrEqualTest2434()
{
	this.RequireArgumentIsGreaterThanOrEqualTest24(0L, "Ā", 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest24ThrowsArgumentOutOfRangeException850()
{
	this.RequireArgumentIsGreaterThanOrEqualTest24(0L, "\t", 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest24ThrowsArgumentOutOfRangeException107()
{
	this.RequireArgumentIsGreaterThanOrEqualTest24(0L, "\t\t", 0L);
}
	}
}
