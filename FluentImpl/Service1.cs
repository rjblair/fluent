using System;
using System.Collections.Generic;
using System.Text;

namespace FluentImpl.Service1
{
    public interface IService1
    {
        IService1 WithDocument(string document);
        void Process();
    }

    public interface IService1Manager
    {
        IService1 Service1 { get; }
    }
    public class Service1Manager : IService1Manager
    {
        private IService1 service1;
        private int _charter;
        private int _documentId;

        public Service1Manager(int charter, int documentId)
        {
            _charter = charter;
            _documentId = documentId;
        }

        public IService1 Service1
        {
            get
            {
                if (service1 == null)
                {
                    service1 = new Service1Impl(_charter, _documentId);
                }
                return service1;
            }
        }
    }

    public class Service1Impl : IService1
    {
        private int charter;
        private int id;
        private string document;

        // public IWithDocumentId WithCharter(int charter) {
        //     this.charter = charter;
        //     return this;
        // }
        public Service1Impl(int charter, int documentId)
        {
            this.charter = charter;
            this.id = documentId;
        }

        public IService1 WithDocument(string document)
        {
            this.document = document;
            return this;
        }

        public void Process()
        {
            Console.WriteLine($"With charter {charter} on record {id} against document {document}");
        }
    }
}
