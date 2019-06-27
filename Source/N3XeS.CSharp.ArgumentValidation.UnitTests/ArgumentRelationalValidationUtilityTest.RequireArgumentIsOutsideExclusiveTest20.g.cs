using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsOutsideExclusiveTest20.g.cs">Copyright © N3XeS LLC 2016</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace N3XeS.CSharp.ArgumentValidation.Utilities.UnitTests
{
	public partial class ArgumentRelationalValidationUtilityTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsOutsideExclusiveTest20ThrowsArgumentNullException772()
{
	this.RequireArgumentIsOutsideExclusiveTest20
		(new decimal?(0e-4M), (string)null, default(decimal), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest20ThrowsArgumentOutOfRangeException546()
{
	this.RequireArgumentIsOutsideExclusiveTest20
		(new decimal?(0e-4M), "", default(decimal), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest20ThrowsArgumentOutOfRangeException16()
{
	this.RequireArgumentIsOutsideExclusiveTest20
		(new decimal?(0e-4M), "\0", default(decimal), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideExclusiveTest20760()
{
	this.RequireArgumentIsOutsideExclusiveTest20
		(default(decimal?), "\0", default(decimal), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest20ThrowsArgumentOutOfRangeException866()
{
	this.RequireArgumentIsOutsideExclusiveTest20
		(new decimal?(-76819052936496198642298613574e-19M), "\0", 
		 default(decimal), 1M);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest20ThrowsArgumentOutOfRangeException947()
{
	this.RequireArgumentIsOutsideExclusiveTest20
		(new decimal?(0e-4M), "Ā", default(decimal), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest20ThrowsArgumentOutOfRangeException840()
{
	this.RequireArgumentIsOutsideExclusiveTest20
		(new decimal?(0e-4M), "\t", default(decimal), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest20ThrowsArgumentOutOfRangeException252()
{
	this.RequireArgumentIsOutsideExclusiveTest20
		(new decimal?(0e-4M), "\t\0", default(decimal), default(decimal));
}
	}
}
