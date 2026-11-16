using System;
using FluentImpl.Service1;
using FluentImpl.Service2;

namespace FluentImpl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            var fluent = FluentClass.Configure()
                .WithCharter(2196)
                .WithDocumentId(1);

            fluent.Service1
                  .WithDocument("first")
                  .Process();
            
            fluent.Service2
                  .Process();
        }
    }

    public interface IFluentClass 
    {
        IService1 Service1 { get;}
        IService2 Service2 { get;}
    }
    
    public class FluentClass : IFluentClass
    {
        private IService1Manager service1Manager;
        private IService2Manager service2Manager;
         
        private FluentClass(int id, int charter) {
            service1Manager = new Service1Manager(id, charter);
            service2Manager = new Service2Manager(id, charter);
        }
        public static IConfigure Configure() => new Configurable();

        protected class Configurable : IConfigure, IWithDocumentId
        {
            public int id { get; private set; }
            public int charter { get; private set;}
            
            public IWithDocumentId WithCharter(int charter) {
                this.charter = charter;
                return this;
            }
            public IFluentClass WithDocumentId(int id) {
                this.id = id;
                return new FluentClass(id, charter);
            }
        }
        public interface IConfigure {
            IWithDocumentId WithCharter(int charter);
        }    
        
        public interface IWithDocumentId {
            IFluentClass WithDocumentId(int id);
        }

        public IService1 Service1 { get { return service1Manager.Service1; }}

        public IService2 Service2 { get { return service2Manager.Service2; }}
    }   
}