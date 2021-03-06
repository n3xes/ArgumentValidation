using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsBetweenTest46.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest46ThrowsArgumentNullException980()
{
	this.RequireArgumentIsBetweenTest46(new int?(512), (string)null, new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest46ThrowsArgumentOutOfRangeException13()
{
	this.RequireArgumentIsBetweenTest46(new int?(1), "", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest46ThrowsArgumentOutOfRangeException420()
{
	this.RequireArgumentIsBetweenTest46(new int?(1), "\0", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest46648()
{
	this.RequireArgumentIsBetweenTest46(default(int?), "\0", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest46312()
{
	this.RequireArgumentIsBetweenTest46(new int?(4), "\0", new int?(1), 512);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest46ThrowsArgumentOutOfRangeException711()
{
	this.RequireArgumentIsBetweenTest46(new int?(0), "\0", new int?(2), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest46ThrowsArgumentOutOfRangeException899()
{
	this.RequireArgumentIsBetweenTest46(new int?(2), "耀", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest46ThrowsArgumentOutOfRangeException972()
{
	this.RequireArgumentIsBetweenTest46(new int?(1), "\t", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest46ThrowsArgumentOutOfRangeException789()
{
	this.RequireArgumentIsBetweenTest46(new int?(1), "\t\0", new int?(1), 0);
}
	}
}
