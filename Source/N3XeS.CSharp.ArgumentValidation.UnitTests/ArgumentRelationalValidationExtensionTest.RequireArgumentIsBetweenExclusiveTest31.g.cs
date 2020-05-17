using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest31.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest31ThrowsArgumentNullException978()
{
	this.RequireArgumentIsBetweenExclusiveTest31
		(new double?(0), (string)null, new double?(1), new double?(2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest31ThrowsArgumentOutOfRangeException529()
{
	this.RequireArgumentIsBetweenExclusiveTest31
		(new double?(0), "", new double?(1), new double?(2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest31ThrowsArgumentOutOfRangeException300()
{
	this.RequireArgumentIsBetweenExclusiveTest31
		(new double?(0), "\0", new double?(1), new double?(2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenExclusiveTest31170()
{
	this.RequireArgumentIsBetweenExclusiveTest31
		(new double?(0), "\0", default(double?), new double?(2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest31ThrowsArgumentOutOfRangeException548()
{
	this.RequireArgumentIsBetweenExclusiveTest31
		(new double?(0), "Ā", new double?(1), new double?(2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest31ThrowsArgumentOutOfRangeException665()
{
	this.RequireArgumentIsBetweenExclusiveTest31
		(new double?(0), "Ā", new double?(1), default(double?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest31ThrowsArgumentOutOfRangeException130()
{
	this.RequireArgumentIsBetweenExclusiveTest31
		(new double?(0), "\t", new double?(1), new double?(2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenExclusiveTest31795()
{
	this.RequireArgumentIsBetweenExclusiveTest31
		(default(double?), "Ā", new double?(1), new double?(2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest31ThrowsArgumentOutOfRangeException693()
{
	this.RequireArgumentIsBetweenExclusiveTest31
		(new double?(-1), "Ā", new double?(1), new double?(-7720));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest31ThrowsArgumentOutOfRangeException667()
{
	this.RequireArgumentIsBetweenExclusiveTest31
		(new double?(0), "\t\0", new double?(1), new double?(2));
}
	}
}
