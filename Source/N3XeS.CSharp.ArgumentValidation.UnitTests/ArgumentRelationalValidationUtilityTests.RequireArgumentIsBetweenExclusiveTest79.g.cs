using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsBetweenExclusiveTest79.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentRelationalValidationUtilityTests
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsBetweenExclusiveTest79ThrowsArgumentNullException225()
{
	this.RequireArgumentIsBetweenExclusiveTest79
		(default(uint?), (string)null, default(uint?), default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest79ThrowsArgumentOutOfRangeException132()
{
	this.RequireArgumentIsBetweenExclusiveTest79
		(default(uint?), "", default(uint?), default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenExclusiveTest79668()
{
	this.RequireArgumentIsBetweenExclusiveTest79
		(default(uint?), "\0", default(uint?), default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenExclusiveTest79716()
{
	this.RequireArgumentIsBetweenExclusiveTest79
		(new uint?(0u), "\0", default(uint?), default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest79ThrowsArgumentOutOfRangeException265()
{
	this.RequireArgumentIsBetweenExclusiveTest79
		(new uint?(0u), "\0", new uint?(0u), default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest79ThrowsArgumentOutOfRangeException737()
{
	this.RequireArgumentIsBetweenExclusiveTest79
		(new uint?(0u), "\0", default(uint?), new uint?(0u));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenExclusiveTest79703()
{
	this.RequireArgumentIsBetweenExclusiveTest79
		(default(uint?), "Ā", default(uint?), default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest79ThrowsArgumentOutOfRangeException690()
{
	this.RequireArgumentIsBetweenExclusiveTest79
		(default(uint?), "\t", default(uint?), default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenExclusiveTest79166()
{
	this.RequireArgumentIsBetweenExclusiveTest79
		(default(uint?), "\t\0", default(uint?), default(uint?));
}
	}
}
