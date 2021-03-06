#region Header: Copyright © 2016, John Caruthers

// --------------------------------------------------------------------------------------------------------------------
// <copyright company="John Caruthers" file="AssemblyInfo.cs">
//		Copyright © 2016, John Caruthers
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
////-------------------------------------------------------------------------------------------------------------------

#endregion

#region Directives

using System;
using System.Resources;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

#endregion


// System.Reflection

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("N3XeS C# - Argument Validation Library Unit Tests")]
[assembly: AssemblyDescription("The N3XeS C# library containing extensions and utilities that are intended to be used to standardize argument validation exception types and the exception type's messages IntelliTest unit tests.")]
[assembly: AssemblyCompany("John Caruthers")]
[assembly: AssemblyProduct("N3XeS.CSharp.ArgumentValidation.UnitTests")]
[assembly: AssemblyCopyright("Copyright (c) 2016, John Caruthers")]
[assembly: AssemblyTrademark("N3XeS is a registered trademark of, John Caruthers")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyFileVersion("1.0.*")]
[assembly: AssemblyVersion("1.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyInformationalVersion("1.0")]

[assembly: AssemblyCulture("neutral")]
[assembly: NeutralResourcesLanguage("en-US")]

#if DEBUG

[assembly: AssemblyConfiguration("Debug")]

#else

[assembly: AssemblyConfiguration("Release")]

#endif

/*
#if (!NETFX_V2 && !NETFX_V3 && !NETFX_V35 && !NETFX_V4)

[assembly: AssemblySignatureKey("002400000c8000009400000006020000002400005253413100040000010001005d6df96db3295e863486dfa5858d7f475b6c3bbd01233276a62f5ac838b93d7b729a055a7b9def5900377976ca40e939cdb255a6a6dc4b387dbc014a158ccf685b7a0bc8c62bf49f6898405b7648a136b5c475212f0844c1890a862234698d66af94e9c1de0916f79ea9672282a5403a8f0e9d49054e708bd2020a59ab270bbb",
								"40d932701497932b3fd6dbbe90eb76fda14965d7808c3800e6e17fda30bc2dd8059a8fd57d7a02f9ad053d1f06d3c82bce08828d0bbbf80fe2bea2255e7605c3e24f7a9f2b3fda62d9adecfa614785f8fea3a6fa08116c68e2cdd3c2b74caf02d8848adeaabde41f028e9fc080e83e0c34b27715f5debbace8ddcb5c1f746c50")]
#endif
*/

// System
[assembly: CLSCompliant(false)]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]
// The following Guid is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("4b32c3b9-c1d3-4df4-94d3-dd11cb899e42")]

// System.Runtime.CompilerServices
[assembly: InternalsVisibleTo("Microsoft.Pex, PublicKey=002400000480000094000000060200000024000052534131000400000100010007d1fa57c4aed9f0a32e84aa0faefd0de9e8fd6aec8f87fb03766c834c99921eb23be79ad9d5dcc1dd9ad236132102900b723cf980957fc4e177108fc607774f29e8320e92ea05ece4e821c0a5efe8f1645c4c0c93c1ab99285d622caa652c1dfad63d745d6f2de5f17e5eaf0fc4963d261c8a12436518206dc093344d5ad293")]

// System.Security
[assembly: SecurityRules(SecurityRuleSet.Level1)]
