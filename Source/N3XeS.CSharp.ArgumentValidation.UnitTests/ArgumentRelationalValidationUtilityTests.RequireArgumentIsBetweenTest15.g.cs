using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsBetweenTest15.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest15ThrowsArgumentNullException423()
{
	this.RequireArgumentIsBetweenTest15
		(new byte?((byte)1), (string)null, new byte?((byte)1), new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest15ThrowsArgumentOutOfRangeException168()
{
	this.RequireArgumentIsBetweenTest15
		(new byte?((byte)1), "", new byte?((byte)1), new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest15552()
{
	this.RequireArgumentIsBetweenTest15
		(new byte?((byte)1), "\0", new byte?((byte)1), new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest15530()
{
	this.RequireArgumentIsBetweenTest15
		(new byte?((byte)1), "\0", default(byte?), new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest15ThrowsArgumentOutOfRangeException678()
{
	this.RequireArgumentIsBetweenTest15
		(new byte?((byte)1), "\0", new byte?((byte)2), new byte?((byte)128));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest15627()
{
	this.RequireArgumentIsBetweenTest15
		(new byte?((byte)1), "Ā", new byte?((byte)1), new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest15391()
{
	this.RequireArgumentIsBetweenTest15
		(new byte?((byte)1), "Ā", new byte?((byte)1), default(byte?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest15ThrowsArgumentOutOfRangeException846()
{
	this.RequireArgumentIsBetweenTest15
		(new byte?((byte)1), "\t", new byte?((byte)1), new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest15423()
{
	this.RequireArgumentIsBetweenTest15
		(default(byte?), "Ā", new byte?((byte)1), new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest15ThrowsArgumentOutOfRangeException945()
{
	this.RequireArgumentIsBetweenTest15
		(new byte?((byte)3), "Ā", new byte?((byte)1), new byte?((byte)2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest15974()
{
	this.RequireArgumentIsBetweenTest15
		(new byte?((byte)1), "\t\0", new byte?((byte)1), new byte?((byte)1));
}
	}
}
