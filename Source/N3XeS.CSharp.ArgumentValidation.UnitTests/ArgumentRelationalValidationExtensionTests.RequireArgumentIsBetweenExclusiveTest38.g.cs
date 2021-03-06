using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsBetweenExclusiveTest38.g.cs">Copyright © N3XeS LLC 2016</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace N3XeS.CSharp.ArgumentValidation.Extensions.UnitTests
{
	public partial class ArgumentRelationalValidationExtensionTests
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsBetweenExclusiveTest38ThrowsArgumentNullException879()
{
	this.RequireArgumentIsBetweenExclusiveTest38
		(new float?((float)0), (string)null, new float?((float)1), (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest38ThrowsArgumentOutOfRangeException544()
{
	this.RequireArgumentIsBetweenExclusiveTest38
		(new float?((float)0), "", new float?((float)1), (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest38ThrowsArgumentOutOfRangeException409()
{
	this.RequireArgumentIsBetweenExclusiveTest38
		(new float?((float)0), "\0", new float?((float)1), (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenExclusiveTest38648()
{
	this.RequireArgumentIsBetweenExclusiveTest38
		(default(float?), "\0", new float?((float)1), (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest38ThrowsArgumentOutOfRangeException944()
{
	this.RequireArgumentIsBetweenExclusiveTest38
		(new float?((float)(-1)), "\0", new float?((float)1), (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest38ThrowsArgumentOutOfRangeException388()
{
	this.RequireArgumentIsBetweenExclusiveTest38
		(new float?((float)0), "Ā", new float?((float)1), (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest38ThrowsArgumentOutOfRangeException999()
{
	this.RequireArgumentIsBetweenExclusiveTest38
		(new float?((float)0), "\t", new float?((float)1), (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest38ThrowsArgumentOutOfRangeException283()
{
	this.RequireArgumentIsBetweenExclusiveTest38
		(new float?((float)0), "\t\0", new float?((float)1), (float)0);
}
	}
}
