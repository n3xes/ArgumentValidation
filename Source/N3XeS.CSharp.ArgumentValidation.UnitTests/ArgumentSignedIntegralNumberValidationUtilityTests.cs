// <copyright file="ArgumentSignedIntegralNumberValidationUtilityTests.cs">Copyright © N3XeS LLC 2016</copyright>

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3XeS.CSharp.ArgumentValidation.Utilities;

namespace N3XeS.CSharp.ArgumentValidation.Utilities.UnitTests
{
	/// <summary>This class contains parameterized unit tests for ArgumentSignedIntegralNumberValidationUtility</summary>
	[TestClass]
	[ExcludeFromCodeCoverage]
	[PexClass(typeof(ArgumentSignedIntegralNumberValidationUtility))]
	[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
	[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
	public partial class ArgumentSignedIntegralNumberValidationUtilityTests
	{

		/// <summary>Test stub for RequireArgumentIsNegative(Decimal, String)</summary>
		[PexMethod]
		public void RequireArgumentIsNegativeTest(decimal valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationUtility.RequireArgumentIsNegative(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationUtilityTests.RequireArgumentIsNegativeTest(Decimal, String)
		}

		/// <summary>Test stub for RequireArgumentIsNegative(Nullable`1&lt;Decimal&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentIsNegativeTest01(decimal? valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationUtility.RequireArgumentIsNegative(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationUtilityTests.RequireArgumentIsNegativeTest01(Nullable`1<Decimal>, String)
		}

		/// <summary>Test stub for RequireArgumentIsNegative(Int32, String)</summary>
		[PexMethod]
		public void RequireArgumentIsNegativeTest02(int valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationUtility.RequireArgumentIsNegative(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationUtilityTests.RequireArgumentIsNegativeTest02(Int32, String)
		}

		/// <summary>Test stub for RequireArgumentIsNegative(Nullable`1&lt;Int32&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentIsNegativeTest03(int? valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationUtility.RequireArgumentIsNegative(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationUtilityTests.RequireArgumentIsNegativeTest03(Nullable`1<Int32>, String)
		}

		/// <summary>Test stub for RequireArgumentIsNegative(Int64, String)</summary>
		[PexMethod]
		public void RequireArgumentIsNegativeTest04(long valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationUtility.RequireArgumentIsNegative(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationUtilityTests.RequireArgumentIsNegativeTest04(Int64, String)
		}

		/// <summary>Test stub for RequireArgumentIsNegative(Nullable`1&lt;Int64&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentIsNegativeTest05(long? valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationUtility.RequireArgumentIsNegative(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationUtilityTests.RequireArgumentIsNegativeTest05(Nullable`1<Int64>, String)
		}

		/// <summary>Test stub for RequireArgumentIsNegative(SByte, String)</summary>
		[PexMethod]
		public void RequireArgumentIsNegativeTest06(sbyte valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationUtility.RequireArgumentIsNegative(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationUtilityTests.RequireArgumentIsNegativeTest06(SByte, String)
		}

		/// <summary>Test stub for RequireArgumentIsNegative(Nullable`1&lt;SByte&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentIsNegativeTest07(sbyte? valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationUtility.RequireArgumentIsNegative(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationUtilityTests.RequireArgumentIsNegativeTest07(Nullable`1<SByte>, String)
		}

		/// <summary>Test stub for RequireArgumentIsNegative(Int16, String)</summary>
		[PexMethod]
		public void RequireArgumentIsNegativeTest08(short valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationUtility.RequireArgumentIsNegative(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationUtilityTests.RequireArgumentIsNegativeTest08(Int16, String)
		}

		/// <summary>Test stub for RequireArgumentIsNegative(Nullable`1&lt;Int16&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentIsNegativeTest09(short? valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationUtility.RequireArgumentIsNegative(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationUtilityTests.RequireArgumentIsNegativeTest09(Nullable`1<Int16>, String)
		}

		/// <summary>Test stub for RequireArgumentIsPositive(Decimal, String)</summary>
		[PexMethod]
		public void RequireArgumentIsPositiveTest(decimal valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationUtility.RequireArgumentIsPositive(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationUtilityTests.RequireArgumentIsPositiveTest(Decimal, String)
		}

		/// <summary>Test stub for RequireArgumentIsPositive(Nullable`1&lt;Decimal&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentIsPositiveTest01(decimal? valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationUtility.RequireArgumentIsPositive(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationUtilityTests.RequireArgumentIsPositiveTest01(Nullable`1<Decimal>, String)
		}

		/// <summary>Test stub for RequireArgumentIsPositive(Int32, String)</summary>
		[PexMethod]
		public void RequireArgumentIsPositiveTest02(int valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationUtility.RequireArgumentIsPositive(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationUtilityTests.RequireArgumentIsPositiveTest02(Int32, String)
		}

		/// <summary>Test stub for RequireArgumentIsPositive(Nullable`1&lt;Int32&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentIsPositiveTest03(int? valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationUtility.RequireArgumentIsPositive(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationUtilityTests.RequireArgumentIsPositiveTest03(Nullable`1<Int32>, String)
		}

		/// <summary>Test stub for RequireArgumentIsPositive(Int64, String)</summary>
		[PexMethod]
		public void RequireArgumentIsPositiveTest04(long valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationUtility.RequireArgumentIsPositive(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationUtilityTests.RequireArgumentIsPositiveTest04(Int64, String)
		}

		/// <summary>Test stub for RequireArgumentIsPositive(Nullable`1&lt;Int64&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentIsPositiveTest05(long? valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationUtility.RequireArgumentIsPositive(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationUtilityTests.RequireArgumentIsPositiveTest05(Nullable`1<Int64>, String)
		}

		/// <summary>Test stub for RequireArgumentIsPositive(SByte, String)</summary>
		[PexMethod]
		public void RequireArgumentIsPositiveTest06(sbyte valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationUtility.RequireArgumentIsPositive(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationUtilityTests.RequireArgumentIsPositiveTest06(SByte, String)
		}

		/// <summary>Test stub for RequireArgumentIsPositive(Nullable`1&lt;SByte&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentIsPositiveTest07(sbyte? valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationUtility.RequireArgumentIsPositive(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationUtilityTests.RequireArgumentIsPositiveTest07(Nullable`1<SByte>, String)
		}

		/// <summary>Test stub for RequireArgumentIsPositive(Int16, String)</summary>
		[PexMethod]
		public void RequireArgumentIsPositiveTest08(short valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationUtility.RequireArgumentIsPositive(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationUtilityTests.RequireArgumentIsPositiveTest08(Int16, String)
		}

		/// <summary>Test stub for RequireArgumentIsPositive(Nullable`1&lt;Int16&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentIsPositiveTest09(short? valueArgument, string nameArgument)
		{
			ArgumentSignedIntegralNumberValidationUtility.RequireArgumentIsPositive(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedIntegralNumberValidationUtilityTests.RequireArgumentIsPositiveTest09(Nullable`1<Int16>, String)
		}
	}
}
