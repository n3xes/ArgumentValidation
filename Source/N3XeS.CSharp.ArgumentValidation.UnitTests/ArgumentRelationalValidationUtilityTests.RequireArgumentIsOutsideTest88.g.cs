using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsOutsideTest88.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideTest88ThrowsArgumentNullException620()
{
	this.RequireArgumentIsOutsideTest88
		((ushort)32, (string)null, (ushort)32, (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest88ThrowsArgumentOutOfRangeException871()
{
	this.RequireArgumentIsOutsideTest88((ushort)32, "", (ushort)32, (ushort)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideTest8879()
{
	this.RequireArgumentIsOutsideTest88((ushort)32, "\0", (ushort)32, (ushort)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest88ThrowsArgumentOutOfRangeException940()
{
	this.RequireArgumentIsOutsideTest88((ushort)34, "\0", (ushort)32, (ushort)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest88ThrowsArgumentOutOfRangeException()
{
	this.RequireArgumentIsOutsideTest88((ushort)33, "\0", (ushort)33, (ushort)34);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideTest88350()
{
	this.RequireArgumentIsOutsideTest88((ushort)32, "Ā", (ushort)32, (ushort)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest88ThrowsArgumentOutOfRangeException308()
{
	this.RequireArgumentIsOutsideTest88((ushort)32, "\t", (ushort)32, (ushort)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideTest88599()
{
	this.RequireArgumentIsOutsideTest88((ushort)32, "\t\0", (ushort)32, (ushort)32);
}
	}
}
