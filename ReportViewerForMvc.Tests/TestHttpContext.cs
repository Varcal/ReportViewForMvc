using System.Web.Mvc;

namespace ReportViewerForMvc.Tests
{
    //class TestHttpContext : HttpContextBase
    //{
    //    private Dictionary<object, object> items = new Dictionary<object, object>();
    //    public override System.Collections.IDictionary Items
    //    {
    //        get
    //        {
    //            return this.items;
    //        }
    //    }

    //}

    public class TestViewDataContainer : IViewDataContainer
    {
        private ViewDataDictionary viewData = new ViewDataDictionary();
        public ViewDataDictionary ViewData
        {
            get
            {
                return this.viewData;
            }
            set
            {
                this.viewData = value;
            }
        }
    }
}
