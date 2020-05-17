using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsBetweenExclusiveTest23.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest23ThrowsArgumentNullException920()
{
	this.RequireArgumentIsBetweenExclusiveTest23
		(new decimal?(1152921504606846976M), (string)null, 
		 new decimal?(0e-4M), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest23ThrowsArgumentOutOfRangeException711()
{
	this.RequireArgumentIsBetweenExclusiveTest23
		(new decimal?(1152921504606846976M), "", 
		 new decimal?(0e-4M), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest23ThrowsArgumentOutOfRangeException331()
{
	this.RequireArgumentIsBetweenExclusiveTest23
		(new decimal?(134217728M), "\0", new decimal?(0e-4M), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenExclusiveTest23946()
{
	this.RequireArgumentIsBetweenExclusiveTest23
		(new decimal?(134217728M), "\0", new decimal?(0e-4M), default(decimal?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest23ThrowsArgumentOutOfRangeException783()
{
	this.RequireArgumentIsBetweenExclusiveTest23
		(new decimal?(-76819052936496198642298613574e-19M), "\0", 
		 new decimal?(0e-4M), new decimal?(1M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenExclusiveTest23189()
{
	this.RequireArgumentIsBetweenExclusiveTest23
		(new decimal?(134217728M), "\0", default(decimal?), default(decimal?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest23ThrowsArgumentOutOfRangeException812()
{
	this.RequireArgumentIsBetweenExclusiveTest23
		(new decimal?(19342813113834066795298816M), "\t", 
		 new decimal?(0e-4M), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenExclusiveTest23759()
{
	this.RequireArgumentIsBetweenExclusiveTest23
		(default(decimal?), "\0", new decimal?(0e-4M), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest23ThrowsArgumentOutOfRangeException425()
{
	this.RequireArgumentIsBetweenExclusiveTest23
		(new decimal?(32768M), "Ā", new decimal?(0e-4M), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest23ThrowsArgumentOutOfRangeException756()
{
	this.RequireArgumentIsBetweenExclusiveTest23
		(new decimal?(295147905179352825856M), "\f\0", 
		 new decimal?(0e-4M), new decimal?(0e-4M));
}
	}
}
