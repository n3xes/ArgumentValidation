using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsOutsideTest21.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideTest21ThrowsArgumentNullException725()
{
	this.RequireArgumentIsOutsideTest21
		(new decimal?(0e-4M), (string)null, default(decimal), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest21ThrowsArgumentOutOfRangeException968()
{
	this.RequireArgumentIsOutsideTest21
		(new decimal?(0e-4M), "", default(decimal), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest21787()
{
	this.RequireArgumentIsOutsideTest21
		(new decimal?(0e-4M), "\0", default(decimal), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest21252()
{
	this.RequireArgumentIsOutsideTest21
		(new decimal?(0e-4M), "\0", default(decimal), default(decimal?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest21ThrowsArgumentOutOfRangeException950()
{
	this.RequireArgumentIsOutsideTest21
		(new decimal?(-76819052936496198642298613574e-19M), "\0", 
		 1965637706M, new decimal?(1M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest21537()
{
	this.RequireArgumentIsOutsideTest21
		(new decimal?(0e-4M), "䀀", default(decimal), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest21ThrowsArgumentOutOfRangeException993()
{
	this.RequireArgumentIsOutsideTest21(new decimal?(73786976294838206464M), "䀀", 
										default(decimal), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest21ThrowsArgumentOutOfRangeException210()
{
	this.RequireArgumentIsOutsideTest21
		(new decimal?(0e-4M), "\t", default(decimal), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest21812()
{
	this.RequireArgumentIsOutsideTest21
		(default(decimal?), "䀀", default(decimal), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest21568()
{
	this.RequireArgumentIsOutsideTest21
		(new decimal?(0e-4M), "\t\0", default(decimal), new decimal?(0e-4M));
}
	}
}
