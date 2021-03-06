using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsOutsideExclusiveTest86.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest86ThrowsArgumentNullException931()
{
	this.RequireArgumentIsOutsideExclusiveTest86
		(new ulong?(1uL), (string)null, new ulong?(1uL), 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest86ThrowsArgumentOutOfRangeException988()
{
	this.RequireArgumentIsOutsideExclusiveTest86
		(new ulong?(1uL), "", new ulong?(1uL), 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest86ThrowsArgumentOutOfRangeException32()
{
	this.RequireArgumentIsOutsideExclusiveTest86
		(new ulong?(1uL), "\0", new ulong?(1uL), 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideExclusiveTest86648()
{
	this.RequireArgumentIsOutsideExclusiveTest86
		(default(ulong?), "\0", new ulong?(1uL), 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideExclusiveTest86615()
{
	this.RequireArgumentIsOutsideExclusiveTest86
		(new ulong?(2uL), "\0", new ulong?(1uL), 3uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest86ThrowsArgumentOutOfRangeException54()
{
	this.RequireArgumentIsOutsideExclusiveTest86
		(new ulong?(0uL), "\0", new ulong?(1uL), 1uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest86ThrowsArgumentOutOfRangeException316()
{
	this.RequireArgumentIsOutsideExclusiveTest86
		(new ulong?(1uL), "Ā", new ulong?(1uL), 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest86ThrowsArgumentOutOfRangeException595()
{
	this.RequireArgumentIsOutsideExclusiveTest86
		(new ulong?(1uL), "\t", new ulong?(1uL), 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest86ThrowsArgumentOutOfRangeException176()
{
	this.RequireArgumentIsOutsideExclusiveTest86
		(new ulong?(1uL), "\t\0", new ulong?(1uL), 0uL);
}
	}
}
