// <copyright file="ArgumentSignedIntegralNumberValidationExtensionTests.cs">Copyright © N3XeS LLC 2016</copyright>

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3XeS.CSharp.ArgumentValidation.Extensions;

namespace N3XeS.CSharp.ArgumentValidation.Extensions.UnitTests
{
	/// <summary>This class contains parameterized unit tests for ArgumentSignedIntegralNumberValidationExtension</summary>
	[TestClass]
	[ExcludeFromCodeCoverage]
	[PexClass(typeof(ArgumentSignedIntegralNumberValidationExtension))]
	[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
	[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
	public partial class ArgumentSignedIntegralNumberValidationExtensionTests
	{

		/// <summary>Test stub for RequireArgumentIsNegative(Decimal, String)</summary>
		[PexMethod]
		public void RequireArgumentIsNegativeTest(decimal valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationExtension.RequireArgumentIsNegative
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationExtensionTests.RequireArgumentIsNegativeTest(Decimal, String)
		}

		/// <summary>Test stub for RequireArgumentIsNegative(Nullable`1&lt;Decimal&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsNegativeTest01(decimal? valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationExtension.RequireArgumentIsNegative
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationExtensionTests.RequireArgumentIsNegativeTest01(Nullable`1<Decimal>, String)
		}

		/// <summary>Test stub for RequireArgumentIsNegative(Int32, String)</summary>
		[PexMethod]
		public void RequireArgumentIsNegativeTest02(int valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationExtension.RequireArgumentIsNegative
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationExtensionTests.RequireArgumentIsNegativeTest02(Int32, String)
		}

		/// <summary>Test stub for RequireArgumentIsNegative(Nullable`1&lt;Int32&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsNegativeTest03(int? valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationExtension.RequireArgumentIsNegative
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationExtensionTests.RequireArgumentIsNegativeTest03(Nullable`1<Int32>, String)
		}

		/// <summary>Test stub for RequireArgumentIsNegative(Int64, String)</summary>
		[PexMethod]
		public void RequireArgumentIsNegativeTest04(long valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationExtension.RequireArgumentIsNegative
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationExtensionTests.RequireArgumentIsNegativeTest04(Int64, String)
		}

		/// <summary>Test stub for RequireArgumentIsNegative(Nullable`1&lt;Int64&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsNegativeTest05(long? valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationExtension.RequireArgumentIsNegative
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationExtensionTests.RequireArgumentIsNegativeTest05(Nullable`1<Int64>, String)
		}

		/// <summary>Test stub for RequireArgumentIsNegative(SByte, String)</summary>
		[PexMethod]
		public void RequireArgumentIsNegativeTest06(sbyte valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationExtension.RequireArgumentIsNegative
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationExtensionTests.RequireArgumentIsNegativeTest06(SByte, String)
		}

		/// <summary>Test stub for RequireArgumentIsNegative(Nullable`1&lt;SByte&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsNegativeTest07(sbyte? valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationExtension.RequireArgumentIsNegative
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationExtensionTests.RequireArgumentIsNegativeTest07(Nullable`1<SByte>, String)
		}

		/// <summary>Test stub for RequireArgumentIsNegative(Int16, String)</summary>
		[PexMethod]
		public void RequireArgumentIsNegativeTest08(short valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationExtension.RequireArgumentIsNegative
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationExtensionTests.RequireArgumentIsNegativeTest08(Int16, String)
		}

		/// <summary>Test stub for RequireArgumentIsNegative(Nullable`1&lt;Int16&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsNegativeTest09(short? valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationExtension.RequireArgumentIsNegative
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationExtensionTests.RequireArgumentIsNegativeTest09(Nullable`1<Int16>, String)
		}

		/// <summary>Test stub for RequireArgumentIsPositive(Decimal, String)</summary>
		[PexMethod]
		public void RequireArgumentIsPositiveTest(decimal valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationExtension.RequireArgumentIsPositive
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationExtensionTests.RequireArgumentIsPositiveTest(Decimal, String)
		}

		/// <summary>Test stub for RequireArgumentIsPositive(Nullable`1&lt;Decimal&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsPositiveTest01(decimal? valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationExtension.RequireArgumentIsPositive
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationExtensionTests.RequireArgumentIsPositiveTest01(Nullable`1<Decimal>, String)
		}

		/// <summary>Test stub for RequireArgumentIsPositive(Int32, String)</summary>
		[PexMethod]
		public void RequireArgumentIsPositiveTest02(int valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationExtension.RequireArgumentIsPositive
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationExtensionTests.RequireArgumentIsPositiveTest02(Int32, String)
		}

		/// <summary>Test stub for RequireArgumentIsPositive(Nullable`1&lt;Int32&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsPositiveTest03(int? valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationExtension.RequireArgumentIsPositive
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationExtensionTests.RequireArgumentIsPositiveTest03(Nullable`1<Int32>, String)
		}

		/// <summary>Test stub for RequireArgumentIsPositive(Int64, String)</summary>
		[PexMethod]
		public void RequireArgumentIsPositiveTest04(long valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationExtension.RequireArgumentIsPositive
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationExtensionTests.RequireArgumentIsPositiveTest04(Int64, String)
		}

		/// <summary>Test stub for RequireArgumentIsPositive(Nullable`1&lt;Int64&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsPositiveTest05(long? valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationExtension.RequireArgumentIsPositive
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationExtensionTests.RequireArgumentIsPositiveTest05(Nullable`1<Int64>, String)
		}

		/// <summary>Test stub for RequireArgumentIsPositive(SByte, String)</summary>
		[PexMethod]
		public void RequireArgumentIsPositiveTest06(sbyte valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationExtension.RequireArgumentIsPositive
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationExtensionTests.RequireArgumentIsPositiveTest06(SByte, String)
		}

		/// <summary>Test stub for RequireArgumentIsPositive(Nullable`1&lt;SByte&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsPositiveTest07(sbyte? valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationExtension.RequireArgumentIsPositive
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationExtensionTests.RequireArgumentIsPositiveTest07(Nullable`1<SByte>, String)
		}

		/// <summary>Test stub for RequireArgumentIsPositive(Int16, String)</summary>
		[PexMethod]
		public void RequireArgumentIsPositiveTest08(short valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationExtension.RequireArgumentIsPositive
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationExtensionTests.RequireArgumentIsPositiveTest08(Int16, String)
		}

		/// <summary>Test stub for RequireArgumentIsPositive(Nullable`1&lt;Int16&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsPositiveTest09(short? valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationExtension.RequireArgumentIsPositive
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationExtensionTests.RequireArgumentIsPositiveTest09(Nullable`1<Int16>, String)
		}
	}
}
