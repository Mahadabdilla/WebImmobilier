using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebImmobilier.Models;


namespace WebIMmobilier.Controllers
{
    public class MaisonViewModelsController : Controller
    {
        private bdImmobilierContext db = new bdImmobilierContext();

        private List<MaisonViewModels> GetMaisonViewModels()
        {
            List<MaisonViewModels> liste = new List<MaisonViewModels>();
            var listeMaison = db.maisons.ToList();
            var listeBien = db.biens.ToList();
            foreach (var item in listeMaison)
            {
                var leBien = listeBien.Where(a => a.IdBien == item.IdBien).FirstOrDefault();
                MaisonViewModels m = new MaisonViewModels();
                m.IdBien = item.IdBien;
                m.SuperficieBien = item.SuperficieBien;
                m.DescriptionBien = item.DescriptionBien;
                m.LocaliteBien = item.LocaliteBien;
                m.IdProprio = item.IdProprio;
                m.NbreChambre = item.NbreChambre;
                m.NbreSalleEau = item.NbreSalleEau;
                m.NbreCuisine = item.NbreCuisine;
                m.NbreToilette = item.NbreToilette;
                liste.Add(m);
            }
            return liste;
        }

        // GET: MaisonViewModels
        public ActionResult Index()
        {
            //var biens = db.biens.Include(m => m.Proprietaire);
            var maisonViewModels = GetMaisonViewModels();
            return View(maisonViewModels.ToList());
        }

        // GET: MaisonViewModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MaisonViewModels maisonViewModel = null;// db.biens.Find(id);
            if (maisonViewModel == null)
            {
                return HttpNotFound();
            }
            return View(maisonViewModel);
        }

        // GET: MaisonViewModels/Create
        public ActionResult Create()
        {
            //ViewBag.IdProprio = new SelectList(db.utilisateurs, "IdUtilisateur", "NomUtil");
            return View();
        }

        // POST: MaisonViewModels/Create
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdBien,DescriptionBien,SuperficieBien,LocaliteBien,IdProprio,NbreChambre,NbreSalleEau,NbreCuisine,NbreToilette")] MaisonViewModels maisonViewModel)
        {
            if (ModelState.IsValid)
            {
                //db.biens.Add(maisonViewModel);
                Maison b = new Maison();
                b.NbreCuisine = maisonViewModel.NbreCuisine;
                b.SuperficieBien = maisonViewModel.SuperficieBien;
                b.DescriptionBien = maisonViewModel.DescriptionBien;
                b.LocaliteBien = maisonViewModel.LocaliteBien;
                b.NbreSalleEau = maisonViewModel.NbreSalleEau;
                b.NbreToilette = maisonViewModel.NbreToilette;
                b.NbreChambre = maisonViewModel.NbreChambre;
                db.biens.Add(b);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            //ViewBag.IdProprio = new SelectList(db.proprietaires, "IdUtilisateur", "NomUtil", maisonViewModel.IdProprio);
            return View(maisonViewModel);
        }

        // GET: MaisonViewModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MaisonViewModels maisonViewModel = null;// db.biens.Find(id);
            if (maisonViewModel == null)
            {
                return HttpNotFound();
            }
            //ViewBag.IdProprio = new SelectList(db.utilisateurs, "IdUtilisateur", "NomUtil", maisonViewModel.IdProprio);
            return View(maisonViewModel);
        }

        // POST: MaisonViewModels/Edit/5
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdBien,DescriptionBien,SuperficieBien,LocaliteBien,IdProprio,NbreChambre,NbreSalleEau,NbreCuisine,NbreToilette")] MaisonViewModels maisonViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(maisonViewModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            //ViewBag.IdProprio = new SelectList(db.utilisateurs, "IdUtilisateur", "NomUtil", maisonViewModel.IdProprio);
            return View(maisonViewModel);
        }

        // GET: MaisonViewModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MaisonViewModels maisonViewModel = null; // db.biens.Find(id);
            if (maisonViewModel == null)
            {
                return HttpNotFound();
            }
            return View(maisonViewModel);
        }

        // POST: MaisonViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //MaisonViewModels maisonViewModel = null;// db.biens.Find(id);
            //db.biens.Remove(maisonViewModel);
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
