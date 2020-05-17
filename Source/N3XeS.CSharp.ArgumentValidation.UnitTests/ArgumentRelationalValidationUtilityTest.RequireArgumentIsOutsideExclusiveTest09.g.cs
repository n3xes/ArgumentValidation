using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsOutsideExclusiveTest09.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest09ThrowsArgumentNullException193()
{
	this.RequireArgumentIsOutsideExclusiveTest09
		((byte)0, (string)null, (byte)0, new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest09ThrowsArgumentOutOfRangeException154()
{
	this.RequireArgumentIsOutsideExclusiveTest09
		((byte)0, "", (byte)0, new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest09ThrowsArgumentOutOfRangeException830()
{
	this.RequireArgumentIsOutsideExclusiveTest09
		((byte)0, "\0", (byte)0, new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest09ThrowsArgumentOutOfRangeException683()
{
	this.RequireArgumentIsOutsideExclusiveTest09
		((byte)128, "\0", (byte)0, new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideExclusiveTest0934()
{
	this.RequireArgumentIsOutsideExclusiveTest09
		((byte)2, "\0", (byte)0, new byte?((byte)3));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest09ThrowsArgumentOutOfRangeException49()
{
	this.RequireArgumentIsOutsideExclusiveTest09
		((byte)0, "Ā", (byte)0, new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest09ThrowsArgumentOutOfRangeException52()
{
	this.RequireArgumentIsOutsideExclusiveTest09
		((byte)0, "Ā", (byte)0, default(byte?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest09ThrowsArgumentOutOfRangeException781()
{
	this.RequireArgumentIsOutsideExclusiveTest09
		((byte)0, "\t", (byte)0, new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest09ThrowsArgumentOutOfRangeException551()
{
	this.RequireArgumentIsOutsideExclusiveTest09
		((byte)0, "\t\0", (byte)0, new byte?((byte)1));
}
	}
}
