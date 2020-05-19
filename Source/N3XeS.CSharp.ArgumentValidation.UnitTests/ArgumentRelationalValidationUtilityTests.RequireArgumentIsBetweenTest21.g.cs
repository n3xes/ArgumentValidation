using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsBetweenTest21.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest21ThrowsArgumentNullException916()
{
	this.RequireArgumentIsBetweenTest21
		(new decimal?(0e-4M), (string)null, default(decimal), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest21ThrowsArgumentOutOfRangeException33()
{
	this.RequireArgumentIsBetweenTest21
		(new decimal?(0e-4M), "", default(decimal), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest21787()
{
	this.RequireArgumentIsBetweenTest21
		(new decimal?(0e-4M), "\0", default(decimal), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest21ThrowsArgumentOutOfRangeException849()
{
	this.RequireArgumentIsBetweenTest21(new decimal?(decimal.MaxValue), "\0", 
										default(decimal), new decimal?(2034639888M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest21ThrowsArgumentOutOfRangeException397()
{
	this.RequireArgumentIsBetweenTest21
		(new decimal?(-76819052936496198642298613574e-19M), "\0", 
		 1M, new decimal?(1965637706M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest21537()
{
	this.RequireArgumentIsBetweenTest21
		(new decimal?(0e-4M), "䀀", default(decimal), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest21246()
{
	this.RequireArgumentIsBetweenTest21
		(new decimal?(0e-4M), "䀀", default(decimal), default(decimal?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest21ThrowsArgumentOutOfRangeException777()
{
	this.RequireArgumentIsBetweenTest21
		(new decimal?(0e-4M), "\t", default(decimal), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest21812()
{
	this.RequireArgumentIsBetweenTest21
		(default(decimal?), "䀀", default(decimal), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest21568()
{
	this.RequireArgumentIsBetweenTest21
		(new decimal?(0e-4M), "\t\0", default(decimal), new decimal?(0e-4M));
}
	}
}
