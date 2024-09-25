using Microsoft.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebProject.ModelValidation;

namespace WebProject.Entites
{
    public class Product
    {
        public Product()
        {
            ID = Guid.NewGuid().ToString();
            CreatedDate = DateTime.Now;
        }

        [Key]
        public string ID { get; set; }


        [StringLength(50)]
        [Display(Name = "Mã số")]
        public string SKU { get; set; } //Mã số để quản lý trong kho

        [Display(Name = "Tên")]
        [Required(ErrorMessage = "{0} không được bỏ trống.")]
        public string Name { get; set; }

        [Display(Name = "Mô tả")]
        [DataType(DataType.Text)]
        public string Description { set; get; }

       
        [Display(Name = "Giá bán")]    
        public decimal Price { get; set; }

        [Display(Name = "Giá vốn")]
        public decimal CostPrice { get; set; }

        [Display(Name = "Giảm giá")]
        public int Discount { get; set; }

        
        [Display(Name="Số lượng hàng tồn kho")]
        public int StockQuantity { get; set; }

        
        [Display(Name = "Số lượng hàng tồn kho tối thiểu ")]
        public int MinimumStock { get; set; }


        [Display(Name = "Ảnh")]
        public string ImageURL { get; set; }


        [Display(Name = "Nổi bật")]
        public bool IsFeatured { get; set; }

        
        [Display(Name ="Trạng thái hoặt động")]
        public bool IsActive { get; set; }

        [Required(ErrorMessage = "{0} không được bỏ trống.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "{0} có độ dài từ {1} đến {2} kí tự.")]
        [SlugValidation]
        public string Slug { get; set; }

        [Display(Name = "Ngày tạo")]
        public DateTime CreatedDate { get; set; }

        
        [Display(Name = "Ngày cập nhật")]
        public DateTime UpdatedDate { get; set; }

        [Display(Name = "Danh mục")]
        public string CategoryID { get; set; }

        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }

        [Display(Name = "Nhà cung cấp")]
        public string SupplierID { get; set; }

        [ForeignKey("SupplierID")]
        public virtual Supplier Supplier { get; set; }

        [Display(Name = "Hàng Hóa")]
        public string CommodityID { get; set; }

        [ForeignKey("CommodityID")]
        public virtual Commodity Commodity { get; set; }



        /*
        ProductID INT PRIMARY KEY,
        SKU VARCHAR(50),
        ProductName VARCHAR(255) NOT NULL,
        Description TEXT,
        CategoryID INT,
        BrandID INT,
        Price DECIMAL(10, 2),
        Discount DECIMAL(10, 2),
        CostPrice DECIMAL(10, 2),
        StockQuantity INT,
        MinimumStock INT,
        Weight DECIMAL(10, 2),
        Dimensions VARCHAR(100),
        ImageURL VARCHAR(255),
        Status VARCHAR(50),
        IsFeatured BIT,
        IsActive BIT,
        CreatedDate DATETIME,
        UpdatedDate DATETIME,
        PublishedDate DATETIME,
        SupplierID INT*/
    }
}
