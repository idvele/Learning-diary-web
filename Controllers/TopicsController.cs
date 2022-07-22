using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LearningDiary_IK0._1.Data;
using LearningDiary_IK0._1.Models;

namespace LearningDiary_IK0._1.Controllers
{
    public class TopicsController : Controller
    {
        private readonly LearningDiary_IK0_1Context _context;

        public TopicsController(LearningDiary_IK0_1Context context)
        {
            _context = context;
        }

        // GET: Topics
        public async Task<IActionResult> Index()
        {
            return View(await _context.Topics.ToListAsync());
        }

        // GET: Topics/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var topics = await _context.Topics
                .FirstOrDefaultAsync(m => m.Id == id);
            if (topics == null)
            {
                return NotFound();
            }

            return View(topics);
        }

        // GET: Topics/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Topics/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,EstimatedTimeToMaster,TimeSpent,Source,StartLearningDate,inProgress,CompletionDate")] Topics topics)
        {
            if (ModelState.IsValid)
            {
                _context.Add(topics);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(topics);
        }

        // GET: Topics/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var topics = await _context.Topics.FindAsync(id);
            if (topics == null)
            {
                return NotFound();
            }
            return View(topics);
        }

        // POST: Topics/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,EstimatedTimeToMaster,TimeSpent,Source,StartLearningDate,inProgress,CompletionDate")] Topics topics)
        {
            if (id != topics.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(topics);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TopicsExists(topics.Id))
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
            return View(topics);
        }

        // GET: Topics/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var topics = await _context.Topics
                .FirstOrDefaultAsync(m => m.Id == id);
            if (topics == null)
            {
                return NotFound();
            }

            return View(topics);
        }

        // POST: Topics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var topics = await _context.Topics.FindAsync(id);
            _context.Topics.Remove(topics);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TopicsExists(int id)
        {
            return _context.Topics.Any(e => e.Id == id);
        }
    }
}
