// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The TasksStateTasks. </summary>
    public partial class TasksStateTasks
    {
        /// <summary> Initializes a new instance of TasksStateTasks. </summary>
        /// <param name="completed"> . </param>
        /// <param name="failed"> . </param>
        /// <param name="inProgress"> . </param>
        /// <param name="total"> . </param>
        internal TasksStateTasks(int completed, int failed, int inProgress, int total)
        {
            Details = new ChangeTrackingList<TaskState>();
            Completed = completed;
            Failed = failed;
            InProgress = inProgress;
            Total = total;
            EntityRecognitionTasks = new ChangeTrackingList<TasksStateTasksEntityRecognitionTasksItem>();
            EntityRecognitionPiiTasks = new ChangeTrackingList<TasksStateTasksEntityRecognitionPiiTasksItem>();
            EntityLinkingTasks = new ChangeTrackingList<TasksStateTasksEntityLinkingTasksItem>();
            KeyPhraseExtractionTasks = new ChangeTrackingList<TasksStateTasksKeyPhraseExtractionTasksItem>();
            SentimentAnalysisTasks = new ChangeTrackingList<TasksStateTasksSentimentAnalysisTasksItem>();
            CustomClassificationTasks = new ChangeTrackingList<TasksStateTasksCustomClassificationTasksItem>();
            CustomEntityRecognitionTasks = new ChangeTrackingList<TasksStateTasksCustomEntityRecognitionTasksItem>();
        }

        /// <summary> Initializes a new instance of TasksStateTasks. </summary>
        /// <param name="details"> . </param>
        /// <param name="completed"> . </param>
        /// <param name="failed"> . </param>
        /// <param name="inProgress"> . </param>
        /// <param name="total"> . </param>
        /// <param name="entityRecognitionTasks"> . </param>
        /// <param name="entityRecognitionPiiTasks"> . </param>
        /// <param name="entityLinkingTasks"> . </param>
        /// <param name="keyPhraseExtractionTasks"> . </param>
        /// <param name="sentimentAnalysisTasks"> . </param>
        /// <param name="customClassificationTasks"> . </param>
        /// <param name="customEntityRecognitionTasks"> . </param>
        internal TasksStateTasks(IReadOnlyList<TaskState> details, int completed, int failed, int inProgress, int total, IReadOnlyList<TasksStateTasksEntityRecognitionTasksItem> entityRecognitionTasks, IReadOnlyList<TasksStateTasksEntityRecognitionPiiTasksItem> entityRecognitionPiiTasks, IReadOnlyList<TasksStateTasksEntityLinkingTasksItem> entityLinkingTasks, IReadOnlyList<TasksStateTasksKeyPhraseExtractionTasksItem> keyPhraseExtractionTasks, IReadOnlyList<TasksStateTasksSentimentAnalysisTasksItem> sentimentAnalysisTasks, IReadOnlyList<TasksStateTasksCustomClassificationTasksItem> customClassificationTasks, IReadOnlyList<TasksStateTasksCustomEntityRecognitionTasksItem> customEntityRecognitionTasks)
        {
            Details = details;
            Completed = completed;
            Failed = failed;
            InProgress = inProgress;
            Total = total;
            EntityRecognitionTasks = entityRecognitionTasks;
            EntityRecognitionPiiTasks = entityRecognitionPiiTasks;
            EntityLinkingTasks = entityLinkingTasks;
            KeyPhraseExtractionTasks = keyPhraseExtractionTasks;
            SentimentAnalysisTasks = sentimentAnalysisTasks;
            CustomClassificationTasks = customClassificationTasks;
            CustomEntityRecognitionTasks = customEntityRecognitionTasks;
        }

        public IReadOnlyList<TaskState> Details { get; }
        public int Completed { get; }
        public int Failed { get; }
        public int InProgress { get; }
        public int Total { get; }
        public IReadOnlyList<TasksStateTasksEntityRecognitionTasksItem> EntityRecognitionTasks { get; }
        public IReadOnlyList<TasksStateTasksEntityRecognitionPiiTasksItem> EntityRecognitionPiiTasks { get; }
        public IReadOnlyList<TasksStateTasksEntityLinkingTasksItem> EntityLinkingTasks { get; }
        public IReadOnlyList<TasksStateTasksKeyPhraseExtractionTasksItem> KeyPhraseExtractionTasks { get; }
        public IReadOnlyList<TasksStateTasksSentimentAnalysisTasksItem> SentimentAnalysisTasks { get; }
        public IReadOnlyList<TasksStateTasksCustomClassificationTasksItem> CustomClassificationTasks { get; }
        public IReadOnlyList<TasksStateTasksCustomEntityRecognitionTasksItem> CustomEntityRecognitionTasks { get; }
    }
}
