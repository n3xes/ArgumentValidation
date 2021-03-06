using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsOutsideTest87.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideTest87ThrowsArgumentNullException921()
{
	this.RequireArgumentIsOutsideTest87
		(new ulong?(1uL), (string)null, new ulong?(1uL), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest87ThrowsArgumentOutOfRangeException960()
{
	this.RequireArgumentIsOutsideTest87
		(new ulong?(1uL), "", new ulong?(1uL), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest8758()
{
	this.RequireArgumentIsOutsideTest87
		(new ulong?(1uL), "\0", new ulong?(1uL), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest87642()
{
	this.RequireArgumentIsOutsideTest87
		(new ulong?(1uL), "\0", new ulong?(1uL), default(ulong?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest87ThrowsArgumentOutOfRangeException727()
{
	this.RequireArgumentIsOutsideTest87
		(new ulong?(1uL), "\0", new ulong?(9223372036854775808uL), new ulong?(2uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest87506()
{
	this.RequireArgumentIsOutsideTest87
		(new ulong?(1uL), "Ā", new ulong?(1uL), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest87689()
{
	this.RequireArgumentIsOutsideTest87
		(new ulong?(1uL), "Ā", default(ulong?), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest87ThrowsArgumentOutOfRangeException686()
{
	this.RequireArgumentIsOutsideTest87
		(new ulong?(1uL), "\t", new ulong?(1uL), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest87943()
{
	this.RequireArgumentIsOutsideTest87
		(default(ulong?), "Ā", new ulong?(1uL), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest87ThrowsArgumentOutOfRangeException462()
{
	this.RequireArgumentIsOutsideTest87
		(new ulong?(3uL), "Ā", new ulong?(2uL), new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest87978()
{
	this.RequireArgumentIsOutsideTest87
		(new ulong?(1uL), "\t\0", new ulong?(1uL), new ulong?(1uL));
}
	}
}
