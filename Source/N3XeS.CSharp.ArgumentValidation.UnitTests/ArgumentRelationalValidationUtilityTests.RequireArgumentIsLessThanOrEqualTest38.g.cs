using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsLessThanOrEqualTest38.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsLessThanOrEqualTest38ThrowsArgumentNullException265()
{
	this.RequireArgumentIsLessThanOrEqualTest38(new uint?(1u), (string)null, 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest38ThrowsArgumentOutOfRangeException346()
{
	this.RequireArgumentIsLessThanOrEqualTest38(new uint?(1u), "", 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest38ThrowsArgumentOutOfRangeException624()
{
	this.RequireArgumentIsLessThanOrEqualTest38(new uint?(1u), "\0", 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsLessThanOrEqualTest38875()
{
	this.RequireArgumentIsLessThanOrEqualTest38(default(uint?), "\0", 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest38ThrowsArgumentOutOfRangeException185()
{
	this.RequireArgumentIsLessThanOrEqualTest38(new uint?(1u), "Ā", 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest38ThrowsArgumentOutOfRangeException126()
{
	this.RequireArgumentIsLessThanOrEqualTest38(new uint?(1u), "\t", 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest38ThrowsArgumentOutOfRangeException772()
{
	this.RequireArgumentIsLessThanOrEqualTest38(new uint?(1u), "\t\t", 0u);
}
	}
}
