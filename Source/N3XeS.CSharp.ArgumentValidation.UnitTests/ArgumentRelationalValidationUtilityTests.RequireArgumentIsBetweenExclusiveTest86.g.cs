using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsBetweenExclusiveTest86.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest86ThrowsArgumentNullException454()
{
	this.RequireArgumentIsBetweenExclusiveTest86
		(new ulong?(1uL), (string)null, new ulong?(1uL), 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest86ThrowsArgumentOutOfRangeException247()
{
	this.RequireArgumentIsBetweenExclusiveTest86
		(new ulong?(1uL), "", new ulong?(1uL), 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest86ThrowsArgumentOutOfRangeException547()
{
	this.RequireArgumentIsBetweenExclusiveTest86
		(new ulong?(1uL), "\0", new ulong?(1uL), 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenExclusiveTest86648()
{
	this.RequireArgumentIsBetweenExclusiveTest86
		(default(ulong?), "\0", new ulong?(1uL), 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenExclusiveTest86615()
{
	this.RequireArgumentIsBetweenExclusiveTest86
		(new ulong?(2uL), "\0", new ulong?(1uL), 3uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest86ThrowsArgumentOutOfRangeException713()
{
	this.RequireArgumentIsBetweenExclusiveTest86
		(new ulong?(0uL), "\0", new ulong?(1uL), 1uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest86ThrowsArgumentOutOfRangeException189()
{
	this.RequireArgumentIsBetweenExclusiveTest86
		(new ulong?(1uL), "Ā", new ulong?(1uL), 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest86ThrowsArgumentOutOfRangeException566()
{
	this.RequireArgumentIsBetweenExclusiveTest86
		(new ulong?(1uL), "\t", new ulong?(1uL), 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest86ThrowsArgumentOutOfRangeException122()
{
	this.RequireArgumentIsBetweenExclusiveTest86
		(new ulong?(1uL), "\t\0", new ulong?(1uL), 0uL);
}
	}
}
