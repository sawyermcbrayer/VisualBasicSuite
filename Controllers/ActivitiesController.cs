#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASPexample.Data;
using ASPexample.Models;
using Microsoft.AspNetCore.Authorization;

namespace ASPexample.Controllers
{
    public class ActivitiesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ActivitiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Activities
        public async Task<IActionResult> Index()
        {
            return View(await _context.Activities.ToListAsync());
        }

        // GET: Activities/ShowSearchForm
        public async Task<IActionResult> ShowSearchForm()
        {
            return View();
        }
        // POST: Activities/ShowSearchResults
        public async Task<IActionResult> ShowSearchResults(String SearchPhrase)
        {
            return View("Index" , await _context.Activities.Where( j => j.ActivityQuestion.Contains(SearchPhrase)).ToListAsync());
        }

        // GET: Activities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activities = await _context.Activities
                .FirstOrDefaultAsync(m => m.Id == id);
            if (activities == null)
            {
                return NotFound();
            }

            return View(activities);
        }

        // GET: Activities/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Activities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ActivityQuestion,ActivityAnswer")] Activities activities)
        {
            if (ModelState.IsValid)
            {
                _context.Add(activities);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(activities);
        }

        // GET: Activities/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activities = await _context.Activities.FindAsync(id);
            if (activities == null)
            {
                return NotFound();
            }
            return View(activities);
        }

        // POST: Activities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ActivityQuestion,ActivityAnswer")] Activities activities)
        {
            if (id != activities.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(activities);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ActivitiesExists(activities.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(activities);
        }

        // GET: Activities/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activities = await _context.Activities
                .FirstOrDefaultAsync(m => m.Id == id);
            if (activities == null)
            {
                return NotFound();
            }

            return View(activities);
        }

        // POST: Activities/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var activities = await _context.Activities.FindAsync(id);
            _context.Activities.Remove(activities);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ActivitiesExists(int id)
        {
            return _context.Activities.Any(e => e.Id == id);
        }
    }
}
