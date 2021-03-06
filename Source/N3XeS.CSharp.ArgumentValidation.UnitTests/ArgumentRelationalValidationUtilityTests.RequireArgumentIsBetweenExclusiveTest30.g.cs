using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsBetweenExclusiveTest30.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest30ThrowsArgumentNullException289()
{
	this.RequireArgumentIsBetweenExclusiveTest30
		(new double?(0), (string)null, new double?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest30ThrowsArgumentOutOfRangeException240()
{
	this.RequireArgumentIsBetweenExclusiveTest30
		(new double?(0), "", new double?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest30ThrowsArgumentOutOfRangeException61()
{
	this.RequireArgumentIsBetweenExclusiveTest30
		(new double?(0), "\0", new double?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenExclusiveTest30648()
{
	this.RequireArgumentIsBetweenExclusiveTest30
		(default(double?), "\0", new double?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest30ThrowsArgumentOutOfRangeException192()
{
	this.RequireArgumentIsBetweenExclusiveTest30
		(new double?(-1), "\0", new double?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest30ThrowsArgumentOutOfRangeException542()
{
	this.RequireArgumentIsBetweenExclusiveTest30
		(new double?(0), "Ā", new double?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest30ThrowsArgumentOutOfRangeException833()
{
	this.RequireArgumentIsBetweenExclusiveTest30
		(new double?(0), "\t", new double?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest30ThrowsArgumentOutOfRangeException529()
{
	this.RequireArgumentIsBetweenExclusiveTest30
		(new double?(0), "\t\0", new double?(1), 0);
}
	}
}
