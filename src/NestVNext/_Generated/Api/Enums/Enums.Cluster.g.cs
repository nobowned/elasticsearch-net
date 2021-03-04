// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗ 
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝ 
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗   
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝   
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗ 
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝ 
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
// Run the following in the root of the repository:
//
// TODO - RUN INSTRUCTIONS
//
// ------------------------------------------------
using System.Runtime.Serialization;

namespace Nest
{
    public enum AllocationExplainDecision
    {
        [EnumMember(Value = "NO")]
        No,
        [EnumMember(Value = "YES")]
        Yes,
        [EnumMember(Value = "THROTTLE")]
        Throttle,
        [EnumMember(Value = "ALWAYS")]
        Always
    }

    public enum Decision
    {
        [EnumMember(Value = "yes")]
        Yes,
        [EnumMember(Value = "no")]
        No,
        [EnumMember(Value = "worse_balance")]
        WorseBalance,
        [EnumMember(Value = "throttled")]
        Throttled,
        [EnumMember(Value = "awaiting_info")]
        AwaitingInfo,
        [EnumMember(Value = "allocation_delayed")]
        AllocationDelayed,
        [EnumMember(Value = "no_valid_shard_copy")]
        NoValidShardCopy,
        [EnumMember(Value = "no_attempt")]
        NoAttempt
    }

    public enum NodeRole
    {
        [EnumMember(Value = "master")]
        Master,
        [EnumMember(Value = "data")]
        Data,
        [EnumMember(Value = "client")]
        Client,
        [EnumMember(Value = "ingest")]
        Ingest,
        [EnumMember(Value = "ml")]
        Ml,
        [EnumMember(Value = "voting_only")]
        VotingOnly,
        [EnumMember(Value = "transform")]
        Transform,
        [EnumMember(Value = "remote_cluster_client")]
        RemoteClusterClient,
        [EnumMember(Value = "coordinating_only")]
        CoordinatingOnly
    }

    public enum StoreCopy
    {
        [EnumMember(Value = "NONE")]
        None,
        [EnumMember(Value = "AVAILABLE")]
        Available,
        [EnumMember(Value = "CORRUPT")]
        Corrupt,
        [EnumMember(Value = "IO_ERROR")]
        IoError,
        [EnumMember(Value = "STALE")]
        Stale,
        [EnumMember(Value = "UNKNOWN")]
        Unknown
    }

    public enum UnassignedInformationReason
    {
        [EnumMember(Value = "INDEX_CREATED")]
        IndexCreated,
        [EnumMember(Value = "CLUSTER_RECOVERED")]
        ClusterRecovered,
        [EnumMember(Value = "INDEX_REOPENED")]
        IndexReopened,
        [EnumMember(Value = "DANGLING_INDEX_IMPORTED")]
        DanglingIndexImported,
        [EnumMember(Value = "NEW_INDEX_RESTORED")]
        NewIndexRestored,
        [EnumMember(Value = "EXISTING_INDEX_RESTORED")]
        ExistingIndexRestored,
        [EnumMember(Value = "REPLICA_ADDED")]
        ReplicaAdded,
        [EnumMember(Value = "ALLOCATION_FAILED")]
        AllocationFailed,
        [EnumMember(Value = "NODE_LEFT")]
        NodeLeft,
        [EnumMember(Value = "REROUTE_CANCELLED")]
        RerouteCancelled,
        [EnumMember(Value = "REINITIALIZED")]
        Reinitialized,
        [EnumMember(Value = "REALLOCATED_REPLICA")]
        ReallocatedReplica,
        [EnumMember(Value = "PRIMARY_FAILED")]
        PrimaryFailed,
        [EnumMember(Value = "FORCED_EMPTY_PRIMARY")]
        ForcedEmptyPrimary,
        [EnumMember(Value = "MANUAL_ALLOCATION")]
        ManualAllocation
    }
}