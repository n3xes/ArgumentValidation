using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsOutsideTest46.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentRelationalValidationUtilityTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsOutsideTest46ThrowsArgumentNullException703()
{
	this.RequireArgumentIsOutsideTest46(new int?(512), (string)null, new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest46ThrowsArgumentOutOfRangeException986()
{
	this.RequireArgumentIsOutsideTest46(new int?(1), "", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest46806()
{
	this.RequireArgumentIsOutsideTest46(new int?(1), "\0", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest46ThrowsArgumentOutOfRangeException878()
{
	this.RequireArgumentIsOutsideTest46(new int?(33), "\0", new int?(32), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest46ThrowsArgumentOutOfRangeException288()
{
	this.RequireArgumentIsOutsideTest46(new int?(831), "\0", new int?(831), 894);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest46ThrowsArgumentOutOfRangeException809()
{
	this.RequireArgumentIsOutsideTest46(new int?(2), "耀", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest46580()
{
	this.RequireArgumentIsOutsideTest46(new int?(2), "耀", default(int?), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest46ThrowsArgumentOutOfRangeException326()
{
	this.RequireArgumentIsOutsideTest46(new int?(1), "\t", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest4637()
{
	this.RequireArgumentIsOutsideTest46(default(int?), "耀", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest46446()
{
	this.RequireArgumentIsOutsideTest46(new int?(1), "\t\0", new int?(1), 0);
}
	}
}
