using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsLessThanOrEqualTest24.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsLessThanOrEqualTest24ThrowsArgumentNullException264()
{
	this.RequireArgumentIsLessThanOrEqualTest24(0L, (string)null, 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest24ThrowsArgumentOutOfRangeException144()
{
	this.RequireArgumentIsLessThanOrEqualTest24(0L, "", 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsLessThanOrEqualTest24817()
{
	this.RequireArgumentIsLessThanOrEqualTest24(0L, "\0", 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest24ThrowsArgumentOutOfRangeException689()
{
	this.RequireArgumentIsLessThanOrEqualTest24(1L, "\0", 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsLessThanOrEqualTest24370()
{
	this.RequireArgumentIsLessThanOrEqualTest24(0L, "Ā", 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest24ThrowsArgumentOutOfRangeException782()
{
	this.RequireArgumentIsLessThanOrEqualTest24(0L, "\t", 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest24ThrowsArgumentOutOfRangeException348()
{
	this.RequireArgumentIsLessThanOrEqualTest24(0L, "\t\t", 0L);
}
	}
}
