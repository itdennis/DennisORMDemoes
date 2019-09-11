using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using webapi_dennis2.DBContext;
using webapi_dennis2.Models;

namespace webapi_dennis2.Controllers
{
    public class SystemInfoesController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/SystemInfoes
        public IQueryable<SystemInfo> GetSystemInfos()
        {
            return db.SystemInfos;
        }

        // GET: api/SystemInfoes/5
        [ResponseType(typeof(SystemInfo))]
        public async Task<IHttpActionResult> GetSystemInfo(long id)
        {
            SystemInfo systemInfo = await db.SystemInfos.FindAsync(id);
            if (systemInfo == null)
            {
                return NotFound();
            }

            return Ok(systemInfo);
        }

        // PUT: api/SystemInfoes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutSystemInfo(long id, SystemInfo systemInfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != systemInfo.Id)
            {
                return BadRequest();
            }

            db.Entry(systemInfo).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SystemInfoExists(id))
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

        // POST: api/SystemInfoes
        [ResponseType(typeof(SystemInfo))]
        public async Task<IHttpActionResult> PostSystemInfo(SystemInfo systemInfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SystemInfos.Add(systemInfo);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = systemInfo.Id }, systemInfo);
        }

        // DELETE: api/SystemInfoes/5
        [ResponseType(typeof(SystemInfo))]
        public async Task<IHttpActionResult> DeleteSystemInfo(long id)
        {
            SystemInfo systemInfo = await db.SystemInfos.FindAsync(id);
            if (systemInfo == null)
            {
                return NotFound();
            }

            db.SystemInfos.Remove(systemInfo);
            await db.SaveChangesAsync();

            return Ok(systemInfo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SystemInfoExists(long id)
        {
            return db.SystemInfos.Count(e => e.Id == id) > 0;
        }
    }
}