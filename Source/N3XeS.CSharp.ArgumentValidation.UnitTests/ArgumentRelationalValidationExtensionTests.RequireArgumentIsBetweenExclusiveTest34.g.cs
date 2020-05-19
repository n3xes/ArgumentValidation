using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsBetweenExclusiveTest34.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest34ThrowsArgumentNullException138()
{
	this.RequireArgumentIsBetweenExclusiveTest34
		((float)0, (string)null, new float?((float)0), (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest34ThrowsArgumentOutOfRangeException761()
{
	this.RequireArgumentIsBetweenExclusiveTest34
		((float)0, "", new float?((float)0), (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest34ThrowsArgumentOutOfRangeException61()
{
	this.RequireArgumentIsBetweenExclusiveTest34
		((float)0, "\0", new float?((float)0), (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest34ThrowsArgumentOutOfRangeException603()
{
	this.RequireArgumentIsBetweenExclusiveTest34
		((float)0, "\0", new float?((float)0), (float)1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenExclusiveTest34372()
{
	this.RequireArgumentIsBetweenExclusiveTest34
		((float)0, "\0", new float?((float)(-1)), (float)1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest34ThrowsArgumentOutOfRangeException348()
{
	this.RequireArgumentIsBetweenExclusiveTest34
		((float)0, "Ā", new float?((float)0), (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenExclusiveTest34504()
{
	this.RequireArgumentIsBetweenExclusiveTest34
		((float)0, "\0", default(float?), (float)1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest34ThrowsArgumentOutOfRangeException23()
{
	this.RequireArgumentIsBetweenExclusiveTest34
		((float)0, "\t", new float?((float)0), (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest34ThrowsArgumentOutOfRangeException459()
{
	this.RequireArgumentIsBetweenExclusiveTest34
		((float)0, "\n\0", new float?((float)0), (float)0);
}
	}
}
