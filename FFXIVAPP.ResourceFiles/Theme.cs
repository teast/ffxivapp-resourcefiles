﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Theme.cs" company="SyndicatedLife">
//   Copyright© 2007 - 2020 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (https://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   Theme.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.ResourceFiles {
    using System;
    using System.IO;
    using System.Reflection;
    using Avalonia.Media.Imaging;

    public static class Theme {
        private static Assembly assembly = typeof(Game).GetTypeInfo().Assembly;
        private static Stream GetResource(string path) => assembly.GetManifestResourceStream(path);
        public static Bitmap ChineseFlag = new Bitmap(GetResource($"{Constants.ThemePack}.cn.png"));

        public static Bitmap Default = new Bitmap(GetResource($"{Constants.ThemePack}.default.png"));

        public static Bitmap DefaultAvatar = new Bitmap(GetResource($"{Constants.ThemePack}.default-avatar.jpg"));

        public static Bitmap DefaultPluginLogo = new Bitmap(GetResource($"{Constants.ThemePack}.default-plugin-logo.png"));

        public static Bitmap EnglishFlag = new Bitmap(GetResource($"{Constants.ThemePack}.en.png"));

        public static Bitmap FFXIVAPP = new Bitmap(GetResource($"{Constants.ThemePack}.ffxivapp.png"));

        public static Bitmap FFXIVAPPBase = new Bitmap(GetResource($"{Constants.ThemePack}.ffxivapp-base.png"));

        public static Bitmap FFXIVAPPIcon = new Bitmap(GetResource($"{Constants.ThemePack}.ffxivapp.ico"));

        public static Bitmap FFXIVAPPLogo = new Bitmap(GetResource($"{Constants.ThemePack}.ffxivapp-logo.png"));

        public static Bitmap FrenchFlag = new Bitmap(GetResource($"{Constants.ThemePack}.fr.png"));

        public static Bitmap GermanFlag = new Bitmap(GetResource($"{Constants.ThemePack}.de.png"));

        public static Bitmap JapaneseFlag = new Bitmap(GetResource($"{Constants.ThemePack}.ja.png"));

        public static Bitmap KoreanFlag = new Bitmap(GetResource($"{Constants.ThemePack}.ko.png"));

        public static Bitmap RussianFlag = new Bitmap(GetResource($"{Constants.ThemePack}.ru.png"));

        public static Bitmap Splash = new Bitmap(GetResource($"{Constants.ThemePack}.splash.png"));

        public static Bitmap RefreshIcon20 = new Bitmap(GetResource($"{Constants.ThemePack}.fa-refresh-20.png"));

        public static Bitmap TimesIcon20 = new Bitmap(GetResource($"{Constants.ThemePack}.fa-times-20.png"));

        public static Bitmap CogIcon20 = new Bitmap(GetResource($"{Constants.ThemePack}.fa-cog-20.png"));

        public static Bitmap HomeIcon20 = new Bitmap(GetResource($"{Constants.ThemePack}.fa-home-20.png"));

        public static Bitmap InfoIcon20 = new Bitmap(GetResource($"{Constants.ThemePack}.fa-info-20.png"));

        public static Bitmap StarIcon20 = new Bitmap(GetResource($"{Constants.ThemePack}.fa-star-20.png"));
        public static Bitmap PowerOffIcon20 = new Bitmap(GetResource($"{Constants.ThemePack}.fa-poweroff-20.png"));
        public static Bitmap CameraIcon20 = new Bitmap(GetResource($"{Constants.ThemePack}.fa-camera-solid-20.png"));
        public static Bitmap MaximizeIcon20 = new Bitmap(GetResource($"{Constants.ThemePack}.fa-window-maximize-regular-20.png"));
        public static Bitmap MinimizeIcon20 = new Bitmap(GetResource($"{Constants.ThemePack}.fa-window-minimize-regular-20.png"));
        public static Bitmap RestoreIcon20 = new Bitmap(GetResource($"{Constants.ThemePack}.fa-window-restore-regular-20.png"));
        public static Bitmap SaveIcon20 = new Bitmap(GetResource($"{Constants.ThemePack}.fa-save-regular-20.png"));

        public static Bitmap GetImageByName(string name) {
            try {
                return new Bitmap(GetResource($"{Constants.IconsPack}.{name.ToLowerInvariant()}.png"));
            }
            catch (Exception) {
                return Default;
            }
        }

        public static string GetImagePackURI(string name) {
            return $"{Constants.ThemePack}.{name.ToLowerInvariant()}.png";
        }
    }
}