using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest68.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideTest68ThrowsArgumentNullException147()
{
	this.RequireArgumentIsOutsideTest68
		(new short?((short)65), (string)null, (short)32, (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest68ThrowsArgumentOutOfRangeException868()
{
	this.RequireArgumentIsOutsideTest68
		(new short?((short)65), "", (short)32, (short)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest68ThrowsArgumentOutOfRangeException115()
{
	this.RequireArgumentIsOutsideTest68
		(new short?((short)65), "\0", (short)32, (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest68684()
{
	this.RequireArgumentIsOutsideTest68(default(short?), "\0", (short)32, (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest68ThrowsArgumentOutOfRangeException543()
{
	this.RequireArgumentIsOutsideTest68
		(new short?((short)33), "\0", (short)64, (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest68ThrowsArgumentOutOfRangeException552()
{
	this.RequireArgumentIsOutsideTest68
		(new short?((short)65), "Ā", (short)32, (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest68ThrowsArgumentOutOfRangeException398()
{
	this.RequireArgumentIsOutsideTest68
		(new short?((short)65), "\t", (short)32, (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest68ThrowsArgumentOutOfRangeException100()
{
	this.RequireArgumentIsOutsideTest68
		(new short?((short)65), "\t\0", (short)32, (short)64);
}
	}
}
