using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NationalParks.Models;
using Microsoft.EntityFrameworkCore;


namespace NationalParks.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private NationalParksContext _db;

    public ParksController(NationalParksContext db)
    {
      _db = db;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Park>> Get(string name, string city, string state, int climbingRoutes, int campgrounds, int generalStores)
    {
      var query = _db.Parks.AsQueryable();


      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }
      if (city != null)
      {
        query = query.Where(entry => entry.City == city);
      }
      if (state != null)
      {
        query = query.Where(entry => entry.State == state);
      }
       if (climbingRoutes != 0)
      {
        query = query.Where(entry => entry.ClimbingRoutes == climbingRoutes);
      }
       if (campgrounds != 0)
      {
        query = query.Where(entry => entry.Campgrounds == campgrounds);
      }
      if (generalStores != 0)
      {
        query = query.Where(entry => entry.GeneralStores == generalStores);
      }
      return query.ToList();
    }
    [HttpPost]
    public void Post([FromBody] Park park)
    {
      _db.Parks.Add(park);
      _db.SaveChanges();
    }

    // GET api/parks/1
    [HttpGet("{id}")]
    public ActionResult<Park> Get(int id)
    {
      return _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
    }
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Park park)
    {
        park.ParkId = id;
        _db.Entry(park).State = EntityState.Modified;
        _db.SaveChanges();
    }
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var parkToDelete = _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
      _db.Parks.Remove(parkToDelete);
      _db.SaveChanges();
    }
  }
}