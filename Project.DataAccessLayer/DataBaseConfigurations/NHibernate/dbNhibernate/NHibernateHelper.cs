using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccessLayer.DataBaseConfigurations.NHibernate.dbNhibernate
{
    public class NHibernateHelper
    {
        public static ISessionFactory _sessionFactory;
        //public Configuration config = new Configuration().Configure("hibernate.cfg.xml");
        
        public static ISession GetSession()
        {
            if (_sessionFactory == null)
            {
                lock (typeof(NHibernateHelper))
                {
                    if (_sessionFactory == null)
                    {
                        Configuration cfg = new Configuration();
                        cfg.AddAssembly("Project.DataAccessLayer");
                        _sessionFactory = cfg.BuildSessionFactory();
                    }
                }               
            }
            return _sessionFactory.OpenSession();
        }

        private NHibernateHelper()
        { }
    }
    
}
