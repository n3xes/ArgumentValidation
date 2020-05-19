using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsBetweenExclusiveTest33.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest33ThrowsArgumentNullException568()
{
	this.RequireArgumentIsBetweenExclusiveTest33
		((float)0, (string)null, (float)0, new float?((float)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest33ThrowsArgumentOutOfRangeException119()
{
	this.RequireArgumentIsBetweenExclusiveTest33
		((float)0, "", (float)0, new float?((float)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest33ThrowsArgumentOutOfRangeException60()
{
	this.RequireArgumentIsBetweenExclusiveTest33
		((float)0, "\0", (float)0, new float?((float)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest33ThrowsArgumentOutOfRangeException342()
{
	this.RequireArgumentIsBetweenExclusiveTest33
		((float)0, "\0", (float)0, default(float?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest33ThrowsArgumentOutOfRangeException588()
{
	this.RequireArgumentIsBetweenExclusiveTest33
		((float)0, "Ā", (float)0, new float?((float)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenExclusiveTest33579()
{
	this.RequireArgumentIsBetweenExclusiveTest33
		((float)1, "\0", (float)0, default(float?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest33ThrowsArgumentOutOfRangeException667()
{
	this.RequireArgumentIsBetweenExclusiveTest33
		((float)0, "\t", (float)0, new float?((float)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest33ThrowsArgumentOutOfRangeException423()
{
	this.RequireArgumentIsBetweenExclusiveTest33
		((float)0, "\n\0", (float)0, new float?((float)0));
}
	}
}
