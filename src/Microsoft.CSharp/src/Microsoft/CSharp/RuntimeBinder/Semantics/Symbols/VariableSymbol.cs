// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
    // ----------------------------------------------------------------------------
    //
    // VariableSymbol
    //
    // VariableSymbol - a symbol representing a variable. Specific subclasses are 
    // used - FieldSymbol for member variables, LocalVariableSymbol for local variables
    // and formal parameters, 
    // ----------------------------------------------------------------------------

    internal abstract class VariableSymbol : Symbol
    {
        protected CType type;                       // CType of the field.
    }
}
