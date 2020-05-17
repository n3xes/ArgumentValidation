﻿#region Header: Copyright © 2013, John Caruthers

// =====================================================================================================================
// <copyright company="John Caruthers" file="ArgumentSignedFloatingPointNumberValidationExtension.cs">
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

namespace N3XeS.CSharp.ArgumentValidation.Extensions
{
	#region Directives

	using System;

	using JetBrains.Annotations;

	using Utilities;

	#endregion

	#region Delegates

	#endregion

	#region Enums

	#endregion

	/// <summary>
	///		A signed floating point number argument validation related extension.
	/// </summary>
	/// <author>
	///  <AuthorName>John Caruthers</AuthorName>
	///  <CreationDate>Tuesday, September 24, 2013  (09/24/2013)</CreationDate>
	///  <CreationTime>07:58:33 PM</CreationTime>
	/// </author>
	/// <history>
	///  <Modification>
	///   <ModifierName></ModifierName>
	///   <ModificationDate></ModificationDate>
	///   <ModificationTime></ModificationTime>
	///   <ModificationDescription></ModificationDescription>
	///  </Modification>
	/// </history>
	public static class ArgumentSignedFloatingPointNumberValidationExtension
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
		///		Validates that the <paramref name="valueArgument"/> is negative.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Double"/> argument value to validate is negative.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Double"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is positive.</exception>
		public static void RequireArgumentIsNegative(this Double valueArgument,
													 [NotNull] String nameArgument)
		{
			ArgumentSignedFloatingPointNumberValidationUtility.RequireArgumentIsNegative(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is negative.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> argument value to validate is negative.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is positive.</exception>
		public static void RequireArgumentIsNegative(this Double? valueArgument,
													 [NotNull] String nameArgument)
		{
			ArgumentSignedFloatingPointNumberValidationUtility.RequireArgumentIsNegative(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is negative.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Single"/> argument value to validate is negative.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Single"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is positive.</exception>
		public static void RequireArgumentIsNegative(this Single valueArgument,
													 [NotNull] String nameArgument)
		{
			ArgumentSignedFloatingPointNumberValidationUtility.RequireArgumentIsNegative(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is negative.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> argument value to validate is negative.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is positive.</exception>
		public static void RequireArgumentIsNegative(this Single? valueArgument,
													 [NotNull] String nameArgument)
		{
			ArgumentSignedFloatingPointNumberValidationUtility.RequireArgumentIsNegative(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is positive.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Double"/> argument value to validate is positive.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Double"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is negative.</exception>
		public static void RequireArgumentIsPositive(this Double valueArgument,
													 [NotNull] String nameArgument)
		{
			ArgumentSignedFloatingPointNumberValidationUtility.RequireArgumentIsPositive(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is positive.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> argument value to validate is positive.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is negative.</exception>
		public static void RequireArgumentIsPositive(this Double? valueArgument,
													 [NotNull] String nameArgument)
		{
			ArgumentSignedFloatingPointNumberValidationUtility.RequireArgumentIsPositive(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is positive.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Single"/> argument value to validate is positive.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Single"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is negative.</exception>
		public static void RequireArgumentIsPositive(this Single valueArgument,
													 [NotNull] String nameArgument)
		{
			ArgumentSignedFloatingPointNumberValidationUtility.RequireArgumentIsPositive(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is positive.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> argument value to validate is positive.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is negative.</exception>
		public static void RequireArgumentIsPositive(this Single? valueArgument,
													 [NotNull] String nameArgument)
		{
			ArgumentSignedFloatingPointNumberValidationUtility.RequireArgumentIsPositive(valueArgument, nameArgument);
		}

		#endregion

		#region Operators

		#endregion

		#region Nested Types

		#endregion
	}
}
