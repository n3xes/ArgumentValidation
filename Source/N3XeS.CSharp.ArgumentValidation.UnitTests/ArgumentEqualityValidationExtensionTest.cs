using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3XeS.CSharp.ArgumentValidation.Extensions;

namespace N3XeS.CSharp.ArgumentValidation.Extensions.UnitTests
{
    /// <summary>This class contains parameterized unit tests for ArgumentEqualityValidationExtension</summary>
    [TestClass]
    [PexClass(typeof(ArgumentEqualityValidationExtension))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ArgumentEqualityValidationExtensionTest
    {

		/// <summary>Test stub for RequireArgumentApproximatelyDefaultValue(Double, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentApproximatelyDefaultValueTest(double valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentApproximatelyDefaultValue
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentApproximatelyDefaultValueTest(Double, String)
		}

		/// <summary>Test stub for RequireArgumentApproximatelyEqual(Double, Double, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentApproximatelyEqualTest(
			double valueArgumentA,
			double valueArgumentB,
			string nameArgument
		)
		{
			ArgumentEqualityValidationExtension.RequireArgumentApproximatelyEqual
				(valueArgumentA, valueArgumentB, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentApproximatelyEqualTest(Double, Double, String)
		}

		/// <summary>Test stub for RequireArgumentApproximatelyEqual(Nullable`1&lt;Double&gt;, Double, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentApproximatelyEqualTest01(
			double? valueArgumentA,
			double valueArgumentB,
			string nameArgument
		)
		{
			ArgumentEqualityValidationExtension.RequireArgumentApproximatelyEqual
				(valueArgumentA, valueArgumentB, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentApproximatelyEqualTest01(Nullable`1<Double>, Double, String)
		}

		/// <summary>Test stub for RequireArgumentApproximatelyEqual(Double, Nullable`1&lt;Double&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentApproximatelyEqualTest02(
			double valueArgumentA,
			double? valueArgumentB,
			string nameArgument
		)
		{
			ArgumentEqualityValidationExtension.RequireArgumentApproximatelyEqual
				(valueArgumentA, valueArgumentB, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentApproximatelyEqualTest02(Double, Nullable`1<Double>, String)
		}

		/// <summary>Test stub for RequireArgumentApproximatelyEqual(Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentApproximatelyEqualTest03(
			double? valueArgumentA,
			double? valueArgumentB,
			string nameArgument
		)
		{
			ArgumentEqualityValidationExtension.RequireArgumentApproximatelyEqual
				(valueArgumentA, valueArgumentB, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentApproximatelyEqualTest03(Nullable`1<Double>, Nullable`1<Double>, String)
		}

		/// <summary>Test stub for RequireArgumentApproximatelyEqual(Single, Single, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentApproximatelyEqualTest04(
			float valueArgumentA,
			float valueArgumentB,
			string nameArgument
		)
		{
			ArgumentEqualityValidationExtension.RequireArgumentApproximatelyEqual
				(valueArgumentA, valueArgumentB, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentApproximatelyEqualTest04(Single, Single, String)
		}

		/// <summary>Test stub for RequireArgumentApproximatelyEqual(Nullable`1&lt;Single&gt;, Single, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentApproximatelyEqualTest05(
			float? valueArgumentA,
			float valueArgumentB,
			string nameArgument
		)
		{
			ArgumentEqualityValidationExtension.RequireArgumentApproximatelyEqual
				(valueArgumentA, valueArgumentB, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentApproximatelyEqualTest05(Nullable`1<Single>, Single, String)
		}

		/// <summary>Test stub for RequireArgumentApproximatelyEqual(Single, Nullable`1&lt;Single&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentApproximatelyEqualTest06(
			float valueArgumentA,
			float? valueArgumentB,
			string nameArgument
		)
		{
			ArgumentEqualityValidationExtension.RequireArgumentApproximatelyEqual
				(valueArgumentA, valueArgumentB, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentApproximatelyEqualTest06(Single, Nullable`1<Single>, String)
		}

		/// <summary>Test stub for RequireArgumentApproximatelyEqual(Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentApproximatelyEqualTest07(
			float? valueArgumentA,
			float? valueArgumentB,
			string nameArgument
		)
		{
			ArgumentEqualityValidationExtension.RequireArgumentApproximatelyEqual
				(valueArgumentA, valueArgumentB, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentApproximatelyEqualTest07(Nullable`1<Single>, Nullable`1<Single>, String)
		}

		/// <summary>Test stub for RequireArgumentDefault(!!0, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(string))]
		[PexMethod]
		public void RequireArgumentDefaultTest<T>(T valueArgument, string nameArgument)
			where T : class
		{
			ArgumentEqualityValidationExtension.RequireArgumentDefault<T>(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentDefaultTest(!!0, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(DateTime, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentDefaultValueTest(DateTime valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentDefaultValueTest(DateTime, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Nullable`1&lt;DateTime&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentDefaultValueTest01(DateTime? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentDefaultValueTest01(Nullable`1<DateTime>, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Guid, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentDefaultValueTest02(Guid valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentDefaultValueTest02(Guid, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Nullable`1&lt;Guid&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentDefaultValueTest03(Guid? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentDefaultValueTest03(Nullable`1<Guid>, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Byte, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentDefaultValueTest04(byte valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentDefaultValueTest04(Byte, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Nullable`1&lt;Byte&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentDefaultValueTest05(byte? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentDefaultValueTest05(Nullable`1<Byte>, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Char, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentDefaultValueTest06(char valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentDefaultValueTest06(Char, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Nullable`1&lt;Char&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentDefaultValueTest07(char? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentDefaultValueTest07(Nullable`1<Char>, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Decimal, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentDefaultValueTest08(decimal valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentDefaultValueTest08(Decimal, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Nullable`1&lt;Decimal&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentDefaultValueTest09(decimal? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentDefaultValueTest09(Nullable`1<Decimal>, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Nullable`1&lt;Double&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentDefaultValueTest10(double? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentDefaultValueTest10(Nullable`1<Double>, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Nullable`1&lt;Single&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentDefaultValueTest11(float? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentDefaultValueTest11(Nullable`1<Single>, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Int32, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentDefaultValueTest12(int valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentDefaultValueTest12(Int32, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Nullable`1&lt;Int32&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentDefaultValueTest13(int? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentDefaultValueTest13(Nullable`1<Int32>, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Int64, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentDefaultValueTest14(long valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentDefaultValueTest14(Int64, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Nullable`1&lt;Int64&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentDefaultValueTest15(long? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentDefaultValueTest15(Nullable`1<Int64>, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(SByte, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentDefaultValueTest16(sbyte valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentDefaultValueTest16(SByte, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Nullable`1&lt;SByte&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentDefaultValueTest17(sbyte? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentDefaultValueTest17(Nullable`1<SByte>, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Int16, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentDefaultValueTest18(short valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentDefaultValueTest18(Int16, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Nullable`1&lt;Int16&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentDefaultValueTest19(short? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentDefaultValueTest19(Nullable`1<Int16>, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(UInt32, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentDefaultValueTest20(uint valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentDefaultValueTest20(UInt32, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Nullable`1&lt;UInt32&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentDefaultValueTest21(uint? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentDefaultValueTest21(Nullable`1<UInt32>, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(UInt64, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentDefaultValueTest22(ulong valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentDefaultValueTest22(UInt64, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Nullable`1&lt;UInt64&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentDefaultValueTest23(ulong? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentDefaultValueTest23(Nullable`1<UInt64>, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(UInt16, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentDefaultValueTest24(ushort valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentDefaultValueTest24(UInt16, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Nullable`1&lt;UInt16&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentDefaultValueTest25(ushort? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentDefaultValueTest25(Nullable`1<UInt16>, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(!!0, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentDefaultValueTest26<T>(T valueArgument, string nameArgument)
			where T : struct
		{
			ArgumentEqualityValidationExtension.RequireArgumentDefaultValue<T>(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentDefaultValueTest26(!!0, String)
		}

		/// <summary>Test stub for RequireArgumentDefaultValue(Nullable`1&lt;!!0&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentDefaultValueTest27<T>(T? valueArgument, string nameArgument)
			where T : struct
		{
			ArgumentEqualityValidationExtension.RequireArgumentDefaultValue<T>(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentDefaultValueTest27(Nullable`1<!!0>, String)
		}

		/// <summary>Test stub for RequireArgumentHasNoValue(String, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentHasNoValueTest(string valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentHasNoValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentHasNoValueTest(String, String)
		}

		/// <summary>Test stub for RequireArgumentHasNonwhiteSpaceValue(String, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentHasNonwhiteSpaceValueTest(string valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentHasNonwhiteSpaceValue
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentHasNonwhiteSpaceValueTest(String, String)
		}

		/// <summary>Test stub for RequireArgumentHasNullEmptyOrWhiteSpaceValue(String, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentHasNullEmptyOrWhiteSpaceValueTest(string valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentHasNullEmptyOrWhiteSpaceValue
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentHasNullEmptyOrWhiteSpaceValueTest(String, String)
		}

		/// <summary>Test stub for RequireArgumentHasValue(String, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentHasValueTest(string valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentHasValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentHasValueTest(String, String)
		}

		/// <summary>Test stub for RequireArgumentNotApproximatelyDefaultValue(Double, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentNotApproximatelyDefaultValueTest(double valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotApproximatelyDefaultValue
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotApproximatelyDefaultValueTest(Double, String)
		}

		/// <summary>Test stub for RequireArgumentNotApproximatelyDefaultValue(Single, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentNotApproximatelyDefaultValueTest01(float valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotApproximatelyDefaultValue
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotApproximatelyDefaultValueTest01(Single, String)
		}

		/// <summary>Test stub for RequireArgumentNotApproximatelyEqual(Double, Double, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentNotApproximatelyEqualTest(
			double valueArgumentA,
			double valueArgumentB,
			string nameArgument
		)
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotApproximatelyEqual
				(valueArgumentA, valueArgumentB, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotApproximatelyEqualTest(Double, Double, String)
		}

		/// <summary>Test stub for RequireArgumentNotApproximatelyEqual(Nullable`1&lt;Double&gt;, Double, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentNotApproximatelyEqualTest01(
			double? valueArgumentA,
			double valueArgumentB,
			string nameArgument
		)
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotApproximatelyEqual
				(valueArgumentA, valueArgumentB, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotApproximatelyEqualTest01(Nullable`1<Double>, Double, String)
		}

		/// <summary>Test stub for RequireArgumentNotApproximatelyEqual(Double, Nullable`1&lt;Double&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentNotApproximatelyEqualTest02(
			double valueArgumentA,
			double? valueArgumentB,
			string nameArgument
		)
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotApproximatelyEqual
				(valueArgumentA, valueArgumentB, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotApproximatelyEqualTest02(Double, Nullable`1<Double>, String)
		}

		/// <summary>Test stub for RequireArgumentNotApproximatelyEqual(Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentNotApproximatelyEqualTest03(
			double? valueArgumentA,
			double? valueArgumentB,
			string nameArgument
		)
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotApproximatelyEqual
				(valueArgumentA, valueArgumentB, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotApproximatelyEqualTest03(Nullable`1<Double>, Nullable`1<Double>, String)
		}

		/// <summary>Test stub for RequireArgumentNotApproximatelyEqual(Single, Single, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentNotApproximatelyEqualTest04(
			float valueArgumentA,
			float valueArgumentB,
			string nameArgument
		)
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotApproximatelyEqual
				(valueArgumentA, valueArgumentB, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotApproximatelyEqualTest04(Single, Single, String)
		}

		/// <summary>Test stub for RequireArgumentNotApproximatelyEqual(Nullable`1&lt;Single&gt;, Single, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentNotApproximatelyEqualTest05(
			float? valueArgumentA,
			float valueArgumentB,
			string nameArgument
		)
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotApproximatelyEqual
				(valueArgumentA, valueArgumentB, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotApproximatelyEqualTest05(Nullable`1<Single>, Single, String)
		}

		/// <summary>Test stub for RequireArgumentNotApproximatelyEqual(Single, Nullable`1&lt;Single&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentNotApproximatelyEqualTest06(
			float valueArgumentA,
			float? valueArgumentB,
			string nameArgument
		)
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotApproximatelyEqual
				(valueArgumentA, valueArgumentB, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotApproximatelyEqualTest06(Single, Nullable`1<Single>, String)
		}

		/// <summary>Test stub for RequireArgumentNotApproximatelyEqual(Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentNotApproximatelyEqualTest07(
			float? valueArgumentA,
			float? valueArgumentB,
			string nameArgument
		)
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotApproximatelyEqual
				(valueArgumentA, valueArgumentB, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotApproximatelyEqualTest07(Nullable`1<Single>, Nullable`1<Single>, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefault(!!0, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(string))]
		[PexMethod]
		public void RequireArgumentNotDefaultTest<T>(T valueArgument, string nameArgument)
			where T : class
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotDefault<T>(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotDefaultTest(!!0, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(DateTime, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest(DateTime valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotDefaultValueTest(DateTime, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Nullable`1&lt;DateTime&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest01(DateTime? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotDefaultValueTest01(Nullable`1<DateTime>, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Guid, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest02(Guid valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotDefaultValueTest02(Guid, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Nullable`1&lt;Guid&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest03(Guid? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotDefaultValueTest03(Nullable`1<Guid>, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Byte, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest04(byte valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotDefaultValueTest04(Byte, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Nullable`1&lt;Byte&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest05(byte? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotDefaultValueTest05(Nullable`1<Byte>, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Char, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest06(char valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotDefaultValueTest06(Char, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Nullable`1&lt;Char&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest07(char? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotDefaultValueTest07(Nullable`1<Char>, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Decimal, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest08(decimal valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotDefaultValueTest08(Decimal, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Nullable`1&lt;Decimal&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest09(decimal? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotDefaultValueTest09(Nullable`1<Decimal>, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Nullable`1&lt;Double&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest10(double? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotDefaultValueTest10(Nullable`1<Double>, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Nullable`1&lt;Single&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest11(float? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotDefaultValueTest11(Nullable`1<Single>, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Int32, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest12(int valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotDefaultValueTest12(Int32, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Nullable`1&lt;Int32&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest13(int? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotDefaultValueTest13(Nullable`1<Int32>, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Int64, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest14(long valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotDefaultValueTest14(Int64, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Nullable`1&lt;Int64&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest15(long? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotDefaultValueTest15(Nullable`1<Int64>, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(SByte, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest16(sbyte valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotDefaultValueTest16(SByte, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Nullable`1&lt;SByte&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest17(sbyte? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotDefaultValueTest17(Nullable`1<SByte>, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Int16, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest18(short valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotDefaultValueTest18(Int16, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Nullable`1&lt;Int16&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest19(short? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotDefaultValueTest19(Nullable`1<Int16>, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(UInt32, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest20(uint valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotDefaultValueTest20(UInt32, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Nullable`1&lt;UInt32&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest21(uint? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotDefaultValueTest21(Nullable`1<UInt32>, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(UInt64, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest22(ulong valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotDefaultValueTest22(UInt64, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Nullable`1&lt;UInt64&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest23(ulong? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotDefaultValueTest23(Nullable`1<UInt64>, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(UInt16, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest24(ushort valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotDefaultValueTest24(UInt16, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Nullable`1&lt;UInt16&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest25(ushort? valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotDefaultValueTest25(Nullable`1<UInt16>, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(!!0, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest26<T>(T valueArgument, string nameArgument)
			where T : struct
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotDefaultValue<T>(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotDefaultValueTest26(!!0, String)
		}

		/// <summary>Test stub for RequireArgumentNotDefaultValue(Nullable`1&lt;!!0&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentNotDefaultValueTest27<T>(T? valueArgument, string nameArgument)
			where T : struct
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotDefaultValue<T>(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotDefaultValueTest27(Nullable`1<!!0>, String)
		}

		/// <summary>Test stub for RequireArgumentNotNull(!!0, String)</summary>
		[PexAllowedException(typeof(ArgumentNullException))]
		[PexGenericArguments(typeof(string))]
		[PexMethod]
		public void RequireArgumentNotNullTest<T>(T valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotNull<T>(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotNullTest(!!0, String)
		}

		/// <summary>Test stub for RequireArgumentNotNull(Nullable`1&lt;!!0&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentNullException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentNotNullTest01<T>(T? valueArgument, string nameArgument)
			where T : struct
		{
			ArgumentEqualityValidationExtension.RequireArgumentNotNull<T>(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNotNullTest01(Nullable`1<!!0>, String)
		}

		/// <summary>Test stub for RequireArgumentNull(!!0, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(string))]
		[PexMethod]
		public void RequireArgumentNullTest<T>(T valueArgument, string nameArgument)
		{
			ArgumentEqualityValidationExtension.RequireArgumentNull<T>(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNullTest(!!0, String)
		}

		/// <summary>Test stub for RequireArgumentNull(Nullable`1&lt;!!0&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentNullTest01<T>(T? valueArgument, string nameArgument)
			where T : struct
		{
			ArgumentEqualityValidationExtension.RequireArgumentNull<T>(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentEqualityValidationExtensionTest.RequireArgumentNullTest01(Nullable`1<!!0>, String)
		}
	}
}
