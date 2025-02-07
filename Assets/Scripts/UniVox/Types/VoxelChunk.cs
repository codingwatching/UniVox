using System;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

public struct VoxelChunk : IDisposable
{
    public VoxelChunk(int3 chunkSize, Allocator allocator = Allocator.Persistent,
        NativeArrayOptions options = NativeArrayOptions.UninitializedMemory)
    {
        var voxels = chunkSize.x * chunkSize.y * chunkSize.z;
        ChunkSize = chunkSize;
        Identities = new NativeArray<byte>(voxels, allocator, options);
        Flags = new NativeArray<VoxelFlag>(voxels, allocator, options);
    }

    public int3 ChunkSize { get; }
    
    public NativeArray<byte> Identities { get; }
    public NativeArray<VoxelFlag> Flags { get; }

    public VoxelBlock GetBlock(int index)
    {
        return new VoxelBlock()
        {
            Identity = Identities[index],
            Flags = Flags[index]
        };
    }
    
    public void SetBlock(int index, VoxelBlock block)
    {
        var identities = Identities;
        var flags = Flags;
        identities[index] = block.Identity;
        flags[index] = block.Flags;
    }
    
    public void Dispose()
    {
        if (Identities.IsCreated)
            Identities.Dispose();
        if (Flags.IsCreated)
            Flags.Dispose();
    }

    public JobHandle Dispose(JobHandle depends)
    {
        if (Identities.IsCreated)
            depends = Identities.Dispose(depends);
        if (Flags.IsCreated)
            depends = Flags.Dispose(depends);
        return depends;
    }

    public void CopyTo(VoxelChunk chunk)
    {
        Identities.CopyTo(chunk.Identities);
        Flags.CopyTo(chunk.Flags);
    }
}