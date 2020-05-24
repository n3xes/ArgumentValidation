#region Header: Copyright © 2013, John Caruthers

// =====================================================================================================================
// <copyright company="John Caruthers" file="ArgumentGenericRelationalValidationUtility.cs">
//		Copyright © 2013, John Caruthers
//		All rights reserved.
//
//		THIS PROGRAM ND ALL OF THE INFORMATION CONTAINED HEREIN IS FREE SOFTWARE:
//		YOU CAN REDISTRIBUTE IT AND/OR MODIFY IT UNDER THE TERMS OF THE GNU GENERAL
//		PUBLIC LICENSE AS PUBLISHED BY THE FREE SOFTWARE FOUNDATION, EITHER VERSION
//		3 OF THE LICENSE, OR (AT YOUR OPTION) ANY LATER VERSION.
//
//		THIS PROGRAM IS DISTRIBUTED IN THE HOPE THAT IT WILL BE USEFUL, BUT WITHOUT
//		ANY WARRANTY; WITHOUT EVEN THE IMPLIED WARRANTY OF MERCHANTABILITY OR FITNESS
//		FOR A PARTICULAR PURPOSE.SEE THE GNU GENERAL PUBLIC LICENSE FOR MORE DETAILS.
//
//		YOU SHOULD HAVE RECEIVED A COPY OF THE GNU GENERAL PUBLIC LICENSE ALONG
//		WITH THIS PROGRAM.  IF NOT, SEE https://www.gnu.org/licenses/.
//
// </copyright>
////====================================================================================================================

#endregion

// These were put in to fix problems with 3rd party software misdiagnosing code problems.
// ReSharper disable UnusedParameter.Global
// ReSharper disable UnusedTypeParameter
namespace N3XeS.CSharp.ArgumentValidation.Utilities
{
	#region Directives

	using System;
	using System.Globalization;

#if (!NETFX_V2 && !NETFX_V3 && !NETFX_V35)

	using System.Numerics;

#endif

	using JetBrains.Annotations;

	using Analyzation.Extensions;

	using Extensions;
	using Properties;

	#endregion

	#region Delegates

	#endregion

	#region Enums

	#endregion

	/// <summary>
	///		An argument generic relational validation related utility.
	/// </summary>
	/// <author>
	///  <AuthorName>John Caruthers</AuthorName>
	///  <CreationDate>Tuesday, September 24, 2013  (09/24/2013)</CreationDate>
	///  <CreationTime>06:52:09 PM</CreationTime>
	/// </author>
	/// <history>
	///  <Modification>
	///   <ModifierName></ModifierName>
	///   <ModificationDate></ModificationDate>
	///   <ModificationTime></ModificationTime>
	///   <ModificationDescription></ModificationDescription>
	///  </Modification>
	/// </history>
	[PublicAPI]
	// ReSharper disable once ClassTooBig
	public static class ArgumentGenericRelationalValidationUtility
	{
		#region Constants

		#endregion

		#region Instance/Member/Field Variables

		#endregion

		#region Constructors

		#endregion

		#region Destructor

		#endregion

		#region Events

		#endregion

		#region Properties/Accessors/Mutators

		#endregion

		#region Indexers

		#endregion

		#region Event Handlers

		#endregion

		#region Methods/Functions

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <typeparamref name="T"/> to validate if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than the <paramref name="valueBoundLower"/>.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is greater than the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsBetween<T>([CanBeNull] T valueArgument,
													   [NotNull] String nameArgument,
													   [CanBeNull] T valueBoundLower,
													   [CanBeNull] T valueBoundUpper)
			where T : IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			valueArgument.RequireArgumentIsLessThanOrEqual(nameArgument, valueBoundUpper);
			valueArgument.RequireArgumentIsGreaterThanOrEqual(nameArgument, valueBoundLower);
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <typeparamref name="T"/> to validate if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than the <paramref name="valueBoundLower"/>.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is greater than the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsBetween<T>(T valueArgument,
													   [NotNull] String nameArgument,
													   T valueBoundLower,
													   [CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			valueArgument.RequireArgumentIsLessThanOrEqual(nameArgument, valueBoundUpper);
			valueArgument.RequireArgumentIsGreaterThanOrEqual(nameArgument, valueBoundLower);
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <typeparamref name="T"/> to validate if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than the <paramref name="valueBoundLower"/>.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is greater than the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsBetween<T>(T valueArgument,
													   [NotNull] String nameArgument,
													   [CanBeNull] T? valueBoundLower,
													   T valueBoundUpper)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			valueArgument.RequireArgumentIsLessThanOrEqual(nameArgument, valueBoundUpper);
			valueArgument.RequireArgumentIsGreaterThanOrEqual(nameArgument, valueBoundLower);
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <typeparamref name="T"/> to validate if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than the <paramref name="valueBoundLower"/>.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is greater than the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsBetween<T>(T valueArgument,
													   [NotNull] String nameArgument,
													   [CanBeNull] T? valueBoundLower,
													   [CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			valueArgument.RequireArgumentIsLessThanOrEqual(nameArgument, valueBoundUpper);
			valueArgument.RequireArgumentIsGreaterThanOrEqual(nameArgument, valueBoundLower);
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than the <paramref name="valueBoundLower"/>.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is greater than the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsBetween<T>([CanBeNull] T? valueArgument,
													   [NotNull] String nameArgument,
													   T valueBoundLower,
													   T valueBoundUpper)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			valueArgument.RequireArgumentIsLessThanOrEqual(nameArgument, valueBoundUpper);
			valueArgument.RequireArgumentIsGreaterThanOrEqual(nameArgument, valueBoundLower);
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than the <paramref name="valueBoundLower"/>.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is greater than the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsBetween<T>([CanBeNull] T? valueArgument,
													   [NotNull] String nameArgument,
													   T valueBoundLower,
													   [CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			valueArgument.RequireArgumentIsLessThanOrEqual(nameArgument, valueBoundUpper);
			valueArgument.RequireArgumentIsGreaterThanOrEqual(nameArgument, valueBoundLower);
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than the <paramref name="valueBoundLower"/>.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is greater than the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsBetween<T>([CanBeNull] T? valueArgument,
													   [NotNull] String nameArgument,
													   [CanBeNull] T? valueBoundLower,
													   T valueBoundUpper)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			valueArgument.RequireArgumentIsLessThanOrEqual(nameArgument, valueBoundUpper);
			valueArgument.RequireArgumentIsGreaterThanOrEqual(nameArgument, valueBoundLower);
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than the <paramref name="valueBoundLower"/>.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is greater than the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsBetween<T>([CanBeNull] T? valueArgument,
													   [NotNull] String nameArgument,
													   [CanBeNull] T? valueBoundLower,
													   [CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			valueArgument.RequireArgumentIsLessThanOrEqual(nameArgument, valueBoundUpper);
			valueArgument.RequireArgumentIsGreaterThanOrEqual(nameArgument, valueBoundLower);
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <typeparamref name="T"/> to validate if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than or equal to the <paramref name="valueBoundLower"/>.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is greater than or equal to the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsBetweenExclusive<T>([CanBeNull] T valueArgument,
																[NotNull] String nameArgument,
																[CanBeNull] T valueBoundLower,
																[CanBeNull] T valueBoundUpper)
			where T : IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			valueArgument.RequireArgumentIsLessThan(nameArgument, valueBoundUpper);
			valueArgument.RequireArgumentIsGreaterThan(nameArgument, valueBoundLower);
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <typeparamref name="T"/> to validate if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than or equal to the <paramref name="valueBoundLower"/>.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is greater than or equal to the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsBetweenExclusive<T>(T valueArgument,
																[NotNull] String nameArgument,
																T valueBoundLower,
																[CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			valueArgument.RequireArgumentIsLessThan(nameArgument, valueBoundUpper);
			valueArgument.RequireArgumentIsGreaterThan(nameArgument, valueBoundLower);
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <typeparamref name="T"/> to validate if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than or equal to the <paramref name="valueBoundLower"/>.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is greater than or equal to the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsBetweenExclusive<T>(T valueArgument,
																[NotNull] String nameArgument,
																[CanBeNull] T? valueBoundLower,
																T valueBoundUpper)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			valueArgument.RequireArgumentIsLessThan(nameArgument, valueBoundUpper);
			valueArgument.RequireArgumentIsGreaterThan(nameArgument, valueBoundLower);
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <typeparamref name="T"/> to validate if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than or equal to the <paramref name="valueBoundLower"/>.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is greater than or equal to the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsBetweenExclusive<T>(T valueArgument,
																[NotNull] String nameArgument,
																[CanBeNull] T? valueBoundLower,
																[CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			valueArgument.RequireArgumentIsLessThan(nameArgument, valueBoundUpper);
			valueArgument.RequireArgumentIsGreaterThan(nameArgument, valueBoundLower);
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than or equal to the <paramref name="valueBoundLower"/>.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is greater than or equal to the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsBetweenExclusive<T>([CanBeNull] T? valueArgument,
																[NotNull] String nameArgument,
																T valueBoundLower,
																T valueBoundUpper)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			valueArgument.RequireArgumentIsLessThan(nameArgument, valueBoundUpper);
			valueArgument.RequireArgumentIsGreaterThan(nameArgument, valueBoundLower);
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than or equal to the <paramref name="valueBoundLower"/>.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is greater than or equal to the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsBetweenExclusive<T>([CanBeNull] T? valueArgument,
																[NotNull] String nameArgument,
																T valueBoundLower,
																[CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			valueArgument.RequireArgumentIsLessThan(nameArgument, valueBoundUpper);
			valueArgument.RequireArgumentIsGreaterThan(nameArgument, valueBoundLower);
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than or equal to the <paramref name="valueBoundLower"/>.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is greater than or equal to the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsBetweenExclusive<T>([CanBeNull] T? valueArgument,
																[NotNull] String nameArgument,
																[CanBeNull] T? valueBoundLower,
																T valueBoundUpper)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			valueArgument.RequireArgumentIsLessThan(nameArgument, valueBoundUpper);
			valueArgument.RequireArgumentIsGreaterThan(nameArgument, valueBoundLower);
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than or equal to the <paramref name="valueBoundLower"/>.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is greater than or equal to the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsBetweenExclusive<T>([CanBeNull] T? valueArgument,
																[NotNull] String nameArgument,
																[CanBeNull] T? valueBoundLower,
																[CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			valueArgument.RequireArgumentIsLessThan(nameArgument, valueBoundUpper);
			valueArgument.RequireArgumentIsGreaterThan(nameArgument, valueBoundLower);
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <typeparamref name="T"/> to validate if is greater than the <paramref name="valueBoundLower"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than or equal to the <paramref name="valueBoundLower"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsGreaterThan<T>([CanBeNull] T valueArgument,
														   [NotNull] String nameArgument,
														   [CanBeNull] T valueBoundLower)
			where T : IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsLessThanOrEqual(valueBoundLower))
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.CurrentCulture, "{0}.  {1}, {2}.", Resources.ValueOutOfRange, Resources.ValueMustBeGreaterThan, valueBoundLower));
			}
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <typeparamref name="T"/> to validate if is greater than the <paramref name="valueBoundLower"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than or equal to the <paramref name="valueBoundLower"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsGreaterThan<T>(T valueArgument,
														   [NotNull] String nameArgument,
														   [CanBeNull] T? valueBoundLower)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsLessThanOrEqual(valueBoundLower))
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.CurrentCulture, "{0}.  {1}, {2}.", Resources.ValueOutOfRange, Resources.ValueMustBeGreaterThan, valueBoundLower));
			}
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if is greater than the <paramref name="valueBoundLower"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than or equal to the <paramref name="valueBoundLower"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsGreaterThan<T>([CanBeNull] T? valueArgument,
														   [NotNull] String nameArgument,
														   T valueBoundLower)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsLessThanOrEqual(valueBoundLower))
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.CurrentCulture, "{0}.  {1}, {2}.", Resources.ValueOutOfRange, Resources.ValueMustBeGreaterThan, valueBoundLower));
			}
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if is greater than the <paramref name="valueBoundLower"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than or equal to the <paramref name="valueBoundLower"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsGreaterThan<T>([CanBeNull] T? valueArgument,
														   [NotNull] String nameArgument,
														   [CanBeNull] T? valueBoundLower)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsLessThanOrEqual(valueBoundLower))
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.CurrentCulture, "{0}.  {1}, {2}.", Resources.ValueOutOfRange, Resources.ValueMustBeGreaterThan, valueBoundLower));
			}
		}
		
		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <typeparamref name="T"/> to validate if is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than the <paramref name="valueBoundLower"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsGreaterThanOrEqual<T>([CanBeNull] T valueArgument,
																  [NotNull] String nameArgument,
																  [CanBeNull] T valueBoundLower)
			where T : IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsLessThan(valueBoundLower))
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.CurrentCulture, "{0}.  {1}, {2}.", Resources.ValueOutOfRange, Resources.ValueMustBeGreaterThanOrEqual, valueBoundLower));
			}
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <typeparamref name="T"/> to validate if is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than the <paramref name="valueBoundLower"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsGreaterThanOrEqual<T>(T valueArgument,
																  [NotNull] String nameArgument,
																  [CanBeNull] T? valueBoundLower)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsLessThan(valueBoundLower))
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.CurrentCulture, "{0}.  {1}, {2}.", Resources.ValueOutOfRange, Resources.ValueMustBeGreaterThanOrEqual, valueBoundLower));
			}
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than the <paramref name="valueBoundLower"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsGreaterThanOrEqual<T>([CanBeNull] T? valueArgument,
																  [NotNull] String nameArgument,
																  T valueBoundLower)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsLessThan(valueBoundLower))
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.CurrentCulture, "{0}.  {1}, {2}.", Resources.ValueOutOfRange, Resources.ValueMustBeGreaterThanOrEqual, valueBoundLower));
			}
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than the <paramref name="valueBoundLower"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsGreaterThanOrEqual<T>([CanBeNull] T? valueArgument,
																  [NotNull] String nameArgument,
																  [CanBeNull] T? valueBoundLower)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsLessThan(valueBoundLower))
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.CurrentCulture, "{0}.  {1}, {2}.", Resources.ValueOutOfRange, Resources.ValueMustBeGreaterThanOrEqual, valueBoundLower));
			}
		}
		
		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <typeparamref name="T"/> to validate if is less than the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is greater than or equal to the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsLessThan<T>([CanBeNull] T valueArgument,
														[NotNull] String nameArgument,
														[CanBeNull] T valueBoundUpper)
			where T : IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsGreaterThanOrEqual(valueBoundUpper))
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.CurrentCulture, "{0}.  {1}, {2}.", Resources.ValueOutOfRange, Resources.ValueMustBeLessThan, valueBoundUpper));
			}
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <typeparamref name="T"/> to validate if is less than the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is greater than or equal to the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsLessThan<T>(T valueArgument,
														[NotNull] String nameArgument,
														[CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsGreaterThanOrEqual(valueBoundUpper))
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.CurrentCulture, "{0}.  {1}, {2}.", Resources.ValueOutOfRange, Resources.ValueMustBeLessThan, valueBoundUpper));
			}
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if is less than the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is greater than or equal to the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsLessThan<T>([CanBeNull] T? valueArgument,
														[NotNull] String nameArgument,
														T valueBoundUpper)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsGreaterThanOrEqual(valueBoundUpper))
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.CurrentCulture, "{0}.  {1}, {2}.", Resources.ValueOutOfRange, Resources.ValueMustBeLessThan, valueBoundUpper));
			}
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if is less than the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is greater than or equal to the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsLessThan<T>([CanBeNull] T? valueArgument,
														[NotNull] String nameArgument,
														[CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsGreaterThanOrEqual(valueBoundUpper))
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.CurrentCulture, "{0}.  {1}, {2}.", Resources.ValueOutOfRange, Resources.ValueMustBeLessThan, valueBoundUpper));
			}
		}		
		
		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <typeparamref name="T"/> to validate if is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsLessThanOrEqual<T>([CanBeNull] T valueArgument,
															   [NotNull] String nameArgument,
															   [CanBeNull] T valueBoundUpper)
			where T : IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsGreaterThan(valueBoundUpper))
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.CurrentCulture, "{0}.  {1}, {2}.", Resources.ValueOutOfRange, Resources.ValueMustBeLessThanOrEqual, valueBoundUpper));
			}
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <typeparamref name="T"/> to validate if is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsLessThanOrEqual<T>(T valueArgument,
															   [NotNull] String nameArgument,
															   [CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsGreaterThan(valueBoundUpper))
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.CurrentCulture, "{0}.  {1}, {2}.", Resources.ValueOutOfRange, Resources.ValueMustBeLessThanOrEqual, valueBoundUpper));
			}
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsLessThanOrEqual<T>([CanBeNull] T? valueArgument,
															   [NotNull] String nameArgument,
															   T valueBoundUpper)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsGreaterThan(valueBoundUpper))
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.CurrentCulture, "{0}.  {1}, {2}.", Resources.ValueOutOfRange, Resources.ValueMustBeLessThanOrEqual, valueBoundUpper));
			}
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsLessThanOrEqual<T>([CanBeNull] T? valueArgument,
															   [NotNull] String nameArgument,
															   [CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsGreaterThan(valueBoundUpper))
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.CurrentCulture, "{0}.  {1}, {2}.", Resources.ValueOutOfRange, Resources.ValueMustBeLessThanOrEqual, valueBoundUpper));
			}
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is less than or equal to the <paramref name="valueBoundLower"/> and greater than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if is less than or equal to the <paramref name="valueBoundLower"/> and greater than or equal to the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is greater than the <paramref name="valueBoundLower"/>.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsOutside<T>([CanBeNull] T valueArgument,
													   [NotNull] String nameArgument,
													   [CanBeNull] T valueBoundLower,
													   [CanBeNull] T valueBoundUpper)
			where T : IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			valueArgument.RequireArgumentIsLessThanOrEqual(nameArgument, valueBoundLower);
			valueArgument.RequireArgumentIsGreaterThanOrEqual(nameArgument, valueBoundUpper);
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is less than or equal to the <paramref name="valueBoundLower"/> and greater than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if is less than or equal to the <paramref name="valueBoundLower"/> and greater than or equal to the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is greater than the <paramref name="valueBoundLower"/>.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsOutside<T>(T valueArgument,
													   [NotNull] String nameArgument,
													   T valueBoundLower,
													   [CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			valueArgument.RequireArgumentIsLessThanOrEqual(nameArgument, valueBoundLower);
			valueArgument.RequireArgumentIsGreaterThanOrEqual(nameArgument, valueBoundUpper);
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is less than or equal to the <paramref name="valueBoundLower"/> and greater than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if is less than or equal to the <paramref name="valueBoundLower"/> and greater than or equal to the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is greater than the <paramref name="valueBoundLower"/>.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsOutside<T>(T valueArgument,
													   [NotNull] String nameArgument,
													   [CanBeNull] T? valueBoundLower,
													   T valueBoundUpper)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			valueArgument.RequireArgumentIsLessThanOrEqual(nameArgument, valueBoundLower);
			valueArgument.RequireArgumentIsGreaterThanOrEqual(nameArgument, valueBoundUpper);
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is less than or equal to the <paramref name="valueBoundLower"/> and greater than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if is less than or equal to the <paramref name="valueBoundLower"/> and greater than or equal to the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is greater than the <paramref name="valueBoundLower"/>.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsOutside<T>(T valueArgument,
													   [NotNull] String nameArgument,
													   [CanBeNull] T? valueBoundLower,
													   [CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			valueArgument.RequireArgumentIsLessThanOrEqual(nameArgument, valueBoundLower);
			valueArgument.RequireArgumentIsGreaterThanOrEqual(nameArgument, valueBoundUpper);
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is less than or equal to the <paramref name="valueBoundLower"/> and greater than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if is less than or equal to the <paramref name="valueBoundLower"/> and greater than or equal to the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is greater than the <paramref name="valueBoundLower"/>.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsOutside<T>([CanBeNull] T? valueArgument,
													   [NotNull] String nameArgument,
													   T valueBoundLower,
													   T valueBoundUpper)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			valueArgument.RequireArgumentIsLessThanOrEqual(nameArgument, valueBoundLower);
			valueArgument.RequireArgumentIsGreaterThanOrEqual(nameArgument, valueBoundUpper);
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is less than or equal to the <paramref name="valueBoundLower"/> and greater than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if is less than or equal to the <paramref name="valueBoundLower"/> and greater than or equal to the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is greater than the <paramref name="valueBoundLower"/>.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsOutside<T>([CanBeNull] T? valueArgument,
													   [NotNull] String nameArgument,
													   T valueBoundLower,
													   [CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			valueArgument.RequireArgumentIsLessThanOrEqual(nameArgument, valueBoundLower);
			valueArgument.RequireArgumentIsGreaterThanOrEqual(nameArgument, valueBoundUpper);
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is less than or equal to the <paramref name="valueBoundLower"/> and greater than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if is less than or equal to the <paramref name="valueBoundLower"/> and greater than or equal to the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is greater than the <paramref name="valueBoundLower"/>.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsOutside<T>([CanBeNull] T? valueArgument,
													   [NotNull] String nameArgument,
													   [CanBeNull] T? valueBoundLower,
													   T valueBoundUpper)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			valueArgument.RequireArgumentIsLessThanOrEqual(nameArgument, valueBoundLower);
			valueArgument.RequireArgumentIsGreaterThanOrEqual(nameArgument, valueBoundUpper);
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is less than or equal to the <paramref name="valueBoundLower"/> and greater than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if is less than or equal to the <paramref name="valueBoundLower"/> and greater than or equal to the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is greater than the <paramref name="valueBoundLower"/>.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsOutside<T>([CanBeNull] T? valueArgument,
													   [NotNull] String nameArgument,
													   [CanBeNull] T? valueBoundLower,
													   [CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			valueArgument.RequireArgumentIsLessThanOrEqual(nameArgument, valueBoundLower);
			valueArgument.RequireArgumentIsGreaterThanOrEqual(nameArgument, valueBoundUpper);
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is less than the <paramref name="valueBoundLower"/> and greater than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <typeparamref name="T"/> to validate if is less than the <paramref name="valueBoundLower"/> and greater than the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is greater than or equal to the <paramref name="valueBoundLower"/>.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsOutsideExclusive<T>([CanBeNull] T valueArgument,
																[NotNull] String nameArgument,
																[CanBeNull] T valueBoundLower,
																[CanBeNull] T valueBoundUpper)
			where T : IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			valueArgument.RequireArgumentIsLessThan(nameArgument, valueBoundUpper);
			valueArgument.RequireArgumentIsGreaterThan(nameArgument, valueBoundLower);
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is less than the <paramref name="valueBoundLower"/> and greater than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <typeparamref name="T"/> to validate if is less than the <paramref name="valueBoundLower"/> and greater than the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is greater than or equal to the <paramref name="valueBoundLower"/>.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsOutsideExclusive<T>(T valueArgument,
																[NotNull] String nameArgument,
																T valueBoundLower,
																[CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			valueArgument.RequireArgumentIsLessThan(nameArgument, valueBoundUpper);
			valueArgument.RequireArgumentIsGreaterThan(nameArgument, valueBoundLower);
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is less than the <paramref name="valueBoundLower"/> and greater than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <typeparamref name="T"/> to validate if is less than the <paramref name="valueBoundLower"/> and greater than the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is greater than or equal to the <paramref name="valueBoundLower"/>.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsOutsideExclusive<T>(T valueArgument,
																[NotNull] String nameArgument,
																[CanBeNull] T? valueBoundLower,
																T valueBoundUpper)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			valueArgument.RequireArgumentIsLessThan(nameArgument, valueBoundUpper);
			valueArgument.RequireArgumentIsGreaterThan(nameArgument, valueBoundLower);
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is less than the <paramref name="valueBoundLower"/> and greater than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <typeparamref name="T"/> to validate if is less than the <paramref name="valueBoundLower"/> and greater than the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is greater than or equal to the <paramref name="valueBoundLower"/>.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsOutsideExclusive<T>(T valueArgument,
																[NotNull] String nameArgument,
																[CanBeNull] T? valueBoundLower,
																[CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			valueArgument.RequireArgumentIsLessThan(nameArgument, valueBoundUpper);
			valueArgument.RequireArgumentIsGreaterThan(nameArgument, valueBoundLower);
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is less than the <paramref name="valueBoundLower"/> and greater than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if is less than the <paramref name="valueBoundLower"/> and greater than the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is greater than or equal to the <paramref name="valueBoundLower"/>.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsOutsideExclusive<T>([CanBeNull] T? valueArgument,
																[NotNull] String nameArgument,
																T valueBoundLower,
																T valueBoundUpper)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			valueArgument.RequireArgumentIsLessThan(nameArgument, valueBoundUpper);
			valueArgument.RequireArgumentIsGreaterThan(nameArgument, valueBoundLower);
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is less than the <paramref name="valueBoundLower"/> and greater than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if is less than the <paramref name="valueBoundLower"/> and greater than the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is greater than or equal to the <paramref name="valueBoundLower"/>.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsOutsideExclusive<T>([CanBeNull] T? valueArgument,
																[NotNull] String nameArgument,
																T valueBoundLower,
																[CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			valueArgument.RequireArgumentIsLessThan(nameArgument, valueBoundUpper);
			valueArgument.RequireArgumentIsGreaterThan(nameArgument, valueBoundLower);
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is less than the <paramref name="valueBoundLower"/> and greater than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if is less than the <paramref name="valueBoundLower"/> and greater than the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is greater than or equal to the <paramref name="valueBoundLower"/>.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsOutsideExclusive<T>([CanBeNull] T? valueArgument,
																[NotNull] String nameArgument,
																[CanBeNull] T? valueBoundLower,
																T valueBoundUpper)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			valueArgument.RequireArgumentIsLessThan(nameArgument, valueBoundUpper);
			valueArgument.RequireArgumentIsGreaterThan(nameArgument, valueBoundLower);
		}

		/// <summary>
		///		Validates that the provided <paramref name="valueArgument"/> is less than the <paramref name="valueBoundLower"/> and greater than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if is less than the <paramref name="valueBoundLower"/> and greater than the <paramref name="valueBoundUpper"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <paramref name="valueArgument"/> to validate.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is less than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate if the <paramref name="valueArgument"/> is greater than or equal to.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> is <see cref="F:System.String.Empty"/> or white space.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is greater than or equal to the <paramref name="valueBoundLower"/>.  
		///		-or-  
		///		The <paramref name="valueArgument"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsOutsideExclusive<T>([CanBeNull] T? valueArgument,
																[NotNull] String nameArgument,
																[CanBeNull] T? valueBoundLower,
																[CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			valueArgument.RequireArgumentIsLessThan(nameArgument, valueBoundUpper);
			valueArgument.RequireArgumentIsGreaterThan(nameArgument, valueBoundLower);
		}
		
		#endregion

		#region Operators

		#endregion

		#region Nested Types

		#endregion
	}
}
