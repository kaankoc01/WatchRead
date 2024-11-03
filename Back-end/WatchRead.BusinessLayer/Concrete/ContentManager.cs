using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchRead.BusinessLayer.Abstract;
using WatchRead.DataAccessLayer.Abstract;
using WatchRead.EntityLayer.Concrete;

namespace WatchRead.BusinessLayer.Concrete
{
    public class ContentManager : GenericManager<Content>,IContentService
    {
        private readonly IContentDal _contentDal;

        public ContentManager(IContentDal contentDal) :base(contentDal) 
        {
            _contentDal = contentDal;
        }
    }
}
