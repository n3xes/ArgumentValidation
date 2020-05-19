using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsBetweenExclusiveTest25.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest25ThrowsArgumentNullException842()
{
	this.RequireArgumentIsBetweenExclusiveTest25(0, (string)null, 0, new double?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest25ThrowsArgumentOutOfRangeException598()
{
	this.RequireArgumentIsBetweenExclusiveTest25(0, "", 0, new double?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest25ThrowsArgumentOutOfRangeException257()
{
	this.RequireArgumentIsBetweenExclusiveTest25(0, "\0", 0, new double?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest25ThrowsArgumentOutOfRangeException45()
{
	this.RequireArgumentIsBetweenExclusiveTest25(0, "\0", 0, default(double?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest25ThrowsArgumentOutOfRangeException766()
{
	this.RequireArgumentIsBetweenExclusiveTest25(0, "Ā", 0, new double?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenExclusiveTest25579()
{
	this.RequireArgumentIsBetweenExclusiveTest25(1, "\0", 0, default(double?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest25ThrowsArgumentOutOfRangeException303()
{
	this.RequireArgumentIsBetweenExclusiveTest25(0, "\t", 0, new double?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest25ThrowsArgumentOutOfRangeException326()
{
	this.RequireArgumentIsBetweenExclusiveTest25(0, "\n\0", 0, new double?(0));
}
	}
}
