using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsBetweenTest87.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest87ThrowsArgumentNullException272()
{
	this.RequireArgumentIsBetweenTest87
		(new ulong?(1uL), (string)null, new ulong?(1uL), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest87ThrowsArgumentOutOfRangeException515()
{
	this.RequireArgumentIsBetweenTest87
		(new ulong?(1uL), "", new ulong?(1uL), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest8758()
{
	this.RequireArgumentIsBetweenTest87
		(new ulong?(1uL), "\0", new ulong?(1uL), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest87534()
{
	this.RequireArgumentIsBetweenTest87
		(new ulong?(1uL), "\0", default(ulong?), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest87ThrowsArgumentOutOfRangeException242()
{
	this.RequireArgumentIsBetweenTest87
		(new ulong?(1uL), "\0", new ulong?(2uL), new ulong?(9223372036854775808uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest87506()
{
	this.RequireArgumentIsBetweenTest87
		(new ulong?(1uL), "Ā", new ulong?(1uL), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest87314()
{
	this.RequireArgumentIsBetweenTest87
		(new ulong?(1uL), "Ā", new ulong?(1uL), default(ulong?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest87ThrowsArgumentOutOfRangeException589()
{
	this.RequireArgumentIsBetweenTest87
		(new ulong?(1uL), "\t", new ulong?(1uL), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest87943()
{
	this.RequireArgumentIsBetweenTest87
		(default(ulong?), "Ā", new ulong?(1uL), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest87ThrowsArgumentOutOfRangeException514()
{
	this.RequireArgumentIsBetweenTest87
		(new ulong?(3uL), "Ā", new ulong?(1uL), new ulong?(2uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest87978()
{
	this.RequireArgumentIsBetweenTest87
		(new ulong?(1uL), "\t\0", new ulong?(1uL), new ulong?(1uL));
}
	}
}
