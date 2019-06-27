using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsBetweenExclusiveTest88.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest88ThrowsArgumentNullException534()
{
	this.RequireArgumentIsBetweenExclusiveTest88
		((ushort)32, (string)null, (ushort)32, (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest88ThrowsArgumentOutOfRangeException570()
{
	this.RequireArgumentIsBetweenExclusiveTest88
		((ushort)32, "", (ushort)32, (ushort)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest88ThrowsArgumentOutOfRangeException613()
{
	this.RequireArgumentIsBetweenExclusiveTest88
		((ushort)32, "\0", (ushort)32, (ushort)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest88ThrowsArgumentOutOfRangeException529()
{
	this.RequireArgumentIsBetweenExclusiveTest88
		((ushort)32, "\0", (ushort)32, (ushort)34);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenExclusiveTest88633()
{
	this.RequireArgumentIsBetweenExclusiveTest88
		((ushort)34, "\0", (ushort)32, (ushort)35);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest88ThrowsArgumentOutOfRangeException323()
{
	this.RequireArgumentIsBetweenExclusiveTest88
		((ushort)32, "Ā", (ushort)32, (ushort)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest88ThrowsArgumentOutOfRangeException253()
{
	this.RequireArgumentIsBetweenExclusiveTest88
		((ushort)32, "\t", (ushort)32, (ushort)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest88ThrowsArgumentOutOfRangeException239()
{
	this.RequireArgumentIsBetweenExclusiveTest88
		((ushort)32, "\t\0", (ushort)32, (ushort)32);
}
	}
}
