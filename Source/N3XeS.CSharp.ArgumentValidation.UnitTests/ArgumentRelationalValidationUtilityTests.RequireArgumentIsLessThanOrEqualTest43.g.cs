using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsLessThanOrEqualTest43.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsLessThanOrEqualTest43ThrowsArgumentNullException425()
{
	this.RequireArgumentIsLessThanOrEqualTest43
		(new ulong?(1uL), (string)null, new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest43ThrowsArgumentOutOfRangeException636()
{
	this.RequireArgumentIsLessThanOrEqualTest43
		(new ulong?(1uL), "", new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsLessThanOrEqualTest43709()
{
	this.RequireArgumentIsLessThanOrEqualTest43
		(new ulong?(1uL), "\0", new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsLessThanOrEqualTest43599()
{
	this.RequireArgumentIsLessThanOrEqualTest43
		(new ulong?(1uL), "\0", default(ulong?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest43ThrowsArgumentOutOfRangeException148()
{
	this.RequireArgumentIsLessThanOrEqualTest43
		(new ulong?(3uL), "\0", new ulong?(2uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsLessThanOrEqualTest43548()
{
	this.RequireArgumentIsLessThanOrEqualTest43
		(new ulong?(1uL), "Ā", new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsLessThanOrEqualTest43639()
{
	this.RequireArgumentIsLessThanOrEqualTest43
		(default(ulong?), "Ā", new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest43ThrowsArgumentOutOfRangeException540()
{
	this.RequireArgumentIsLessThanOrEqualTest43
		(new ulong?(1uL), "\t", new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest43ThrowsArgumentOutOfRangeException87()
{
	this.RequireArgumentIsLessThanOrEqualTest43
		(new ulong?(1uL), "\t\t", new ulong?(1uL));
}
	}
}
