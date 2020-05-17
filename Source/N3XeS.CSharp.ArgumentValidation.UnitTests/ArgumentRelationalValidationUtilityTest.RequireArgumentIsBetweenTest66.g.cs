using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsBetweenTest66.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest66ThrowsArgumentNullException334()
{
	this.RequireArgumentIsBetweenTest66
		((short)64, (string)null, new short?((short)65), (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest66ThrowsArgumentOutOfRangeException844()
{
	this.RequireArgumentIsBetweenTest66
		((short)32, "", new short?((short)65), (short)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest66ThrowsArgumentOutOfRangeException9()
{
	this.RequireArgumentIsBetweenTest66
		((short)32, "\0", new short?((short)33), (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenTest66747()
{
	this.RequireArgumentIsBetweenTest66((short)32, "\0", default(short?), (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest66ThrowsArgumentOutOfRangeException291()
{
	this.RequireArgumentIsBetweenTest66
		((short)32, "Ā", new short?((short)65), (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest66ThrowsArgumentOutOfRangeException474()
{
	this.RequireArgumentIsBetweenTest66
		((short)33, "Ā", new short?((short)65), (short)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest66ThrowsArgumentOutOfRangeException484()
{
	this.RequireArgumentIsBetweenTest66
		((short)64, "\t", new short?((short)65), (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest66ThrowsArgumentOutOfRangeException944()
{
	this.RequireArgumentIsBetweenTest66
		((short)32, "\t\0", new short?((short)65), (short)64);
}
	}
}
