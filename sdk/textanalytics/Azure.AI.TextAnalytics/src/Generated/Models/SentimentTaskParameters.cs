// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The SentimentTaskParameters. </summary>
    public partial class SentimentTaskParameters
    {
        /// <summary> Initializes a new instance of SentimentTaskParameters. </summary>
        public SentimentTaskParameters()
        {
        }

        public string ModelVersion { get; set; }
        public bool? OpinionMining { get; set; }
        public StringIndexType? StringIndexType { get; set; }
    }
}
