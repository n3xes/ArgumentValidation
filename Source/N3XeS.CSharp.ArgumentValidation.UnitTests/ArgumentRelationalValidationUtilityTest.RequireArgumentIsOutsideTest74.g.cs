using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsOutsideTest74.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideTest74ThrowsArgumentNullException957()
{
	this.RequireArgumentIsOutsideTest74(0u, (string)null, new uint?(1u), 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest74ThrowsArgumentOutOfRangeException30()
{
	this.RequireArgumentIsOutsideTest74(0u, "", new uint?(1u), 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest74162()
{
	this.RequireArgumentIsOutsideTest74(0u, "\0", new uint?(1u), 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest74ThrowsArgumentOutOfRangeException303()
{
	this.RequireArgumentIsOutsideTest74(513u, "\0", new uint?(512u), 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest74ThrowsArgumentOutOfRangeException2()
{
	this.RequireArgumentIsOutsideTest74(1022u, "\0", new uint?(1022u), 1023u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest74567()
{
	this.RequireArgumentIsOutsideTest74(0u, "Ā", new uint?(1u), 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest74960()
{
	this.RequireArgumentIsOutsideTest74(0u, "Ā", default(uint?), 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest74ThrowsArgumentOutOfRangeException169()
{
	this.RequireArgumentIsOutsideTest74(0u, "\t", new uint?(1u), 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest74604()
{
	this.RequireArgumentIsOutsideTest74(0u, "\t\0", new uint?(1u), 0u);
}
	}
}
