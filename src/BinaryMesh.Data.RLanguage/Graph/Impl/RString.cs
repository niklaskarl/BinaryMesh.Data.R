﻿// -----------------------------------------------------------------------
// <copyright file="RString.cs" company="Binary Mesh">
// Copyright © Binary Mesh. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Text;

namespace BinaryMesh.Data.RLanguage.Graph
{
    internal sealed class RString : IRString
    {
        private string _text;

        public RString(string text)
        {
            _text = text;
        }

        public RString(byte[] buffer, CharEncoding encoding)
        {
            Encoding enc;
            switch (encoding)
            {
                case CharEncoding.Native:
                    enc = Encoding.GetEncoding("us-ascii");
                    break;
                case CharEncoding.Utf8:
                    enc = Encoding.GetEncoding("utf-8");
                    break;
                case CharEncoding.Latin1:
                    enc = Encoding.GetEncoding("iso-8859-1");
                    break;
                case CharEncoding.Bytes:
                    enc = Encoding.GetEncoding("utf-8");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            _text = enc.GetString(buffer, 0, buffer.Length);
        }

        public enum CharEncoding
        {
            Native,
            Utf8,
            Latin1,
            Bytes
        }

        public static IRString NotAvailable { get; } = new RString(null);

        public RNodeType ObjectType => RNodeType.Char;

        public int Levels { get; set; }

        public bool IsObject { get; set; }

        public IRNode Attribute { get; set; }

        public IRNode Tag { get; set; }

        public IRNode CAR { get; set; }

        public IRNode CAD { get; set; }

        public string String => _text;
    }
}
