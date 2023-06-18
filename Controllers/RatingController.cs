using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FoodOrdering.DBAccess;
using FoodOrdering.Models;
using FoodOrdering.ViewModels;

[ApiController]
[Route("[Controller]/[action]")]

public class RatingController : ControllerBase
    {
        private readonly List<Rating> _ratingList = new List<Rating>();

        [HttpGet]
        public ActionResult<IEnumerable<Rating>> Get()
        {
            return _ratingList;
        }

        [HttpGet("{id}")]
        public ActionResult<Rating> Get(int id)
        {
            var rating = _ratingList.Find(r => r.Id == id);
            if (rating == null)
            {
                return NotFound();
            }
            {
                return rating;
            }
        }

        [HttpPost]
        public ActionResult<Rating> Post(Rating rating)
        {
            _ratingList.Add(rating);
            return CreatedAtAction(nameof(Get), new {id = rating.Id}, rating);
        }

        [HttpPut("{id}")]
        public ActionResult<Rating> Put(int id, Rating rating)
        {
            var existingRating = _ratingList.Find(r => r.Id == id);
            if (existingRating == null)
            {
                return NotFound();
            }
            existingRating.FoodItem = rating.FoodItem;
            existingRating.Rate = rating.Rate;
            existingRating.UserId = rating.UserId;
            existingRating.FoodItemId = rating.FoodItemId;

            return Ok(existingRating);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var rating = _ratingList.Find(r => r.Id == id);
            if (rating == null)
            {
                return NotFound();
            }
            _ratingList.Remove(rating);
            return NoContent();
        }
    }