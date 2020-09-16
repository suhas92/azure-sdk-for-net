// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The Components4X9ZamSchemasTasksstatePropertiesTasksPropertiesCustomclassificationtasksItemsAllof1. </summary>
    internal partial class CustomClassificationTasksItemProperties
    {
        /// <summary> Initializes a new instance of CustomClassificationTasksItemProperties. </summary>
        internal CustomClassificationTasksItemProperties()
        {
        }

        /// <summary> Initializes a new instance of CustomClassificationTasksItemProperties. </summary>
        /// <param name="results"> . </param>
        internal CustomClassificationTasksItemProperties(CustomClassificationResult results)
        {
            Results = results;
        }

        public CustomClassificationResult Results { get; }
    }
}
