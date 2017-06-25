﻿using CatenaryReplacer.OptionsFramework.Attibutes;

namespace CatenaryReplacer
{
    [Options("CatenaryReplacer.xml", "CatenaryReplacer.xml")]
    public class CatenaryReplacerConfiguration
    {
        [Checkbox("Replace catenaries", null, nameof(ReplacementHandler), nameof(ReplacementHandler.ReplaceBool))]
        public bool ReplacementEnabled { get; set; } = true;

        [DropDown("Catenary Style", nameof(CatenaryStyle), null, nameof(ReplacementHandler), nameof(ReplacementHandler.ReplaceInt))]
        public int Style { get; set; } = (int) CatenaryStyle.German;
    }
}