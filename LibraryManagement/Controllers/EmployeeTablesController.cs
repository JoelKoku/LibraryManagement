using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Database_Layer;

namespace LibraryManagement.Controllers
{
    public class EmployeeTablesController : Controller
    {
        private OnlineLabEntitiesDbEntities db = new OnlineLabEntitiesDbEntities();

        // GET: EmployeeTables
        public ActionResult Index()
        {
            var employeeTables = db.EmployeeTables.Include(e => e.DepartmentTable).Include(e => e.DesignationTable).Include(e => e.DesignationTable1);
            return View(employeeTables.ToList());
        }

        // GET: EmployeeTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeTable employeeTable = db.EmployeeTables.Find(id);
            if (employeeTable == null)
            {
                return HttpNotFound();
            }
            return View(employeeTable);
        }

        // GET: EmployeeTables/Create
        public ActionResult Create()
        {
            ViewBag.DepartmentID = new SelectList(db.DepartmentTables, "DepartmentID", "DepartmentName");
            ViewBag.DesignationID = new SelectList(db.DesignationTables, "DesignationID", "Name");
            ViewBag.DepartmentID = new SelectList(db.DesignationTables, "DesignationID", "Name");
            return View();
        }

        // POST: EmployeeTables/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeTable employeeTable)
        {
            int userid = Convert.ToInt32(Convert.ToString(Session["UserID"]));
            employeeTable.UserID = userid;
            if (ModelState.IsValid)
            {
                db.EmployeeTables.Add(employeeTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DepartmentID = new SelectList(db.DepartmentTables, "DepartmentID", "DepartmentName", employeeTable.DepartmentID);
            ViewBag.DesignationID = new SelectList(db.DesignationTables, "DesignationID", "Name", employeeTable.DesignationID);
            ViewBag.DepartmentID = new SelectList(db.DesignationTables, "DesignationID", "Name", employeeTable.DepartmentID);
            return View(employeeTable);
        }

        // GET: EmployeeTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeTable employeeTable = db.EmployeeTables.Find(id);
            if (employeeTable == null)
            {
                return HttpNotFound();
            }
            ViewBag.DepartmentID = new SelectList(db.DepartmentTables, "DepartmentID", "DepartmentName", employeeTable.DepartmentID);
            ViewBag.DesignationID = new SelectList(db.DesignationTables, "DesignationID", "Name", employeeTable.DesignationID);
            ViewBag.DepartmentID = new SelectList(db.DesignationTables, "DesignationID", "Name", employeeTable.DepartmentID);
            return View(employeeTable);
        }

        // POST: EmployeeTables/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmployeeTable employeeTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employeeTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DepartmentID = new SelectList(db.DepartmentTables, "DepartmentID", "DepartmentName", employeeTable.DepartmentID);
            ViewBag.DesignationID = new SelectList(db.DesignationTables, "DesignationID", "Name", employeeTable.DesignationID);
            ViewBag.DepartmentID = new SelectList(db.DesignationTables, "DesignationID", "Name", employeeTable.DepartmentID);
            return View(employeeTable);
        }

        // GET: EmployeeTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeTable employeeTable = db.EmployeeTables.Find(id);
            if (employeeTable == null)
            {
                return HttpNotFound();
            }
            return View(employeeTable);
        }

        // POST: EmployeeTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmployeeTable employeeTable = db.EmployeeTables.Find(id);
            db.EmployeeTables.Remove(employeeTable);
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
