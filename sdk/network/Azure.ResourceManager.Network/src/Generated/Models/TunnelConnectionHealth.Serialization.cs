// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class TunnelConnectionHealth : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Tunnel != null)
            {
                writer.WritePropertyName("tunnel");
                writer.WriteStringValue(Tunnel);
            }
            if (ConnectionStatus != null)
            {
                writer.WritePropertyName("connectionStatus");
                writer.WriteStringValue(ConnectionStatus.Value.ToString());
            }
            if (IngressBytesTransferred != null)
            {
                writer.WritePropertyName("ingressBytesTransferred");
                writer.WriteNumberValue(IngressBytesTransferred.Value);
            }
            if (EgressBytesTransferred != null)
            {
                writer.WritePropertyName("egressBytesTransferred");
                writer.WriteNumberValue(EgressBytesTransferred.Value);
            }
            if (LastConnectionEstablishedUtcTime != null)
            {
                writer.WritePropertyName("lastConnectionEstablishedUtcTime");
                writer.WriteStringValue(LastConnectionEstablishedUtcTime);
            }
            writer.WriteEndObject();
        }

        internal static TunnelConnectionHealth DeserializeTunnelConnectionHealth(JsonElement element)
        {
            string tunnel = default;
            VirtualNetworkGatewayConnectionStatus? connectionStatus = default;
            long? ingressBytesTransferred = default;
            long? egressBytesTransferred = default;
            string lastConnectionEstablishedUtcTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tunnel"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tunnel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectionStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectionStatus = new VirtualNetworkGatewayConnectionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ingressBytesTransferred"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ingressBytesTransferred = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("egressBytesTransferred"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    egressBytesTransferred = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("lastConnectionEstablishedUtcTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastConnectionEstablishedUtcTime = property.Value.GetString();
                    continue;
                }
            }
            return new TunnelConnectionHealth(tunnel, connectionStatus, ingressBytesTransferred, egressBytesTransferred, lastConnectionEstablishedUtcTime);
        }
    }
}