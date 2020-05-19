using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsOutsideTest86.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideTest86ThrowsArgumentNullException900()
{
	this.RequireArgumentIsOutsideTest86
		(new ulong?(1uL), (string)null, new ulong?(1uL), 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest86ThrowsArgumentOutOfRangeException654()
{
	this.RequireArgumentIsOutsideTest86(new ulong?(1uL), "", new ulong?(1uL), 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest86806()
{
	this.RequireArgumentIsOutsideTest86(new ulong?(1uL), "\0", new ulong?(1uL), 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest86ThrowsArgumentOutOfRangeException909()
{
	this.RequireArgumentIsOutsideTest86(new ulong?(3uL), "\0", new ulong?(2uL), 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest86ThrowsArgumentOutOfRangeException230()
{
	this.RequireArgumentIsOutsideTest86
		(new ulong?(1uL), "\0", new ulong?(9223372036854775808uL), 2uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest86174()
{
	this.RequireArgumentIsOutsideTest86(new ulong?(1uL), "Ā", new ulong?(1uL), 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest86393()
{
	this.RequireArgumentIsOutsideTest86(new ulong?(1uL), "Ā", default(ulong?), 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest86ThrowsArgumentOutOfRangeException590()
{
	this.RequireArgumentIsOutsideTest86(new ulong?(1uL), "\t", new ulong?(1uL), 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest86681()
{
	this.RequireArgumentIsOutsideTest86(default(ulong?), "Ā", new ulong?(1uL), 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest86446()
{
	this.RequireArgumentIsOutsideTest86
		(new ulong?(1uL), "\t\0", new ulong?(1uL), 0uL);
}
	}
}
