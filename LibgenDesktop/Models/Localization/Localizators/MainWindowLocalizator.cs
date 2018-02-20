﻿using System;
using System.Collections.Generic;

namespace LibgenDesktop.Models.Localization.Localizators
{
    internal class MainWindowLocalizator : Localizator
    {
        public MainWindowLocalizator(List<Translation> prioritizedTranslationList, LanguageFormatter formatter)
            : base(prioritizedTranslationList, formatter)
        {
            WindowTitle = Format(translation => translation?.WindowTitle);
            ToolbarDownloadManagerTooltip = Format(translation => translation?.DownloadManagerTooltip);
            ToolbarUpdate = Format(translation => translation?.Update);
            ToolbarImport = Format(translation => translation?.Import);
            ToolbarSynchronize = Format(translation => translation?.Synchronize);
            ToolbarSettings = Format(translation => translation?.Settings);
        }

        public string WindowTitle { get; }
        public string ToolbarDownloadManagerTooltip { get; }
        public string ToolbarUpdate { get; }
        public string ToolbarImport { get; }
        public string ToolbarSynchronize { get; }
        public string ToolbarSettings { get; }

        private string Format(Func<Translation.MainWindowTranslation, string> field)
        {
            return Format(translation => field(translation?.MainWindow));
        }

        private string Format(Func<Translation.MainMenuTranslation, string> field)
        {
            return Format(translation => field(translation?.MainWindow?.MainMenu));
        }
    }
}
