using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsLessThanOrEqualTest05.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsLessThanOrEqualTest05ThrowsArgumentNullException543()
{
	this.RequireArgumentIsLessThanOrEqualTest05
		((byte)0, (string)null, new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest05ThrowsArgumentOutOfRangeException980()
{
	this.RequireArgumentIsLessThanOrEqualTest05((byte)0, "", new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsLessThanOrEqualTest05843()
{
	this.RequireArgumentIsLessThanOrEqualTest05((byte)0, "\0", new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsLessThanOrEqualTest05359()
{
	this.RequireArgumentIsLessThanOrEqualTest05((byte)0, "\0", default(byte?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest05ThrowsArgumentOutOfRangeException11()
{
	this.RequireArgumentIsLessThanOrEqualTest05((byte)3, "\0", new byte?((byte)2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsLessThanOrEqualTest05801()
{
	this.RequireArgumentIsLessThanOrEqualTest05((byte)0, "Ā", new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest05ThrowsArgumentOutOfRangeException913()
{
	this.RequireArgumentIsLessThanOrEqualTest05((byte)0, "\t", new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest05ThrowsArgumentOutOfRangeException388()
{
	this.RequireArgumentIsLessThanOrEqualTest05((byte)0, "\t\t", new byte?((byte)1));
}
	}
}
