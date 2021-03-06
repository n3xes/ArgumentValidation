using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsLessThanTest43.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsLessThanTest43ThrowsArgumentNullException450()
{
	this.RequireArgumentIsLessThanTest43
		(new ulong?(1uL), (string)null, new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest43ThrowsArgumentOutOfRangeException835()
{
	this.RequireArgumentIsLessThanTest43(new ulong?(1uL), "", new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest43ThrowsArgumentOutOfRangeException160()
{
	this.RequireArgumentIsLessThanTest43(new ulong?(1uL), "\0", new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsLessThanTest43599()
{
	this.RequireArgumentIsLessThanTest43(new ulong?(1uL), "\0", default(ulong?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest43ThrowsArgumentOutOfRangeException500()
{
	this.RequireArgumentIsLessThanTest43(new ulong?(1uL), "Ā", new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsLessThanTest43639()
{
	this.RequireArgumentIsLessThanTest43(default(ulong?), "Ā", new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest43ThrowsArgumentOutOfRangeException896()
{
	this.RequireArgumentIsLessThanTest43(new ulong?(1uL), "\t", new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest43ThrowsArgumentOutOfRangeException142()
{
	this.RequireArgumentIsLessThanTest43(new ulong?(1uL), "\t\t", new ulong?(1uL));
}
	}
}
