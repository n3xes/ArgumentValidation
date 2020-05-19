using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsOutsideExclusiveTest27.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentRelationalValidationExtensionTests
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsOutsideExclusiveTest27ThrowsArgumentNullException889()
{
	this.RequireArgumentIsOutsideExclusiveTest27
		(0, (string)null, new double?(0), new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest27ThrowsArgumentOutOfRangeException853()
{
	this.RequireArgumentIsOutsideExclusiveTest27
		(0, "", new double?(0), new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest27ThrowsArgumentOutOfRangeException435()
{
	this.RequireArgumentIsOutsideExclusiveTest27
		(0, "\0", new double?(0), new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideExclusiveTest27504()
{
	this.RequireArgumentIsOutsideExclusiveTest27
		(0, "\0", default(double?), new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest27ThrowsArgumentOutOfRangeException487()
{
	this.RequireArgumentIsOutsideExclusiveTest27
		(0, "Ā", new double?(0), new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest27ThrowsArgumentOutOfRangeException694()
{
	this.RequireArgumentIsOutsideExclusiveTest27
		(0, "Ā", new double?(0), new double?(-1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest27ThrowsArgumentOutOfRangeException506()
{
	this.RequireArgumentIsOutsideExclusiveTest27
		(0, "\t", new double?(0), new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest27ThrowsArgumentOutOfRangeException966()
{
	this.RequireArgumentIsOutsideExclusiveTest27
		(0, "Ā", new double?(0), default(double?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest27ThrowsArgumentOutOfRangeException957()
{
	this.RequireArgumentIsOutsideExclusiveTest27
		(0, "\t\0", new double?(0), new double?(1));
}
	}
}
