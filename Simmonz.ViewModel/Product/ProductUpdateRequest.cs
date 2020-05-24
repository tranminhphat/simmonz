﻿using Microsoft.AspNetCore.Http;
using Simmonz.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Simmonz.ViewModel.Product
{
   public class ProductUpdateRequest
    {
        [DisplayName("Mã")]
        public int Id { get; set; }
        [DisplayName("Tên sản phẩm")]
        public string ProductName { get; set; }
        [DisplayName("Hình ảnh")]
        public IFormFile Image { get; set; }

        [DisplayName("Gía")]
        public decimal Price { get; set; }

        [DisplayName("Số lượng")]
        public int Quantity { get; set; }

        [DisplayName("Mô tả")]
        public string Description { get; set; }
        [DisplayName("Danh mục")]
        public int CategoryId { get; set; }
        public int DiscountId { get; set; }

    }
}