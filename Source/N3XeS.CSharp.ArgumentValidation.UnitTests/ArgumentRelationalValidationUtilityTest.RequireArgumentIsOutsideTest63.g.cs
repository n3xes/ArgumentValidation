using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsOutsideTest63.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideTest63ThrowsArgumentNullException400()
{
	this.RequireArgumentIsOutsideTest63(new sbyte?((sbyte)1), (string)null, 
										new sbyte?((sbyte)1), new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest63ThrowsArgumentOutOfRangeException532()
{
	this.RequireArgumentIsOutsideTest63
		(new sbyte?((sbyte)1), "", new sbyte?((sbyte)1), new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest63552()
{
	this.RequireArgumentIsOutsideTest63
		(new sbyte?((sbyte)1), "\0", new sbyte?((sbyte)1), new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest63130()
{
	this.RequireArgumentIsOutsideTest63
		(new sbyte?((sbyte)1), "\0", new sbyte?((sbyte)1), default(sbyte?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest63ThrowsArgumentOutOfRangeException336()
{
	this.RequireArgumentIsOutsideTest63(new sbyte?((sbyte)(-125)), "\0", 
										new sbyte?((sbyte)2), new sbyte?((sbyte)(-122)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest63627()
{
	this.RequireArgumentIsOutsideTest63
		(new sbyte?((sbyte)1), "Ā", new sbyte?((sbyte)1), new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest63417()
{
	this.RequireArgumentIsOutsideTest63
		(new sbyte?((sbyte)1), "Ā", default(sbyte?), new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest63ThrowsArgumentOutOfRangeException901()
{
	this.RequireArgumentIsOutsideTest63
		(new sbyte?((sbyte)1), "\t", new sbyte?((sbyte)1), new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest63423()
{
	this.RequireArgumentIsOutsideTest63
		(default(sbyte?), "Ā", new sbyte?((sbyte)1), new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest63ThrowsArgumentOutOfRangeException270()
{
	this.RequireArgumentIsOutsideTest63
		(new sbyte?((sbyte)3), "Ā", new sbyte?((sbyte)2), new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest63974()
{
	this.RequireArgumentIsOutsideTest63
		(new sbyte?((sbyte)1), "\t\0", new sbyte?((sbyte)1), new sbyte?((sbyte)1));
}
	}
}
