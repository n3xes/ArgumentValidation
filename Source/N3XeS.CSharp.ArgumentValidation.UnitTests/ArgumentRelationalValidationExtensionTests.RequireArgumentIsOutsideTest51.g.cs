using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsOutsideTest51.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideTest51ThrowsArgumentNullException748()
{
	this.RequireArgumentIsOutsideTest51
		(0L, (string)null, new long?(1L), new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest51ThrowsArgumentOutOfRangeException387()
{
	this.RequireArgumentIsOutsideTest51(0L, "", new long?(1L), new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest51ThrowsArgumentOutOfRangeException245()
{
	this.RequireArgumentIsOutsideTest51(0L, "\0", new long?(1L), new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest51502()
{
	this.RequireArgumentIsOutsideTest51(0L, "\0", new long?(1L), default(long?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest51ThrowsArgumentOutOfRangeException544()
{
	this.RequireArgumentIsOutsideTest51(0L, "Ā", new long?(1L), new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest51ThrowsArgumentOutOfRangeException185()
{
	this.RequireArgumentIsOutsideTest51(3L, "Ā", new long?(2L), new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest51ThrowsArgumentOutOfRangeException30()
{
	this.RequireArgumentIsOutsideTest51(0L, "\t", new long?(1L), new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest51ThrowsArgumentOutOfRangeException540()
{
	this.RequireArgumentIsOutsideTest51(0L, "Ā", default(long?), new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest51ThrowsArgumentOutOfRangeException593()
{
	this.RequireArgumentIsOutsideTest51(0L, "\t\0", new long?(2L), new long?(1L));
}
	}
}
