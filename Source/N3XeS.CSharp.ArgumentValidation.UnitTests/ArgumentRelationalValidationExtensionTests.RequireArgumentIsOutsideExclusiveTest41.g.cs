using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsOutsideExclusiveTest41.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest41ThrowsArgumentNullException745()
{
	this.RequireArgumentIsOutsideExclusiveTest41(1, (string)null, 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest41ThrowsArgumentOutOfRangeException837()
{
	this.RequireArgumentIsOutsideExclusiveTest41(1, "", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest41ThrowsArgumentOutOfRangeException667()
{
	this.RequireArgumentIsOutsideExclusiveTest41(1, "\0", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest41ThrowsArgumentOutOfRangeException628()
{
	this.RequireArgumentIsOutsideExclusiveTest41(1, "\0", 1, new int?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideExclusiveTest41968()
{
	this.RequireArgumentIsOutsideExclusiveTest41(3, "\0", 2, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest41ThrowsArgumentOutOfRangeException677()
{
	this.RequireArgumentIsOutsideExclusiveTest41(1, "Ā", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest41ThrowsArgumentOutOfRangeException59()
{
	this.RequireArgumentIsOutsideExclusiveTest41(1, "\t", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest41ThrowsArgumentOutOfRangeException925()
{
	this.RequireArgumentIsOutsideExclusiveTest41(1, "\t\0", 1, default(int?));
}
	}
}
