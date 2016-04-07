// Copyright 2005-2015 Giacomo Stelluti Scala & Contributors. All rights reserved. See License.md in the project root for license information.

using System;
using System.Collections.Generic;

namespace CommandLine
{
    /// <summary>
    /// Defines generic overloads for <see cref="CommandLine.Parser.ParseArguments(IEnumerable&lt;string&gt;,Type[])"/>.
    /// </summary>
    public static class ParserExtensions
    {
        /// <summary>
        /// Parses a string array of command line arguments for verb commands scenario, constructing the proper instance from types as generic arguments.
        /// Grammar rules are defined decorating public properties with appropriate attributes.
        /// The <see cref="CommandLine.VerbAttribute"/> must be applied to types in the array.
        /// </summary>
        /// <typeparam name="T1">The type of the first verb.</typeparam>
        /// <typeparam name="T2">The type of the second verb.</typeparam>
        /// <param name="parser">A <see cref="CommandLine.Parser"/> instance.</param>
        /// <param name="args">A <see cref="System.String"/> array of command line arguments, normally supplied by application entry point.</param>
        /// <returns>A <see cref="CommandLine.ParserResult{T}"/> containing the appropriate instance with parsed values as a <see cref="System.Object"/>
        /// and a sequence of <see cref="CommandLine.Error"/>.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if one or more arguments are null.</exception>
        /// <remarks>All types must expose a parameterless constructor.</remarks>
        public static ParserResult<object> ParseArguments<T1, T2>(this Parser parser, IEnumerable<string> args)
        {
            if (parser == null) throw new ArgumentNullException("parser");

            return parser.ParseArguments(args, new[] { typeof(T1), typeof(T2) });
        }

        /// <summary>
        /// Parses a string array of command line arguments for verb commands scenario, constructing the proper instance from types as generic arguments.
        /// Grammar rules are defined decorating public properties with appropriate attributes.
        /// The <see cref="CommandLine.VerbAttribute"/> must be applied to types in the array.
        /// </summary>
        /// <typeparam name="T1">The type of the first verb.</typeparam>
        /// <typeparam name="T2">The type of the second verb.</typeparam>
        /// <typeparam name="T3">The type of the third verb.</typeparam>
        /// <param name="parser">A <see cref="CommandLine.Parser"/> instance.</param>
        /// <param name="args">A <see cref="System.String"/> array of command line arguments, normally supplied by application entry point.</param>
        /// <returns>A <see cref="CommandLine.ParserResult{T}"/> containing the appropriate instance with parsed values as a <see cref="System.Object"/>
        /// and a sequence of <see cref="CommandLine.Error"/>.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if one or more arguments are null.</exception>
        /// <remarks>All types must expose a parameterless constructor.</remarks>
        public static ParserResult<object> ParseArguments<T1, T2, T3>(this Parser parser, IEnumerable<string> args)
        {
            if (parser == null) throw new ArgumentNullException("parser");

            return parser.ParseArguments(args, new[] { typeof(T1), typeof(T2), typeof(T3) });
        }

        /// <summary>
        /// Parses a string array of command line arguments for verb commands scenario, constructing the proper instance from types as generic arguments.
        /// Grammar rules are defined decorating public properties with appropriate attributes.
        /// The <see cref="CommandLine.VerbAttribute"/> must be applied to types in the array.
        /// </summary>
        /// <typeparam name="T1">The type of the first verb.</typeparam>
        /// <typeparam name="T2">The type of the second verb.</typeparam>
        /// <typeparam name="T3">The type of the third verb.</typeparam>
        /// <typeparam name="T4">The type of the fourth verb.</typeparam>
        /// <param name="parser">A <see cref="CommandLine.Parser"/> instance.</param>
        /// <param name="args">A <see cref="System.String"/> array of command line arguments, normally supplied by application entry point.</param>
        /// <returns>A <see cref="CommandLine.ParserResult{T}"/> containing the appropriate instance with parsed values as a <see cref="System.Object"/>
        /// and a sequence of <see cref="CommandLine.Error"/>.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if one or more arguments are null.</exception>
        /// <remarks>All types must expose a parameterless constructor.</remarks>
        public static ParserResult<object> ParseArguments<T1, T2, T3, T4>(this Parser parser, IEnumerable<string> args)
        {
            if (parser == null) throw new ArgumentNullException("parser");

            return parser.ParseArguments(args, new[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4) });
        }

        /// <summary>
        /// Parses a string array of command line arguments for verb commands scenario, constructing the proper instance from types as generic arguments.
        /// Grammar rules are defined decorating public properties with appropriate attributes.
        /// The <see cref="CommandLine.VerbAttribute"/> must be applied to types in the array.
        /// </summary>
        /// <typeparam name="T1">The type of the first verb.</typeparam>
        /// <typeparam name="T2">The type of the second verb.</typeparam>
        /// <typeparam name="T3">The type of the third verb.</typeparam>
        /// <typeparam name="T4">The type of the fourth verb.</typeparam>
        /// <typeparam name="T5">The type of the fifth verb.</typeparam>
        /// <param name="parser">A <see cref="CommandLine.Parser"/> instance.</param>
        /// <param name="args">A <see cref="System.String"/> array of command line arguments, normally supplied by application entry point.</param>
        /// <returns>A <see cref="CommandLine.ParserResult{T}"/> containing the appropriate instance with parsed values as a <see cref="System.Object"/>
        /// and a sequence of <see cref="CommandLine.Error"/>.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if one or more arguments are null.</exception>
        /// <remarks>All types must expose a parameterless constructor.</remarks>
        public static ParserResult<object> ParseArguments<T1, T2, T3, T4, T5>(this Parser parser, IEnumerable<string> args)
        {
            if (parser == null) throw new ArgumentNullException("parser");

            return parser.ParseArguments(args, new[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5) });
        }

        /// <summary>
        /// Parses a string array of command line arguments for verb commands scenario, constructing the proper instance from types as generic arguments.
        /// Grammar rules are defined decorating public properties with appropriate attributes.
        /// The <see cref="CommandLine.VerbAttribute"/> must be applied to types in the array.
        /// </summary>
        /// <typeparam name="T1">The type of the first verb.</typeparam>
        /// <typeparam name="T2">The type of the second verb.</typeparam>
        /// <typeparam name="T3">The type of the third verb.</typeparam>
        /// <typeparam name="T4">The type of the fourth verb.</typeparam>
        /// <typeparam name="T5">The type of the fifth verb.</typeparam>
        /// <typeparam name="T6">The type of the sixth verb.</typeparam>
        /// <param name="parser">A <see cref="CommandLine.Parser"/> instance.</param>
        /// <param name="args">A <see cref="System.String"/> array of command line arguments, normally supplied by application entry point.</param>
        /// <returns>A <see cref="CommandLine.ParserResult{T}"/> containing the appropriate instance with parsed values as a <see cref="System.Object"/>
        /// and a sequence of <see cref="CommandLine.Error"/>.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if one or more arguments are null.</exception>
        /// <remarks>All types must expose a parameterless constructor.</remarks>
        public static ParserResult<object> ParseArguments<T1, T2, T3, T4, T5, T6>(this Parser parser, IEnumerable<string> args)
        {
            if (parser == null) throw new ArgumentNullException("parser");

            return parser.ParseArguments(args, new[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6) });
        }

        /// <summary>
        /// Parses a string array of command line arguments for verb commands scenario, constructing the proper instance from types as generic arguments.
        /// Grammar rules are defined decorating public properties with appropriate attributes.
        /// The <see cref="CommandLine.VerbAttribute"/> must be applied to types in the array.
        /// </summary>
        /// <typeparam name="T1">The type of the first verb.</typeparam>
        /// <typeparam name="T2">The type of the second verb.</typeparam>
        /// <typeparam name="T3">The type of the third verb.</typeparam>
        /// <typeparam name="T4">The type of the fourth verb.</typeparam>
        /// <typeparam name="T5">The type of the fifth verb.</typeparam>
        /// <typeparam name="T6">The type of the sixth verb.</typeparam>
        /// <typeparam name="T7">The type of the seventh verb.</typeparam>
        /// <param name="parser">A <see cref="CommandLine.Parser"/> instance.</param>
        /// <param name="args">A <see cref="System.String"/> array of command line arguments, normally supplied by application entry point.</param>
        /// <returns>A <see cref="CommandLine.ParserResult{T}"/> containing the appropriate instance with parsed values as a <see cref="System.Object"/>
        /// and a sequence of <see cref="CommandLine.Error"/>.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if one or more arguments are null.</exception>
        /// <remarks>All types must expose a parameterless constructor.</remarks>
        public static ParserResult<object> ParseArguments<T1, T2, T3, T4, T5, T6, T7>(this Parser parser, IEnumerable<string> args)
        {
            if (parser == null) throw new ArgumentNullException("parser");

            return parser.ParseArguments(args, new[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7) });
        }

        /// <summary>
        /// Parses a string array of command line arguments for verb commands scenario, constructing the proper instance from types as generic arguments.
        /// Grammar rules are defined decorating public properties with appropriate attributes.
        /// The <see cref="CommandLine.VerbAttribute"/> must be applied to types in the array.
        /// </summary>
        /// <typeparam name="T1">The type of the first verb.</typeparam>
        /// <typeparam name="T2">The type of the second verb.</typeparam>
        /// <typeparam name="T3">The type of the third verb.</typeparam>
        /// <typeparam name="T4">The type of the fourth verb.</typeparam>
        /// <typeparam name="T5">The type of the fifth verb.</typeparam>
        /// <typeparam name="T6">The type of the sixth verb.</typeparam>
        /// <typeparam name="T7">The type of the seventh verb.</typeparam>
        /// <typeparam name="T8">The type of the eighth verb.</typeparam>
        /// <param name="parser">A <see cref="CommandLine.Parser"/> instance.</param>
        /// <param name="args">A <see cref="System.String"/> array of command line arguments, normally supplied by application entry point.</param>
        /// <returns>A <see cref="CommandLine.ParserResult{T}"/> containing the appropriate instance with parsed values as a <see cref="System.Object"/>
        /// and a sequence of <see cref="CommandLine.Error"/>.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if one or more arguments are null.</exception>
        /// <remarks>All types must expose a parameterless constructor.</remarks>
        public static ParserResult<object> ParseArguments<T1, T2, T3, T4, T5, T6, T7, T8>(this Parser parser, IEnumerable<string> args)
        {
            if (parser == null) throw new ArgumentNullException("parser");

            return parser.ParseArguments(args, new[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8) });
        }

        /// <summary>
        /// Parses a string array of command line arguments for verb commands scenario, constructing the proper instance from types as generic arguments.
        /// Grammar rules are defined decorating public properties with appropriate attributes.
        /// The <see cref="CommandLine.VerbAttribute"/> must be applied to types in the array.
        /// </summary>
        /// <typeparam name="T1">The type of the first verb.</typeparam>
        /// <typeparam name="T2">The type of the second verb.</typeparam>
        /// <typeparam name="T3">The type of the third verb.</typeparam>
        /// <typeparam name="T4">The type of the fourth verb.</typeparam>
        /// <typeparam name="T5">The type of the fifth verb.</typeparam>
        /// <typeparam name="T6">The type of the sixth verb.</typeparam>
        /// <typeparam name="T7">The type of the seventh verb.</typeparam>
        /// <typeparam name="T8">The type of the eighth verb.</typeparam>
        /// <typeparam name="T9">The type of the ninth verb.</typeparam>
        /// <param name="parser">A <see cref="CommandLine.Parser"/> instance.</param>
        /// <param name="args">A <see cref="System.String"/> array of command line arguments, normally supplied by application entry point.</param>
        /// <returns>A <see cref="CommandLine.ParserResult{T}"/> containing the appropriate instance with parsed values as a <see cref="System.Object"/>
        /// and a sequence of <see cref="CommandLine.Error"/>.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if one or more arguments are null.</exception>
        /// <remarks>All types must expose a parameterless constructor.</remarks>
        public static ParserResult<object> ParseArguments<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Parser parser, IEnumerable<string> args)
        {
            if (parser == null) throw new ArgumentNullException("parser");

            return parser.ParseArguments(args, new[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8),
                typeof(T9) });
        }

        /// <summary>
        /// Parses a string array of command line arguments for verb commands scenario, constructing the proper instance from types as generic arguments.
        /// Grammar rules are defined decorating public properties with appropriate attributes.
        /// The <see cref="CommandLine.VerbAttribute"/> must be applied to types in the array.
        /// </summary>
        /// <typeparam name="T1">The type of the first verb.</typeparam>
        /// <typeparam name="T2">The type of the second verb.</typeparam>
        /// <typeparam name="T3">The type of the third verb.</typeparam>
        /// <typeparam name="T4">The type of the fourth verb.</typeparam>
        /// <typeparam name="T5">The type of the fifth verb.</typeparam>
        /// <typeparam name="T6">The type of the sixth verb.</typeparam>
        /// <typeparam name="T7">The type of the seventh verb.</typeparam>
        /// <typeparam name="T8">The type of the eighth verb.</typeparam>
        /// <typeparam name="T9">The type of the ninth verb.</typeparam>
        /// <typeparam name="T10">The type of the tenth verb.</typeparam>
        /// <param name="parser">A <see cref="CommandLine.Parser"/> instance.</param>
        /// <param name="args">A <see cref="System.String"/> array of command line arguments, normally supplied by application entry point.</param>
        /// <returns>A <see cref="CommandLine.ParserResult{T}"/> containing the appropriate instance with parsed values as a <see cref="System.Object"/>
        /// and a sequence of <see cref="CommandLine.Error"/>.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if one or more arguments are null.</exception>
        /// <remarks>All types must expose a parameterless constructor.</remarks>
        public static ParserResult<object> ParseArguments<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Parser parser, IEnumerable<string> args)
        {
            if (parser == null) throw new ArgumentNullException("parser");

            return parser.ParseArguments(args, new[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8),
                typeof(T9), typeof(T10) });
        }

        /// <summary>
        /// Parses a string array of command line arguments for verb commands scenario, constructing the proper instance from types as generic arguments.
        /// Grammar rules are defined decorating public properties with appropriate attributes.
        /// The <see cref="CommandLine.VerbAttribute"/> must be applied to types in the array.
        /// </summary>
        /// <typeparam name="T1">The type of the first verb.</typeparam>
        /// <typeparam name="T2">The type of the second verb.</typeparam>
        /// <typeparam name="T3">The type of the third verb.</typeparam>
        /// <typeparam name="T4">The type of the fourth verb.</typeparam>
        /// <typeparam name="T5">The type of the fifth verb.</typeparam>
        /// <typeparam name="T6">The type of the sixth verb.</typeparam>
        /// <typeparam name="T7">The type of the seventh verb.</typeparam>
        /// <typeparam name="T8">The type of the eighth verb.</typeparam>
        /// <typeparam name="T9">The type of the ninth verb.</typeparam>
        /// <typeparam name="T10">The type of the tenth verb.</typeparam>
        /// <typeparam name="T11">The type of the eleventh verb.</typeparam>
        /// <param name="parser">A <see cref="CommandLine.Parser"/> instance.</param>
        /// <param name="args">A <see cref="System.String"/> array of command line arguments, normally supplied by application entry point.</param>
        /// <returns>A <see cref="CommandLine.ParserResult{T}"/> containing the appropriate instance with parsed values as a <see cref="System.Object"/>
        /// and a sequence of <see cref="CommandLine.Error"/>.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if one or more arguments are null.</exception>
        /// <remarks>All types must expose a parameterless constructor.</remarks>
        public static ParserResult<object> ParseArguments<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Parser parser, IEnumerable<string> args)
        {
            if (parser == null) throw new ArgumentNullException("parser");

            return parser.ParseArguments(args, new[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8),
                typeof(T9), typeof(T10), typeof(T11) });
        }

        /// <summary>
        /// Parses a string array of command line arguments for verb commands scenario, constructing the proper instance from types as generic arguments.
        /// Grammar rules are defined decorating public properties with appropriate attributes.
        /// The <see cref="CommandLine.VerbAttribute"/> must be applied to types in the array.
        /// </summary>
        /// <typeparam name="T1">The type of the first verb.</typeparam>
        /// <typeparam name="T2">The type of the second verb.</typeparam>
        /// <typeparam name="T3">The type of the third verb.</typeparam>
        /// <typeparam name="T4">The type of the fourth verb.</typeparam>
        /// <typeparam name="T5">The type of the fifth verb.</typeparam>
        /// <typeparam name="T6">The type of the sixth verb.</typeparam>
        /// <typeparam name="T7">The type of the seventh verb.</typeparam>
        /// <typeparam name="T8">The type of the eighth verb.</typeparam>
        /// <typeparam name="T9">The type of the ninth verb.</typeparam>
        /// <typeparam name="T10">The type of the tenth verb.</typeparam>
        /// <typeparam name="T11">The type of the eleventh verb.</typeparam>
        /// <typeparam name="T12">The type of the twelfth verb.</typeparam>
        /// <param name="parser">A <see cref="CommandLine.Parser"/> instance.</param>
        /// <param name="args">A <see cref="System.String"/> array of command line arguments, normally supplied by application entry point.</param>
        /// <returns>A <see cref="CommandLine.ParserResult{T}"/> containing the appropriate instance with parsed values as a <see cref="System.Object"/>
        /// and a sequence of <see cref="CommandLine.Error"/>.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if one or more arguments are null.</exception>
        /// <remarks>All types must expose a parameterless constructor.</remarks>
        public static ParserResult<object> ParseArguments<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Parser parser, IEnumerable<string> args)
        {
            if (parser == null) throw new ArgumentNullException("parser");

            return parser.ParseArguments(args, new[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8),
                typeof(T9), typeof(T10), typeof(T11), typeof(T12) });
        }

        /// <summary>
        /// Parses a string array of command line arguments for verb commands scenario, constructing the proper instance from types as generic arguments.
        /// Grammar rules are defined decorating public properties with appropriate attributes.
        /// The <see cref="CommandLine.VerbAttribute"/> must be applied to types in the array.
        /// </summary>
        /// <typeparam name="T1">The type of the first verb.</typeparam>
        /// <typeparam name="T2">The type of the second verb.</typeparam>
        /// <typeparam name="T3">The type of the third verb.</typeparam>
        /// <typeparam name="T4">The type of the fourth verb.</typeparam>
        /// <typeparam name="T5">The type of the fifth verb.</typeparam>
        /// <typeparam name="T6">The type of the sixth verb.</typeparam>
        /// <typeparam name="T7">The type of the seventh verb.</typeparam>
        /// <typeparam name="T8">The type of the eighth verb.</typeparam>
        /// <typeparam name="T9">The type of the ninth verb.</typeparam>
        /// <typeparam name="T10">The type of the tenth verb.</typeparam>
        /// <typeparam name="T11">The type of the eleventh verb.</typeparam>
        /// <typeparam name="T12">The type of the twelfth verb.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth verb.</typeparam>
        /// <param name="parser">A <see cref="CommandLine.Parser"/> instance.</param>
        /// <param name="args">A <see cref="System.String"/> array of command line arguments, normally supplied by application entry point.</param>
        /// <returns>A <see cref="CommandLine.ParserResult{T}"/> containing the appropriate instance with parsed values as a <see cref="System.Object"/>
        /// and a sequence of <see cref="CommandLine.Error"/>.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if one or more arguments are null.</exception>
        /// <remarks>All types must expose a parameterless constructor.</remarks>
        public static ParserResult<object> ParseArguments<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Parser parser, IEnumerable<string> args)
        {
            if (parser == null) throw new ArgumentNullException("parser");

            return parser.ParseArguments(args, new[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8),
                typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13) });
        }

        /// <summary>
        /// Parses a string array of command line arguments for verb commands scenario, constructing the proper instance from types as generic arguments.
        /// Grammar rules are defined decorating public properties with appropriate attributes.
        /// The <see cref="CommandLine.VerbAttribute"/> must be applied to types in the array.
        /// </summary>
        /// <typeparam name="T1">The type of the first verb.</typeparam>
        /// <typeparam name="T2">The type of the second verb.</typeparam>
        /// <typeparam name="T3">The type of the third verb.</typeparam>
        /// <typeparam name="T4">The type of the fourth verb.</typeparam>
        /// <typeparam name="T5">The type of the fifth verb.</typeparam>
        /// <typeparam name="T6">The type of the sixth verb.</typeparam>
        /// <typeparam name="T7">The type of the seventh verb.</typeparam>
        /// <typeparam name="T8">The type of the eighth verb.</typeparam>
        /// <typeparam name="T9">The type of the ninth verb.</typeparam>
        /// <typeparam name="T10">The type of the tenth verb.</typeparam>
        /// <typeparam name="T11">The type of the eleventh verb.</typeparam>
        /// <typeparam name="T12">The type of the twelfth verb.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth verb.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth verb.</typeparam>
        /// <param name="parser">A <see cref="CommandLine.Parser"/> instance.</param>
        /// <param name="args">A <see cref="System.String"/> array of command line arguments, normally supplied by application entry point.</param>
        /// <returns>A <see cref="CommandLine.ParserResult{T}"/> containing the appropriate instance with parsed values as a <see cref="System.Object"/>
        /// and a sequence of <see cref="CommandLine.Error"/>.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if one or more arguments are null.</exception>
        /// <remarks>All types must expose a parameterless constructor.</remarks>
        public static ParserResult<object> ParseArguments<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Parser parser, IEnumerable<string> args)
        {
            if (parser == null) throw new ArgumentNullException("parser");

            return parser.ParseArguments(args, new[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8),
                typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14) });
        }

        /// <summary>
        /// Parses a string array of command line arguments for verb commands scenario, constructing the proper instance from types as generic arguments.
        /// Grammar rules are defined decorating public properties with appropriate attributes.
        /// The <see cref="CommandLine.VerbAttribute"/> must be applied to types in the array.
        /// </summary>
        /// <typeparam name="T1">The type of the first verb.</typeparam>
        /// <typeparam name="T2">The type of the second verb.</typeparam>
        /// <typeparam name="T3">The type of the third verb.</typeparam>
        /// <typeparam name="T4">The type of the fourth verb.</typeparam>
        /// <typeparam name="T5">The type of the fifth verb.</typeparam>
        /// <typeparam name="T6">The type of the sixth verb.</typeparam>
        /// <typeparam name="T7">The type of the seventh verb.</typeparam>
        /// <typeparam name="T8">The type of the eighth verb.</typeparam>
        /// <typeparam name="T9">The type of the ninth verb.</typeparam>
        /// <typeparam name="T10">The type of the tenth verb.</typeparam>
        /// <typeparam name="T11">The type of the eleventh verb.</typeparam>
        /// <typeparam name="T12">The type of the twelfth verb.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth verb.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth verb.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth verb.</typeparam>
        /// <param name="parser">A <see cref="CommandLine.Parser"/> instance.</param>
        /// <param name="args">A <see cref="System.String"/> array of command line arguments, normally supplied by application entry point.</param>
        /// <returns>A <see cref="CommandLine.ParserResult{T}"/> containing the appropriate instance with parsed values as a <see cref="System.Object"/>
        /// and a sequence of <see cref="CommandLine.Error"/>.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if one or more arguments are null.</exception>
        /// <remarks>All types must expose a parameterless constructor.</remarks>
        public static ParserResult<object> ParseArguments<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Parser parser, IEnumerable<string> args)
        {
            if (parser == null) throw new ArgumentNullException("parser");

            return parser.ParseArguments(args, new[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8),
                typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15) });
        }

        /// <summary>
        /// Parses a string array of command line arguments for verb commands scenario, constructing the proper instance from types as generic arguments.
        /// Grammar rules are defined decorating public properties with appropriate attributes.
        /// The <see cref="CommandLine.VerbAttribute"/> must be applied to types in the array.
        /// </summary>
        /// <typeparam name="T1">The type of the first verb.</typeparam>
        /// <typeparam name="T2">The type of the second verb.</typeparam>
        /// <typeparam name="T3">The type of the third verb.</typeparam>
        /// <typeparam name="T4">The type of the fourth verb.</typeparam>
        /// <typeparam name="T5">The type of the fifth verb.</typeparam>
        /// <typeparam name="T6">The type of the sixth verb.</typeparam>
        /// <typeparam name="T7">The type of the seventh verb.</typeparam>
        /// <typeparam name="T8">The type of the eighth verb.</typeparam>
        /// <typeparam name="T9">The type of the ninth verb.</typeparam>
        /// <typeparam name="T10">The type of the tenth verb.</typeparam>
        /// <typeparam name="T11">The type of the eleventh verb.</typeparam>
        /// <typeparam name="T12">The type of the twelfth verb.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth verb.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth verb.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth verb.</typeparam>
        /// <typeparam name="T16">The type of the sixteenth verb.</typeparam>
        /// <param name="parser">A <see cref="CommandLine.Parser"/> instance.</param>
        /// <param name="args">A <see cref="System.String"/> array of command line arguments, normally supplied by application entry point.</param>
        /// <returns>A <see cref="CommandLine.ParserResult{T}"/> containing the appropriate instance with parsed values as a <see cref="System.Object"/>
        /// and a sequence of <see cref="CommandLine.Error"/>.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if one or more arguments are null.</exception>
        /// <remarks>All types must expose a parameterless constructor.</remarks>
        public static ParserResult<object> ParseArguments<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> (this Parser parser, IEnumerable<string> args)
        {
            if (parser == null) throw new ArgumentNullException ("parser");

            return parser.ParseArguments (args, new [] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8),
                typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15), typeof(T16)});
        }

        /// <summary>
        /// Parses a string array of command line arguments for verb commands scenario, constructing the proper instance from types as generic arguments.
        /// Grammar rules are defined decorating public properties with appropriate attributes.
        /// The <see cref="CommandLine.VerbAttribute"/> must be applied to types in the array.
        /// </summary>
        /// <typeparam name="T1">The type of the first verb.</typeparam>
        /// <typeparam name="T2">The type of the second verb.</typeparam>
        /// <typeparam name="T3">The type of the third verb.</typeparam>
        /// <typeparam name="T4">The type of the fourth verb.</typeparam>
        /// <typeparam name="T5">The type of the fifth verb.</typeparam>
        /// <typeparam name="T6">The type of the sixth verb.</typeparam>
        /// <typeparam name="T7">The type of the seventh verb.</typeparam>
        /// <typeparam name="T8">The type of the eighth verb.</typeparam>
        /// <typeparam name="T9">The type of the ninth verb.</typeparam>
        /// <typeparam name="T10">The type of the tenth verb.</typeparam>
        /// <typeparam name="T11">The type of the eleventh verb.</typeparam>
        /// <typeparam name="T12">The type of the twelfth verb.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth verb.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth verb.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth verb.</typeparam>
        /// <typeparam name="T16">The type of the sixteenth verb.</typeparam>
        /// <typeparam name="T17">The type of the seventeenth verb.</typeparam>
        /// <param name="parser">A <see cref="CommandLine.Parser"/> instance.</param>
        /// <param name="args">A <see cref="System.String"/> array of command line arguments, normally supplied by application entry point.</param>
        /// <returns>A <see cref="CommandLine.ParserResult{T}"/> containing the appropriate instance with parsed values as a <see cref="System.Object"/>
        /// and a sequence of <see cref="CommandLine.Error"/>.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if one or more arguments are null.</exception>
        /// <remarks>All types must expose a parameterless constructor.</remarks>
        public static ParserResult<object> ParseArguments<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> (this Parser parser, IEnumerable<string> args)
        {
            if (parser == null) throw new ArgumentNullException ("parser");

            return parser.ParseArguments (args, new [] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8),
                typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15), typeof(T16), typeof(T17)});
        }

        /// <summary>
        /// Parses a string array of command line arguments for verb commands scenario, constructing the proper instance from types as generic arguments.
        /// Grammar rules are defined decorating public properties with appropriate attributes.
        /// The <see cref="CommandLine.VerbAttribute"/> must be applied to types in the array.
        /// </summary>
        /// <typeparam name="T1">The type of the first verb.</typeparam>
        /// <typeparam name="T2">The type of the second verb.</typeparam>
        /// <typeparam name="T3">The type of the third verb.</typeparam>
        /// <typeparam name="T4">The type of the fourth verb.</typeparam>
        /// <typeparam name="T5">The type of the fifth verb.</typeparam>
        /// <typeparam name="T6">The type of the sixth verb.</typeparam>
        /// <typeparam name="T7">The type of the seventh verb.</typeparam>
        /// <typeparam name="T8">The type of the eighth verb.</typeparam>
        /// <typeparam name="T9">The type of the ninth verb.</typeparam>
        /// <typeparam name="T10">The type of the tenth verb.</typeparam>
        /// <typeparam name="T11">The type of the eleventh verb.</typeparam>
        /// <typeparam name="T12">The type of the twelfth verb.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth verb.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth verb.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth verb.</typeparam>
        /// <typeparam name="T16">The type of the sixteenth verb.</typeparam>
        /// <typeparam name="T17">The type of the seventeenth verb.</typeparam>
        /// <typeparam name="T18">The type of the eighteenth verb.</typeparam>
        /// <param name="parser">A <see cref="CommandLine.Parser"/> instance.</param>
        /// <param name="args">A <see cref="System.String"/> array of command line arguments, normally supplied by application entry point.</param>
        /// <returns>A <see cref="CommandLine.ParserResult{T}"/> containing the appropriate instance with parsed values as a <see cref="System.Object"/>
        /// and a sequence of <see cref="CommandLine.Error"/>.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if one or more arguments are null.</exception>
        /// <remarks>All types must expose a parameterless constructor.</remarks>
        public static ParserResult<object> ParseArguments<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> (this Parser parser, IEnumerable<string> args)
        {
            if (parser == null) throw new ArgumentNullException ("parser");

            return parser.ParseArguments (args, new [] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8),
                typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15), typeof(T16), typeof(T17), typeof(T18)});
        }

        /// <summary>
        /// Parses a string array of command line arguments for verb commands scenario, constructing the proper instance from types as generic arguments.
        /// Grammar rules are defined decorating public properties with appropriate attributes.
        /// The <see cref="CommandLine.VerbAttribute"/> must be applied to types in the array.
        /// </summary>
        /// <typeparam name="T1">The type of the first verb.</typeparam>
        /// <typeparam name="T2">The type of the second verb.</typeparam>
        /// <typeparam name="T3">The type of the third verb.</typeparam>
        /// <typeparam name="T4">The type of the fourth verb.</typeparam>
        /// <typeparam name="T5">The type of the fifth verb.</typeparam>
        /// <typeparam name="T6">The type of the sixth verb.</typeparam>
        /// <typeparam name="T7">The type of the seventh verb.</typeparam>
        /// <typeparam name="T8">The type of the eighth verb.</typeparam>
        /// <typeparam name="T9">The type of the ninth verb.</typeparam>
        /// <typeparam name="T10">The type of the tenth verb.</typeparam>
        /// <typeparam name="T11">The type of the eleventh verb.</typeparam>
        /// <typeparam name="T12">The type of the twelfth verb.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth verb.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth verb.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth verb.</typeparam>
        /// <typeparam name="T16">The type of the sixteenth verb.</typeparam>
        /// <typeparam name="T17">The type of the seventeenth verb.</typeparam>
        /// <typeparam name="T18">The type of the eighteenth verb.</typeparam>
        /// <typeparam name="T19">The type of the nineteenth verb.</typeparam>
        /// <param name="parser">A <see cref="CommandLine.Parser"/> instance.</param>
        /// <param name="args">A <see cref="System.String"/> array of command line arguments, normally supplied by application entry point.</param>
        /// <returns>A <see cref="CommandLine.ParserResult{T}"/> containing the appropriate instance with parsed values as a <see cref="System.Object"/>
        /// and a sequence of <see cref="CommandLine.Error"/>.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if one or more arguments are null.</exception>
        /// <remarks>All types must expose a parameterless constructor.</remarks>
        public static ParserResult<object> ParseArguments<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> (this Parser parser, IEnumerable<string> args)
        {
            if (parser == null) throw new ArgumentNullException ("parser");

            return parser.ParseArguments (args, new [] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8),
                typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15), typeof(T16), typeof(T17), typeof(T18),
                typeof(T19)});
        }

        /// <summary>
        /// Parses a string array of command line arguments for verb commands scenario, constructing the proper instance from types as generic arguments.
        /// Grammar rules are defined decorating public properties with appropriate attributes.
        /// The <see cref="CommandLine.VerbAttribute"/> must be applied to types in the array.
        /// </summary>
        /// <typeparam name="T1">The type of the first verb.</typeparam>
        /// <typeparam name="T2">The type of the second verb.</typeparam>
        /// <typeparam name="T3">The type of the third verb.</typeparam>
        /// <typeparam name="T4">The type of the fourth verb.</typeparam>
        /// <typeparam name="T5">The type of the fifth verb.</typeparam>
        /// <typeparam name="T6">The type of the sixth verb.</typeparam>
        /// <typeparam name="T7">The type of the seventh verb.</typeparam>
        /// <typeparam name="T8">The type of the eighth verb.</typeparam>
        /// <typeparam name="T9">The type of the ninth verb.</typeparam>
        /// <typeparam name="T10">The type of the tenth verb.</typeparam>
        /// <typeparam name="T11">The type of the eleventh verb.</typeparam>
        /// <typeparam name="T12">The type of the twelfth verb.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth verb.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth verb.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth verb.</typeparam>
        /// <typeparam name="T16">The type of the sixteenth verb.</typeparam>
        /// <typeparam name="T17">The type of the seventeenth verb.</typeparam>
        /// <typeparam name="T18">The type of the eighteenth verb.</typeparam>
        /// <typeparam name="T19">The type of the nineteenth verb.</typeparam>
        /// <typeparam name="T20">The type of the twentieth verb.</typeparam>
        /// <param name="parser">A <see cref="CommandLine.Parser"/> instance.</param>
        /// <param name="args">A <see cref="System.String"/> array of command line arguments, normally supplied by application entry point.</param>
        /// <returns>A <see cref="CommandLine.ParserResult{T}"/> containing the appropriate instance with parsed values as a <see cref="System.Object"/>
        /// and a sequence of <see cref="CommandLine.Error"/>.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if one or more arguments are null.</exception>
        /// <remarks>All types must expose a parameterless constructor.</remarks>
        public static ParserResult<object> ParseArguments<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> (this Parser parser, IEnumerable<string> args)
        {
            if (parser == null) throw new ArgumentNullException ("parser");

            return parser.ParseArguments (args, new [] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8),
                typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15), typeof(T16), typeof(T17), typeof(T18),
                typeof(T19), typeof(T20)});
        }

        /// <summary>
        /// Parses a string array of command line arguments for verb commands scenario, constructing the proper instance from types as generic arguments.
        /// Grammar rules are defined decorating public properties with appropriate attributes.
        /// The <see cref="CommandLine.VerbAttribute"/> must be applied to types in the array.
        /// </summary>
        /// <typeparam name="T1">The type of the first verb.</typeparam>
        /// <typeparam name="T2">The type of the second verb.</typeparam>
        /// <typeparam name="T3">The type of the third verb.</typeparam>
        /// <typeparam name="T4">The type of the fourth verb.</typeparam>
        /// <typeparam name="T5">The type of the fifth verb.</typeparam>
        /// <typeparam name="T6">The type of the sixth verb.</typeparam>
        /// <typeparam name="T7">The type of the seventh verb.</typeparam>
        /// <typeparam name="T8">The type of the eighth verb.</typeparam>
        /// <typeparam name="T9">The type of the ninth verb.</typeparam>
        /// <typeparam name="T10">The type of the tenth verb.</typeparam>
        /// <typeparam name="T11">The type of the eleventh verb.</typeparam>
        /// <typeparam name="T12">The type of the twelfth verb.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth verb.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth verb.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth verb.</typeparam>
        /// <typeparam name="T16">The type of the sixteenth verb.</typeparam>
        /// <typeparam name="T17">The type of the seventeenth verb.</typeparam>
        /// <typeparam name="T18">The type of the eighteenth verb.</typeparam>
        /// <typeparam name="T19">The type of the nineteenth verb.</typeparam>
        /// <typeparam name="T20">The type of the twentieth verb.</typeparam>
        /// <typeparam name="T21">The type of the twenty-first verb.</typeparam>
        /// <param name="parser">A <see cref="CommandLine.Parser"/> instance.</param>
        /// <param name="args">A <see cref="System.String"/> array of command line arguments, normally supplied by application entry point.</param>
        /// <returns>A <see cref="CommandLine.ParserResult{T}"/> containing the appropriate instance with parsed values as a <see cref="System.Object"/>
        /// and a sequence of <see cref="CommandLine.Error"/>.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if one or more arguments are null.</exception>
        /// <remarks>All types must expose a parameterless constructor.</remarks>
        public static ParserResult<object> ParseArguments<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> (this Parser parser, IEnumerable<string> args)
        {
            if (parser == null) throw new ArgumentNullException ("parser");

            return parser.ParseArguments (args, new [] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8),
                typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15), typeof(T16), typeof(T17), typeof(T18),
                typeof(T19), typeof(T20), typeof(T21)});
        }

        /// <summary>
        /// Parses a string array of command line arguments for verb commands scenario, constructing the proper instance from types as generic arguments.
        /// Grammar rules are defined decorating public properties with appropriate attributes.
        /// The <see cref="CommandLine.VerbAttribute"/> must be applied to types in the array.
        /// </summary>
        /// <typeparam name="T1">The type of the first verb.</typeparam>
        /// <typeparam name="T2">The type of the second verb.</typeparam>
        /// <typeparam name="T3">The type of the third verb.</typeparam>
        /// <typeparam name="T4">The type of the fourth verb.</typeparam>
        /// <typeparam name="T5">The type of the fifth verb.</typeparam>
        /// <typeparam name="T6">The type of the sixth verb.</typeparam>
        /// <typeparam name="T7">The type of the seventh verb.</typeparam>
        /// <typeparam name="T8">The type of the eighth verb.</typeparam>
        /// <typeparam name="T9">The type of the ninth verb.</typeparam>
        /// <typeparam name="T10">The type of the tenth verb.</typeparam>
        /// <typeparam name="T11">The type of the eleventh verb.</typeparam>
        /// <typeparam name="T12">The type of the twelfth verb.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth verb.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth verb.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth verb.</typeparam>
        /// <typeparam name="T16">The type of the sixteenth verb.</typeparam>
        /// <typeparam name="T17">The type of the seventeenth verb.</typeparam>
        /// <typeparam name="T18">The type of the eighteenth verb.</typeparam>
        /// <typeparam name="T19">The type of the nineteenth verb.</typeparam>
        /// <typeparam name="T20">The type of the twentieth verb.</typeparam>
        /// <typeparam name="T21">The type of the twenty-first verb.</typeparam>
        /// <typeparam name="T22">The type of the twenty-second verb.</typeparam>
        /// <param name="parser">A <see cref="CommandLine.Parser"/> instance.</param>
        /// <param name="args">A <see cref="System.String"/> array of command line arguments, normally supplied by application entry point.</param>
        /// <returns>A <see cref="CommandLine.ParserResult{T}"/> containing the appropriate instance with parsed values as a <see cref="System.Object"/>
        /// and a sequence of <see cref="CommandLine.Error"/>.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if one or more arguments are null.</exception>
        /// <remarks>All types must expose a parameterless constructor.</remarks>
        public static ParserResult<object> ParseArguments<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> (this Parser parser, IEnumerable<string> args)
        {
            if (parser == null) throw new ArgumentNullException ("parser");

            return parser.ParseArguments (args, new [] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8),
                typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15), typeof(T16), typeof(T17), typeof(T18),
                typeof(T19), typeof(T20), typeof(T21), typeof(T22)});
        }

        /// <summary>
        /// Parses a string array of command line arguments for verb commands scenario, constructing the proper instance from types as generic arguments.
        /// Grammar rules are defined decorating public properties with appropriate attributes.
        /// The <see cref="CommandLine.VerbAttribute"/> must be applied to types in the array.
        /// </summary>
        /// <typeparam name="T1">The type of the first verb.</typeparam>
        /// <typeparam name="T2">The type of the second verb.</typeparam>
        /// <typeparam name="T3">The type of the third verb.</typeparam>
        /// <typeparam name="T4">The type of the fourth verb.</typeparam>
        /// <typeparam name="T5">The type of the fifth verb.</typeparam>
        /// <typeparam name="T6">The type of the sixth verb.</typeparam>
        /// <typeparam name="T7">The type of the seventh verb.</typeparam>
        /// <typeparam name="T8">The type of the eighth verb.</typeparam>
        /// <typeparam name="T9">The type of the ninth verb.</typeparam>
        /// <typeparam name="T10">The type of the tenth verb.</typeparam>
        /// <typeparam name="T11">The type of the eleventh verb.</typeparam>
        /// <typeparam name="T12">The type of the twelfth verb.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth verb.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth verb.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth verb.</typeparam>
        /// <typeparam name="T16">The type of the sixteenth verb.</typeparam>
        /// <typeparam name="T17">The type of the seventeenth verb.</typeparam>
        /// <typeparam name="T18">The type of the eighteenth verb.</typeparam>
        /// <typeparam name="T19">The type of the nineteenth verb.</typeparam>
        /// <typeparam name="T20">The type of the twentieth verb.</typeparam>
        /// <typeparam name="T21">The type of the twenty-first verb.</typeparam>
        /// <typeparam name="T22">The type of the twenty-second verb.</typeparam>
        /// <typeparam name="T23">The type of the twenty-third verb.</typeparam>
        /// <param name="parser">A <see cref="CommandLine.Parser"/> instance.</param>
        /// <param name="args">A <see cref="System.String"/> array of command line arguments, normally supplied by application entry point.</param>
        /// <returns>A <see cref="CommandLine.ParserResult{T}"/> containing the appropriate instance with parsed values as a <see cref="System.Object"/>
        /// and a sequence of <see cref="CommandLine.Error"/>.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if one or more arguments are null.</exception>
        /// <remarks>All types must expose a parameterless constructor.</remarks>
        public static ParserResult<object> ParseArguments<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> (this Parser parser, IEnumerable<string> args)
        {
            if (parser == null) throw new ArgumentNullException ("parser");

            return parser.ParseArguments (args, new [] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8),
                typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15), typeof(T16), typeof(T17), typeof(T18),
                typeof(T19), typeof(T20), typeof(T21), typeof(T22), typeof(T23)});
        }

        /// <summary>
        /// Parses a string array of command line arguments for verb commands scenario, constructing the proper instance from types as generic arguments.
        /// Grammar rules are defined decorating public properties with appropriate attributes.
        /// The <see cref="CommandLine.VerbAttribute"/> must be applied to types in the array.
        /// </summary>
        /// <typeparam name="T1">The type of the first verb.</typeparam>
        /// <typeparam name="T2">The type of the second verb.</typeparam>
        /// <typeparam name="T3">The type of the third verb.</typeparam>
        /// <typeparam name="T4">The type of the fourth verb.</typeparam>
        /// <typeparam name="T5">The type of the fifth verb.</typeparam>
        /// <typeparam name="T6">The type of the sixth verb.</typeparam>
        /// <typeparam name="T7">The type of the seventh verb.</typeparam>
        /// <typeparam name="T8">The type of the eighth verb.</typeparam>
        /// <typeparam name="T9">The type of the ninth verb.</typeparam>
        /// <typeparam name="T10">The type of the tenth verb.</typeparam>
        /// <typeparam name="T11">The type of the eleventh verb.</typeparam>
        /// <typeparam name="T12">The type of the twelfth verb.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth verb.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth verb.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth verb.</typeparam>
        /// <typeparam name="T16">The type of the sixteenth verb.</typeparam>
        /// <typeparam name="T17">The type of the seventeenth verb.</typeparam>
        /// <typeparam name="T18">The type of the eighteenth verb.</typeparam>
        /// <typeparam name="T19">The type of the nineteenth verb.</typeparam>
        /// <typeparam name="T20">The type of the twentieth verb.</typeparam>
        /// <typeparam name="T21">The type of the twenty-first verb.</typeparam>
        /// <typeparam name="T22">The type of the twenty-second verb.</typeparam>
        /// <typeparam name="T23">The type of the twenty-third verb.</typeparam>
        /// <typeparam name="T24">The type of the twenty-fourth verb.</typeparam>
        /// <param name="parser">A <see cref="CommandLine.Parser"/> instance.</param>
        /// <param name="args">A <see cref="System.String"/> array of command line arguments, normally supplied by application entry point.</param>
        /// <returns>A <see cref="CommandLine.ParserResult{T}"/> containing the appropriate instance with parsed values as a <see cref="System.Object"/>
        /// and a sequence of <see cref="CommandLine.Error"/>.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if one or more arguments are null.</exception>
        /// <remarks>All types must expose a parameterless constructor.</remarks>
        public static ParserResult<object> ParseArguments<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24> (this Parser parser, IEnumerable<string> args)
        {
            if (parser == null) throw new ArgumentNullException ("parser");

            return parser.ParseArguments (args, new [] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8),
                typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15), typeof(T16), typeof(T17), typeof(T18),
                typeof(T19), typeof(T20), typeof(T21), typeof(T22), typeof(T23), typeof(T24)});
        }

        /// <summary>
        /// Parses a string array of command line arguments for verb commands scenario, constructing the proper instance from types as generic arguments.
        /// Grammar rules are defined decorating public properties with appropriate attributes.
        /// The <see cref="CommandLine.VerbAttribute"/> must be applied to types in the array.
        /// </summary>
        /// <typeparam name="T1">The type of the first verb.</typeparam>
        /// <typeparam name="T2">The type of the second verb.</typeparam>
        /// <typeparam name="T3">The type of the third verb.</typeparam>
        /// <typeparam name="T4">The type of the fourth verb.</typeparam>
        /// <typeparam name="T5">The type of the fifth verb.</typeparam>
        /// <typeparam name="T6">The type of the sixth verb.</typeparam>
        /// <typeparam name="T7">The type of the seventh verb.</typeparam>
        /// <typeparam name="T8">The type of the eighth verb.</typeparam>
        /// <typeparam name="T9">The type of the ninth verb.</typeparam>
        /// <typeparam name="T10">The type of the tenth verb.</typeparam>
        /// <typeparam name="T11">The type of the eleventh verb.</typeparam>
        /// <typeparam name="T12">The type of the twelfth verb.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth verb.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth verb.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth verb.</typeparam>
        /// <typeparam name="T16">The type of the sixteenth verb.</typeparam>
        /// <typeparam name="T17">The type of the seventeenth verb.</typeparam>
        /// <typeparam name="T18">The type of the eighteenth verb.</typeparam>
        /// <typeparam name="T19">The type of the nineteenth verb.</typeparam>
        /// <typeparam name="T20">The type of the twentieth verb.</typeparam>
        /// <typeparam name="T21">The type of the twenty-first verb.</typeparam>
        /// <typeparam name="T22">The type of the twenty-second verb.</typeparam>
        /// <typeparam name="T23">The type of the twenty-third verb.</typeparam>
        /// <typeparam name="T24">The type of the twenty-fourth verb.</typeparam>
        /// <typeparam name="T25">The type of the twenty-fifth verb.</typeparam>
        /// <param name="parser">A <see cref="CommandLine.Parser"/> instance.</param>
        /// <param name="args">A <see cref="System.String"/> array of command line arguments, normally supplied by application entry point.</param>
        /// <returns>A <see cref="CommandLine.ParserResult{T}"/> containing the appropriate instance with parsed values as a <see cref="System.Object"/>
        /// and a sequence of <see cref="CommandLine.Error"/>.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if one or more arguments are null.</exception>
        /// <remarks>All types must expose a parameterless constructor.</remarks>
        public static ParserResult<object> ParseArguments<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25> (this Parser parser, IEnumerable<string> args)
        {
            if (parser == null) throw new ArgumentNullException ("parser");

            return parser.ParseArguments (args, new [] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8),
                typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15), typeof(T16), typeof(T17), typeof(T18),
                typeof(T19), typeof(T20), typeof(T21), typeof(T22), typeof(T23), typeof(T24), typeof(T25)});
        }

        /// <summary>
        /// Parses a string array of command line arguments for verb commands scenario, constructing the proper instance from types as generic arguments.
        /// Grammar rules are defined decorating public properties with appropriate attributes.
        /// The <see cref="CommandLine.VerbAttribute"/> must be applied to types in the array.
        /// </summary>
        /// <typeparam name="T1">The type of the first verb.</typeparam>
        /// <typeparam name="T2">The type of the second verb.</typeparam>
        /// <typeparam name="T3">The type of the third verb.</typeparam>
        /// <typeparam name="T4">The type of the fourth verb.</typeparam>
        /// <typeparam name="T5">The type of the fifth verb.</typeparam>
        /// <typeparam name="T6">The type of the sixth verb.</typeparam>
        /// <typeparam name="T7">The type of the seventh verb.</typeparam>
        /// <typeparam name="T8">The type of the eighth verb.</typeparam>
        /// <typeparam name="T9">The type of the ninth verb.</typeparam>
        /// <typeparam name="T10">The type of the tenth verb.</typeparam>
        /// <typeparam name="T11">The type of the eleventh verb.</typeparam>
        /// <typeparam name="T12">The type of the twelfth verb.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth verb.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth verb.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth verb.</typeparam>
        /// <typeparam name="T16">The type of the sixteenth verb.</typeparam>
        /// <typeparam name="T17">The type of the seventeenth verb.</typeparam>
        /// <typeparam name="T18">The type of the eighteenth verb.</typeparam>
        /// <typeparam name="T19">The type of the nineteenth verb.</typeparam>
        /// <typeparam name="T20">The type of the twentieth verb.</typeparam>
        /// <typeparam name="T21">The type of the twenty-first verb.</typeparam>
        /// <typeparam name="T22">The type of the twenty-second verb.</typeparam>
        /// <typeparam name="T23">The type of the twenty-third verb.</typeparam>
        /// <typeparam name="T24">The type of the twenty-fourth verb.</typeparam>
        /// <typeparam name="T25">The type of the twenty-fifth verb.</typeparam>
        /// <typeparam name="T26">The type of the twenty-sixth verb.</typeparam>
        /// <param name="parser">A <see cref="CommandLine.Parser"/> instance.</param>
        /// <param name="args">A <see cref="System.String"/> array of command line arguments, normally supplied by application entry point.</param>
        /// <returns>A <see cref="CommandLine.ParserResult{T}"/> containing the appropriate instance with parsed values as a <see cref="System.Object"/>
        /// and a sequence of <see cref="CommandLine.Error"/>.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if one or more arguments are null.</exception>
        /// <remarks>All types must expose a parameterless constructor.</remarks>
        public static ParserResult<object> ParseArguments<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26> (this Parser parser, IEnumerable<string> args)
        {
            if (parser == null) throw new ArgumentNullException ("parser");

            return parser.ParseArguments (args, new [] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8),
                typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15), typeof(T16), typeof(T17), typeof(T18),
                typeof(T19), typeof(T20), typeof(T21), typeof(T22), typeof(T23), typeof(T24), typeof(T25), typeof(T26)});
        }

        /// <summary>
        /// Parses a string array of command line arguments for verb commands scenario, constructing the proper instance from types as generic arguments.
        /// Grammar rules are defined decorating public properties with appropriate attributes.
        /// The <see cref="CommandLine.VerbAttribute"/> must be applied to types in the array.
        /// </summary>
        /// <typeparam name="T1">The type of the first verb.</typeparam>
        /// <typeparam name="T2">The type of the second verb.</typeparam>
        /// <typeparam name="T3">The type of the third verb.</typeparam>
        /// <typeparam name="T4">The type of the fourth verb.</typeparam>
        /// <typeparam name="T5">The type of the fifth verb.</typeparam>
        /// <typeparam name="T6">The type of the sixth verb.</typeparam>
        /// <typeparam name="T7">The type of the seventh verb.</typeparam>
        /// <typeparam name="T8">The type of the eighth verb.</typeparam>
        /// <typeparam name="T9">The type of the ninth verb.</typeparam>
        /// <typeparam name="T10">The type of the tenth verb.</typeparam>
        /// <typeparam name="T11">The type of the eleventh verb.</typeparam>
        /// <typeparam name="T12">The type of the twelfth verb.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth verb.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth verb.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth verb.</typeparam>
        /// <typeparam name="T16">The type of the sixteenth verb.</typeparam>
        /// <typeparam name="T17">The type of the seventeenth verb.</typeparam>
        /// <typeparam name="T18">The type of the eighteenth verb.</typeparam>
        /// <typeparam name="T19">The type of the nineteenth verb.</typeparam>
        /// <typeparam name="T20">The type of the twentieth verb.</typeparam>
        /// <typeparam name="T21">The type of the twenty-first verb.</typeparam>
        /// <typeparam name="T22">The type of the twenty-second verb.</typeparam>
        /// <typeparam name="T23">The type of the twenty-third verb.</typeparam>
        /// <typeparam name="T24">The type of the twenty-fourth verb.</typeparam>
        /// <typeparam name="T25">The type of the twenty-fifth verb.</typeparam>
        /// <typeparam name="T26">The type of the twenty-sixth verb.</typeparam>
        /// <typeparam name="T27">The type of the twenty-seventh verb.</typeparam>
        /// <param name="parser">A <see cref="CommandLine.Parser"/> instance.</param>
        /// <param name="args">A <see cref="System.String"/> array of command line arguments, normally supplied by application entry point.</param>
        /// <returns>A <see cref="CommandLine.ParserResult{T}"/> containing the appropriate instance with parsed values as a <see cref="System.Object"/>
        /// and a sequence of <see cref="CommandLine.Error"/>.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if one or more arguments are null.</exception>
        /// <remarks>All types must expose a parameterless constructor.</remarks>
        public static ParserResult<object> ParseArguments<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27> (this Parser parser, IEnumerable<string> args)
        {
            if (parser == null) throw new ArgumentNullException ("parser");

            return parser.ParseArguments (args, new [] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8),
                typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15), typeof(T16), typeof(T17), typeof(T18),
                typeof(T19), typeof(T20), typeof(T21), typeof(T22), typeof(T23), typeof(T24), typeof(T25), typeof(T26), typeof(T27)});
        }

        /// <summary>
        /// Parses a string array of command line arguments for verb commands scenario, constructing the proper instance from types as generic arguments.
        /// Grammar rules are defined decorating public properties with appropriate attributes.
        /// The <see cref="CommandLine.VerbAttribute"/> must be applied to types in the array.
        /// </summary>
        /// <typeparam name="T1">The type of the first verb.</typeparam>
        /// <typeparam name="T2">The type of the second verb.</typeparam>
        /// <typeparam name="T3">The type of the third verb.</typeparam>
        /// <typeparam name="T4">The type of the fourth verb.</typeparam>
        /// <typeparam name="T5">The type of the fifth verb.</typeparam>
        /// <typeparam name="T6">The type of the sixth verb.</typeparam>
        /// <typeparam name="T7">The type of the seventh verb.</typeparam>
        /// <typeparam name="T8">The type of the eighth verb.</typeparam>
        /// <typeparam name="T9">The type of the ninth verb.</typeparam>
        /// <typeparam name="T10">The type of the tenth verb.</typeparam>
        /// <typeparam name="T11">The type of the eleventh verb.</typeparam>
        /// <typeparam name="T12">The type of the twelfth verb.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth verb.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth verb.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth verb.</typeparam>
        /// <typeparam name="T16">The type of the sixteenth verb.</typeparam>
        /// <typeparam name="T17">The type of the seventeenth verb.</typeparam>
        /// <typeparam name="T18">The type of the eighteenth verb.</typeparam>
        /// <typeparam name="T19">The type of the nineteenth verb.</typeparam>
        /// <typeparam name="T20">The type of the twentieth verb.</typeparam>
        /// <typeparam name="T21">The type of the twenty-first verb.</typeparam>
        /// <typeparam name="T22">The type of the twenty-second verb.</typeparam>
        /// <typeparam name="T23">The type of the twenty-third verb.</typeparam>
        /// <typeparam name="T24">The type of the twenty-fourth verb.</typeparam>
        /// <typeparam name="T25">The type of the twenty-fifth verb.</typeparam>
        /// <typeparam name="T26">The type of the twenty-sixth verb.</typeparam>
        /// <typeparam name="T27">The type of the twenty-seventh verb.</typeparam>
        /// <typeparam name="T28">The type of the twenty-eighth verb.</typeparam>
        /// <param name="parser">A <see cref="CommandLine.Parser"/> instance.</param>
        /// <param name="args">A <see cref="System.String"/> array of command line arguments, normally supplied by application entry point.</param>
        /// <returns>A <see cref="CommandLine.ParserResult{T}"/> containing the appropriate instance with parsed values as a <see cref="System.Object"/>
        /// and a sequence of <see cref="CommandLine.Error"/>.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if one or more arguments are null.</exception>
        /// <remarks>All types must expose a parameterless constructor.</remarks>
        public static ParserResult<object> ParseArguments<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> (this Parser parser, IEnumerable<string> args)
        {
            if (parser == null) throw new ArgumentNullException ("parser");

            return parser.ParseArguments (args, new [] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8),
                typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15), typeof(T16), typeof(T17), typeof(T18),
                typeof(T19), typeof(T20), typeof(T21), typeof(T22), typeof(T23), typeof(T24), typeof(T25), typeof(T26), typeof(T27), typeof(T28)});
        }

        /// <summary>
        /// Parses a string array of command line arguments for verb commands scenario, constructing the proper instance from types as generic arguments.
        /// Grammar rules are defined decorating public properties with appropriate attributes.
        /// The <see cref="CommandLine.VerbAttribute"/> must be applied to types in the array.
        /// </summary>
        /// <typeparam name="T1">The type of the first verb.</typeparam>
        /// <typeparam name="T2">The type of the second verb.</typeparam>
        /// <typeparam name="T3">The type of the third verb.</typeparam>
        /// <typeparam name="T4">The type of the fourth verb.</typeparam>
        /// <typeparam name="T5">The type of the fifth verb.</typeparam>
        /// <typeparam name="T6">The type of the sixth verb.</typeparam>
        /// <typeparam name="T7">The type of the seventh verb.</typeparam>
        /// <typeparam name="T8">The type of the eighth verb.</typeparam>
        /// <typeparam name="T9">The type of the ninth verb.</typeparam>
        /// <typeparam name="T10">The type of the tenth verb.</typeparam>
        /// <typeparam name="T11">The type of the eleventh verb.</typeparam>
        /// <typeparam name="T12">The type of the twelfth verb.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth verb.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth verb.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth verb.</typeparam>
        /// <typeparam name="T16">The type of the sixteenth verb.</typeparam>
        /// <typeparam name="T17">The type of the seventeenth verb.</typeparam>
        /// <typeparam name="T18">The type of the eighteenth verb.</typeparam>
        /// <typeparam name="T19">The type of the nineteenth verb.</typeparam>
        /// <typeparam name="T20">The type of the twentieth verb.</typeparam>
        /// <typeparam name="T21">The type of the twenty-first verb.</typeparam>
        /// <typeparam name="T22">The type of the twenty-second verb.</typeparam>
        /// <typeparam name="T23">The type of the twenty-third verb.</typeparam>
        /// <typeparam name="T24">The type of the twenty-fourth verb.</typeparam>
        /// <typeparam name="T25">The type of the twenty-fifth verb.</typeparam>
        /// <typeparam name="T26">The type of the twenty-sixth verb.</typeparam>
        /// <typeparam name="T27">The type of the twenty-seventh verb.</typeparam>
        /// <typeparam name="T28">The type of the twenty-eighth verb.</typeparam>
        /// <typeparam name="T29">The type of the twenty-ninth verb.</typeparam>
        /// <param name="parser">A <see cref="CommandLine.Parser"/> instance.</param>
        /// <param name="args">A <see cref="System.String"/> array of command line arguments, normally supplied by application entry point.</param>
        /// <returns>A <see cref="CommandLine.ParserResult{T}"/> containing the appropriate instance with parsed values as a <see cref="System.Object"/>
        /// and a sequence of <see cref="CommandLine.Error"/>.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if one or more arguments are null.</exception>
        /// <remarks>All types must expose a parameterless constructor.</remarks>
        public static ParserResult<object> ParseArguments<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29> (this Parser parser, IEnumerable<string> args)
        {
            if (parser == null) throw new ArgumentNullException ("parser");

            return parser.ParseArguments (args, new [] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8),
                typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15), typeof(T16), typeof(T17), typeof(T18),
                typeof(T19), typeof(T20), typeof(T21), typeof(T22), typeof(T23), typeof(T24), typeof(T25), typeof(T26), typeof(T27), typeof(T28),
                typeof(T29)});
        }

        /// <summary>
        /// Parses a string array of command line arguments for verb commands scenario, constructing the proper instance from types as generic arguments.
        /// Grammar rules are defined decorating public properties with appropriate attributes.
        /// The <see cref="CommandLine.VerbAttribute"/> must be applied to types in the array.
        /// </summary>
        /// <typeparam name="T1">The type of the first verb.</typeparam>
        /// <typeparam name="T2">The type of the second verb.</typeparam>
        /// <typeparam name="T3">The type of the third verb.</typeparam>
        /// <typeparam name="T4">The type of the fourth verb.</typeparam>
        /// <typeparam name="T5">The type of the fifth verb.</typeparam>
        /// <typeparam name="T6">The type of the sixth verb.</typeparam>
        /// <typeparam name="T7">The type of the seventh verb.</typeparam>
        /// <typeparam name="T8">The type of the eighth verb.</typeparam>
        /// <typeparam name="T9">The type of the ninth verb.</typeparam>
        /// <typeparam name="T10">The type of the tenth verb.</typeparam>
        /// <typeparam name="T11">The type of the eleventh verb.</typeparam>
        /// <typeparam name="T12">The type of the twelfth verb.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth verb.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth verb.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth verb.</typeparam>
        /// <typeparam name="T16">The type of the sixteenth verb.</typeparam>
        /// <typeparam name="T17">The type of the seventeenth verb.</typeparam>
        /// <typeparam name="T18">The type of the eighteenth verb.</typeparam>
        /// <typeparam name="T19">The type of the nineteenth verb.</typeparam>
        /// <typeparam name="T20">The type of the twentieth verb.</typeparam>
        /// <typeparam name="T21">The type of the twenty-first verb.</typeparam>
        /// <typeparam name="T22">The type of the twenty-second verb.</typeparam>
        /// <typeparam name="T23">The type of the twenty-third verb.</typeparam>
        /// <typeparam name="T24">The type of the twenty-fourth verb.</typeparam>
        /// <typeparam name="T25">The type of the twenty-fifth verb.</typeparam>
        /// <typeparam name="T26">The type of the twenty-sixth verb.</typeparam>
        /// <typeparam name="T27">The type of the twenty-seventh verb.</typeparam>
        /// <typeparam name="T28">The type of the twenty-eighth verb.</typeparam>
        /// <typeparam name="T29">The type of the twenty-ninth verb.</typeparam>
        /// <typeparam name="T30">The type of the thirtieth verb.</typeparam>
        /// <param name="parser">A <see cref="CommandLine.Parser"/> instance.</param>
        /// <param name="args">A <see cref="System.String"/> array of command line arguments, normally supplied by application entry point.</param>
        /// <returns>A <see cref="CommandLine.ParserResult{T}"/> containing the appropriate instance with parsed values as a <see cref="System.Object"/>
        /// and a sequence of <see cref="CommandLine.Error"/>.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if one or more arguments are null.</exception>
        /// <remarks>All types must expose a parameterless constructor.</remarks>
        public static ParserResult<object> ParseArguments<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30> (this Parser parser, IEnumerable<string> args)
        {
            if (parser == null) throw new ArgumentNullException ("parser");

            return parser.ParseArguments (args, new [] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8),
                typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15), typeof(T16), typeof(T17), typeof(T18),
                typeof(T19), typeof(T20), typeof(T21), typeof(T22), typeof(T23), typeof(T24), typeof(T25), typeof(T26), typeof(T27), typeof(T28),
                typeof(T29), typeof(T30)});
        }

        /// <summary>
        /// Parses a string array of command line arguments for verb commands scenario, constructing the proper instance from types as generic arguments.
        /// Grammar rules are defined decorating public properties with appropriate attributes.
        /// The <see cref="CommandLine.VerbAttribute"/> must be applied to types in the array.
        /// </summary>
        /// <typeparam name="T1">The type of the first verb.</typeparam>
        /// <typeparam name="T2">The type of the second verb.</typeparam>
        /// <typeparam name="T3">The type of the third verb.</typeparam>
        /// <typeparam name="T4">The type of the fourth verb.</typeparam>
        /// <typeparam name="T5">The type of the fifth verb.</typeparam>
        /// <typeparam name="T6">The type of the sixth verb.</typeparam>
        /// <typeparam name="T7">The type of the seventh verb.</typeparam>
        /// <typeparam name="T8">The type of the eighth verb.</typeparam>
        /// <typeparam name="T9">The type of the ninth verb.</typeparam>
        /// <typeparam name="T10">The type of the tenth verb.</typeparam>
        /// <typeparam name="T11">The type of the eleventh verb.</typeparam>
        /// <typeparam name="T12">The type of the twelfth verb.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth verb.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth verb.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth verb.</typeparam>
        /// <typeparam name="T16">The type of the sixteenth verb.</typeparam>
        /// <typeparam name="T17">The type of the seventeenth verb.</typeparam>
        /// <typeparam name="T18">The type of the eighteenth verb.</typeparam>
        /// <typeparam name="T19">The type of the nineteenth verb.</typeparam>
        /// <typeparam name="T20">The type of the twentieth verb.</typeparam>
        /// <typeparam name="T21">The type of the twenty-first verb.</typeparam>
        /// <typeparam name="T22">The type of the twenty-second verb.</typeparam>
        /// <typeparam name="T23">The type of the twenty-third verb.</typeparam>
        /// <typeparam name="T24">The type of the twenty-fourth verb.</typeparam>
        /// <typeparam name="T25">The type of the twenty-fifth verb.</typeparam>
        /// <typeparam name="T26">The type of the twenty-sixth verb.</typeparam>
        /// <typeparam name="T27">The type of the twenty-seventh verb.</typeparam>
        /// <typeparam name="T28">The type of the twenty-eighth verb.</typeparam>
        /// <typeparam name="T29">The type of the twenty-ninth verb.</typeparam>
        /// <typeparam name="T30">The type of the thirtieth verb.</typeparam>
        /// <typeparam name="T31">The type of the thirty-first verb.</typeparam>
        /// <param name="parser">A <see cref="CommandLine.Parser"/> instance.</param>
        /// <param name="args">A <see cref="System.String"/> array of command line arguments, normally supplied by application entry point.</param>
        /// <returns>A <see cref="CommandLine.ParserResult{T}"/> containing the appropriate instance with parsed values as a <see cref="System.Object"/>
        /// and a sequence of <see cref="CommandLine.Error"/>.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if one or more arguments are null.</exception>
        /// <remarks>All types must expose a parameterless constructor.</remarks>
        public static ParserResult<object> ParseArguments<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> (this Parser parser, IEnumerable<string> args)
        {
            if (parser == null) throw new ArgumentNullException ("parser");

            return parser.ParseArguments (args, new [] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8),
                typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15), typeof(T16), typeof(T17), typeof(T18),
                typeof(T19), typeof(T20), typeof(T21), typeof(T22), typeof(T23), typeof(T24), typeof(T25), typeof(T26), typeof(T27), typeof(T28),
                typeof(T29), typeof(T30), typeof(T31)});
        }

        /// <summary>
        /// Parses a string array of command line arguments for verb commands scenario, constructing the proper instance from types as generic arguments.
        /// Grammar rules are defined decorating public properties with appropriate attributes.
        /// The <see cref="CommandLine.VerbAttribute"/> must be applied to types in the array.
        /// </summary>
        /// <typeparam name="T1">The type of the first verb.</typeparam>
        /// <typeparam name="T2">The type of the second verb.</typeparam>
        /// <typeparam name="T3">The type of the third verb.</typeparam>
        /// <typeparam name="T4">The type of the fourth verb.</typeparam>
        /// <typeparam name="T5">The type of the fifth verb.</typeparam>
        /// <typeparam name="T6">The type of the sixth verb.</typeparam>
        /// <typeparam name="T7">The type of the seventh verb.</typeparam>
        /// <typeparam name="T8">The type of the eighth verb.</typeparam>
        /// <typeparam name="T9">The type of the ninth verb.</typeparam>
        /// <typeparam name="T10">The type of the tenth verb.</typeparam>
        /// <typeparam name="T11">The type of the eleventh verb.</typeparam>
        /// <typeparam name="T12">The type of the twelfth verb.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth verb.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth verb.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth verb.</typeparam>
        /// <typeparam name="T16">The type of the sixteenth verb.</typeparam>
        /// <typeparam name="T17">The type of the seventeenth verb.</typeparam>
        /// <typeparam name="T18">The type of the eighteenth verb.</typeparam>
        /// <typeparam name="T19">The type of the nineteenth verb.</typeparam>
        /// <typeparam name="T20">The type of the twentieth verb.</typeparam>
        /// <typeparam name="T21">The type of the twenty-first verb.</typeparam>
        /// <typeparam name="T22">The type of the twenty-second verb.</typeparam>
        /// <typeparam name="T23">The type of the twenty-third verb.</typeparam>
        /// <typeparam name="T24">The type of the twenty-fourth verb.</typeparam>
        /// <typeparam name="T25">The type of the twenty-fifth verb.</typeparam>
        /// <typeparam name="T26">The type of the twenty-sixth verb.</typeparam>
        /// <typeparam name="T27">The type of the twenty-seventh verb.</typeparam>
        /// <typeparam name="T28">The type of the twenty-eighth verb.</typeparam>
        /// <typeparam name="T29">The type of the twenty-ninth verb.</typeparam>
        /// <typeparam name="T30">The type of the thirtieth verb.</typeparam>
        /// <typeparam name="T31">The type of the thirty-first verb.</typeparam>
        /// <typeparam name="T32">The type of the thirty-second verb.</typeparam>
        /// <param name="parser">A <see cref="CommandLine.Parser"/> instance.</param>
        /// <param name="args">A <see cref="System.String"/> array of command line arguments, normally supplied by application entry point.</param>
        /// <returns>A <see cref="CommandLine.ParserResult{T}"/> containing the appropriate instance with parsed values as a <see cref="System.Object"/>
        /// and a sequence of <see cref="CommandLine.Error"/>.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if one or more arguments are null.</exception>
        /// <remarks>All types must expose a parameterless constructor.</remarks>
        public static ParserResult<object> ParseArguments<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32> (this Parser parser, IEnumerable<string> args)
        {
            if (parser == null) throw new ArgumentNullException ("parser");

            return parser.ParseArguments (args, new [] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8),
                typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15), typeof(T16), typeof(T17), typeof(T18),
                typeof(T19), typeof(T20), typeof(T21), typeof(T22), typeof(T23), typeof(T24), typeof(T25), typeof(T26), typeof(T27), typeof(T28),
                typeof(T29), typeof(T30), typeof(T31), typeof(T32)});
        }
    }
}