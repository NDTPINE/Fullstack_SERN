using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Dynamic;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Reflection;
using MakeWebByASP.Net.Models;
using PagedList;

namespace MakeWebByASP.Net.Controllers
{
    public class UsersController : Controller
    {
        private MakeWebByASPEntities db = new MakeWebByASPEntities();
        public class HttpParamActionAttribute : ActionNameSelectorAttribute
        {
            public override bool IsValidName(ControllerContext controllerContext, string actionName, MethodInfo methodInfo)
            {
                if (actionName.Equals(methodInfo.Name, StringComparison.InvariantCultureIgnoreCase))
                    return true;

                var request = controllerContext.RequestContext.HttpContext.Request;
                return request[methodInfo.Name] != null;
            }
        }
        [HttpGet]
        public ActionResult Index(int? size, int? page, string sortProperty, string sortOrder, string searchString)
        {
            // 1. Tạo biến ViewBag gồm sortOrder, searchValue, sortProperty và page
            if (sortOrder == "asc") ViewBag.sortOrder = "desc";
            if (sortOrder == "desc") ViewBag.sortOrder = "";
            if (sortOrder == "") ViewBag.sortOrder = "asc";
            ViewBag.searchValue = searchString;
            ViewBag.sortProperty = sortProperty;
            ViewBag.page = page;

            // 2. Tạo danh sách chọn số trang
            List<SelectListItem> items = new List<SelectListItem>();
            items.Add(new SelectListItem { Text = "5", Value = "5" });
            items.Add(new SelectListItem { Text = "10", Value = "10" });
            items.Add(new SelectListItem { Text = "20", Value = "20" });
            items.Add(new SelectListItem { Text = "25", Value = "25" });
            items.Add(new SelectListItem { Text = "50", Value = "50" });
            items.Add(new SelectListItem { Text = "100", Value = "100" });
            items.Add(new SelectListItem { Text = "200", Value = "200" });

            // 2.1. Thiết lập số trang đang chọn vào danh sách List<SelectListItem> items
            foreach (var item in items)
            {
                if (item.Value == size.ToString()) item.Selected = true;
            }
            ViewBag.size = items;
            ViewBag.currentSize = size;

            // 3. Lấy tất cả tên thuộc tính của lớp Link (LinkID, LinkName, LinkURL,...)
            var properties = typeof(User).GetProperties();
            List<Tuple<string, bool, int>> list = new List<Tuple<string, bool, int>>();
            foreach (var item in properties)
            {
                int order = 999;
                var isVirtual = item.GetAccessors()[0].IsVirtual;

                if (item.Name == "Name") order = 1;
                if (item.Name == "Status") order = 5;
                if (item.Name == "UserName") order = 2;
                if (item.Name == "Password") order = 3;
                if (item.Name == "Rules") order = 4;
                if (item.Name == "Id") continue; // Không hiển thị cột này
                Tuple<string, bool, int> t = new Tuple<string, bool, int>(item.Name, isVirtual, order);
                list.Add(t);
            }
            list = list.OrderBy(x => x.Item3).ToList();

            // 3.1. Tạo Heading sắp xếp cho các cột
            foreach (var item in list)
            {
                if (!item.Item2)
                {
                    if (sortOrder == "desc" && sortProperty == item.Item1)
                    {
                        ViewBag.Headings += "<th><a href='?page=" + page + "&size=" + ViewBag.currentSize + "&sortProperty=" + item.Item1 + "&sortOrder=" +
                            ViewBag.sortOrder + "&searchString=" + searchString + "'>" + item.Item1 + "<i class='fa fa-fw fa-sort-desc'></i></th></a></th>";
                    }
                    else if (sortOrder == "asc" && sortProperty == item.Item1)
                    {
                        ViewBag.Headings += "<th><a href='?page=" + page + "&size=" + ViewBag.currentSize + "&sortProperty=" + item.Item1 + "&sortOrder=" +
                            ViewBag.sortOrder + "&searchString=" + searchString + "'>" + item.Item1 + "<i class='fa fa-fw fa-sort-asc'></a></th>";
                    }
                    else
                    {
                        ViewBag.Headings += "<th><a href='?page=" + page + "&size=" + ViewBag.currentSize + "&sortProperty=" + item.Item1 + "&sortOrder=" +
                           ViewBag.sortOrder + "&searchString=" + searchString + "'>" + item.Item1 + "<i class='fa fa-fw fa-sort'></a></th>";
                    }

                }
                else ViewBag.Headings += "<th>" + item.Item1 + "</th>";
            }

            // 4. Truy vấn lấy tất cả đường dẫn
            var users = from l in db.Users
                        select l;

            // 5. Tạo thuộc tính sắp xếp mặc định là "LinkID"
            if (String.IsNullOrEmpty(sortProperty)) sortProperty = "LinkID";

            // 5. Sắp xếp tăng/giảm bằng phương thức OrderBy sử dụng trong thư viện Dynamic LINQ
            if (sortOrder == "desc") users = users.OrderBy(sortProperty + " desc");
            else if (sortOrder == "asc") users = users.OrderBy(sortProperty);
            else users = users.OrderBy("Name");

            // 5.1. Thêm phần tìm kiếm
            if (!String.IsNullOrEmpty(searchString))
            {
                users = users.Where(s => s.Name.Contains(searchString));
            }

            // 5.2. Nếu page = null thì đặt lại là 1.
            page = page ?? 1; //if (page == null) page = 1;

            // 5.3. Tạo kích thước trang (pageSize), mặc định là 5.
            int pageSize = (size ?? 5);

            ViewBag.pageSize = pageSize;

            // 6. Toán tử ?? trong C# mô tả nếu page khác null thì lấy giá trị page, còn
            // nếu page = null thì lấy giá trị 1 cho biến pageNumber. --- dammio.com
            int pageNumber = (page ?? 1);

            // 6.2 Lấy tổng số record chia cho kích thước để biết bao nhiêu trang
            int checkTotal = (int)(users.ToList().Count / pageSize) + 1;
            // Nếu trang vượt qua tổng số trang thì thiết lập là 1 hoặc tổng số trang
            if (pageNumber > checkTotal) pageNumber = checkTotal;

            // 7. Trả về các Link được phân trang theo kích thước và số trang.
            return View(users.ToPagedList(pageNumber, pageSize));
        }

        [HttpPost, HttpParamAction]
        public ActionResult Reset()
        {
            ViewBag.searchValue = "";
            Index(null, null, "", "", "");
            return View();
        }
        //public ActionResult Index(int? size, int? page)
        //{
        //    // 1. Tạo list pageSize để người dùng có thể chọn xem để phân trang
        //    // Bạn có thể thêm bớt tùy ý --- dammio.com
        //    List<SelectListItem> items = new List<SelectListItem>();
        //    items.Add(new SelectListItem { Text = "5", Value = "5" });
        //    items.Add(new SelectListItem { Text = "10", Value = "10" });
        //    items.Add(new SelectListItem { Text = "20", Value = "20" });
        //    items.Add(new SelectListItem { Text = "25", Value = "25" });
        //    items.Add(new SelectListItem { Text = "50", Value = "50" });
        //    items.Add(new SelectListItem { Text = "100", Value = "100" });
        //    items.Add(new SelectListItem { Text = "200", Value = "200" });

        //    // 1.1. Giữ trạng thái kích thước trang được chọn trên DropDownList
        //    foreach (var item in items)
        //    {
        //        if (item.Value == size.ToString()) item.Selected = true;
        //    }

        //    // 1.2. Tạo các biến ViewBag
        //    ViewBag.size = items; // ViewBag DropDownList
        //    ViewBag.currentSize = size; // tạo biến kích thước trang hiện tại

        //    // 2. Nếu page = null thì đặt lại là 1.
        //    page = page ?? 1; //if (page == null) page = 1;

        //    // 3. Tạo truy vấn, lưu ý phải sắp xếp theo trường nào đó, ví dụ OrderBy
        //    // theo LinkID mới có thể phân trang.
        //    var user = (from l in db.Users
        //                 select l).OrderBy(x => x.Id);

        //    // 4. Tạo kích thước trang (pageSize), mặc định là 5.
        //    int pageSize = (size ?? 5);

        //    // 4.1 Toán tử ?? trong C# mô tả nếu page khác null thì lấy giá trị page, còn
        //    // nếu page = null thì lấy giá trị 1 cho biến pageNumber.
        //    int pageNumber = (page ?? 1);
        //    int checkTotal = (int)(user.ToList().Count / pageSize) + 1;
        //    if (pageNumber > checkTotal) pageNumber = checkTotal;

        //    // 5. Trả về các Link được phân trang theo kích thước và số trang.
        //    return View(user.ToPagedList(pageNumber, pageSize));
        //}
        //public ActionResult Index(int? page)
        //{

        //    // 1. Tham số int? dùng để thể hiện null và kiểu int
        //    // page có thể có giá trị là null và kiểu int.

        //    // 2. Nếu page = null thì đặt lại là 1.
        //    if (page == null) page = 1;

        //    // 3. Tạo truy vấn, lưu ý phải sắp xếp theo trường nào đó, ví dụ OrderBy
        //    // theo LinkID mới có thể phân trang.
        //    var user = (from l in db.Users
        //                 select l).OrderBy(x => x.Id);

        //    // 4. Tạo kích thước trang (pageSize) hay là số Link hiển thị trên 1 trang
        //    int pageSize = 3;

        //    // 4.1 Toán tử ?? trong C# mô tả nếu page khác null thì lấy giá trị page, còn
        //    // nếu page = null thì lấy giá trị 1 cho biến pageNumber.
        //    int pageNumber = (page ?? 1);

        //    // 5. Trả về các Link được phân trang theo kích thước và số trang.
        //    return View(user.ToPagedList(pageNumber, pageSize));
        //}
        // GET: Users
        //public ActionResult Index(string sortProperty, string sortOrder, string searchString)
        //{
        //    //ViewBag.SortOrder = string.IsNullOrEmpty(sortOrder) ? "desc" : "";
        //    if (sortOrder == "asc") ViewBag.SortOrder = "desc";
        //    if (sortOrder == "desc") ViewBag.SortOrder = "";
        //    if (sortOrder == "") ViewBag.SortOrder = "asc";

        //    ViewBag.searchValue = searchString;

        //    var properties = typeof(User).GetProperties();
        //    List<Tuple<string, bool, int>> list = new List<Tuple<string, bool, int>>();

        //    foreach (var item in properties)
        //    {
        //        if (item.Name == "Id") continue;
        //        int order = 999;
        //        var isVirtual = item.GetAccessors()[0].IsVirtual;
        //        if (item.Name == "Name") order = 1;
        //        if (item.Name == "UserName") order = 2;
        //        if (item.Name == "Password") order = 3;
        //        if (item.Name == "Rules") order = 4;
        //        if (item.Name == "Status") order = 5;
        //        Tuple<string, bool, int> t = new Tuple<string, bool, int>(item.Name, isVirtual, order);
        //        list.Add(t);

        //    }
        //    list = list.OrderBy(x => x.Item3).ToList();
        //    foreach( var item in list)
        //    {
        //    if (!item.Item2)
        //        {
        //            if (sortOrder == "desc" && sortProperty == item.Item1)
        //            {
        //                ViewBag.Headings += "<th><a href= '?sortProperty=" + item.Item1+ "&sortOrder=" + ViewBag.SortOrder + "&searchString=" + searchString + "'>" + item.Item1 + "<i class='fa fa-fw fa-sort-desc'></i></th></a></th>";
        //            }
        //            else if (sortOrder == "asc" && sortProperty == item.Item1)
        //            {
        //                ViewBag.Headings += "<th><a href='?sortProperty=" + item.Item1 + "&sortOrder=" +
        //                    ViewBag.SortOrder + "&searchString=" + searchString + "'>" + item.Item1 + "<i class='fa fa-fw fa-sort-asc'></a></th>";
        //            }
        //            else
        //            {
        //                ViewBag.Headings += "<th><a href='?sortProperty=" + item.Item1 + "&sortOrder=" +
        //                   ViewBag.SortOrder + "&searchString=" + searchString + "'>" + item.Item1 + "<i class='fa fa-fw fa-sort'></a></th>";
        //            }
        //        }
        //        else ViewBag.Headings += "<th>" + item.Item1 + "</th>";
        //    }
        //    var user = from u in db.Users select u;
        //    if (String.IsNullOrEmpty(sortProperty)) sortProperty = "Name";
        //    if (sortOrder == "desc") user = user.OrderBy(sortProperty + " desc");
        //    else user = user.OrderBy(sortProperty);

        //    if (!String.IsNullOrEmpty(searchString))
        //    {
        //        user = user.Where(s => s.Name.Contains(searchString));
        //    }
        //    return View(user.ToList());
        //}
        
        //public ActionResult Reset()
        //{
        //    ViewBag.searchValue = "";
        //    Index("", "", "");
        //    return View();
        //}

        // GET: Users/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,UserName,Password,Rules,Status")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(user);
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,UserName,Password,Rules,Status")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
