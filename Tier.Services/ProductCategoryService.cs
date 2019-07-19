using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tier.Model.Models;
using Tier.Repository.Infrastructure;
using Tier.Repository.Repositories;

namespace Tier.Services
{
    public interface IProductCategoryService
    {
        ProductCategory Add(ProductCategory ProductCategory);

        void Update(ProductCategory ProductCategory);

        ProductCategory Delete(int id);

        IEnumerable<ProductCategory> GetAll();

        IEnumerable<ProductCategory> GetAll(string keyword);

        IEnumerable<ProductCategory> GetAllByParentId(int parentId);

        ProductCategory GetById(int id);

        void Save();
    }
    public class ProductCategoryService : IProductCategoryService
    {
        IUnitOfWork _unitOfWork;
        IProductCategoryRepository _productCategory;

        public ProductCategoryService(IUnitOfWork unitOfWork, IProductCategoryRepository productCategory)
        {
            this._unitOfWork = unitOfWork;
            this._productCategory = productCategory;
        }

        public ProductCategory Add(ProductCategory ProductCategory)
        {
            return _productCategory.Add(ProductCategory);
        }

        public ProductCategory Delete(int id)
        {
            return _productCategory.Delete(id);
        }

        public IEnumerable<ProductCategory> GetAll()
        {
            return _productCategory.GetAll();
        }

        public IEnumerable<ProductCategory> GetAll(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
                return _productCategory.GetMulti(x => x.Name.Contains(keyword) || x.Description.Contains(keyword));
            else
                return _productCategory.GetAll();
        }

        public IEnumerable<ProductCategory> GetAllByParentId(int parentId)
        {
            return _productCategory.GetMulti(x => x.Status == true && x.ParentID == parentId);
        }

        public ProductCategory GetById(int id)
        {
            return _productCategory.GetSingleById(id);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(ProductCategory ProductCategory)
        {
            _productCategory.Update(ProductCategory);
        }
    }
}
