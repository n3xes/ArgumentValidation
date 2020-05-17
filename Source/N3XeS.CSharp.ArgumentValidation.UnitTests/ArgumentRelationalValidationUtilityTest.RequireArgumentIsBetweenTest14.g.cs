using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsBetweenTest14.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest14ThrowsArgumentNullException996()
{
	this.RequireArgumentIsBetweenTest14
		(new byte?((byte)1), (string)null, new byte?((byte)1), (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest14ThrowsArgumentOutOfRangeException447()
{
	this.RequireArgumentIsBetweenTest14
		(new byte?((byte)1), "", new byte?((byte)1), (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest14ThrowsArgumentOutOfRangeException424()
{
	this.RequireArgumentIsBetweenTest14
		(new byte?((byte)1), "\0", new byte?((byte)1), (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenTest14373()
{
	this.RequireArgumentIsBetweenTest14
		(default(byte?), "\0", new byte?((byte)1), (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenTest14812()
{
	this.RequireArgumentIsBetweenTest14
		(new byte?((byte)1), "\0", new byte?((byte)1), (byte)128);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest14ThrowsArgumentOutOfRangeException874()
{
	this.RequireArgumentIsBetweenTest14
		(new byte?((byte)1), "\0", new byte?((byte)2), (byte)128);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest14ThrowsArgumentOutOfRangeException832()
{
	this.RequireArgumentIsBetweenTest14
		(new byte?((byte)1), "Ā", new byte?((byte)1), (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest14ThrowsArgumentOutOfRangeException586()
{
	this.RequireArgumentIsBetweenTest14
		(new byte?((byte)1), "\t", new byte?((byte)1), (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest14ThrowsArgumentOutOfRangeException193()
{
	this.RequireArgumentIsBetweenTest14
		(new byte?((byte)1), "\t\0", new byte?((byte)1), (byte)0);
}
	}
}
