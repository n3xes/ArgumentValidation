using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsBetweenTest80.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest80ThrowsArgumentNullException266()
{
	this.RequireArgumentIsBetweenTest80(0uL, (string)null, 0uL, 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest80ThrowsArgumentOutOfRangeException301()
{
	this.RequireArgumentIsBetweenTest80(0uL, "", 0uL, 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenTest80582()
{
	this.RequireArgumentIsBetweenTest80(0uL, "\0", 0uL, 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest80ThrowsArgumentOutOfRangeException186()
{
	this.RequireArgumentIsBetweenTest80(1uL, "\0", 0uL, 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest80ThrowsArgumentOutOfRangeException496()
{
	this.RequireArgumentIsBetweenTest80(1uL, "\0", 2uL, 9223372036854775808uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenTest80915()
{
	this.RequireArgumentIsBetweenTest80(0uL, "Ā", 0uL, 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest80ThrowsArgumentOutOfRangeException664()
{
	this.RequireArgumentIsBetweenTest80(0uL, "\t", 0uL, 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenTest80867()
{
	this.RequireArgumentIsBetweenTest80(0uL, "\t\0", 0uL, 0uL);
}
	}
}
