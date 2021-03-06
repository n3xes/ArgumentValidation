using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsBetweenTest64.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest64ThrowsArgumentNullException647()
{
	this.RequireArgumentIsBetweenTest64
		((short)32, (string)null, (short)32, (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest64ThrowsArgumentOutOfRangeException853()
{
	this.RequireArgumentIsBetweenTest64((short)32, "", (short)32, (short)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenTest6479()
{
	this.RequireArgumentIsBetweenTest64((short)32, "\0", (short)32, (short)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest64ThrowsArgumentOutOfRangeException436()
{
	this.RequireArgumentIsBetweenTest64((short)33, "\0", (short)32, (short)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest64ThrowsArgumentOutOfRangeException553()
{
	this.RequireArgumentIsBetweenTest64((short)33, "\0", (short)34, (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenTest64350()
{
	this.RequireArgumentIsBetweenTest64((short)32, "Ā", (short)32, (short)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest64ThrowsArgumentOutOfRangeException551()
{
	this.RequireArgumentIsBetweenTest64((short)32, "\t", (short)32, (short)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenTest64599()
{
	this.RequireArgumentIsBetweenTest64((short)32, "\t\0", (short)32, (short)32);
}
	}
}
