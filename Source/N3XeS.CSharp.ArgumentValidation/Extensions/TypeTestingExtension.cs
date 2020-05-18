#region Header: Copyright © 2013, John Caruthers

// =====================================================================================================================
// <copyright company="John Caruthers" file="TypeTestingExtension.cs">
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
	using System.Diagnostics.CodeAnalysis;

	using JetBrains.Annotations;

	using Utilities;

	#endregion

	#region Delegates

	#endregion

	#region Enums

	#endregion

	/// <summary>
	///		A type testing related extension.
	/// </summary>
	/// <author>
	///  <AuthorName>John Caruthers</AuthorName>
	///  <CreationDate>Tuesday, September 24, 2013  (09/24/2013)</CreationDate>
	///  <CreationTime>04:54:07 PM</CreationTime>
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
	public static class TypeTestingExtension
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
		///		Checks if the <paramref name="valueBoxed"/> is of the provided type <typeparamref name="T"/>.
		/// </summary>
		/// <typeparam name="T">The type to test.</typeparam>
		/// <param name="valueBoxed">
		///		The boxed <see cref="T:System.Object"/> to check if is of the provided type <typeparamref name="T"/>.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="valueBoxed"/> is of the provided type <typeparamref name="T"/>; otherwise, <see langword="false"/>.
		/// </returns>
		/// <exception cref="ArgumentNullException">The <paramref name="valueBoxed"/> is <see langword="null" />.</exception>
		[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter",
						 Justification = "Reviewed.  Suppression is OK here.  This is required.")]
		public static Boolean IsBoxedTypeOf<T>([NotNull] this Object valueBoxed)
		{
			return TypeTestingUtility.IsBoxedTypeOf<T>(valueBoxed);
		}

		/// <summary>
		///		Checks if the <paramref name="valueBoxed"/> is not of the provided type <typeparamref name="T"/>.
		/// </summary>
		/// <typeparam name="T">The type to test.</typeparam>
		/// <param name="valueBoxed">
		///		The boxed <see cref="T:System.Object"/> to check if is not of the provided type <typeparamref name="T"/>.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="valueBoxed"/> is not of the provided type <typeparamref name="T"/>; otherwise, <see langword="false"/>.
		/// </returns>
		/// <exception cref="ArgumentNullException">The <paramref name="valueBoxed"/> is <see langword="null" />.</exception>
		[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter",
						 Justification = "Reviewed.  Suppression is OK here.  This is required.")]
		public static Boolean IsNotBoxedTypeOf<T>([NotNull] this Object valueBoxed)
		{
			return TypeTestingUtility.IsNotBoxedTypeOf<T>(valueBoxed);
		}

		#endregion

		#region Operators

		#endregion

		#region Nested Types

		#endregion
	}
}
