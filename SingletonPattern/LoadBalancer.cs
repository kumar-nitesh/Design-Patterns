using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// The Singleton Class.
    /// </summary>
    sealed class LoadBalancer
    {
        // Static members are 'eagerly initialized', that is, immediately when class is loaded for the first time.
        // .NET guarantees thread safety for static initialization
        // private static readonly LoadBalancer _instance = new LoadBalancer();
 
        /// </summary>
        private static LoadBalancer _instance;
       
        private Random _random = new Random(); 

        private List<Server> _servers;

        private static object syncLock = new object();

        /// <summary>
        /// Private Constructor
        /// </summary>
        private LoadBalancer ()
	    {
            _servers = new List<Server>()
            {
                new Server{ Name = "ServerI", Ip = "120.14.220.18" },
                new Server{ Name = "ServerII", Ip = "120.14.220.19" }, 
            };
	    }

        /// <summary>
        /// Supports multithreaded applications through 'Double checked locking' pattern 
        /// which (once the instance exists) avoids locking each time the method is invoked.
        /// </summary>
        /// <returns></returns>
        public static LoadBalancer GetInstance()
        {
            if(_instance == null)
            {
                lock(syncLock)
                {
                    if(_instance == null)
                    {
                        _instance = new LoadBalancer();
                    }
                }
            }

            return _instance;
        }

        
        public Server NextServer
        {
            get
            {
                int r = _random.Next(_servers.Count);
                return _servers[r];
            }
        }

       
    }
}
