// <copyright file="MassTransitInstrumentationEventSource.cs" company="OpenTelemetry Authors">
// Copyright The OpenTelemetry Authors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

using System.Diagnostics.Tracing;

namespace OpenTelemetry.Instrumentation.MassTransit.Implementation;

/// <summary>
/// EventSource events emitted from the project.
/// </summary>
[EventSource(Name = "OpenTelemetry-Instrumentation-MassTransit")]
internal class MassTransitInstrumentationEventSource : EventSource
{
    public static MassTransitInstrumentationEventSource Log = new MassTransitInstrumentationEventSource();

    [Event(1, Message = "Request is filtered out.", Level = EventLevel.Verbose)]
    public void RequestIsFilteredOut(string eventName)
    {
        this.WriteEvent(1, eventName);
    }
}
