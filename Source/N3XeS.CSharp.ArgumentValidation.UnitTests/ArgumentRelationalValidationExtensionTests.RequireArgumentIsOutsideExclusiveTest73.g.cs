using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsOutsideExclusiveTest73.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest73ThrowsArgumentNullException964()
{
	this.RequireArgumentIsOutsideExclusiveTest73
		(1u, (string)null, 1u, default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest73ThrowsArgumentOutOfRangeException681()
{
	this.RequireArgumentIsOutsideExclusiveTest73(1u, "", 1u, default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest73ThrowsArgumentOutOfRangeException891()
{
	this.RequireArgumentIsOutsideExclusiveTest73(1u, "\0", 1u, default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest73ThrowsArgumentOutOfRangeException821()
{
	this.RequireArgumentIsOutsideExclusiveTest73(1u, "\0", 1u, new uint?(0u));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideExclusiveTest73968()
{
	this.RequireArgumentIsOutsideExclusiveTest73(3u, "\0", 2u, default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest73ThrowsArgumentOutOfRangeException963()
{
	this.RequireArgumentIsOutsideExclusiveTest73(1u, "Ā", 1u, default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest73ThrowsArgumentOutOfRangeException405()
{
	this.RequireArgumentIsOutsideExclusiveTest73(1u, "\t", 1u, default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest73ThrowsArgumentOutOfRangeException662()
{
	this.RequireArgumentIsOutsideExclusiveTest73(1u, "\t\0", 1u, default(uint?));
}
	}
}
