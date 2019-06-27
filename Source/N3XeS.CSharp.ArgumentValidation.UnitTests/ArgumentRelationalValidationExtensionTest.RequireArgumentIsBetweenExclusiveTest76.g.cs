using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest76.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest76ThrowsArgumentNullException17()
{
	this.RequireArgumentIsBetweenExclusiveTest76
		(new uint?(64u), (string)null, 0u, 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest76ThrowsArgumentOutOfRangeException675()
{
	this.RequireArgumentIsBetweenExclusiveTest76(new uint?(1u), "", 0u, 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest76ThrowsArgumentOutOfRangeException306()
{
	this.RequireArgumentIsBetweenExclusiveTest76(new uint?(1u), "\0", 0u, 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenExclusiveTest76760()
{
	this.RequireArgumentIsBetweenExclusiveTest76(default(uint?), "\0", 0u, 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenExclusiveTest76824()
{
	this.RequireArgumentIsBetweenExclusiveTest76(new uint?(16u), "\0", 0u, 17u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest76ThrowsArgumentOutOfRangeException6()
{
	this.RequireArgumentIsBetweenExclusiveTest76(new uint?(0u), "\0", 1u, 1u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest76ThrowsArgumentOutOfRangeException314()
{
	this.RequireArgumentIsBetweenExclusiveTest76(new uint?(1u), "Ā", 0u, 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest76ThrowsArgumentOutOfRangeException856()
{
	this.RequireArgumentIsBetweenExclusiveTest76(new uint?(1u), "\t", 0u, 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest76ThrowsArgumentOutOfRangeException673()
{
	this.RequireArgumentIsBetweenExclusiveTest76(new uint?(1u), "\t\0", 0u, 0u);
}
	}
}
