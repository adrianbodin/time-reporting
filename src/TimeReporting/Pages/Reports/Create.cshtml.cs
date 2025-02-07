﻿using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Data;
using TimeReporting.Models;

namespace TimeReporting.Pages.Reports;

public record AddTimeEntryDto()
{
    [Required]
    public string ProjectId { get; set; }

    [Required]
    [Range(0.5, 24, ErrorMessage = "Hours must be between 0.5 and 24.")]
    public double Hours { get; set; }

    [Required]
    public string Description { get; set; }

    [BindProperty(SupportsGet = true), DataType(DataType.Date)]
    public DateTime Date { get; set; }

    [Required]
    public string WorkTypeId { get; set; }
}

[Authorize]
public class Create : PageModel
{
    private readonly AppDbContext _db;

    public Create(AppDbContext db)
    {
        _db = db;
    }

    [BindProperty]
    public AddTimeEntryDto NewEntry { get; set; }

    public IList<Project> Projects { get; set; }

    public IList<WorkType> WorkTypes { get; set; }

    //todo make this better
    public async Task OnGet([FromQuery] int? hours, [FromQuery] int? minutes)
    {
        if (hours.HasValue && minutes.HasValue)
        {
            double totalHours = hours.Value + Math.Round((double)minutes.Value / 30) * 0.5;
            NewEntry.Hours = totalHours;
        }

        ViewData["Title"] = "Add Time Entry";
        NewEntry = new AddTimeEntryDto();
        NewEntry.Date = DateTime.Now;
        Projects = await _db.Projects.AsNoTracking().ToListAsync();
        WorkTypes = await _db.WorkTypes.AsNoTracking().ToListAsync();
    }

    public async Task<IActionResult> OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        var workType = await _db.WorkTypes.FindAsync(NewEntry.WorkTypeId);
        if (workType == null)
        {
            TempData["Toast-Type"] = NotificationType.Danger;
            TempData["Toast-Message"] = "Invalid work type selected.";
            return Page();
        }

        var timeEntry = new TimeEntry
        {
            Id = Guid.NewGuid().ToString(),
            ProjectId = NewEntry.ProjectId,
            EmployeeId = User.FindFirst(ClaimTypes.NameIdentifier).Value,
            Hours = NewEntry.Hours,
            Description = NewEntry.Description,
            Date = DateOnly.FromDateTime(NewEntry.Date),
            WorkTypeId = NewEntry.WorkTypeId,
            HourlyRate = workType.HourlyRate
        };

        try
        {
            _db.TimeEntries.Add(timeEntry);
            await _db.SaveChangesAsync();

            TempData["Notification-Type"] = NotificationType.Success;
            TempData["Notification-Message"] = "The time entry was added successfully";
        }
        catch (Exception e)
        {
            TempData["Toast-Type"] = NotificationType.Danger;
            TempData["Toast-Message"] = "There was an error adding the new time entry";
        }

        return RedirectToPage("/Reports/Index", new { SelectedDate = NewEntry.Date.ToString("yyyy-MM-dd") });
    }
}