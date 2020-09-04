// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    public partial class JobManifestTasks : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(EntityRecognitionTasks))
            {
                writer.WritePropertyName("entityRecognitionTasks");
                writer.WriteStartArray();
                foreach (var item in EntityRecognitionTasks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(EntityRecognitionPiiTasks))
            {
                writer.WritePropertyName("entityRecognitionPiiTasks");
                writer.WriteStartArray();
                foreach (var item in EntityRecognitionPiiTasks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(EntityLinkingTasks))
            {
                writer.WritePropertyName("entityLinkingTasks");
                writer.WriteStartArray();
                foreach (var item in EntityLinkingTasks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(KeyPhraseExtractionTasks))
            {
                writer.WritePropertyName("keyPhraseExtractionTasks");
                writer.WriteStartArray();
                foreach (var item in KeyPhraseExtractionTasks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SentimentAnalysisTasks))
            {
                writer.WritePropertyName("sentimentAnalysisTasks");
                writer.WriteStartArray();
                foreach (var item in SentimentAnalysisTasks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(CustomClassificationTasks))
            {
                writer.WritePropertyName("customClassificationTasks");
                writer.WriteStartArray();
                foreach (var item in CustomClassificationTasks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(CustomEntityRecognitionTasks))
            {
                writer.WritePropertyName("customEntityRecognitionTasks");
                writer.WriteStartArray();
                foreach (var item in CustomEntityRecognitionTasks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
    }
}
