using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest84.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest84ThrowsArgumentNullException568()
{
	this.RequireArgumentIsOutsideExclusiveTest84
		(new ulong?(1uL), (string)null, 0uL, 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest84ThrowsArgumentOutOfRangeException65()
{
	this.RequireArgumentIsOutsideExclusiveTest84(new ulong?(1uL), "", 0uL, 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest84ThrowsArgumentOutOfRangeException903()
{
	this.RequireArgumentIsOutsideExclusiveTest84(new ulong?(1uL), "\0", 0uL, 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideExclusiveTest84760()
{
	this.RequireArgumentIsOutsideExclusiveTest84(default(ulong?), "\0", 0uL, 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideExclusiveTest844()
{
	this.RequireArgumentIsOutsideExclusiveTest84(new ulong?(2uL), "\0", 0uL, 3uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest84ThrowsArgumentOutOfRangeException476()
{
	this.RequireArgumentIsOutsideExclusiveTest84(new ulong?(0uL), "\0", 0uL, 1uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest84ThrowsArgumentOutOfRangeException417()
{
	this.RequireArgumentIsOutsideExclusiveTest84(new ulong?(1uL), "Ā", 0uL, 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest84ThrowsArgumentOutOfRangeException375()
{
	this.RequireArgumentIsOutsideExclusiveTest84(new ulong?(1uL), "\t", 0uL, 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest84ThrowsArgumentOutOfRangeException979()
{
	this.RequireArgumentIsOutsideExclusiveTest84(new ulong?(1uL), "\t\0", 0uL, 0uL);
}
	}
}
