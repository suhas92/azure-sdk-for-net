// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    public partial class Components15Gvwi3SchemasTasksstatePropertiesTasksPropertiesEntityrecognitiontasksItemsAllof1
    {
        internal static Components15Gvwi3SchemasTasksstatePropertiesTasksPropertiesEntityrecognitiontasksItemsAllof1 DeserializeComponents15Gvwi3SchemasTasksstatePropertiesTasksPropertiesEntityrecognitiontasksItemsAllof1(JsonElement element)
        {
            Optional<EntitiesResult> results = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"))
                {
                    results = EntitiesResult.DeserializeEntitiesResult(property.Value);
                    continue;
                }
            }
            return new Components15Gvwi3SchemasTasksstatePropertiesTasksPropertiesEntityrecognitiontasksItemsAllof1(results.Value);
        }
    }
}
