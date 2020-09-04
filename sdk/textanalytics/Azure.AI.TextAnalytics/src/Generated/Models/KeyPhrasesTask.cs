// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The KeyPhrasesTask. </summary>
    internal partial class KeyPhrasesTask : TextAnalyticsTask
    {
        /// <summary> Initializes a new instance of KeyPhrasesTask. </summary>
        /// <param name="enable"> . </param>
        public KeyPhrasesTask(bool enable) : base(enable)
        {
        }

        public KeyPhrasesTaskParameters Parameters { get; set; }
    }
}
