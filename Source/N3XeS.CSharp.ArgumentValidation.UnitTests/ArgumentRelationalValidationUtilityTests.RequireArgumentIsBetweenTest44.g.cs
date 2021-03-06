using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsBetweenTest44.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest44ThrowsArgumentNullException803()
{
	this.RequireArgumentIsBetweenTest44(new int?(64), (string)null, 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest44ThrowsArgumentOutOfRangeException242()
{
	this.RequireArgumentIsBetweenTest44(new int?(1), "", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest44ThrowsArgumentOutOfRangeException210()
{
	this.RequireArgumentIsBetweenTest44(new int?(1), "\0", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest44760()
{
	this.RequireArgumentIsBetweenTest44(default(int?), "\0", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest4494()
{
	this.RequireArgumentIsBetweenTest44(new int?(769), "\0", 0, 896);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest44ThrowsArgumentOutOfRangeException778()
{
	this.RequireArgumentIsBetweenTest44(new int?(1), "\0", 2, 1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest44ThrowsArgumentOutOfRangeException384()
{
	this.RequireArgumentIsBetweenTest44(new int?(1), "Ā", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest44ThrowsArgumentOutOfRangeException65()
{
	this.RequireArgumentIsBetweenTest44(new int?(1), "\t", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest44ThrowsArgumentOutOfRangeException241()
{
	this.RequireArgumentIsBetweenTest44(new int?(1), "\t\0", 0, 0);
}
	}
}
