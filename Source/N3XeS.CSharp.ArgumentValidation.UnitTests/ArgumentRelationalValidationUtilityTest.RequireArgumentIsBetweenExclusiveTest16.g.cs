using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsBetweenExclusiveTest16.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest16ThrowsArgumentNullException573()
{
	this.RequireArgumentIsBetweenExclusiveTest16
		(default(decimal), (string)null, default(decimal), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest16ThrowsArgumentOutOfRangeException72()
{
	this.RequireArgumentIsBetweenExclusiveTest16
		(default(decimal), "", default(decimal), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest16ThrowsArgumentOutOfRangeException590()
{
	this.RequireArgumentIsBetweenExclusiveTest16
		(default(decimal), "\0", default(decimal), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest16ThrowsArgumentOutOfRangeException280()
{
	this.RequireArgumentIsBetweenExclusiveTest16
		(-76819052936496198642298613574e-19M, "\0", default(decimal), 1M);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenExclusiveTest16183()
{
	this.RequireArgumentIsBetweenExclusiveTest16
		(177519435M, "\0", 1e-1M, 47783165704927611543839379711e-17M);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest16ThrowsArgumentOutOfRangeException304()
{
	this.RequireArgumentIsBetweenExclusiveTest16
		(default(decimal), "Ā", default(decimal), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest16ThrowsArgumentOutOfRangeException32()
{
	this.RequireArgumentIsBetweenExclusiveTest16
		(default(decimal), "\t", default(decimal), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest16ThrowsArgumentOutOfRangeException227()
{
	this.RequireArgumentIsBetweenExclusiveTest16
		(default(decimal), "\t\0", default(decimal), default(decimal));
}
	}
}
