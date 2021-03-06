using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsBetweenTest87.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest87ThrowsArgumentNullException117()
{
	this.RequireArgumentIsBetweenTest87
		(new ulong?(1uL), (string)null, new ulong?(1uL), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest87ThrowsArgumentOutOfRangeException64()
{
	this.RequireArgumentIsBetweenTest87
		(new ulong?(1uL), "", new ulong?(1uL), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenTest8758()
{
	this.RequireArgumentIsBetweenTest87
		(new ulong?(1uL), "\0", new ulong?(1uL), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenTest87534()
{
	this.RequireArgumentIsBetweenTest87
		(new ulong?(1uL), "\0", default(ulong?), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest87ThrowsArgumentOutOfRangeException3()
{
	this.RequireArgumentIsBetweenTest87
		(new ulong?(1uL), "\0", new ulong?(2uL), new ulong?(9223372036854775808uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenTest87506()
{
	this.RequireArgumentIsBetweenTest87
		(new ulong?(1uL), "Ā", new ulong?(1uL), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenTest87314()
{
	this.RequireArgumentIsBetweenTest87
		(new ulong?(1uL), "Ā", new ulong?(1uL), default(ulong?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest87ThrowsArgumentOutOfRangeException837()
{
	this.RequireArgumentIsBetweenTest87
		(new ulong?(1uL), "\t", new ulong?(1uL), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenTest87943()
{
	this.RequireArgumentIsBetweenTest87
		(default(ulong?), "Ā", new ulong?(1uL), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest87ThrowsArgumentOutOfRangeException920()
{
	this.RequireArgumentIsBetweenTest87
		(new ulong?(3uL), "Ā", new ulong?(1uL), new ulong?(2uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenTest87978()
{
	this.RequireArgumentIsBetweenTest87
		(new ulong?(1uL), "\t\0", new ulong?(1uL), new ulong?(1uL));
}
	}
}
