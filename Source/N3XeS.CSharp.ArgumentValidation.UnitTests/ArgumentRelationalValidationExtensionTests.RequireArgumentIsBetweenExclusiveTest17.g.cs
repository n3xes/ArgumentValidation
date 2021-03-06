using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsBetweenExclusiveTest17.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest17ThrowsArgumentNullException690()
{
	this.RequireArgumentIsBetweenExclusiveTest17
		(default(decimal), (string)null, default(decimal), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest17ThrowsArgumentOutOfRangeException240()
{
	this.RequireArgumentIsBetweenExclusiveTest17
		(default(decimal), "", default(decimal), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest17ThrowsArgumentOutOfRangeException758()
{
	this.RequireArgumentIsBetweenExclusiveTest17
		(default(decimal), "\0", default(decimal), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest17ThrowsArgumentOutOfRangeException148()
{
	this.RequireArgumentIsBetweenExclusiveTest17
		(default(decimal), "\0", default(decimal), default(decimal?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest17ThrowsArgumentOutOfRangeException526()
{
	this.RequireArgumentIsBetweenExclusiveTest17
		(default(decimal), "Ā", default(decimal), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenExclusiveTest17376()
{
	this.RequireArgumentIsBetweenExclusiveTest17
		(decimal.MaxValue, "\0", 2034639888M, default(decimal?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest17ThrowsArgumentOutOfRangeException457()
{
	this.RequireArgumentIsBetweenExclusiveTest17
		(default(decimal), "\t", default(decimal), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest17ThrowsArgumentOutOfRangeException549()
{
	this.RequireArgumentIsBetweenExclusiveTest17
		(default(decimal), "\t\0", default(decimal), new decimal?(0e-4M));
}
	}
}
