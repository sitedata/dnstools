﻿using DnsTools.Worker.Models;

namespace DnsTools.Worker
{
	// Adds `IHasError` interface to Protobuf classes

	public sealed partial class PingResponse : IHasError { }
	public sealed partial class TracerouteResponse : IHasError { }
}