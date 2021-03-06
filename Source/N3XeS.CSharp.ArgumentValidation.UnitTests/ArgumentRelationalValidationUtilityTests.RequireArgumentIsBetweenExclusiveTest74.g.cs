using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsBetweenExclusiveTest74.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest74ThrowsArgumentNullException698()
{
	this.RequireArgumentIsBetweenExclusiveTest74
		(0u, (string)null, new uint?(1u), 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest74ThrowsArgumentOutOfRangeException262()
{
	this.RequireArgumentIsBetweenExclusiveTest74(0u, "", new uint?(1u), 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest74ThrowsArgumentOutOfRangeException69()
{
	this.RequireArgumentIsBetweenExclusiveTest74(0u, "\0", new uint?(1u), 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenExclusiveTest74615()
{
	this.RequireArgumentIsBetweenExclusiveTest74(2u, "\0", new uint?(1u), 3u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest74ThrowsArgumentOutOfRangeException241()
{
	this.RequireArgumentIsBetweenExclusiveTest74(0u, "\0", new uint?(1u), 1u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest74ThrowsArgumentOutOfRangeException504()
{
	this.RequireArgumentIsBetweenExclusiveTest74(0u, "Ā", new uint?(1u), 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenExclusiveTest74436()
{
	this.RequireArgumentIsBetweenExclusiveTest74(2u, "\0", default(uint?), 3u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest74ThrowsArgumentOutOfRangeException648()
{
	this.RequireArgumentIsBetweenExclusiveTest74(0u, "\t", new uint?(1u), 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest74ThrowsArgumentOutOfRangeException672()
{
	this.RequireArgumentIsBetweenExclusiveTest74(0u, "\t\0", new uint?(1u), 0u);
}
	}
}
