// <copyright file="TypeTestingExtensionTest.cs">Copyright © N3XeS LLC 2016</copyright>

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3XeS.CSharp.ArgumentValidation.Extensions;

namespace N3XeS.CSharp.ArgumentValidation.Extensions.UnitTests
{
	/// <summary>This class contains parameterized unit tests for TypeTestingExtension</summary>
	[TestClass]
	[ExcludeFromCodeCoverage]
	[PexClass(typeof(TypeTestingExtension))]
	[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
	[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
	public partial class TypeTestingExtensionTest
	{

		/// <summary>Test stub for IsBoxedTypeOf(Object)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsBoxedTypeOfTest<T>(object valueBoxed)
		{
			bool result = TypeTestingExtension.IsBoxedTypeOf<T>(valueBoxed);
			return result;
			// TODO: add assertions to method TypeTestingExtensionTest.IsBoxedTypeOfTest(Object)
		}

		/// <summary>Test stub for IsNotBoxedTypeOf(Object)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsNotBoxedTypeOfTest<T>(object valueBoxed)
		{
			bool result = TypeTestingExtension.IsNotBoxedTypeOf<T>(valueBoxed);
			return result;
			// TODO: add assertions to method TypeTestingExtensionTest.IsNotBoxedTypeOfTest(Object)
		}

	}
}
