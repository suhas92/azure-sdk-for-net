// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The TasksStateTasksEntityRecognitionTasksItem. </summary>
    public partial class TasksStateTasksEntityRecognitionTasksItem : TaskState
    {
        /// <summary> Initializes a new instance of TasksStateTasksEntityRecognitionTasksItem. </summary>
        /// <param name="lastUpdateDateTime"> . </param>
        /// <param name="name"> . </param>
        /// <param name="status"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal TasksStateTasksEntityRecognitionTasksItem(DateTimeOffset lastUpdateDateTime, string name, State status) : base(lastUpdateDateTime, name, status)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
        }

        /// <summary> Initializes a new instance of TasksStateTasksEntityRecognitionTasksItem. </summary>
        /// <param name="lastUpdateDateTime"> . </param>
        /// <param name="name"> . </param>
        /// <param name="status"> . </param>
        /// <param name="results"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal TasksStateTasksEntityRecognitionTasksItem(DateTimeOffset lastUpdateDateTime, string name, State status, EntitiesResult results) : base(lastUpdateDateTime, name, status)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Results = results;
        }

        public EntitiesResult Results { get; }
    }
}
