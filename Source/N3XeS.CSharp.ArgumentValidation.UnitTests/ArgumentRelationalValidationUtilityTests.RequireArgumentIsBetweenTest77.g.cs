using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsBetweenTest77.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest77ThrowsArgumentNullException591()
{
	this.RequireArgumentIsBetweenTest77
		(default(uint?), (string)null, 1u, default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest77ThrowsArgumentOutOfRangeException754()
{
	this.RequireArgumentIsBetweenTest77(default(uint?), "", 1u, default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest7780()
{
	this.RequireArgumentIsBetweenTest77(default(uint?), "\0", 1u, default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest77ThrowsArgumentOutOfRangeException140()
{
	this.RequireArgumentIsBetweenTest77(new uint?(0u), "\0", 1u, default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest77870()
{
	this.RequireArgumentIsBetweenTest77(default(uint?), "Ȁ", 1u, default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest77ThrowsArgumentOutOfRangeException301()
{
	this.RequireArgumentIsBetweenTest77(new uint?(0u), "\0", 1u, new uint?(0u));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest77ThrowsArgumentOutOfRangeException517()
{
	this.RequireArgumentIsBetweenTest77(default(uint?), "\t", 1u, default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest77ThrowsArgumentOutOfRangeException38()
{
	this.RequireArgumentIsBetweenTest77(new uint?(1u), "\0", 1u, new uint?(0u));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest77702()
{
	this.RequireArgumentIsBetweenTest77(default(uint?), "\t\0", 1u, default(uint?));
}
	}
}
