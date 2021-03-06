﻿namespace WellFired.Command.Skins.Customisation
{
    internal class SkyBlueSkin : DarkSkin
    {
        // Blue = 85, 168, 222
        // Green = 112, 186, 112
        public override Color MainColor { get; } = new Color(100, 100, 100);
        public override Color MainFontColor { get; } = new Color(100, 100, 100);
        public override Color SecondaryColor { get; } = new Color(85, 168, 222);
        public override Color ButtonColor { get; } = new Color(255, 255, 255);
        public override Color TextEntryFontColor { get; } = new Color(85, 168, 222);
    }
}