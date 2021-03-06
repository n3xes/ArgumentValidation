using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsBetweenTest83.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest83ThrowsArgumentNullException518()
{
	this.RequireArgumentIsBetweenTest83
		(0uL, (string)null, new ulong?(1uL), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest83ThrowsArgumentOutOfRangeException734()
{
	this.RequireArgumentIsBetweenTest83(0uL, "", new ulong?(1uL), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest83ThrowsArgumentOutOfRangeException641()
{
	this.RequireArgumentIsBetweenTest83(0uL, "\0", new ulong?(1uL), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenTest83504()
{
	this.RequireArgumentIsBetweenTest83(0uL, "\0", default(ulong?), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest83ThrowsArgumentOutOfRangeException244()
{
	this.RequireArgumentIsBetweenTest83(0uL, "Ā", new ulong?(1uL), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest83ThrowsArgumentOutOfRangeException931()
{
	this.RequireArgumentIsBetweenTest83(3uL, "Ā", new ulong?(1uL), new ulong?(2uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest83ThrowsArgumentOutOfRangeException113()
{
	this.RequireArgumentIsBetweenTest83(0uL, "\t", new ulong?(1uL), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest83ThrowsArgumentOutOfRangeException219()
{
	this.RequireArgumentIsBetweenTest83(0uL, "Ā", new ulong?(1uL), default(ulong?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest83ThrowsArgumentOutOfRangeException870()
{
	this.RequireArgumentIsBetweenTest83
		(0uL, "\t\0", new ulong?(2uL), new ulong?(1uL));
}
	}
}
