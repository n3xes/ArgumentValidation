using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsBetweenExclusiveTest20.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest20ThrowsArgumentNullException274()
{
	this.RequireArgumentIsBetweenExclusiveTest20
		(new decimal?(0e-4M), (string)null, default(decimal), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest20ThrowsArgumentOutOfRangeException303()
{
	this.RequireArgumentIsBetweenExclusiveTest20
		(new decimal?(0e-4M), "", default(decimal), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest20ThrowsArgumentOutOfRangeException285()
{
	this.RequireArgumentIsBetweenExclusiveTest20
		(new decimal?(0e-4M), "\0", default(decimal), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenExclusiveTest20760()
{
	this.RequireArgumentIsBetweenExclusiveTest20
		(default(decimal?), "\0", default(decimal), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest20ThrowsArgumentOutOfRangeException496()
{
	this.RequireArgumentIsBetweenExclusiveTest20
		(new decimal?(-76819052936496198642298613574e-19M), "\0", 
		 default(decimal), 1M);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest20ThrowsArgumentOutOfRangeException473()
{
	this.RequireArgumentIsBetweenExclusiveTest20
		(new decimal?(0e-4M), "Ā", default(decimal), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest20ThrowsArgumentOutOfRangeException662()
{
	this.RequireArgumentIsBetweenExclusiveTest20
		(new decimal?(0e-4M), "\t", default(decimal), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest20ThrowsArgumentOutOfRangeException694()
{
	this.RequireArgumentIsBetweenExclusiveTest20
		(new decimal?(0e-4M), "\t\0", default(decimal), default(decimal));
}
	}
}
