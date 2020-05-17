using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest08.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest08ThrowsArgumentNullException189()
{
	this.RequireArgumentIsOutsideExclusiveTest08
		((byte)0, (string)null, (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest08ThrowsArgumentOutOfRangeException573()
{
	this.RequireArgumentIsOutsideExclusiveTest08((byte)0, "", (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest08ThrowsArgumentOutOfRangeException854()
{
	this.RequireArgumentIsOutsideExclusiveTest08((byte)0, "\0", (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest08ThrowsArgumentOutOfRangeException641()
{
	this.RequireArgumentIsOutsideExclusiveTest08((byte)0, "\0", (byte)0, (byte)1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideExclusiveTest0840()
{
	this.RequireArgumentIsOutsideExclusiveTest08((byte)4, "\0", (byte)0, (byte)5);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest08ThrowsArgumentOutOfRangeException322()
{
	this.RequireArgumentIsOutsideExclusiveTest08((byte)0, "Ā", (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest08ThrowsArgumentOutOfRangeException28()
{
	this.RequireArgumentIsOutsideExclusiveTest08((byte)0, "\t", (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest08ThrowsArgumentOutOfRangeException994()
{
	this.RequireArgumentIsOutsideExclusiveTest08((byte)0, "\t\0", (byte)0, (byte)0);
}
	}
}
