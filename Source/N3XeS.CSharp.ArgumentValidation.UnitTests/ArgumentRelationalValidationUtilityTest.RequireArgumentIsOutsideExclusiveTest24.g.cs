using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsOutsideExclusiveTest24.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest24ThrowsArgumentNullException862()
{
	this.RequireArgumentIsOutsideExclusiveTest24(0, (string)null, 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest24ThrowsArgumentOutOfRangeException548()
{
	this.RequireArgumentIsOutsideExclusiveTest24(0, "", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest24ThrowsArgumentOutOfRangeException743()
{
	this.RequireArgumentIsOutsideExclusiveTest24(0, "\0", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest24ThrowsArgumentOutOfRangeException648()
{
	this.RequireArgumentIsOutsideExclusiveTest24(0, "\0", 0, 1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideExclusiveTest24372()
{
	this.RequireArgumentIsOutsideExclusiveTest24(0, "\0", -1, 1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest24ThrowsArgumentOutOfRangeException771()
{
	this.RequireArgumentIsOutsideExclusiveTest24(0, "Ā", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest24ThrowsArgumentOutOfRangeException370()
{
	this.RequireArgumentIsOutsideExclusiveTest24(0, "\t", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest24ThrowsArgumentOutOfRangeException94()
{
	this.RequireArgumentIsOutsideExclusiveTest24(0, "\t\0", 0, 0);
}
	}
}
