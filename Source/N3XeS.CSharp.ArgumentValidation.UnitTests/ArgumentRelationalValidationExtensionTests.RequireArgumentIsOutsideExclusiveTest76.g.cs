using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsOutsideExclusiveTest76.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest76ThrowsArgumentNullException736()
{
	this.RequireArgumentIsOutsideExclusiveTest76
		(new uint?(64u), (string)null, 0u, 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest76ThrowsArgumentOutOfRangeException695()
{
	this.RequireArgumentIsOutsideExclusiveTest76(new uint?(1u), "", 0u, 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest76ThrowsArgumentOutOfRangeException432()
{
	this.RequireArgumentIsOutsideExclusiveTest76(new uint?(1u), "\0", 0u, 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideExclusiveTest76760()
{
	this.RequireArgumentIsOutsideExclusiveTest76(default(uint?), "\0", 0u, 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideExclusiveTest76824()
{
	this.RequireArgumentIsOutsideExclusiveTest76(new uint?(16u), "\0", 0u, 17u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest76ThrowsArgumentOutOfRangeException579()
{
	this.RequireArgumentIsOutsideExclusiveTest76(new uint?(0u), "\0", 1u, 1u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest76ThrowsArgumentOutOfRangeException870()
{
	this.RequireArgumentIsOutsideExclusiveTest76(new uint?(1u), "Ā", 0u, 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest76ThrowsArgumentOutOfRangeException66()
{
	this.RequireArgumentIsOutsideExclusiveTest76(new uint?(1u), "\t", 0u, 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest76ThrowsArgumentOutOfRangeException385()
{
	this.RequireArgumentIsOutsideExclusiveTest76(new uint?(1u), "\t\0", 0u, 0u);
}
	}
}
