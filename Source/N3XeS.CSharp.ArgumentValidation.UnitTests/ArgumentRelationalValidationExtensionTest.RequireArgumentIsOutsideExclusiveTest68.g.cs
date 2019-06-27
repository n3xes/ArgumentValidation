using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest68.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest68ThrowsArgumentNullException787()
{
	this.RequireArgumentIsOutsideExclusiveTest68
		(new short?((short)65), (string)null, (short)32, (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest68ThrowsArgumentOutOfRangeException654()
{
	this.RequireArgumentIsOutsideExclusiveTest68
		(new short?((short)65), "", (short)32, (short)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest68ThrowsArgumentOutOfRangeException569()
{
	this.RequireArgumentIsOutsideExclusiveTest68
		(new short?((short)65), "\0", (short)32, (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideExclusiveTest68684()
{
	this.RequireArgumentIsOutsideExclusiveTest68
		(default(short?), "\0", (short)32, (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideExclusiveTest68930()
{
	this.RequireArgumentIsOutsideExclusiveTest68
		(new short?((short)80), "\0", (short)32, (short)81);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest68ThrowsArgumentOutOfRangeException610()
{
	this.RequireArgumentIsOutsideExclusiveTest68
		(new short?((short)0), "\0", (short)65, (short)33);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest68ThrowsArgumentOutOfRangeException834()
{
	this.RequireArgumentIsOutsideExclusiveTest68
		(new short?((short)65), "Ā", (short)32, (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest68ThrowsArgumentOutOfRangeException134()
{
	this.RequireArgumentIsOutsideExclusiveTest68
		(new short?((short)65), "\t", (short)32, (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest68ThrowsArgumentOutOfRangeException86()
{
	this.RequireArgumentIsOutsideExclusiveTest68
		(new short?((short)65), "\t\0", (short)32, (short)64);
}
	}
}
