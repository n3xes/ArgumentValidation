using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsOutsideExclusiveTest85.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest85ThrowsArgumentNullException858()
{
	this.RequireArgumentIsOutsideExclusiveTest85
		(new ulong?(1uL), (string)null, 0uL, new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest85ThrowsArgumentOutOfRangeException695()
{
	this.RequireArgumentIsOutsideExclusiveTest85
		(new ulong?(1uL), "", 0uL, new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest85ThrowsArgumentOutOfRangeException402()
{
	this.RequireArgumentIsOutsideExclusiveTest85
		(new ulong?(1uL), "\0", 0uL, new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideExclusiveTest85579()
{
	this.RequireArgumentIsOutsideExclusiveTest85
		(new ulong?(1uL), "\0", 0uL, default(ulong?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest85ThrowsArgumentOutOfRangeException521()
{
	this.RequireArgumentIsOutsideExclusiveTest85
		(new ulong?(1uL), "\0", 9223372036854775808uL, default(ulong?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideExclusiveTest85164()
{
	this.RequireArgumentIsOutsideExclusiveTest85
		(default(ulong?), "\0", 0uL, new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest85ThrowsArgumentOutOfRangeException962()
{
	this.RequireArgumentIsOutsideExclusiveTest85
		(new ulong?(1uL), "Ā", 0uL, new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest85ThrowsArgumentOutOfRangeException793()
{
	this.RequireArgumentIsOutsideExclusiveTest85
		(new ulong?(1uL), "\t", 0uL, new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest85ThrowsArgumentOutOfRangeException198()
{
	this.RequireArgumentIsOutsideExclusiveTest85
		(new ulong?(1uL), "\t\0", 0uL, new ulong?(1uL));
}
	}
}
