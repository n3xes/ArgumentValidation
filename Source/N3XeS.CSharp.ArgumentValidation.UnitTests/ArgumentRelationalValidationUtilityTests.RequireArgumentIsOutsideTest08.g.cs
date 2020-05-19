using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsOutsideTest08.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideTest08ThrowsArgumentNullException89()
{
	this.RequireArgumentIsOutsideTest08((byte)0, (string)null, (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest08ThrowsArgumentOutOfRangeException935()
{
	this.RequireArgumentIsOutsideTest08((byte)0, "", (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideTest08895()
{
	this.RequireArgumentIsOutsideTest08((byte)0, "\0", (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest08ThrowsArgumentOutOfRangeException792()
{
	this.RequireArgumentIsOutsideTest08((byte)1, "\0", (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest08ThrowsArgumentOutOfRangeException941()
{
	this.RequireArgumentIsOutsideTest08((byte)1, "\0", (byte)128, (byte)2);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideTest08586()
{
	this.RequireArgumentIsOutsideTest08((byte)0, "Ā", (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest08ThrowsArgumentOutOfRangeException928()
{
	this.RequireArgumentIsOutsideTest08((byte)0, "\t", (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideTest0858601()
{
	this.RequireArgumentIsOutsideTest08((byte)0, "\t\0", (byte)0, (byte)0);
}
	}
}
