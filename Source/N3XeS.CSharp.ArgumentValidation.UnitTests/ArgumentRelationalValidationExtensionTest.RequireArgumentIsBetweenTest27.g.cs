using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest27.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest27ThrowsArgumentNullException227()
{
	this.RequireArgumentIsBetweenTest27
		(0, (string)null, new double?(0), new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest27ThrowsArgumentOutOfRangeException601()
{
	this.RequireArgumentIsBetweenTest27(0, "", new double?(0), new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest2758()
{
	this.RequireArgumentIsBetweenTest27(0, "\0", new double?(0), new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest27504()
{
	this.RequireArgumentIsBetweenTest27(0, "\0", default(double?), new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest27ThrowsArgumentOutOfRangeException837()
{
	this.RequireArgumentIsBetweenTest27(-2, "\0", new double?(-1), new double?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest27667()
{
	this.RequireArgumentIsBetweenTest27(0, "Ā", new double?(0), new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest27ThrowsArgumentOutOfRangeException485()
{
	this.RequireArgumentIsBetweenTest27(0, "Ā", new double?(0), new double?(-1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest27ThrowsArgumentOutOfRangeException806()
{
	this.RequireArgumentIsBetweenTest27(0, "\t", new double?(0), new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest27697()
{
	this.RequireArgumentIsBetweenTest27(0, "Ā", new double?(0), default(double?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest27531()
{
	this.RequireArgumentIsBetweenTest27(0, "\t\0", new double?(0), new double?(1));
}
	}
}
