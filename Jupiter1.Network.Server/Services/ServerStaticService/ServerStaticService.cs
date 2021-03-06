﻿using System;
using Jupiter1.Network.Common.Enums;
using Jupiter1.Network.Server.Services.ServerConfiguration;
using Jupiter1.Network.Server.Structures;

namespace Jupiter1.Network.Server.Services.ServerStaticService
{
    internal sealed class ServerStaticService : IServerStaticService
    {
        #region IServerStaticService
        public Client[] Clients { get; }
        public int Time { get; set; }
        public int NextSnapshotEntities { get; set; }
        public int SnapshotEntitiesCount { get; set; }
        public SnapFlag SnapFlagServerBit { get; set; }
        #endregion

        public ServerStaticService(IServerConfiguration configuration)
        {
            if (configuration == null)
                throw new ArgumentNullException(nameof(configuration));

            Clients = new Client[configuration.MaxClientsCount];
        }
    }
}