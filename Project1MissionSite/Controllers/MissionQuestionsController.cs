using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Project1MissionSite.DAL;
using Project1MissionSite.Models;
using Microsoft.AspNet.Identity;

namespace Project1MissionSite.Controllers
{
    public class MissionQuestionsController : Controller
    {
        private MissionSiteContext db = new MissionSiteContext();

        // GET: MissionQuestions
        public ActionResult Index()
        {
            return View(db.MissionQuestions.ToList());
        }

        // GET: MissionQuestions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MissionQuestion missionQuestion = db.MissionQuestions.Find(id);
            if (missionQuestion == null)
            {
                return HttpNotFound();
            }
            return View(missionQuestion);
        }

        // GET: MissionQuestions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MissionQuestions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "missionquestionId,missionquestionQuestion,missionquestionAnswer,missionId,userEmail")] MissionQuestion missionQuestion, int missions)
        {
			//edits the useremail to grab which user was logged in when creating the new question / passing the mission id through again
            if (ModelState.IsValid)
            {
				//set the useremail to the current username
				missionQuestion.userEmail = User.Identity.GetUserName().ToString();
				missionQuestion.missionId = missions;
                db.MissionQuestions.Add(missionQuestion);
                db.SaveChanges();
				return RedirectToAction("MissionSelection", "Home", new { missions = missionQuestion.missionId });
            }

            return View(missionQuestion);
        }

        // GET: MissionQuestions/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MissionQuestion missionQuestion = db.MissionQuestions.Find(id);
            if (missionQuestion == null)
            {
                return HttpNotFound();
            }
            return View(missionQuestion);
        }

        // POST: MissionQuestions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "missionquestionId,missionquestionQuestion,missionquestionAnswer,missionId,userEmail")] MissionQuestion missionQuestion)
        {
			//edits the useremail to grab which user was logged in when editing the new question
            if (ModelState.IsValid)
            {
				missionQuestion.userEmail = User.Identity.GetUserName().ToString(); 
                db.Entry(missionQuestion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("MissionSelection", "Home", new { missions = missionQuestion.missionId });
            }
            return View(missionQuestion);
        }

        // GET: MissionQuestions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MissionQuestion missionQuestion = db.MissionQuestions.Find(id);
            if (missionQuestion == null)
            {
                return HttpNotFound();
            }
            return View(missionQuestion);
        }

        // POST: MissionQuestions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MissionQuestion missionQuestion = db.MissionQuestions.Find(id);
            db.MissionQuestions.Remove(missionQuestion);
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
