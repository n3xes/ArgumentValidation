using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsBetweenExclusiveTest78.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest78ThrowsArgumentNullException155()
{
	this.RequireArgumentIsBetweenExclusiveTest78
		(new uint?(512u), (string)null, new uint?(1u), 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest78ThrowsArgumentOutOfRangeException332()
{
	this.RequireArgumentIsBetweenExclusiveTest78
		(new uint?(1u), "", new uint?(1u), 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest78ThrowsArgumentOutOfRangeException620()
{
	this.RequireArgumentIsBetweenExclusiveTest78
		(new uint?(1u), "\0", new uint?(1u), 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenExclusiveTest78648()
{
	this.RequireArgumentIsBetweenExclusiveTest78
		(default(uint?), "\0", new uint?(1u), 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest78ThrowsArgumentOutOfRangeException945()
{
	this.RequireArgumentIsBetweenExclusiveTest78
		(new uint?(0u), "\0", new uint?(1u), 1u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest78ThrowsArgumentOutOfRangeException70()
{
	this.RequireArgumentIsBetweenExclusiveTest78
		(new uint?(2u), "耀", new uint?(1u), 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest78ThrowsArgumentOutOfRangeException692()
{
	this.RequireArgumentIsBetweenExclusiveTest78
		(new uint?(1u), "\t", new uint?(1u), 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest78ThrowsArgumentOutOfRangeException988()
{
	this.RequireArgumentIsBetweenExclusiveTest78
		(new uint?(1u), "\t\0", new uint?(1u), 0u);
}
	}
}
