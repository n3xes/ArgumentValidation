using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsOutsideExclusiveTest65.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest65ThrowsArgumentNullException861()
{
	this.RequireArgumentIsOutsideExclusiveTest65
		((short)65, (string)null, (short)65, default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest65ThrowsArgumentOutOfRangeException74()
{
	this.RequireArgumentIsOutsideExclusiveTest65
		((short)65, "", (short)65, default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest65ThrowsArgumentOutOfRangeException159()
{
	this.RequireArgumentIsOutsideExclusiveTest65
		((short)65, "\0", (short)65, default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest65ThrowsArgumentOutOfRangeException237()
{
	this.RequireArgumentIsOutsideExclusiveTest65
		((short)65, "\0", (short)65, new short?((short)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideExclusiveTest6560()
{
	this.RequireArgumentIsOutsideExclusiveTest65
		((short)33, "\0", (short)32, default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest65ThrowsArgumentOutOfRangeException90()
{
	this.RequireArgumentIsOutsideExclusiveTest65
		((short)65, "Ā", (short)65, default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest65ThrowsArgumentOutOfRangeException556()
{
	this.RequireArgumentIsOutsideExclusiveTest65
		((short)33, "\t", (short)33, default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest65ThrowsArgumentOutOfRangeException800()
{
	this.RequireArgumentIsOutsideExclusiveTest65
		((short)65, "\t\0", (short)65, default(short?));
}
	}
}
