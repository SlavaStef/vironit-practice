using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task5.Data;
using Task5.Models;

namespace Task5.Controllers
{
    public class OutputController : Controller
    {
        public FileStreamResult ExcelOutputAll()
        {
            HSSFWorkbook workbook = new HSSFWorkbook();
            ISheet productsSheet = workbook.CreateSheet("Products");

            int rowIndex = 0;
            IRow row = productsSheet.CreateRow(rowIndex);
            row.CreateCell(0).SetCellValue("Id");
            row.CreateCell(1).SetCellValue("Name");
            row.CreateCell(2).SetCellValue("Category");
            row.CreateCell(3).SetCellValue("Description");
            row.CreateCell(4).SetCellValue("Price");
            rowIndex++;
            

            foreach(Product item in Products.ProductList)
            {
                row = productsSheet.CreateRow(rowIndex);
                row.CreateCell(0).SetCellValue(item.Id);
                row.CreateCell(1).SetCellValue(item.Name);
                row.CreateCell(2).SetCellValue(item.Category.ToString());
                row.CreateCell(3).SetCellValue(item.Description);
                row.CreateCell(4).SetCellValue(item.Price.ToString());

                rowIndex++;                
            }

            using (var exportData = new MemoryStream())
            {
                workbook.Write(exportData);

                Response.ContentType = "application/vnd.ms-excel";
                Response.AddHeader("Content-Disposition", string.Format("attachment;filename={0}", "Products.xls"));
                Response.Clear();
                Response.BinaryWrite(exportData.GetBuffer());
                Response.End();
            }

            return null;
        }

        public FileStreamResult ExcelOutputFilter(Categories Category, int PriceFrom, int PriceTo)
        {
            var resultProducts = Products.ProductList.Where(x => x.Category == Category && x.Price > PriceFrom && x.Price < PriceTo).ToList();

            HSSFWorkbook workbook = new HSSFWorkbook();
            ISheet productsSheet = workbook.CreateSheet("Products");

            int rowIndex = 0;
            IRow row = productsSheet.CreateRow(rowIndex);
            row.CreateCell(0).SetCellValue("Id");
            row.CreateCell(1).SetCellValue("Name");
            row.CreateCell(2).SetCellValue("Category");
            row.CreateCell(3).SetCellValue("Description");
            row.CreateCell(4).SetCellValue("Price");
            rowIndex++;


            foreach (Product item in resultProducts)
            {
                row = productsSheet.CreateRow(rowIndex);
                row.CreateCell(0).SetCellValue(item.Id);
                row.CreateCell(1).SetCellValue(item.Name);
                row.CreateCell(2).SetCellValue(item.Category.ToString());
                row.CreateCell(3).SetCellValue(item.Description);
                row.CreateCell(4).SetCellValue(item.Price.ToString());

                rowIndex++;
            }

            using (var exportData = new MemoryStream())
            {
                workbook.Write(exportData);

                Response.ContentType = "application/vnd.ms-excel";
                Response.AddHeader("Content-Disposition", string.Format("attachment;filename={0}", "Products.xls"));
                Response.Clear();
                Response.BinaryWrite(exportData.GetBuffer());
                Response.End();
            }


            return null;
        }


    }
}