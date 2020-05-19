using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsOutsideExclusiveTest83.g.cs">Copyright © N3XeS LLC 2016</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace N3XeS.CSharp.ArgumentValidation.Extensions.UnitTests
{
	public partial class ArgumentRelationalValidationExtensionTests
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsOutsideExclusiveTest83ThrowsArgumentNullException500()
{
	this.RequireArgumentIsOutsideExclusiveTest83
		(0uL, (string)null, new ulong?(1uL), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest83ThrowsArgumentOutOfRangeException142()
{
	this.RequireArgumentIsOutsideExclusiveTest83
		(0uL, "", new ulong?(1uL), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest83ThrowsArgumentOutOfRangeException276()
{
	this.RequireArgumentIsOutsideExclusiveTest83
		(0uL, "\0", new ulong?(1uL), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideExclusiveTest83504()
{
	this.RequireArgumentIsOutsideExclusiveTest83
		(0uL, "\0", default(ulong?), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest83ThrowsArgumentOutOfRangeException977()
{
	this.RequireArgumentIsOutsideExclusiveTest83
		(0uL, "Ā", new ulong?(1uL), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest83ThrowsArgumentOutOfRangeException831()
{
	this.RequireArgumentIsOutsideExclusiveTest83
		(9223372036854775808uL, "Ā", new ulong?(1uL), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest83ThrowsArgumentOutOfRangeException491()
{
	this.RequireArgumentIsOutsideExclusiveTest83
		(0uL, "\t", new ulong?(1uL), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest83ThrowsArgumentOutOfRangeException274()
{
	this.RequireArgumentIsOutsideExclusiveTest83
		(0uL, "Ā", new ulong?(1uL), default(ulong?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest83ThrowsArgumentOutOfRangeException671()
{
	this.RequireArgumentIsOutsideExclusiveTest83
		(0uL, "\t\0", new ulong?(2uL), new ulong?(1uL));
}
	}
}
