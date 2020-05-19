using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsBetweenExclusiveTest19.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest19ThrowsArgumentNullException815()
{
	this.RequireArgumentIsBetweenExclusiveTest19
		(default(decimal), (string)null, new decimal?(0e-4M), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest19ThrowsArgumentOutOfRangeException276()
{
	this.RequireArgumentIsBetweenExclusiveTest19
		(default(decimal), "", new decimal?(0e-4M), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest19ThrowsArgumentOutOfRangeException362()
{
	this.RequireArgumentIsBetweenExclusiveTest19
		(default(decimal), "\0", new decimal?(0e-4M), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest19ThrowsArgumentOutOfRangeException571()
{
	this.RequireArgumentIsBetweenExclusiveTest19
		(default(decimal), "\0", new decimal?(0e-4M), default(decimal?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenExclusiveTest19376()
{
	this.RequireArgumentIsBetweenExclusiveTest19
		(decimal.MaxValue, "\0", new decimal?(2034639888M), default(decimal?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest19ThrowsArgumentOutOfRangeException815()
{
	this.RequireArgumentIsBetweenExclusiveTest19
		(-76819052936496198642298613574e-19M, "\0", 
		 new decimal?(0e-4M), new decimal?(1M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenExclusiveTest19716()
{
	this.RequireArgumentIsBetweenExclusiveTest19
		(default(decimal), "\0", default(decimal?), default(decimal?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest19ThrowsArgumentOutOfRangeException199()
{
	this.RequireArgumentIsBetweenExclusiveTest19
		(default(decimal), "Ā", new decimal?(0e-4M), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest19ThrowsArgumentOutOfRangeException744()
{
	this.RequireArgumentIsBetweenExclusiveTest19
		(default(decimal), "\t", new decimal?(0e-4M), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest19ThrowsArgumentOutOfRangeException676()
{
	this.RequireArgumentIsBetweenExclusiveTest19
		(default(decimal), "\t\0", new decimal?(0e-4M), new decimal?(0e-4M));
}
	}
}
