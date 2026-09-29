using System;

namespace Joao_Amazon
{
    public class Product
    {
        public Product()
        {
        }

        public Product(string _productID, string _productName)
        {
            this.ProductID = _productID;
            this.ProductName = _productName;
        }

        public Product(string _productID, string _productName, string _productDescription, string _productCategory, string _productSize)
        {
            this.ProductID = _productID;
            this.ProductName = _productName;
            this.ProductDescription = _productDescription;
            this.ProductCategory = _productCategory;
            this.ProductSize = _productSize;
        }

        public string ProductID { get; init; }

        private string _productName;
        public string ProductName
        {
            get
            {
                return _productName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Product name can't be null or empty.");
                }

                string cleanedValue = value.Trim();

                if (long.TryParse(cleanedValue, out _))
                {
                    throw new ArgumentException("Product name cannot consist of numbers only.");
                }

                if (cleanedValue.Length > 60)
                {
                    throw new ArgumentException("Product name can't have more than 60 char.");
                }

                _productName = cleanedValue;
            }
        }

        public string ProductDescription { get; set; }

        public string ProductCategory { get; init; }

        public string ProductSize { get; set; }
    }
}
