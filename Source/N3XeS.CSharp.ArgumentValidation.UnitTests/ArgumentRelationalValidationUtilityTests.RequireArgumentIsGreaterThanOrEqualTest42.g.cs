using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsGreaterThanOrEqualTest42.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanOrEqualTest42ThrowsArgumentNullException886()
{
	this.RequireArgumentIsGreaterThanOrEqualTest42
		(new ulong?(1uL), (string)null, 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest42ThrowsArgumentOutOfRangeException282()
{
	this.RequireArgumentIsGreaterThanOrEqualTest42(new ulong?(1uL), "", 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsGreaterThanOrEqualTest42223()
{
	this.RequireArgumentIsGreaterThanOrEqualTest42(new ulong?(1uL), "\0", 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsGreaterThanOrEqualTest4239()
{
	this.RequireArgumentIsGreaterThanOrEqualTest42(default(ulong?), "\0", 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest42ThrowsArgumentOutOfRangeException513()
{
	this.RequireArgumentIsGreaterThanOrEqualTest42(new ulong?(2uL), "\0", 3uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsGreaterThanOrEqualTest42808()
{
	this.RequireArgumentIsGreaterThanOrEqualTest42(new ulong?(1uL), "Ā", 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest42ThrowsArgumentOutOfRangeException722()
{
	this.RequireArgumentIsGreaterThanOrEqualTest42(new ulong?(1uL), "\t", 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest42ThrowsArgumentOutOfRangeException776()
{
	this.RequireArgumentIsGreaterThanOrEqualTest42(new ulong?(1uL), "\t\t", 0uL);
}
	}
}
