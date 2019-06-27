using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsOutsideExclusiveTest92.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest92ThrowsArgumentNullException871()
{
	this.RequireArgumentIsOutsideExclusiveTest92
		(new ushort?((ushort)65), (string)null, (ushort)32, (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest92ThrowsArgumentOutOfRangeException66()
{
	this.RequireArgumentIsOutsideExclusiveTest92
		(new ushort?((ushort)65), "", (ushort)32, (ushort)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest92ThrowsArgumentOutOfRangeException36()
{
	this.RequireArgumentIsOutsideExclusiveTest92
		(new ushort?((ushort)65), "\0", (ushort)32, (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideExclusiveTest92684()
{
	this.RequireArgumentIsOutsideExclusiveTest92
		(default(ushort?), "\0", (ushort)32, (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideExclusiveTest92633()
{
	this.RequireArgumentIsOutsideExclusiveTest92
		(new ushort?((ushort)34), "\0", (ushort)32, (ushort)35);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest92ThrowsArgumentOutOfRangeException776()
{
	this.RequireArgumentIsOutsideExclusiveTest92
		(new ushort?((ushort)0), "\0", (ushort)65, (ushort)33);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest92ThrowsArgumentOutOfRangeException938()
{
	this.RequireArgumentIsOutsideExclusiveTest92
		(new ushort?((ushort)65), "Ā", (ushort)32, (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest92ThrowsArgumentOutOfRangeException81()
{
	this.RequireArgumentIsOutsideExclusiveTest92
		(new ushort?((ushort)65), "\t", (ushort)32, (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest92ThrowsArgumentOutOfRangeException409()
{
	this.RequireArgumentIsOutsideExclusiveTest92
		(new ushort?((ushort)65), "\t\0", (ushort)32, (ushort)64);
}
	}
}
