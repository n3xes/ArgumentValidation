using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsBetweenExclusiveTest08.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest08ThrowsArgumentNullException446()
{
	this.RequireArgumentIsBetweenExclusiveTest08
		((byte)0, (string)null, (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest08ThrowsArgumentOutOfRangeException378()
{
	this.RequireArgumentIsBetweenExclusiveTest08((byte)0, "", (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest08ThrowsArgumentOutOfRangeException656()
{
	this.RequireArgumentIsBetweenExclusiveTest08((byte)0, "\0", (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest08ThrowsArgumentOutOfRangeException910()
{
	this.RequireArgumentIsBetweenExclusiveTest08((byte)0, "\0", (byte)0, (byte)1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenExclusiveTest0840()
{
	this.RequireArgumentIsBetweenExclusiveTest08((byte)4, "\0", (byte)0, (byte)5);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest08ThrowsArgumentOutOfRangeException710()
{
	this.RequireArgumentIsBetweenExclusiveTest08((byte)0, "Ā", (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest08ThrowsArgumentOutOfRangeException829()
{
	this.RequireArgumentIsBetweenExclusiveTest08((byte)0, "\t", (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest08ThrowsArgumentOutOfRangeException325()
{
	this.RequireArgumentIsBetweenExclusiveTest08((byte)0, "\t\0", (byte)0, (byte)0);
}
	}
}
