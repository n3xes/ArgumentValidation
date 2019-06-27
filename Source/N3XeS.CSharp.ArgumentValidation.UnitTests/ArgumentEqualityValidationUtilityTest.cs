using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3XeS.CSharp.ArgumentValidation.Utilities;

namespace N3XeS.CSharp.ArgumentValidation.Utilities.UnitTests
{
    /// <summary>This class contains parameterized unit tests for ArgumentEqualityValidationUtility</summary>
    [TestClass]
    [PexClass(typeof(ArgumentEqualityValidationUtility))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ArgumentEqualityValidationUtilityTest
    {

		/// <summary>Test stub for RequireArgumentApproximatelyDefaultValue(Double, String)</summary>
		[PexMethod]
		public void RequireArgumentApproximatelyDefaultValueTest(double valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentApproximatelyDefaultValue
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentApproximatelyDefaultValueTest(Double, String)
		}

		/// <summary>Test stub for RequireArgumentApproximatelyDefaultValue(Single, String)</summary>
		[PexMethod]
		public void RequireArgumentApproximatelyDefaultValueTest01(float valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentApproximatelyDefaultValue
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentApproximatelyDefaultValueTest01(Single, String)
		}

		/// <summary>Test stub for RequireArgumentApproximatelyEqual(Double, Double, String)</summary>
		[PexMethod]
		public void RequireArgumentApproximatelyEqualTest(
			double valueArgumentA,
			double valueArgumentB,
			string nameArgument
		)
		{
			ArgumentEqualityValidationUtility.RequireArgumentApproximatelyEqual
				(valueArgumentA, valueArgumentB, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentApproximatelyEqualTest(Double, Double, String)
		}

		/// <summary>Test stub for RequireArgumentApproximatelyEqual(Nullable`1&lt;Double&gt;, Double, String)</summary>
		[PexMethod]
		public void RequireArgumentApproximatelyEqualTest01(
			double? valueArgumentA,
			double valueArgumentB,
			string nameArgument
		)
		{
			ArgumentEqualityValidationUtility.RequireArgumentApproximatelyEqual
				(valueArgumentA, valueArgumentB, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentApproximatelyEqualTest01(Nullable`1<Double>, Double, String)
		}

		/// <summary>Test stub for RequireArgumentApproximatelyEqual(Double, Nullable`1&lt;Double&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentApproximatelyEqualTest02(
			double valueArgumentA,
			double? valueArgumentB,
			string nameArgument
		)
		{
			ArgumentEqualityValidationUtility.RequireArgumentApproximatelyEqual
				(valueArgumentA, valueArgumentB, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentApproximatelyEqualTest02(Double, Nullable`1<Double>, String)
		}

		/// <summary>Test stub for RequireArgumentApproximatelyEqual(Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentApproximatelyEqualTest03(
			double? valueArgumentA,
			double? valueArgumentB,
			string nameArgument
		)
		{
			ArgumentEqualityValidationUtility.RequireArgumentApproximatelyEqual
				(valueArgumentA, valueArgumentB, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentApproximatelyEqualTest03(Nullable`1<Double>, Nullable`1<Double>, String)
		}

		/// <summary>Test stub for RequireArgumentApproximatelyEqual(Single, Single, String)</summary>
		[PexMethod]
		public void RequireArgumentApproximatelyEqualTest04(
			float valueArgumentA,
			float valueArgumentB,
			string nameArgument
		)
		{
			ArgumentEqualityValidationUtility.RequireArgumentApproximatelyEqual
				(valueArgumentA, valueArgumentB, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentApproximatelyEqualTest04(Single, Single, String)
		}

		/// <summary>Test stub for RequireArgumentApproximatelyEqual(Nullable`1&lt;Single&gt;, Single, String)</summary>
		[PexMethod]
		public void RequireArgumentApproximatelyEqualTest05(
			float? valueArgumentA,
			float valueArgumentB,
			string nameArgument
		)
		{
			ArgumentEqualityValidationUtility.RequireArgumentApproximatelyEqual
				(valueArgumentA, valueArgumentB, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentApproximatelyEqualTest05(Nullable`1<Single>, Single, String)
		}

		/// <summary>Test stub for RequireArgumentApproximatelyEqual(Single, Nullable`1&lt;Single&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentApproximatelyEqualTest06(
			float valueArgumentA,
			float? valueArgumentB,
			string nameArgument
		)
		{
			ArgumentEqualityValidationUtility.RequireArgumentApproximatelyEqual
				(valueArgumentA, valueArgumentB, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentApproximatelyEqualTest06(Single, Nullable`1<Single>, String)
		}

		/// <summary>Test stub for RequireArgumentApproximatelyEqual(Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentApproximatelyEqualTest07(
			float? valueArgumentA,
			float? valueArgumentB,
			string nameArgument
		)
		{
			ArgumentEqualityValidationUtility.RequireArgumentApproximatelyEqual
				(valueArgumentA, valueArgumentB, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentApproximatelyEqualTest07(Nullable`1<Single>, Nullable`1<Single>, String)
		}

		/// <summary>Test stub for RequireArgumentDefault(!!0, String)</summary>
		[PexGenericArguments(typeof(string))]
		[PexMethod]
		public void RequireArgumentDefaultTest<T>(T valueArgument, string nameArgument)
			where T : class
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefault<T>(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentDefaultTest(!!0, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(DateTime, String)</summary>
		[PexMethod]
		public void RequireArgumentDefaultValueTest(DateTime valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentDefaultValueTest(DateTime, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Nullable`1&lt;DateTime&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentDefaultValueTest01(DateTime? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentDefaultValueTest01(Nullable`1<DateTime>, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Guid, String)</summary>
		[PexMethod]
		public void RequireArgumentDefaultValueTest02(Guid valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentDefaultValueTest02(Guid, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Nullable`1&lt;Guid&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentDefaultValueTest03(Guid? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentDefaultValueTest03(Nullable`1<Guid>, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Byte, String)</summary>
		[PexMethod]
		public void RequireArgumentDefaultValueTest04(byte valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentDefaultValueTest04(Byte, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Nullable`1&lt;Byte&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentDefaultValueTest05(byte? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentDefaultValueTest05(Nullable`1<Byte>, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Char, String)</summary>
		[PexMethod]
		public void RequireArgumentDefaultValueTest06(char valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentDefaultValueTest06(Char, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Nullable`1&lt;Char&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentDefaultValueTest07(char? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentDefaultValueTest07(Nullable`1<Char>, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Decimal, String)</summary>
		[PexMethod]
		public void RequireArgumentDefaultValueTest08(decimal valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentDefaultValueTest08(Decimal, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Nullable`1&lt;Decimal&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentDefaultValueTest09(decimal? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentDefaultValueTest09(Nullable`1<Decimal>, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Nullable`1&lt;Double&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentDefaultValueTest10(double? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentDefaultValueTest10(Nullable`1<Double>, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Nullable`1&lt;Single&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentDefaultValueTest11(float? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentDefaultValueTest11(Nullable`1<Single>, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Int32, String)</summary>
		[PexMethod]
		public void RequireArgumentDefaultValueTest12(int valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentDefaultValueTest12(Int32, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Nullable`1&lt;Int32&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentDefaultValueTest13(int? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentDefaultValueTest13(Nullable`1<Int32>, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Int64, String)</summary>
		[PexMethod]
		public void RequireArgumentDefaultValueTest14(long valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentDefaultValueTest14(Int64, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Nullable`1&lt;Int64&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentDefaultValueTest15(long? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentDefaultValueTest15(Nullable`1<Int64>, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(SByte, String)</summary>
		[PexMethod]
		public void RequireArgumentDefaultValueTest16(sbyte valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentDefaultValueTest16(SByte, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Nullable`1&lt;SByte&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentDefaultValueTest17(sbyte? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentDefaultValueTest17(Nullable`1<SByte>, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Int16, String)</summary>
		[PexMethod]
		public void RequireArgumentDefaultValueTest18(short valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentDefaultValueTest18(Int16, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Nullable`1&lt;Int16&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentDefaultValueTest19(short? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentDefaultValueTest19(Nullable`1<Int16>, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(UInt32, String)</summary>
		[PexMethod]
		public void RequireArgumentDefaultValueTest20(uint valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentDefaultValueTest20(UInt32, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Nullable`1&lt;UInt32&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentDefaultValueTest21(uint? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentDefaultValueTest21(Nullable`1<UInt32>, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(UInt64, String)</summary>
		[PexMethod]
		public void RequireArgumentDefaultValueTest22(ulong valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentDefaultValueTest22(UInt64, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Nullable`1&lt;UInt64&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentDefaultValueTest23(ulong? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentDefaultValueTest23(Nullable`1<UInt64>, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(UInt16, String)</summary>
		[PexMethod]
		public void RequireArgumentDefaultValueTest24(ushort valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentDefaultValueTest24(UInt16, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Nullable`1&lt;UInt16&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentDefaultValueTest25(ushort? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentDefaultValueTest25(Nullable`1<UInt16>, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(!!0, String)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentDefaultValueTest26<T>(T valueArgument, string nameArgument)
			where T : struct
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue<T>(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentDefaultValueTest26(!!0, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Nullable`1&lt;!!0&gt;, String)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentDefaultValueTest27<T>(T? valueArgument, string nameArgument)
			where T : struct
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue<T>(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentDefaultValueTest27(Nullable`1<!!0>, String)
		}

		/// <summary>Test stub for RequireArgumentHasNoValue(String, String)</summary>
		[PexMethod]
		public void RequireArgumentHasNoValueTest(string valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentHasNoValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentHasNoValueTest(String, String)
		}

		/// <summary>Test stub for RequireArgumentHasNonwhiteSpaceValue(String, String)</summary>
		[PexMethod]
		public void RequireArgumentHasNonwhiteSpaceValueTest(string valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentHasNonwhiteSpaceValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentHasNonwhiteSpaceValueTest(String, String)
		}

		/// <summary>Test stub for RequireArgumentHasNullEmptyOrWhiteSpaceValue(String, String)</summary>
		[PexMethod]
		public void RequireArgumentHasNullEmptyOrWhiteSpaceValueTest(string valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentHasNullEmptyOrWhiteSpaceValue
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentHasNullEmptyOrWhiteSpaceValueTest(String, String)
		}

		/// <summary>Test stub for RequireArgumentHasValue(String, String)</summary>
		[PexMethod]
		public void RequireArgumentHasValueTest(string valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentHasValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentHasValueTest(String, String)
		}

		/// <summary>Test stub for RequireArgumentNotApproximatelyDefaultValue(Double, String)</summary>
		[PexMethod]
		public void RequireArgumentNotApproximatelyDefaultValueTest(double valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotApproximatelyDefaultValue
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotApproximatelyDefaultValueTest(Double, String)
		}

		/// <summary>Test stub for RequireArgumentNotApproximatelyDefaultValue(Single, String)</summary>
		[PexMethod]
		public void RequireArgumentNotApproximatelyDefaultValueTest01(float valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotApproximatelyDefaultValue
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotApproximatelyDefaultValueTest01(Single, String)
		}

		/// <summary>Test stub for RequireArgumentNotApproximatelyEqual(Double, Double, String)</summary>
		[PexMethod]
		public void RequireArgumentNotApproximatelyEqualTest(
			double valueArgumentA,
			double valueArgumentB,
			string nameArgument
		)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotApproximatelyEqual
				(valueArgumentA, valueArgumentB, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotApproximatelyEqualTest(Double, Double, String)
		}

		/// <summary>Test stub for RequireArgumentNotApproximatelyEqual(Nullable`1&lt;Double&gt;, Double, String)</summary>
		[PexMethod]
		public void RequireArgumentNotApproximatelyEqualTest01(
			double? valueArgumentA,
			double valueArgumentB,
			string nameArgument
		)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotApproximatelyEqual
				(valueArgumentA, valueArgumentB, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotApproximatelyEqualTest01(Nullable`1<Double>, Double, String)
		}

		/// <summary>Test stub for RequireArgumentNotApproximatelyEqual(Double, Nullable`1&lt;Double&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentNotApproximatelyEqualTest02(
			double valueArgumentA,
			double? valueArgumentB,
			string nameArgument
		)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotApproximatelyEqual
				(valueArgumentA, valueArgumentB, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotApproximatelyEqualTest02(Double, Nullable`1<Double>, String)
		}

		/// <summary>Test stub for RequireArgumentNotApproximatelyEqual(Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentNotApproximatelyEqualTest03(
			double? valueArgumentA,
			double? valueArgumentB,
			string nameArgument
		)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotApproximatelyEqual
				(valueArgumentA, valueArgumentB, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotApproximatelyEqualTest03(Nullable`1<Double>, Nullable`1<Double>, String)
		}

		/// <summary>Test stub for RequireArgumentNotApproximatelyEqual(Single, Single, String)</summary>
		[PexMethod]
		public void RequireArgumentNotApproximatelyEqualTest04(
			float valueArgumentA,
			float valueArgumentB,
			string nameArgument
		)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotApproximatelyEqual
				(valueArgumentA, valueArgumentB, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotApproximatelyEqualTest04(Single, Single, String)
		}

		/// <summary>Test stub for RequireArgumentNotApproximatelyEqual(Nullable`1&lt;Single&gt;, Single, String)</summary>
		[PexMethod]
		public void RequireArgumentNotApproximatelyEqualTest05(
			float? valueArgumentA,
			float valueArgumentB,
			string nameArgument
		)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotApproximatelyEqual
				(valueArgumentA, valueArgumentB, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotApproximatelyEqualTest05(Nullable`1<Single>, Single, String)
		}

		/// <summary>Test stub for RequireArgumentNotApproximatelyEqual(Single, Nullable`1&lt;Single&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentNotApproximatelyEqualTest06(
			float valueArgumentA,
			float? valueArgumentB,
			string nameArgument
		)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotApproximatelyEqual
				(valueArgumentA, valueArgumentB, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotApproximatelyEqualTest06(Single, Nullable`1<Single>, String)
		}

		/// <summary>Test stub for RequireArgumentNotApproximatelyEqual(Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentNotApproximatelyEqualTest07(
			float? valueArgumentA,
			float? valueArgumentB,
			string nameArgument
		)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotApproximatelyEqual
				(valueArgumentA, valueArgumentB, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotApproximatelyEqualTest07(Nullable`1<Single>, Nullable`1<Single>, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefault(!!0, String)</summary>
		[PexGenericArguments(typeof(string))]
		[PexMethod]
		public void RequireArgumentNotDefaultTest<T>(T valueArgument, string nameArgument)
			where T : class
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefault<T>(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotDefaultTest(!!0, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(DateTime, String)</summary>
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest(DateTime valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotDefaultValueTest(DateTime, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Nullable`1&lt;DateTime&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest01(DateTime? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotDefaultValueTest01(Nullable`1<DateTime>, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Guid, String)</summary>
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest02(Guid valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotDefaultValueTest02(Guid, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Nullable`1&lt;Guid&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest03(Guid? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotDefaultValueTest03(Nullable`1<Guid>, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Byte, String)</summary>
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest04(byte valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotDefaultValueTest04(Byte, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Nullable`1&lt;Byte&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest05(byte? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotDefaultValueTest05(Nullable`1<Byte>, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Char, String)</summary>
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest06(char valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotDefaultValueTest06(Char, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Nullable`1&lt;Char&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest07(char? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotDefaultValueTest07(Nullable`1<Char>, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Decimal, String)</summary>
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest08(decimal valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotDefaultValueTest08(Decimal, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Nullable`1&lt;Decimal&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest09(decimal? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotDefaultValueTest09(Nullable`1<Decimal>, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Nullable`1&lt;Double&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest10(double? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotDefaultValueTest10(Nullable`1<Double>, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Nullable`1&lt;Single&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest11(float? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotDefaultValueTest11(Nullable`1<Single>, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Int32, String)</summary>
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest12(int valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotDefaultValueTest12(Int32, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Nullable`1&lt;Int32&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest13(int? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotDefaultValueTest13(Nullable`1<Int32>, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Int64, String)</summary>
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest14(long valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotDefaultValueTest14(Int64, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Nullable`1&lt;Int64&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest15(long? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotDefaultValueTest15(Nullable`1<Int64>, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(SByte, String)</summary>
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest16(sbyte valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotDefaultValueTest16(SByte, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Nullable`1&lt;SByte&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest17(sbyte? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotDefaultValueTest17(Nullable`1<SByte>, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Int16, String)</summary>
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest18(short valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotDefaultValueTest18(Int16, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Nullable`1&lt;Int16&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest19(short? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotDefaultValueTest19(Nullable`1<Int16>, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(UInt32, String)</summary>
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest20(uint valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotDefaultValueTest20(UInt32, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Nullable`1&lt;UInt32&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest21(uint? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotDefaultValueTest21(Nullable`1<UInt32>, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(UInt64, String)</summary>
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest22(ulong valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotDefaultValueTest22(UInt64, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Nullable`1&lt;UInt64&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest23(ulong? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotDefaultValueTest23(Nullable`1<UInt64>, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(UInt16, String)</summary>
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest24(ushort valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotDefaultValueTest24(UInt16, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Nullable`1&lt;UInt16&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest25(ushort? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotDefaultValueTest25(Nullable`1<UInt16>, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(!!0, String)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest26<T>(T valueArgument, string nameArgument)
			where T : struct
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue<T>(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotDefaultValueTest26(!!0, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Nullable`1&lt;!!0&gt;, String)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest27<T>(T? valueArgument, string nameArgument)
			where T : struct
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue<T>(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotDefaultValueTest27(Nullable`1<!!0>, String)
		}

		/// <summary>Test stub for RequireArgumentNotNull(!!0, String)</summary>
		[PexGenericArguments(typeof(string))]
		[PexMethod]
		public void RequireArgumentNotNullTest<T>(T valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotNull<T>(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotNullTest(!!0, String)
		}

		/// <summary>Test stub for RequireArgumentNotNull(Nullable`1&lt;!!0&gt;, String)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentNotNullTest01<T>(T? valueArgument, string nameArgument)
			where T : struct
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotNull<T>(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNotNullTest01(Nullable`1<!!0>, String)
		}

		/// <summary>Test stub for RequireArgumentNull(!!0, String)</summary>
		[PexGenericArguments(typeof(string))]
		[PexMethod]
		public void RequireArgumentNullTest<T>(T valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNull<T>(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNullTest(!!0, String)
		}

		/// <summary>Test stub for RequireArgumentNull(Nullable`1&lt;!!0&gt;, String)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentNullTest01<T>(T? valueArgument, string nameArgument)
			where T : struct
		{
			ArgumentEqualityValidationUtility.RequireArgumentNull<T>(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationUtilityTest.RequireArgumentNullTest01(Nullable`1<!!0>, String)
		}
	}
}
