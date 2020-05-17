using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsOutsideExclusiveTest10.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest10ThrowsArgumentNullException412()
{
	this.RequireArgumentIsOutsideExclusiveTest10
		((byte)0, (string)null, new byte?((byte)1), (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest10ThrowsArgumentOutOfRangeException525()
{
	this.RequireArgumentIsOutsideExclusiveTest10
		((byte)0, "", new byte?((byte)1), (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest10ThrowsArgumentOutOfRangeException543()
{
	this.RequireArgumentIsOutsideExclusiveTest10
		((byte)0, "\0", new byte?((byte)1), (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest10ThrowsArgumentOutOfRangeException720()
{
	this.RequireArgumentIsOutsideExclusiveTest10
		((byte)0, "\0", new byte?((byte)1), (byte)1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideExclusiveTest10451()
{
	this.RequireArgumentIsOutsideExclusiveTest10
		((byte)2, "\0", new byte?((byte)1), (byte)3);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest10ThrowsArgumentOutOfRangeException153()
{
	this.RequireArgumentIsOutsideExclusiveTest10
		((byte)0, "Ā", new byte?((byte)1), (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideExclusiveTest108()
{
	this.RequireArgumentIsOutsideExclusiveTest10
		((byte)0, "\0", default(byte?), (byte)1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest10ThrowsArgumentOutOfRangeException459()
{
	this.RequireArgumentIsOutsideExclusiveTest10
		((byte)0, "\t", new byte?((byte)1), (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest10ThrowsArgumentOutOfRangeException680()
{
	this.RequireArgumentIsOutsideExclusiveTest10
		((byte)0, "\t\0", new byte?((byte)1), (byte)0);
}
	}
}
