﻿#region Header: Copyright © 2013, John Caruthers

// =====================================================================================================================
// <copyright company="John Caruthers" file="ArgumentFloatingPointNumberParityValidationUtility.cs">
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
namespace N3XeS.CSharp.ArgumentValidation.Utilities
{
	#region Directives

	using System;
	using System.Globalization;

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
	///		A signed floating point number parity argument validation related utility.
	/// </summary>
	/// <author>
	///  <AuthorName>John Caruthers</AuthorName>
	///  <CreationDate>Friday, October 18, 2013  (10/18/2013)</CreationDate>
	///  <CreationTime>03:37:42 PM</CreationTime>
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
	public static class ArgumentFloatingPointNumberParityValidationUtility
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
		///		Validates that the <paramref name="valueArgument"/> is even.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Double"/> argument value to validate is even.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Double"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is odd.</exception>
		public static void RequireArgumentIsEven(Double valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsEven())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeEven));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is even.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> argument value to validate is even.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is <see langword="null"/> or odd.</exception>
		public static void RequireArgumentIsEven([CanBeNull] Double? valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsOdd())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeEvenNotNull));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is even.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Single"/> argument value to validate is even.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Single"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is odd.</exception>
		public static void RequireArgumentIsEven(Single valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsEven())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeEven));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is even.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> argument value to validate is even.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is <see langword="null"/> or odd.</exception>
		public static void RequireArgumentIsEven([CanBeNull] Single? valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsOdd())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeEvenNotNull));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is odd.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Double"/> argument value to validate is odd.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Double"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is even.</exception>
		public static void RequireArgumentIsOdd(Double valueArgument,
												[NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsOdd())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeOdd));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is odd.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> argument value to validate is odd.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is <see langword="null"/> or even.</exception>
		public static void RequireArgumentIsOdd([CanBeNull] Double? valueArgument,
												[NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsEven())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeOddNotNull));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is odd.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Single"/> argument value to validate is odd.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Single"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is even.</exception>
		public static void RequireArgumentIsOdd(Single valueArgument,
												[NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsOdd())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeOdd));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is odd.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> argument value to validate is odd.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is <see langword="null"/> or even.</exception>
		public static void RequireArgumentIsOdd([CanBeNull] Single? valueArgument,
												[NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsEven())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeOddNotNull));
			}
		}

		#endregion

		#region Operators

		#endregion

		#region Nested Types

		#endregion
	}
}
