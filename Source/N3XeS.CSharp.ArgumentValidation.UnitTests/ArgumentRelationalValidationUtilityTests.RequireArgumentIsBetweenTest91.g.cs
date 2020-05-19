using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsBetweenTest91.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentRelationalValidationUtilityTests
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsBetweenTest91ThrowsArgumentNullException606()
{
	this.RequireArgumentIsBetweenTest91
		((ushort)65, (string)null, default(ushort?), default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest91ThrowsArgumentOutOfRangeException358()
{
	this.RequireArgumentIsBetweenTest91
		((ushort)65, "", default(ushort?), default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest916()
{
	this.RequireArgumentIsBetweenTest91
		((ushort)65, "\0", default(ushort?), default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest91ThrowsArgumentOutOfRangeException721()
{
	this.RequireArgumentIsBetweenTest91
		((ushort)65, "\0", default(ushort?), new ushort?((ushort)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest9161()
{
	this.RequireArgumentIsBetweenTest91
		((ushort)65, "\0", new ushort?((ushort)0), default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest91ThrowsArgumentOutOfRangeException622()
{
	this.RequireArgumentIsBetweenTest91
		((ushort)32, "\0", new ushort?((ushort)33), default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest91451()
{
	this.RequireArgumentIsBetweenTest91
		((ushort)65, "Ā", default(ushort?), default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest91ThrowsArgumentOutOfRangeException14()
{
	this.RequireArgumentIsBetweenTest91
		((ushort)65, "\t", default(ushort?), default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest9132()
{
	this.RequireArgumentIsBetweenTest91
		((ushort)65, "\t\0", default(ushort?), default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest91ThrowsArgumentOutOfRangeException565()
{
	this.RequireArgumentIsBetweenTest91
		((ushort)33, "\t\t", new ushort?((ushort)96), new ushort?((ushort)48));
}
	}
}
