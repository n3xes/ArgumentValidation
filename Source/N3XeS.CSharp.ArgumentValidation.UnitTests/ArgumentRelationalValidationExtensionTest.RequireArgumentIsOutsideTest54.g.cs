using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest54.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideTest54ThrowsArgumentNullException919()
{
	this.RequireArgumentIsOutsideTest54
		(new long?(1L), (string)null, new long?(1L), 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest54ThrowsArgumentOutOfRangeException915()
{
	this.RequireArgumentIsOutsideTest54(new long?(1L), "", new long?(1L), 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest54806()
{
	this.RequireArgumentIsOutsideTest54(new long?(1L), "\0", new long?(1L), 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest54ThrowsArgumentOutOfRangeException825()
{
	this.RequireArgumentIsOutsideTest54(new long?(3L), "\0", new long?(2L), 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest54ThrowsArgumentOutOfRangeException591()
{
	this.RequireArgumentIsOutsideTest54
		(new long?(-9223372036854775805L), "\0", new long?(2L), 6L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest54174()
{
	this.RequireArgumentIsOutsideTest54(new long?(1L), "Ā", new long?(1L), 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest54393()
{
	this.RequireArgumentIsOutsideTest54(new long?(1L), "Ā", default(long?), 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest54ThrowsArgumentOutOfRangeException455()
{
	this.RequireArgumentIsOutsideTest54(new long?(1L), "\t", new long?(1L), 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest54681()
{
	this.RequireArgumentIsOutsideTest54(default(long?), "Ā", new long?(1L), 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest54446()
{
	this.RequireArgumentIsOutsideTest54(new long?(1L), "\t\0", new long?(1L), 0L);
}
	}
}
