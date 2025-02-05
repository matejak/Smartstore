﻿#nullable enable

using Microsoft.AspNetCore.Mvc.Rendering;

namespace Smartstore.Core.Platform.AI.Prompting
{
    /// <summary>
    /// Model interface for the text generation prompt UI.
    /// </summary>
    public interface IPromptContainer
    {
        string? EntityName { get; }
        string? Prompt { get; }

        // TODO: (mc) (ai) Localization is missing. e.g. in simple text dialog.
        int WordLimit { get; }
        string? Style { get; }
        string? Tone { get; }

        bool DisplayWordLimit { get; set; }
        bool DisplayStyle { get; set; }
        bool DisplayTone { get; set; }

        SelectList? AvailableStyles { get; }
        SelectList? AvailableTones { get; }
    }
}
