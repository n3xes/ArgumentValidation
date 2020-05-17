using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest67.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest67ThrowsArgumentNullException578()
{
	this.RequireArgumentIsOutsideExclusiveTest67
		((short)65, (string)null, default(short?), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest67ThrowsArgumentOutOfRangeException196()
{
	this.RequireArgumentIsOutsideExclusiveTest67
		((short)65, "", default(short?), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideExclusiveTest676()
{
	this.RequireArgumentIsOutsideExclusiveTest67
		((short)65, "\0", default(short?), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest67ThrowsArgumentOutOfRangeException216()
{
	this.RequireArgumentIsOutsideExclusiveTest67
		((short)65, "\0", default(short?), new short?((short)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideExclusiveTest6761()
{
	this.RequireArgumentIsOutsideExclusiveTest67
		((short)65, "\0", new short?((short)0), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest67ThrowsArgumentOutOfRangeException683()
{
	this.RequireArgumentIsOutsideExclusiveTest67
		((short)65, "\0", new short?((short)96), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideExclusiveTest67451()
{
	this.RequireArgumentIsOutsideExclusiveTest67
		((short)65, "Ā", default(short?), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest67ThrowsArgumentOutOfRangeException449()
{
	this.RequireArgumentIsOutsideExclusiveTest67
		((short)65, "\t", default(short?), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideExclusiveTest6732()
{
	this.RequireArgumentIsOutsideExclusiveTest67
		((short)65, "\t\0", default(short?), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest67ThrowsArgumentOutOfRangeException234()
{
	this.RequireArgumentIsOutsideExclusiveTest67
		((short)50, "\t\t", new short?((short)52), new short?((short)51));
}
	}
}
