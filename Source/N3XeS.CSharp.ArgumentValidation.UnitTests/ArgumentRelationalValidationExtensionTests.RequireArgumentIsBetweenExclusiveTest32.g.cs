using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsBetweenExclusiveTest32.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest32ThrowsArgumentNullException447()
{
	this.RequireArgumentIsBetweenExclusiveTest32
		((float)0, (string)null, (float)0, (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest32ThrowsArgumentOutOfRangeException645()
{
	this.RequireArgumentIsBetweenExclusiveTest32((float)0, "", (float)0, (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest32ThrowsArgumentOutOfRangeException692()
{
	this.RequireArgumentIsBetweenExclusiveTest32((float)0, "\0", (float)0, (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest32ThrowsArgumentOutOfRangeException129()
{
	this.RequireArgumentIsBetweenExclusiveTest32((float)0, "\0", (float)0, (float)1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenExclusiveTest32372()
{
	this.RequireArgumentIsBetweenExclusiveTest32
		((float)0, "\0", (float)(-1), (float)1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest32ThrowsArgumentOutOfRangeException370()
{
	this.RequireArgumentIsBetweenExclusiveTest32((float)0, "Ā", (float)0, (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest32ThrowsArgumentOutOfRangeException568()
{
	this.RequireArgumentIsBetweenExclusiveTest32((float)0, "\t", (float)0, (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest32ThrowsArgumentOutOfRangeException794()
{
	this.RequireArgumentIsBetweenExclusiveTest32
		((float)0, "\t\0", (float)0, (float)0);
}
	}
}
