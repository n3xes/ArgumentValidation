using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsOutsideExclusiveTest07.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest07ThrowsArgumentNullException225()
{
	this.RequireArgumentIsOutsideExclusiveTest07
		(default(DateTime?), (string)null, default(DateTime?), default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest07ThrowsArgumentOutOfRangeException778()
{
	this.RequireArgumentIsOutsideExclusiveTest07
		(default(DateTime?), "", default(DateTime?), default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideExclusiveTest07668()
{
	this.RequireArgumentIsOutsideExclusiveTest07
		(default(DateTime?), "\0", default(DateTime?), default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideExclusiveTest07910()
{
	this.RequireArgumentIsOutsideExclusiveTest07
		(new DateTime?(default(DateTime)), "\0", 
		 default(DateTime?), default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest07ThrowsArgumentOutOfRangeException502()
{
	this.RequireArgumentIsOutsideExclusiveTest07
		(new DateTime?(default(DateTime)), "\0", 
		 new DateTime?(default(DateTime)), default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest07ThrowsArgumentOutOfRangeException119()
{
	this.RequireArgumentIsOutsideExclusiveTest07
		(new DateTime?(default(DateTime)), "\0", 
		 default(DateTime?), new DateTime?(default(DateTime)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideExclusiveTest07703()
{
	this.RequireArgumentIsOutsideExclusiveTest07
		(default(DateTime?), "Ā", default(DateTime?), default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest07ThrowsArgumentOutOfRangeException801()
{
	this.RequireArgumentIsOutsideExclusiveTest07
		(default(DateTime?), "\t", default(DateTime?), default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideExclusiveTest07166()
{
	this.RequireArgumentIsOutsideExclusiveTest07
		(default(DateTime?), "\t\0", default(DateTime?), default(DateTime?));
}
	}
}
