using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsBetweenExclusiveTest67.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest67ThrowsArgumentNullException689()
{
	this.RequireArgumentIsBetweenExclusiveTest67
		((short)65, (string)null, default(short?), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest67ThrowsArgumentOutOfRangeException332()
{
	this.RequireArgumentIsBetweenExclusiveTest67
		((short)65, "", default(short?), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenExclusiveTest676()
{
	this.RequireArgumentIsBetweenExclusiveTest67
		((short)65, "\0", default(short?), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest67ThrowsArgumentOutOfRangeException379()
{
	this.RequireArgumentIsBetweenExclusiveTest67
		((short)65, "\0", default(short?), new short?((short)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenExclusiveTest6761()
{
	this.RequireArgumentIsBetweenExclusiveTest67
		((short)65, "\0", new short?((short)0), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest67ThrowsArgumentOutOfRangeException896()
{
	this.RequireArgumentIsBetweenExclusiveTest67
		((short)65, "\0", new short?((short)96), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenExclusiveTest67451()
{
	this.RequireArgumentIsBetweenExclusiveTest67
		((short)65, "Ā", default(short?), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest67ThrowsArgumentOutOfRangeException894()
{
	this.RequireArgumentIsBetweenExclusiveTest67
		((short)65, "\t", default(short?), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenExclusiveTest6732()
{
	this.RequireArgumentIsBetweenExclusiveTest67
		((short)65, "\t\0", default(short?), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest67ThrowsArgumentOutOfRangeException887()
{
	this.RequireArgumentIsBetweenExclusiveTest67
		((short)50, "\t\t", new short?((short)52), new short?((short)51));
}
	}
}
