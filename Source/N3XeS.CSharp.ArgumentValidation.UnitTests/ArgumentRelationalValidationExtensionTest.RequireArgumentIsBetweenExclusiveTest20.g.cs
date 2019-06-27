using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest20.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest20ThrowsArgumentNullException839()
{
	this.RequireArgumentIsBetweenExclusiveTest20
		(new decimal?(0e-4M), (string)null, default(decimal), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest20ThrowsArgumentOutOfRangeException244()
{
	this.RequireArgumentIsBetweenExclusiveTest20
		(new decimal?(0e-4M), "", default(decimal), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest20ThrowsArgumentOutOfRangeException47()
{
	this.RequireArgumentIsBetweenExclusiveTest20
		(new decimal?(0e-4M), "\0", default(decimal), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenExclusiveTest20760()
{
	this.RequireArgumentIsBetweenExclusiveTest20
		(default(decimal?), "\0", default(decimal), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest20ThrowsArgumentOutOfRangeException143()
{
	this.RequireArgumentIsBetweenExclusiveTest20
		(new decimal?(-76819052936496198642298613574e-19M), "\0", 
		 default(decimal), 1M);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest20ThrowsArgumentOutOfRangeException34()
{
	this.RequireArgumentIsBetweenExclusiveTest20
		(new decimal?(0e-4M), "Ā", default(decimal), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest20ThrowsArgumentOutOfRangeException929()
{
	this.RequireArgumentIsBetweenExclusiveTest20
		(new decimal?(0e-4M), "\t", default(decimal), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest20ThrowsArgumentOutOfRangeException305()
{
	this.RequireArgumentIsBetweenExclusiveTest20
		(new decimal?(0e-4M), "\t\0", default(decimal), default(decimal));
}
	}
}
