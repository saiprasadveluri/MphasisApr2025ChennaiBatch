using JobSearchDatabase.Data;
using JobSearchDatabase.Models;
using JobSearchAPI.DataDTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net.Http.Json;

public class JobApplicationController : Controller
{
    private readonly UnitOfWorkDb _unitOfWork;
    private readonly HttpClient _httpClient;

    public JobApplicationController(UnitOfWorkDb unitOfWork)
    {
        _unitOfWork = unitOfWork;
        _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7082/api/") };
    }

    public async Task<IActionResult> Index()
    {
        var applications = await _unitOfWork.jobApplicationRepo.GetAllAsync();
        return View(applications);
    }

    public async Task<IActionResult> Create()
    {
        await PopulateDropdowns();
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(JobSearchDatabase.Data.JobApplicationDTO jobApplication)
    {
        if (!ModelState.IsValid)
        {
            await PopulateDropdowns(jobApplication);
            return View(jobApplication);
        }

        jobApplication.ApplicationId = Guid.NewGuid();
        jobApplication.AppliedDate = DateOnly.FromDateTime(DateTime.Now);
        jobApplication.Status = JobSearchDatabase.EnumsJob.JobStatus.Pending;

        var dto = new JobSearchAPI.DataDTO.JobApplicationDTO
        {
            ApplicationId = jobApplication.ApplicationId,
            JobPostingId = jobApplication.JobPostingId,
            CandidateId = jobApplication.CandidateId,
            AppliedDate = jobApplication.AppliedDate,
            Status = (JobSearchAPI.DataDTO.EnumsJob.JobStatus)(int)jobApplication.Status
        };

        var response = await _httpClient.PostAsJsonAsync("JobApplication", dto);
        response.EnsureSuccessStatusCode();

        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateDropdowns(JobSearchDatabase.Data.JobApplicationDTO selected = null)
    {
        var candidates = await _unitOfWork.candidateRepo.GetAllAsync();
        var jobPostings = await _unitOfWork.jobPostingRepo.GetAllAsync();

        ViewData["CandidateId"] = new SelectList(candidates, "CandidateId", "FirstName", selected?.CandidateId);
        ViewData["JobPostingId"] = new SelectList(jobPostings, "JobPostingId", "JobTitle", selected?.JobPostingId);
    }
}
