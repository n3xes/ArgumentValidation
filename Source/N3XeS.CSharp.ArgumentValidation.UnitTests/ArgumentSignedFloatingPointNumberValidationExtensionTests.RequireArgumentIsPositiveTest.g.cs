using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentSignedFloatingPointNumberValidationExtensionTests.RequireArgumentIsPositiveTest.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentSignedFloatingPointNumberValidationExtensionTests
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedFloatingPointNumberValidationExtensionTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsPositiveTestThrowsArgumentNullException540()
{
	this.RequireArgumentIsPositiveTest(0, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedFloatingPointNumberValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsPositiveTestThrowsArgumentOutOfRangeException936()
{
	this.RequireArgumentIsPositiveTest(0, "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedFloatingPointNumberValidationExtensionTests))]
public void RequireArgumentIsPositiveTest705()
{
	this.RequireArgumentIsPositiveTest(0, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedFloatingPointNumberValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsPositiveTestThrowsArgumentOutOfRangeException171()
{
	this.RequireArgumentIsPositiveTest(-1, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedFloatingPointNumberValidationExtensionTests))]
public void RequireArgumentIsPositiveTest253()
{
	this.RequireArgumentIsPositiveTest(0, "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedFloatingPointNumberValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsPositiveTestThrowsArgumentOutOfRangeException886()
{
	this.RequireArgumentIsPositiveTest(0, "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedFloatingPointNumberValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsPositiveTestThrowsArgumentOutOfRangeException93601()
{
	this.RequireArgumentIsPositiveTest(0, "\t\t");
}
	}
}
