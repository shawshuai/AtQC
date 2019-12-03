using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AtQC.Core.Models;

namespace AtQC.Core.Services
{
    // This class holds sample data used by some generated pages to show how they can be used.
    // TODO WTS: Delete this file once your app is using real data.
    public static class DataService
    {
        private static IEnumerable<SampleOrder> AllOrders()
        {
            // The following is order summary data
            var companies = AllCompanies();
            return companies.SelectMany(c => c.Orders);
        }

        private static IEnumerable<Company> AllCompanies()
        {
            return new List<Company>()
            {
                new Company()
                {
                    CompanyID = "ALFKI",
                    CompanyName = "陈顺辉",
                    ContactName = "Maria Anders",
                    ContactTitle = "Sales Representative",
                    Address = "Obere Str. 57",
                    City = "Berlin",
                    PostalCode = "12209",
                    Country = "Germany",
                    Phone = "030-0074321",
                    Fax = "030-0076545",
                    Orders = new List<SampleOrder>()
                    {
                        new SampleOrder()
                        {
                            OrderID = 10835, // Symbol Music
                            OrderDate = new DateTime(2019, 12, 02),
                            RequiredDate = new DateTime(1998, 2, 12),
                            ShippedDate = new DateTime(1998, 1, 21),
                            ShipperName = "Federal Shipping",
                            ShipperPhone = "(503) 555-9931",
                            Freight = 69.53,
                            Company = "晴川学子喜获第十一届全国大学生广告艺术大赛二等奖",
                            ShipTo = "本网讯（通讯员：吴超） 11月23日，第十一届全国大学生广告艺术大赛（以下简称：大广赛）学科竞赛成果展示盛典在全国政协礼堂隆重举行。武汉晴川学院选送的作品《谜》在众多参赛作品中脱颖而出，荣获“视频类微电影广告”全国二等奖。",
                            OrderTotal = 1837,
                            Status = "晴川学子喜获第十一届全国大学生广告艺术大赛二等奖",
                            SymbolCode = 57737,
                            Details = new List<SampleOrderDetail>()
                            {
                                new SampleOrderDetail()
                                {
                                    ProductID = 59,
                                    ProductName = "Raclette Courdavault",
                                    Quantity = 15,
                                    Discount = 0,
                                    QuantityPerUnit = "5 kg pkg.",
                                    UnitPrice = 55.00,
                                    CategoryName = "Dairy Products",
                                    CategoryDescription = "Cheeses",
                                    Total = 825.00
                                },
                                new SampleOrderDetail()
                                {
                                    ProductID = 77,
                                    ProductName = "Original Frankfurter grüne Soße",
                                    Quantity = 2,
                                    Discount = 0.2,
                                    QuantityPerUnit = "12 boxes",
                                    UnitPrice = 13.0,
                                    CategoryName = "Condiments",
                                    CategoryDescription = "Sweet and savory sauces, relishes, spreads, and seasonings",
                                    Total = 20.80
                                }
                            }
                        }
                    }
                }
            };
        }

        // TODO WTS: Remove this once your MasterDetail pages are displaying real data.
        public static async Task<IEnumerable<SampleOrder>> GetMasterDetailDataAsync()
        {
            await Task.CompletedTask;
            return AllOrders();
        }
    }
}
