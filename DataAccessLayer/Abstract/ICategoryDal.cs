using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
   public interface ICategoryDal
    {
        //CRUD
        //TYPE NAME();
        List<Category> List();

        void Insert(Category p);

        void Update(Category p);

        void Delete(Category p);

    }
}
