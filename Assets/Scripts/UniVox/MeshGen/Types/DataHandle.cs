using Unity.Jobs;

namespace UniVox.MeshGen
{
    public struct DataHandle<TData>
    {
        public DataHandle(TData data, JobHandle handle)
        {
            Data = data;
            Handle = handle;
        }

        public TData Data { get; }
        public JobHandle Handle { get; }
    }
}