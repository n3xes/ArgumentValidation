using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsBetweenTest85.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest85ThrowsArgumentNullException188()
{
	this.RequireArgumentIsBetweenTest85
		(new ulong?(1uL), (string)null, 0uL, new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest85ThrowsArgumentOutOfRangeException417()
{
	this.RequireArgumentIsBetweenTest85(new ulong?(1uL), "", 0uL, new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenTest85521()
{
	this.RequireArgumentIsBetweenTest85(new ulong?(1uL), "\0", 0uL, new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest85ThrowsArgumentOutOfRangeException620()
{
	this.RequireArgumentIsBetweenTest85(new ulong?(3uL), "\0", 0uL, new ulong?(2uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest85ThrowsArgumentOutOfRangeException206()
{
	this.RequireArgumentIsBetweenTest85
		(new ulong?(1uL), "\0", 2uL, new ulong?(9223372036854775808uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenTest85589()
{
	this.RequireArgumentIsBetweenTest85(new ulong?(1uL), "Ā", 0uL, new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenTest85143()
{
	this.RequireArgumentIsBetweenTest85(new ulong?(1uL), "Ā", 0uL, default(ulong?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest85ThrowsArgumentOutOfRangeException175()
{
	this.RequireArgumentIsBetweenTest85(new ulong?(1uL), "\t", 0uL, new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenTest85876()
{
	this.RequireArgumentIsBetweenTest85(default(ulong?), "Ā", 0uL, new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenTest85920()
{
	this.RequireArgumentIsBetweenTest85
		(new ulong?(1uL), "\t\0", 0uL, new ulong?(1uL));
}
	}
}
