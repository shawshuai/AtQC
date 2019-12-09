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
        private static IEnumerable<NewsDetail> AllNewses()
        {
            // The following is order summary data
            var companies = AllNewsController();
            return companies.SelectMany(c => c.Newses);
        }

        private static IEnumerable<NewsController> AllNewsController()
        {
            return new List<NewsController>()
            {
                new NewsController()
                {
                    Publisher = "晴川新闻网",
                    PublishTime = new DateTime(),
                    Newses = new List<NewsDetail>()
                    {
                        new NewsDetail()
                        {
                            OrderID = 10835, // Symbol Music
                            SymbolCode = 57737,
                            NewsID = 3,
                            HeadImageLink = new Uri("https://mmbiz.qpic.cn/mmbiz_jpg/hsDmQyEtEvTfQJveXywKGn9iaY012LvjwDTz2StScTY8UtYxwyJzZI1CpLIbev1OsuKC0r0CCoYVR4iamO8ctI3w/640?wx_fmt=jpeg&tp=webp&wxfrom=5&wx_lazy=1&wx_co=1"),
                            NewsTitle = "计算机学院第十二次团员、学生代表大会圆满结束",
                            NewsSource = "计算机学院微信公众号",
                            Author = "文字 | 宣传部；图片 | 小怪兽、一个大板栗",
                            Editor = "幼儿园园长",
                            SourceLink = new Uri("https://mp.weixin.qq.com/s/of5ezD5KfAez24MYfOkXGw"),
                            NewsBody = new Uri("https://mp.weixin.qq.com/s/of5ezD5KfAez24MYfOkXGw")
                        },
                        new NewsDetail()
                        {
                            OrderID = 10835, // Symbol Music
                            SymbolCode = 57737,
                            NewsID = 1,
                            HeadImageLink = new Uri("http://news.qcuwh.cn/wcs/Upload/201911/5ddb49ceb662e.jpg"),
                            NewsTitle = "千人竞技飞镖赛 晴川学子在全国青少年飞镖锦标赛中获多项大奖",
                            NewsSource = "晴川新闻网",
                            Author = "杨娟 张万林",
                            Editor = "Tangoo",
                            SourceLink = new Uri("http://news.qcuwh.cn/index.php/index-view-aid-15661.html"),
                            NewsBody = new Uri("http://news.qcuwh.cn/index.php/index-view-aid-15661.html")
                        },
                        new NewsDetail()
                        {
                            OrderID = 10835, // Symbol Music
                            SymbolCode = 57737,
                            NewsID = 2,
                            HeadImageLink = new Uri("http://news.qcuwh.cn/wcs/Upload/201912/5de4a5ab17bf6.jpg"),
                            NewsTitle = "走进屈原 品味楚辞 | 国学大讲堂第十五讲《屈原与楚辞》",
                            NewsSource = "晴川新闻网",
                            Author = "N/A",
                            Editor = "Tangoo",
                            SourceLink = new Uri("http://news.qcuwh.cn/index.php/index-view-aid-15832.html"),
                            NewsBody = new Uri("http://news.qcuwh.cn/index.php/index-view-aid-15832.html")
                        },
                        new NewsDetail()
                        {
                            OrderID = 10835, // Symbol Music
                            SymbolCode = 57737,
                            NewsID = 1,
                            HeadImageLink = new Uri("http://news.qcuwh.cn/wcs/Upload/201911/5ddc730e5a1f2.JPG"),
                            NewsTitle = "校园戏剧风 放飞青春梦 | 晴川学子荣获2019湖北高校戏剧展演九项奖",
                            NewsSource = "晴川新闻网",
                            Author = "周奕彤",
                            Editor = "Tangoo",
                            SourceLink = new Uri("http://news.qcuwh.cn/index.php/index-view-aid-15677.html"),
                            NewsBody = new Uri("http://news.qcuwh.cn/index.php/index-view-aid-15677.html")
                        },
                        new NewsDetail()
                        {
                            OrderID = 10835, // Symbol Music
                            SymbolCode = 57737,
                            NewsID = 1,
                            HeadImageLink = new Uri("http://news.qcuwh.cn/wcs/Upload/201911/5dd33be3bdae2.jpg"),
                            NewsTitle = "喜报！晴川学子在2019全国税务技能大赛总决赛荣获团体三等奖",
                            NewsSource = "晴川新闻网",
                            Author = "周奕彤",
                            Editor = "Tangoo",
                            SourceLink = new Uri("http://news.qcuwh.cn/index.php/index-view-aid-15603.html"),
                            NewsBody = new Uri("http://news.qcuwh.cn/index.php/index-view-aid-15603.html")
                        },
                        new NewsDetail()
                        {
                            OrderID = 10835, // Symbol Music
                            SymbolCode = 57737,
                            NewsID = 1,
                            HeadImageLink = new Uri("http://news.qcuwh.cn/wcs/Upload/201911/5dd4d8b383115.jpg"),
                            NewsTitle = "【优秀教师】翟月英：初心不改，用爱与责任陪伴学生前行",
                            NewsSource = "晴川新闻网",
                            Author = "",
                            Editor = "Tangoo",
                            SourceLink = new Uri("http://news.qcuwh.cn/index.php/index-view-aid-15623.html"),
                            NewsBody = new Uri("http://news.qcuwh.cn/index.php/index-view-aid-15623.html")
                        },
                        new NewsDetail()
                        {
                            OrderID = 10835, // Symbol Music
                            SymbolCode = 57737,
                            NewsID = 1,
                            HeadImageLink = new Uri("http://news.qcuwh.cn/wcs/Upload/201912/5de5ada0bc8ea.JPG"),
                            NewsTitle = "武汉晴川学院获批五项湖北省高校学生工作精品项目、实践育人特色项目",
                            NewsSource = "晴川新闻网",
                            Author = "周奕彤",
                            Editor = "Tangoo",
                            SourceLink = new Uri("http://news.qcuwh.cn/index.php/index-view-aid-15840.html"),
                            NewsBody = new Uri("http://news.qcuwh.cn/index.php/index-view-aid-15840.html")
                        },
                    }
                }
            };
        }

        // TODO WTS: Remove this once your MasterDetail pages are displaying real data.
        public static async Task<IEnumerable<NewsDetail>> GetMasterDetailDataAsync()
        {
            await Task.CompletedTask;
            return AllNewses();
        }
    }
}
