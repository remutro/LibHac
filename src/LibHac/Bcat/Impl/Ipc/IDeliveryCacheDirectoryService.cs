﻿using System;

namespace LibHac.Bcat.Impl.Ipc;

public interface IDeliveryCacheDirectoryService : IDisposable
{
    Result Open(ref readonly DirectoryName name);
    Result Read(out int entriesRead, Span<DeliveryCacheDirectoryEntry> entryBuffer);
    Result GetCount(out int count);
}