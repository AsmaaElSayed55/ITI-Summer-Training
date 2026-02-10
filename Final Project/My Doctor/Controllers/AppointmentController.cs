using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using My_Doctor.Data;
using My_Doctor.Data;
using My_Doctor.Models;
using My_Doctor.Models;
using System;
using System.Linq;

public class AppointmentController : Controller
{
    private readonly AppDbContext _context;

    public AppointmentController(AppDbContext context)
    {
        _context = context;
    }

    // GET: /Appointment/Book
    

    // POST: /Appointment/Book

    // GET: /Appointment/MyAppointments
    public IActionResult MyAppointments()
    {
        var patientId = int.Parse(HttpContext.Session.GetString("UserId"));
        var appointments = _context.Appointments.Where(a => a.PatientId == patientId).ToList();
        return View(appointments);
    }

    // GET: /Appointment/PatientAppointments
    public IActionResult PatientAppointments()
    {
        var doctorId = int.Parse(HttpContext.Session.GetString("UserId"));
        var appointments = _context.Appointments.Where(a => a.DoctorId == doctorId).ToList();
        return View(appointments);
    }
    
    [HttpGet]
    public IActionResult Book()
    {
        ViewBag.Doctors = new SelectList(_context.Doctors.ToList(), "Id", "Username");
        return View();
    }

    [HttpPost]
    public IActionResult Book(Appointment appointment)
    {
        appointment.PatientId = int.Parse(HttpContext.Session.GetString("UserId"));
        appointment.Status = "Pending";

        _context.Appointments.Add(appointment);
        _context.SaveChanges();

        return RedirectToAction("MyAppointments");
    }

}
