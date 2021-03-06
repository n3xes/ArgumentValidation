// <copyright file="ArgumentFloatingPointNumberParityValidationExtensionTests.cs">Copyright © N3XeS LLC 2016</copyright>

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3XeS.CSharp.ArgumentValidation.Extensions;

namespace N3XeS.CSharp.ArgumentValidation.Extensions.UnitTests
{
	/// <summary>This class contains parameterized unit tests for ArgumentFloatingPointNumberParityValidationExtension</summary>
	[TestClass]
	[ExcludeFromCodeCoverage]
	[PexClass(typeof(ArgumentFloatingPointNumberParityValidationExtension))]
	[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
	[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
	public partial class ArgumentFloatingPointNumberParityValidationExtensionTests
	{

		/// <summary>Test stub for RequireArgumentIsEven(Double, String)</summary>
		[PexMethod]
		public void RequireArgumentIsEvenTest(double valueArgument, string nameArgument)
		{
			ArgumentFloatingPointNumberParityValidationExtension.RequireArgumentIsEven
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentFloatingPointNumberParityValidationExtensionTests.RequireArgumentIsEvenTest(Double, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(Nullable`1&lt;Double&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsEvenTest01(double? valueArgument, string nameArgument)
		{
			ArgumentFloatingPointNumberParityValidationExtension.RequireArgumentIsEven
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentFloatingPointNumberParityValidationExtensionTests.RequireArgumentIsEvenTest01(Nullable`1<Double>, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(Single, String)</summary>
		[PexMethod]
		public void RequireArgumentIsEvenTest02(float valueArgument, string nameArgument)
		{
			ArgumentFloatingPointNumberParityValidationExtension.RequireArgumentIsEven
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentFloatingPointNumberParityValidationExtensionTests.RequireArgumentIsEvenTest02(Single, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(Nullable`1&lt;Single&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsEvenTest03(float? valueArgument, string nameArgument)
		{
			ArgumentFloatingPointNumberParityValidationExtension.RequireArgumentIsEven
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentFloatingPointNumberParityValidationExtensionTests.RequireArgumentIsEvenTest03(Nullable`1<Single>, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(Double, String)</summary>
		[PexMethod]
		public void RequireArgumentIsOddTest(double valueArgument, string nameArgument)
		{
			ArgumentFloatingPointNumberParityValidationExtension.RequireArgumentIsOdd
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentFloatingPointNumberParityValidationExtensionTests.RequireArgumentIsOddTest(Double, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(Nullable`1&lt;Double&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOddTest01(double? valueArgument, string nameArgument)
		{
			ArgumentFloatingPointNumberParityValidationExtension.RequireArgumentIsOdd
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentFloatingPointNumberParityValidationExtensionTests.RequireArgumentIsOddTest01(Nullable`1<Double>, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(Single, String)</summary>
		[PexMethod]
		public void RequireArgumentIsOddTest02(float valueArgument, string nameArgument)
		{
			ArgumentFloatingPointNumberParityValidationExtension.RequireArgumentIsOdd
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentFloatingPointNumberParityValidationExtensionTests.RequireArgumentIsOddTest02(Single, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(Nullable`1&lt;Single&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOddTest03(float? valueArgument, string nameArgument)
		{
			ArgumentFloatingPointNumberParityValidationExtension.RequireArgumentIsOdd
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentFloatingPointNumberParityValidationExtensionTests.RequireArgumentIsOddTest03(Nullable`1<Single>, String)
		}
	}
}
