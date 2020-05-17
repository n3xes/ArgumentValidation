using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsGreaterThanOrEqualTest43.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanOrEqualTest43ThrowsArgumentNullException635()
{
	this.RequireArgumentIsGreaterThanOrEqualTest43
		(new ulong?(1uL), (string)null, new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest43ThrowsArgumentOutOfRangeException779()
{
	this.RequireArgumentIsGreaterThanOrEqualTest43
		(new ulong?(1uL), "", new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsGreaterThanOrEqualTest43783()
{
	this.RequireArgumentIsGreaterThanOrEqualTest43
		(new ulong?(1uL), "\0", new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsGreaterThanOrEqualTest43452()
{
	this.RequireArgumentIsGreaterThanOrEqualTest43
		(new ulong?(1uL), "\0", default(ulong?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest43ThrowsArgumentOutOfRangeException223()
{
	this.RequireArgumentIsGreaterThanOrEqualTest43
		(new ulong?(2uL), "\0", new ulong?(3uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsGreaterThanOrEqualTest43454()
{
	this.RequireArgumentIsGreaterThanOrEqualTest43
		(new ulong?(1uL), "Ā", new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsGreaterThanOrEqualTest43469()
{
	this.RequireArgumentIsGreaterThanOrEqualTest43
		(default(ulong?), "Ā", new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest43ThrowsArgumentOutOfRangeException885()
{
	this.RequireArgumentIsGreaterThanOrEqualTest43
		(new ulong?(1uL), "\t", new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest43ThrowsArgumentOutOfRangeException294()
{
	this.RequireArgumentIsGreaterThanOrEqualTest43
		(new ulong?(1uL), "\t\t", new ulong?(1uL));
}
	}
}
