using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Employee_Relation.Models;
using Microsoft.AspNetCore.Http;  
namespace Employee_Relation.Controllers;

public class EmployeeController : Controller  
{
       private readonly ACE42023Context db=new ACE42023Context();  
       public EmployeeController(ACE42023Context _db)
       {
              db=_db;
       }
       [Route("Show")]
       public IActionResult ShowEmployee()  
       { 
              ViewData["Username"]=HttpContext.Session.GetString("Username");  
              if(ViewData["Username"]==null)
              {
                 return RedirectToAction("Index","Home");  
              }  
              ViewData["PrevPage"]=HttpContext.Session.GetString("PrevPage");  
              return View(db.Emps);  
       }
       [Route("Create")]
       public IActionResult Create()  
       {
              ViewData["Username"]=HttpContext.Session.GetString("Username");  
              ViewData["Team"]=db.Teams.ToList();
              ViewData["Message"]="";
              ViewData["Team"]=db.Teams.ToList();
              if(ViewData["Username"]==null)
              {
                 return RedirectToAction("Index","Home");  
              } 
              return View();    
       }
       [HttpPost]
       [Route("Create")]
       public IActionResult Create(Emp emp)  
       {
              ViewData["Message"]="";
              foreach(var Emp in db.Emps)
              {
                      if(Emp.Eid==emp.Eid)
                      {
                         ViewData["Message"]=$"User With Id {emp.Eid} Is Already Exist Please Enter Diff Id !!";  
                         return View();
                      }
              }
              foreach(var team in db.Teams)
              {
                      if(team.TeamName==emp.TeamName)          
                      {
                         emp.TeamLead=team.TeamLead;   
                      }
              }
              if(emp.Awards==null)
              {
                 emp.Awards="None";  
              }
              db.Emps.Add(emp);
              db.SaveChanges();
              HttpContext.Session.SetString("PrevPage","Create");  
              return RedirectToAction("ShowEmployee");  
       }
       [Route("GetDetails/{id:int}")]
       public IActionResult Details(int id)  
       { 
              ViewData["Username"]=HttpContext.Session.GetString("Username");  
              if(ViewData["Username"]==null)
              {
                 return RedirectToAction("Index","Home");  
              }  
              Emp Curr_Emp=null;
              foreach(var emp in db.Emps)
              {
                      if(emp.Eid==id)
                      {
                         Curr_Emp=emp;
                         break;
                      }
              }
              return View(Curr_Emp);    
       }
       [Route("Edit")]  
       public IActionResult Edit(int id)
       {
              ViewData["Username"]=HttpContext.Session.GetString("Username");  
              ViewData["Team"]=db.Teams.ToList();
              if(ViewData["Username"]==null)
              {
                 return RedirectToAction("Index","Home");  
              }  
              Emp Curr_Emp=null;
              foreach(var emp in db.Emps)  
              {
                      if(emp.Eid==id)
                      {
                         Curr_Emp=emp;
                         break;
                      }
              }
              return View(Curr_Emp);  
       }
       [HttpPost]
       [Route("Edit")]
       public IActionResult Edit(Emp emp)  
       {
              foreach(var team in db.Teams)
              {
                      if(team.TeamName==emp.TeamName)  
                      {
                         emp.TeamLead=team.TeamLead;   
                      }
              }
              if(emp.Awards==null)
              {
                 emp.Awards="None";  
              }
              db.Emps.Update(emp);  
              db.SaveChanges();  
              HttpContext.Session.SetString("PrevPage","Update");  
              return RedirectToAction("ShowEmployee");  
       }
       public IActionResult Delete(int id)  
       {
              ViewData["Username"]=HttpContext.Session.GetString("Username");  
              if(ViewData["Username"]==null)
              {
                 return RedirectToAction("Index","Home");  
              }  
              Emp Curr_Emp=null;
              foreach(var emp in db.Emps)
              {
                      if(emp.Eid==id)
                      {
                         Curr_Emp=emp;
                         break;
                      }
              }
              return View(Curr_Emp);  
       }
       [HttpPost]       
       public IActionResult Remove(Emp emp)
       {
              db.Emps.Remove(emp);
              db.SaveChanges();
              HttpContext.Session.SetString("PrevPage","Delete");  
              return RedirectToAction("ShowEmployee");  
       }
}