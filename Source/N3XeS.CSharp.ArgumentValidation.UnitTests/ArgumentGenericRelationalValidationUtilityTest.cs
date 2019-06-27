// <copyright file="ArgumentGenericRelationalValidationUtilityTest.cs">Copyright (c) 2013, John Caruthers</copyright>

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3XeS.CSharp.ArgumentValidation.Utilities;

namespace N3XeS.CSharp.ArgumentValidation.Utilities.UnitTests
{
    /// <summary>This class contains parameterized unit tests for ArgumentGenericRelationalValidationUtility</summary>
	[TestClass]
	[ExcludeFromCodeCoverage]
    [PexClass(typeof(ArgumentGenericRelationalValidationUtility))]
	[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
	[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ArgumentGenericRelationalValidationUtilityTest
    {

		/// <summary>Test stub for RequireArgumentIsBetween(!!0, String, !!0, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest<T>(
			T argumentValue,
			string nameArgument,
			T valueBoundLower,
			T valueBoundUpper
		)
			where T : IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsBetween<T>
				(argumentValue, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsBetweenTest(!!0, String, !!0, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(!!0, String, !!0, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest01<T>(
			T argumentValue,
			string nameArgument,
			T valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsBetween<T>
				(argumentValue, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsBetweenTest01(!!0, String, !!0, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(!!0, String, Nullable`1&lt;!!0&gt;, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest02<T>(
			T argumentValue,
			string nameArgument,
			T? valueBoundLower,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsBetween<T>
				(argumentValue, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsBetweenTest02(!!0, String, Nullable`1<!!0>, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(!!0, String, Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest03<T>(
			T argumentValue,
			string nameArgument,
			T? valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsBetween<T>
				(argumentValue, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsBetweenTest03(!!0, String, Nullable`1<!!0>, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;!!0&gt;, String, !!0, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest04<T>(
			T? argumentValue,
			string nameArgument,
			T valueBoundLower,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsBetween<T>
				(argumentValue, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsBetweenTest04(Nullable`1<!!0>, String, !!0, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;!!0&gt;, String, !!0, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest05<T>(
			T? argumentValue,
			string nameArgument,
			T valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsBetween<T>
				(argumentValue, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsBetweenTest05(Nullable`1<!!0>, String, !!0, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;!!0&gt;, String, Nullable`1&lt;!!0&gt;, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest06<T>(
			T? argumentValue,
			string nameArgument,
			T? valueBoundLower,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsBetween<T>
				(argumentValue, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsBetweenTest06(Nullable`1<!!0>, String, Nullable`1<!!0>, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;!!0&gt;, String, Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest07<T>(
			T? argumentValue,
			string nameArgument,
			T? valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsBetween<T>
				(argumentValue, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsBetweenTest07(Nullable`1<!!0>, String, Nullable`1<!!0>, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(!!0, String, !!0, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest<T>(
			T argumentValue,
			string nameArgument,
			T valueBoundLower,
			T valueBoundUpper
		)
			where T : IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsBetweenExclusive<T>
				(argumentValue, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsBetweenExclusiveTest(!!0, String, !!0, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(!!0, String, !!0, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest01<T>(
			T argumentValue,
			string nameArgument,
			T valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsBetweenExclusive<T>
				(argumentValue, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsBetweenExclusiveTest01(!!0, String, !!0, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(!!0, String, Nullable`1&lt;!!0&gt;, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest02<T>(
			T argumentValue,
			string nameArgument,
			T? valueBoundLower,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsBetweenExclusive<T>
				(argumentValue, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsBetweenExclusiveTest02(!!0, String, Nullable`1<!!0>, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(!!0, String, Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest03<T>(
			T argumentValue,
			string nameArgument,
			T? valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsBetweenExclusive<T>
				(argumentValue, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsBetweenExclusiveTest03(!!0, String, Nullable`1<!!0>, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;!!0&gt;, String, !!0, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest04<T>(
			T? argumentValue,
			string nameArgument,
			T valueBoundLower,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsBetweenExclusive<T>
				(argumentValue, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsBetweenExclusiveTest04(Nullable`1<!!0>, String, !!0, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;!!0&gt;, String, !!0, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest05<T>(
			T? argumentValue,
			string nameArgument,
			T valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsBetweenExclusive<T>
				(argumentValue, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsBetweenExclusiveTest05(Nullable`1<!!0>, String, !!0, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;!!0&gt;, String, Nullable`1&lt;!!0&gt;, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest06<T>(
			T? argumentValue,
			string nameArgument,
			T? valueBoundLower,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsBetweenExclusive<T>
				(argumentValue, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsBetweenExclusiveTest06(Nullable`1<!!0>, String, Nullable`1<!!0>, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;!!0&gt;, String, Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest07<T>(
			T? argumentValue,
			string nameArgument,
			T? valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsBetweenExclusive<T>
				(argumentValue, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsBetweenExclusiveTest07(Nullable`1<!!0>, String, Nullable`1<!!0>, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(!!0, String, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest<T>(
			T argumentValue,
			string nameArgument,
			T valueBoundLower
		)
			where T : IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsGreaterThan<T>
				(argumentValue, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsGreaterThanTest(!!0, String, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(!!0, String, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest01<T>(
			T argumentValue,
			string nameArgument,
			T? valueBoundLower
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsGreaterThan<T>
				(argumentValue, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsGreaterThanTest01(!!0, String, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Nullable`1&lt;!!0&gt;, String, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest02<T>(
			T? argumentValue,
			string nameArgument,
			T valueBoundLower
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsGreaterThan<T>
				(argumentValue, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsGreaterThanTest02(Nullable`1<!!0>, String, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Nullable`1&lt;!!0&gt;, String, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest03<T>(
			T? argumentValue,
			string nameArgument,
			T? valueBoundLower
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsGreaterThan<T>
				(argumentValue, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsGreaterThanTest03(Nullable`1<!!0>, String, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(!!0, String, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest<T>(
			T argumentValue,
			string nameArgument,
			T valueBoundLower
		)
			where T : IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsGreaterThanOrEqual<T>
				(argumentValue, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsGreaterThanOrEqualTest(!!0, String, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(!!0, String, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest01<T>(
			T argumentValue,
			string nameArgument,
			T? valueBoundLower
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsGreaterThanOrEqual<T>
				(argumentValue, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsGreaterThanOrEqualTest01(!!0, String, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Nullable`1&lt;!!0&gt;, String, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest02<T>(
			T? argumentValue,
			string nameArgument,
			T valueBoundLower
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsGreaterThanOrEqual<T>
				(argumentValue, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsGreaterThanOrEqualTest02(Nullable`1<!!0>, String, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Nullable`1&lt;!!0&gt;, String, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest03<T>(
			T? argumentValue,
			string nameArgument,
			T? valueBoundLower
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsGreaterThanOrEqual<T>
				(argumentValue, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsGreaterThanOrEqualTest03(Nullable`1<!!0>, String, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(!!0, String, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest<T>(
			T argumentValue,
			string nameArgument,
			T valueBoundUpper
		)
			where T : IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsLessThan<T>
				(argumentValue, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsLessThanTest(!!0, String, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(!!0, String, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest01<T>(
			T argumentValue,
			string nameArgument,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsLessThan<T>
				(argumentValue, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsLessThanTest01(!!0, String, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Nullable`1&lt;!!0&gt;, String, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest02<T>(
			T? argumentValue,
			string nameArgument,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsLessThan<T>
				(argumentValue, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsLessThanTest02(Nullable`1<!!0>, String, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Nullable`1&lt;!!0&gt;, String, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest03<T>(
			T? argumentValue,
			string nameArgument,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsLessThan<T>
				(argumentValue, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsLessThanTest03(Nullable`1<!!0>, String, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(!!0, String, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest<T>(
			T argumentValue,
			string nameArgument,
			T valueBoundUpper
		)
			where T : IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsLessThanOrEqual<T>
				(argumentValue, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsLessThanOrEqualTest(!!0, String, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(!!0, String, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest01<T>(
			T argumentValue,
			string nameArgument,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsLessThanOrEqual<T>
				(argumentValue, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsLessThanOrEqualTest01(!!0, String, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Nullable`1&lt;!!0&gt;, String, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest02<T>(
			T? argumentValue,
			string nameArgument,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsLessThanOrEqual<T>
				(argumentValue, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsLessThanOrEqualTest02(Nullable`1<!!0>, String, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Nullable`1&lt;!!0&gt;, String, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest03<T>(
			T? argumentValue,
			string nameArgument,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsLessThanOrEqual<T>
				(argumentValue, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsLessThanOrEqualTest03(Nullable`1<!!0>, String, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(!!0, String, !!0, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest<T>(
			T argumentValue,
			string nameArgument,
			T valueBoundLower,
			T valueBoundUpper
		)
			where T : IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsOutside<T>
				(argumentValue, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsOutsideTest(!!0, String, !!0, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(!!0, String, !!0, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest01<T>(
			T argumentValue,
			string nameArgument,
			T valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsOutside<T>
				(argumentValue, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsOutsideTest01(!!0, String, !!0, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(!!0, String, Nullable`1&lt;!!0&gt;, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest02<T>(
			T argumentValue,
			string nameArgument,
			T? valueBoundLower,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsOutside<T>
				(argumentValue, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsOutsideTest02(!!0, String, Nullable`1<!!0>, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(!!0, String, Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest03<T>(
			T argumentValue,
			string nameArgument,
			T? valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsOutside<T>
				(argumentValue, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsOutsideTest03(!!0, String, Nullable`1<!!0>, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;!!0&gt;, String, !!0, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest04<T>(
			T? argumentValue,
			string nameArgument,
			T valueBoundLower,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsOutside<T>
				(argumentValue, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsOutsideTest04(Nullable`1<!!0>, String, !!0, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;!!0&gt;, String, !!0, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest05<T>(
			T? argumentValue,
			string nameArgument,
			T valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsOutside<T>
				(argumentValue, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsOutsideTest05(Nullable`1<!!0>, String, !!0, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;!!0&gt;, String, Nullable`1&lt;!!0&gt;, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest06<T>(
			T? argumentValue,
			string nameArgument,
			T? valueBoundLower,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsOutside<T>
				(argumentValue, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsOutsideTest06(Nullable`1<!!0>, String, Nullable`1<!!0>, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;!!0&gt;, String, Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest07<T>(
			T? argumentValue,
			string nameArgument,
			T? valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsOutside<T>
				(argumentValue, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsOutsideTest07(Nullable`1<!!0>, String, Nullable`1<!!0>, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(!!0, String, !!0, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest<T>(
			T argumentValue,
			string nameArgument,
			T valueBoundLower,
			T valueBoundUpper
		)
			where T : IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsOutsideExclusive<T>
				(argumentValue, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsOutsideExclusiveTest(!!0, String, !!0, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(!!0, String, !!0, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest01<T>(
			T argumentValue,
			string nameArgument,
			T valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsOutsideExclusive<T>
				(argumentValue, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsOutsideExclusiveTest01(!!0, String, !!0, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(!!0, String, Nullable`1&lt;!!0&gt;, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest02<T>(
			T argumentValue,
			string nameArgument,
			T? valueBoundLower,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsOutsideExclusive<T>
				(argumentValue, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsOutsideExclusiveTest02(!!0, String, Nullable`1<!!0>, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(!!0, String, Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest03<T>(
			T argumentValue,
			string nameArgument,
			T? valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsOutsideExclusive<T>
				(argumentValue, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsOutsideExclusiveTest03(!!0, String, Nullable`1<!!0>, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;!!0&gt;, String, !!0, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest04<T>(
			T? argumentValue,
			string nameArgument,
			T valueBoundLower,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsOutsideExclusive<T>
				(argumentValue, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsOutsideExclusiveTest04(Nullable`1<!!0>, String, !!0, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;!!0&gt;, String, !!0, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest05<T>(
			T? argumentValue,
			string nameArgument,
			T valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsOutsideExclusive<T>
				(argumentValue, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsOutsideExclusiveTest05(Nullable`1<!!0>, String, !!0, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;!!0&gt;, String, Nullable`1&lt;!!0&gt;, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest06<T>(
			T? argumentValue,
			string nameArgument,
			T? valueBoundLower,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsOutsideExclusive<T>
				(argumentValue, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsOutsideExclusiveTest06(Nullable`1<!!0>, String, Nullable`1<!!0>, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;!!0&gt;, String, Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest07<T>(
			T? argumentValue,
			string nameArgument,
			T? valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationUtility.RequireArgumentIsOutsideExclusive<T>
				(argumentValue, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsOutsideExclusiveTest07(Nullable`1<!!0>, String, Nullable`1<!!0>, Nullable`1<!!0>)
		}
	}
}
