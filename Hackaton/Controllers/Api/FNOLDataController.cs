using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Hackaton.Models;

namespace Hackaton.Controllers.Api
{
    public class FNOLDataController : ApiController
    {
        private HackatonContext db = new HackatonContext();

        // GET: api/FNOLData
        public IQueryable<FNOLData> GetFNOLDatas()
        {
            return db.FNOLDatas;
        }

        // GET: api/FNOLData/5
        [ResponseType(typeof(FNOLData))]
        public IHttpActionResult GetFNOLData(int id)
        {
            //FNOLData fNOLData = db.FNOLDatas.Find(id);
            //if (fNOLData == null)
            //{
            //    return NotFound();
            //}

            //return Ok(fNOLData);
            return Ok("ok");
        }

        // PUT: api/FNOLData/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutFNOLData(int id, FNOLData fNOLData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != fNOLData.Id)
            {
                return BadRequest();
            }

            db.Entry(fNOLData).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FNOLDataExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/FNOLData
        [ResponseType(typeof(FNOLData))]
        public IHttpActionResult PostFNOLData(FNOLData fNOLData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.FNOLDatas.Add(fNOLData);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = fNOLData.Id }, fNOLData);
        }

        // DELETE: api/FNOLData/5
        [ResponseType(typeof(FNOLData))]
        public IHttpActionResult DeleteFNOLData(int id)
        {
            FNOLData fNOLData = db.FNOLDatas.Find(id);
            if (fNOLData == null)
            {
                return NotFound();
            }

            db.FNOLDatas.Remove(fNOLData);
            db.SaveChanges();

            return Ok(fNOLData);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FNOLDataExists(int id)
        {
            return db.FNOLDatas.Count(e => e.Id == id) > 0;
        }
    }
}