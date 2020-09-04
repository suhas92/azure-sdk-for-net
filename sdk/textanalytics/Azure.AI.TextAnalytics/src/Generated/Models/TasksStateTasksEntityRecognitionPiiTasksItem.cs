// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The TasksStateTasksEntityRecognitionPiiTasksItem. </summary>
    public partial class TasksStateTasksEntityRecognitionPiiTasksItem : TaskState
    {
        /// <summary> Initializes a new instance of TasksStateTasksEntityRecognitionPiiTasksItem. </summary>
        /// <param name="lastUpdateDateTime"> . </param>
        /// <param name="name"> . </param>
        /// <param name="status"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal TasksStateTasksEntityRecognitionPiiTasksItem(DateTimeOffset lastUpdateDateTime, string name, State status) : base(lastUpdateDateTime, name, status)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
        }

        /// <summary> Initializes a new instance of TasksStateTasksEntityRecognitionPiiTasksItem. </summary>
        /// <param name="lastUpdateDateTime"> . </param>
        /// <param name="name"> . </param>
        /// <param name="status"> . </param>
        /// <param name="results"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal TasksStateTasksEntityRecognitionPiiTasksItem(DateTimeOffset lastUpdateDateTime, string name, State status, PiiResult results) : base(lastUpdateDateTime, name, status)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Results = results;
        }

        public PiiResult Results { get; }
    }
}
