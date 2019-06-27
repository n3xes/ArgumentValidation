using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsOutsideTest23.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideTest23ThrowsArgumentNullException873()
{
	this.RequireArgumentIsOutsideTest23
		(new decimal?(1152921504606846976M), (string)null, 
		 new decimal?(0e-4M), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest23ThrowsArgumentOutOfRangeException438()
{
	this.RequireArgumentIsOutsideTest23(new decimal?(1152921504606846976M), "", 
										new decimal?(0e-4M), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest23ThrowsArgumentOutOfRangeException188()
{
	this.RequireArgumentIsOutsideTest23
		(new decimal?(134217728M), "\0", new decimal?(0e-4M), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest23550()
{
	this.RequireArgumentIsOutsideTest23
		(new decimal?(134217728M), "\0", default(decimal?), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest23ThrowsArgumentOutOfRangeException648()
{
	this.RequireArgumentIsOutsideTest23
		(new decimal?(-76819052936496198642298613574e-19M), "\0", 
		 default(decimal?), new decimal?(1M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest23189()
{
	this.RequireArgumentIsOutsideTest23
		(new decimal?(134217728M), "\0", default(decimal?), default(decimal?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest23ThrowsArgumentOutOfRangeException131()
{
	this.RequireArgumentIsOutsideTest23
		(new decimal?(19342813113834066795298816M), "\t", 
		 new decimal?(0e-4M), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest23759()
{
	this.RequireArgumentIsOutsideTest23
		(default(decimal?), "\0", new decimal?(0e-4M), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest23ThrowsArgumentOutOfRangeException138()
{
	this.RequireArgumentIsOutsideTest23
		(new decimal?(32768M), "Ā", new decimal?(0e-4M), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest23ThrowsArgumentOutOfRangeException41()
{
	this.RequireArgumentIsOutsideTest23
		(new decimal?(295147905179352825856M), "\f\0", 
		 new decimal?(0e-4M), new decimal?(0e-4M));
}
	}
}
