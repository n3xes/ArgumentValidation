using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest46.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentRelationalValidationExtensionTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsOutsideExclusiveTest46ThrowsArgumentNullException804()
{
	this.RequireArgumentIsOutsideExclusiveTest46
		(new int?(512), (string)null, new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest46ThrowsArgumentOutOfRangeException203()
{
	this.RequireArgumentIsOutsideExclusiveTest46(new int?(1), "", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest46ThrowsArgumentOutOfRangeException205()
{
	this.RequireArgumentIsOutsideExclusiveTest46(new int?(1), "\0", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideExclusiveTest46648()
{
	this.RequireArgumentIsOutsideExclusiveTest46
		(default(int?), "\0", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest46ThrowsArgumentOutOfRangeException598()
{
	this.RequireArgumentIsOutsideExclusiveTest46(new int?(0), "\0", new int?(1), 1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest46ThrowsArgumentOutOfRangeException866()
{
	this.RequireArgumentIsOutsideExclusiveTest46(new int?(2), "耀", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest46ThrowsArgumentOutOfRangeException466()
{
	this.RequireArgumentIsOutsideExclusiveTest46(new int?(1), "\t", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest46ThrowsArgumentOutOfRangeException815()
{
	this.RequireArgumentIsOutsideExclusiveTest46
		(new int?(1), "\t\0", new int?(1), 0);
}
	}
}
