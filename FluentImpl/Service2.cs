using System;

namespace FluentImpl.Service2
{
    public interface IService2
    {
        void Process();
    }

    public interface IService2Manager
    {
        IService2 Service2 { get; }
    }
    public class Service2Manager : IService2Manager
    {
        private IService2 service2;
        private int charter;
        private int documentId;
        public Service2Manager(int charter, int documentId)
        {
            this.charter = charter;
            this.documentId = documentId;
        }

        public IService2 Service2
        {
            get
            {
                if (service2 == null)
                {
                    service2 = new Service2Impl(charter, documentId);
                }
                return service2;
            }
        }
    }

    public class Service2Impl : IService2
    {
        private int charter;
        private int id;
        public Service2Impl(int charter, int documentId)
        {
            this.charter = charter;
            this.id = documentId;
        }

        public void Process()
        {
            Console.WriteLine($"With charter {charter} on record {id} against no document");
        }
    }
}