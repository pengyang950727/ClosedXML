﻿using System;

namespace ClosedXML.Excel
{
    public struct XLFontKey : IEquatable<XLFontKey>
    {
        public bool Bold { get; set; }

        public bool Italic { get; set; }

        public XLFontUnderlineValues Underline { get; set; }

        public bool Strikethrough { get; set; }

        public XLFontVerticalTextAlignmentValues VerticalAlignment { get; set; }

        public bool Shadow { get; set; }

        public double FontSize { get; set; }

        public XLColorKey FontColor { get; set; }

        public string FontName { get; set; }

        public XLFontFamilyNumberingValues FontFamilyNumbering { get; set; }

        public XLFontCharSet FontCharSet { get; set; }

        public bool Equals(XLFontKey other)
        {
            return
                Bold == other.Bold
             && Italic == other.Italic
             && Underline == other.Underline
             && Strikethrough == other.Strikethrough
             && VerticalAlignment == other.VerticalAlignment
             && Shadow == other.Shadow
             && FontSize == other.FontSize
             && FontColor == other.FontColor
             && FontFamilyNumbering == other.FontFamilyNumbering
             && FontCharSet == other.FontCharSet
             && string.Equals(FontName, other.FontName, StringComparison.InvariantCultureIgnoreCase);
        }

        public override bool Equals(object obj)
        {
            if (obj is XLFontKey)
                return Equals((XLFontKey)obj);
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            var hashCode = 1158783753;
            hashCode = hashCode * -1521134295 + Bold.GetHashCode();
            hashCode = hashCode * -1521134295 + Italic.GetHashCode();
            hashCode = hashCode * -1521134295 + Underline.GetHashCode();
            hashCode = hashCode * -1521134295 + Strikethrough.GetHashCode();
            hashCode = hashCode * -1521134295 + VerticalAlignment.GetHashCode();
            hashCode = hashCode * -1521134295 + Shadow.GetHashCode();
            hashCode = hashCode * -1521134295 + FontSize.GetHashCode();
            hashCode = hashCode * -1521134295 + FontColor.GetHashCode();
            hashCode = hashCode * -1521134295 + FontName.ToUpperInvariant().GetHashCode();
            hashCode = hashCode * -1521134295 + FontFamilyNumbering.GetHashCode();
            hashCode = hashCode * -1521134295 + FontCharSet.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(XLFontKey left, XLFontKey right) => left.Equals(right);

        public static bool operator !=(XLFontKey left, XLFontKey right) => !(left.Equals(right));
    }
}
