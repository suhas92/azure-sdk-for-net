// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The set of tasks to execute on the input documents. Cannot specify the same task more than once. </summary>
    public partial class JobManifestTasks
    {
        /// <summary> Initializes a new instance of JobManifestTasks. </summary>
        public JobManifestTasks()
        {
            EntityRecognitionTasks = new ChangeTrackingList<EntitiesTask>();
            EntityRecognitionPiiTasks = new ChangeTrackingList<PiiTask>();
            EntityLinkingTasks = new ChangeTrackingList<EntityLinkingTask>();
            KeyPhraseExtractionTasks = new ChangeTrackingList<KeyPhrasesTask>();
            SentimentAnalysisTasks = new ChangeTrackingList<SentimentTask>();
            CustomClassificationTasks = new ChangeTrackingList<CustomClassificationTask>();
            CustomEntityRecognitionTasks = new ChangeTrackingList<CustomEntitiesTask>();
        }

        public IList<EntitiesTask> EntityRecognitionTasks { get; }
        public IList<PiiTask> EntityRecognitionPiiTasks { get; }
        public IList<EntityLinkingTask> EntityLinkingTasks { get; }
        public IList<KeyPhrasesTask> KeyPhraseExtractionTasks { get; }
        public IList<SentimentTask> SentimentAnalysisTasks { get; }
        public IList<CustomClassificationTask> CustomClassificationTasks { get; }
        public IList<CustomEntitiesTask> CustomEntityRecognitionTasks { get; }
    }
}
