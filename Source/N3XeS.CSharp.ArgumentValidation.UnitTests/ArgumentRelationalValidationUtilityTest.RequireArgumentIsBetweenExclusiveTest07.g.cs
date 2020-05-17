using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsBetweenExclusiveTest07.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest07ThrowsArgumentNullException671()
{
	this.RequireArgumentIsBetweenExclusiveTest07
		(default(DateTime?), (string)null, default(DateTime?), default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest07ThrowsArgumentOutOfRangeException880()
{
	this.RequireArgumentIsBetweenExclusiveTest07
		(default(DateTime?), "", default(DateTime?), default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenExclusiveTest07668()
{
	this.RequireArgumentIsBetweenExclusiveTest07
		(default(DateTime?), "\0", default(DateTime?), default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenExclusiveTest07910()
{
	this.RequireArgumentIsBetweenExclusiveTest07
		(new DateTime?(default(DateTime)), "\0", 
		 default(DateTime?), default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest07ThrowsArgumentOutOfRangeException775()
{
	this.RequireArgumentIsBetweenExclusiveTest07
		(new DateTime?(default(DateTime)), "\0", 
		 new DateTime?(default(DateTime)), default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest07ThrowsArgumentOutOfRangeException334()
{
	this.RequireArgumentIsBetweenExclusiveTest07
		(new DateTime?(default(DateTime)), "\0", 
		 default(DateTime?), new DateTime?(default(DateTime)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenExclusiveTest07703()
{
	this.RequireArgumentIsBetweenExclusiveTest07
		(default(DateTime?), "Ā", default(DateTime?), default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest07ThrowsArgumentOutOfRangeException221()
{
	this.RequireArgumentIsBetweenExclusiveTest07
		(default(DateTime?), "\t", default(DateTime?), default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenExclusiveTest07166()
{
	this.RequireArgumentIsBetweenExclusiveTest07
		(default(DateTime?), "\t\0", default(DateTime?), default(DateTime?));
}
	}
}
